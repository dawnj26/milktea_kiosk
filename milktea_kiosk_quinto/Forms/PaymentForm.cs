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

namespace milktea_kiosk_quinto.Forms
{
    public partial class PaymentForm : Form
    {
        private int order_no;
        private DateTime order_date;
        private int grand_total;
        private MainForm prev_form;

        public PaymentForm(int order_no, DateTime order_date, int grand_total, MainForm f)
        {
            InitializeComponent();
            this.order_date = order_date;
            this.order_no = order_no;
            this.grand_total = grand_total;
            prev_form = f;
        }

        private void close_app_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cash_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void cash_label_KeyUp(object sender, KeyEventArgs e)
        {

            if (cash_label.Text == "")
            {
                change_textbox.Clear();
                return;
            }

            var change = int.Parse(cash_label.Text) - grand_total;
            if (change < 0)
            {
                change_textbox.Clear();
                return;
            }

            change_textbox.Text = change.ToString();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            order_date_label.Text = order_date.ToString("yyyy-M-dd hh:mm tt");
            order_no_label.Text = order_no.ToString();

            grand_total_textbox.Text = grand_total.ToString();
            amount_textbox.Text = grand_total.ToString();
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            if (change_textbox.Text == "")
            {
                MessageBox.Show("Insufficient payment!");
                return;
            }

            DBHelper.insert_order(order_no, order_date.ToString("yyyy-M-dd hh:mm tt"));
            DBHelper.insert_payment(order_no, grand_total, int.Parse(cash_label.Text), int.Parse(change_textbox.Text));
            DBHelper.insert_orders(order_no);

            var report_form = new ReceiptForm(order_no, order_date.ToString("yyyy-M-dd hh:mm tt"), cash_label.Text, change_textbox.Text);
            report_form.ShowDialog();
        }
    }
}
