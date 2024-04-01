using milktea_kiosk_quinto.Forms;
using milktea_kiosk_quinto.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milktea_kiosk_quinto
{
    public partial class MainForm : Form
    {
        private int grand_total = 0;
        private int order_no;

        public MainForm()
        {
            InitializeComponent();
        }

        public void update_cart()
        {
            cart_table.Rows.Clear();

            grand_total = 0;

            foreach (var o in Globals.cart)
            {
                var sub_total = (int) o.Item.Price * o.Quantity;
                cart_table.Rows.Add(o.Item.Number, o.Item.Description, o.Quantity,o.Item.Price, sub_total);

                grand_total += sub_total;
            }

            cart_table.ClearSelection();
            grand_total_label.Text = $"₱ {grand_total}";
        }

        private void close_app_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void update_order_no()
        {
            order_no = DBHelper.get_last_order_no() + 1;

            order_no_label.Text = $"Order {order_no}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            Globals.items[0].Image = regular_picture.Image;
            Globals.items[1].Image = pudding_picture.Image;
            Globals.items[2].Image = matcha_picture.Image;
            Globals.items[3].Image = pearl_picture.Image;

            update_order_no();
        }

        private void open_item(Item i)
        {
            var item_form = new ItemForm(i, this);
            item_form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_time_label.Text = DateTime.Now.ToString();
        }

        private void regular_item_Click(object sender, EventArgs e)
        {
            
            open_item(Globals.items[0]);
        }

        private void pudding_item_Click(object sender, EventArgs e)
        {
            
            open_item(Globals.items[1]);
        }

        private void matcha_item_Click(object sender, EventArgs e)
        {
            
            open_item(Globals.items[2]);
        }

        private void pearl_item_Click(object sender, EventArgs e)
        {
            
            open_item(Globals.items[3]);
        }

        private void cart_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cart_table.SelectedRows.Count < 1) return;

            var selected_index = cart_table.SelectedRows[0].Index;

            var item_form = new ItemForm(selected_index, this);
            item_form.ShowDialog();
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            if (grand_total == 0)
            {
                MessageBox.Show("No item/s in the cart!");
                return;
            }

            var payment_form = new PaymentForm(order_no, DateTime.Now, grand_total, this);
            payment_form.ShowDialog();
        }
    }
}
