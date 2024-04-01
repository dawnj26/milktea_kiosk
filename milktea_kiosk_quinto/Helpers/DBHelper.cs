using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace milktea_kiosk_quinto.Helpers
{
    class DBHelper
    {
        public const string connection_string = "server=localhost;uid=root;pwd=;database=teatea_milk";

        // Items table
        public const string item_table = "items";
        public const string item_no_col = "item_no", item_desc_col = "item_description", item_price_col = "item_price";

        // Orders table
        public const string order_table = "orders";
        public const string order_no_col = "order_no", order_date_col = "order_date";

        // Payments table
        public const string payments_table = "payments";
        public const string pay_no_col = "pay_no", amount_col = "amount_paid", cash_col = "cash_tendered", change_col = "payment_change";

        // Order line table 
        public const string order_line_table = "order_line";
        public const string trans_col = "trans_no", price_col = "price", quantity_col = "order_quantity";

        private static MySqlConnection open_db()
        {
            var conn = new MySqlConnection(connection_string);
            var success = true;

            try
            {
                conn.Open();
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
                success = false;
            } finally
            {
                conn.Close();
            }

            return success ? conn : null;
        }

        public static List<Item> get_items()
        {
            var items = new List<Item>();

            using (var conn = open_db())
            {
                conn.Open();

                var sql = $"SELECT * FROM {item_table}";
                var cmd = new MySqlCommand(sql, conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                }
            }

            return items;
        }

        public static int get_last_order_no()
        {
            var id = 0;
            using (var conn = open_db())
            {
                conn.Open();

                var sql = $"SELECT MAX({order_no_col}) FROM {order_table}";
                var cmd = new MySqlCommand(sql, conn);

                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    id = Convert.ToInt32(result);
                }
            }

            return id;
        }

        public static void insert_order(int order_no, string datetime)
        {
            using (var conn = open_db())
            {
                conn.Open();

                var sql = $"INSERT INTO {order_table} ({order_no_col}, {order_date_col}) VALUES ({order_no}, '{datetime}')";
                var cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
        }

        public static void insert_payment(int order_no, int amount_paid, int cash_tendered, int payment_change)
        {
            using (var conn = open_db())
            {
                conn.Open();

                var sql = $"INSERT INTO {payments_table} ({order_no_col}, {amount_col}, {cash_col}, {change_col}) VALUES ({order_no}, {amount_paid}, {cash_tendered}, {payment_change})";
                var cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
        }

        public static void insert_orders(int order_no)
        {
            using (var conn = open_db())
            {
                conn.Open();

                foreach (var o in Globals.cart)
                {
                    var sql = $"INSERT INTO {order_line_table} ({order_no_col}, {item_no_col}, {price_col}, {quantity_col}) VALUES ({order_no}, {o.Item.Number}, {o.Item.Price}, {o.Quantity})";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
