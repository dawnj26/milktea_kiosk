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
    public partial class ItemForm : Form
    {
        private Item item;
        private MainForm prev_form;

        private Order order;

        private int index = -1;

        public ItemForm(Item i, MainForm f)
        {
            InitializeComponent();
            item = i;
            prev_form = f;
        }

        public ItemForm(int i, MainForm f)
        {
            InitializeComponent();
            index = i;
            prev_form = f;
            order = Globals.cart[i];
        }

        private void close_app_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            if (index == -1)
            {
                item_picture.Image = item.Image;

                no_label.Text = item.Number.ToString();
                desc_label.Text = item.Description;
                price_label.Text = item.Price.ToString();
            } else
            {
                item_picture.Image = order.Item.Image;

                no_label.Text = order.Item.Number.ToString();
                desc_label.Text = order.Item.Description;
                price_label.Text = order.Item.Price.ToString();

                quantity_updown.Value = order.Quantity;

                add_btn.Text = "Save";
            }
            
        }

        private void update_cart(Order o)
        {
            if (index != -1)
            {
                o.Quantity = (int)quantity_updown.Value;
            } else
            {
                o.Quantity += (int)quantity_updown.Value;
            }

            prev_form.update_cart();
            Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                update_cart(order);

                return;
            }

            foreach (var order in Globals.cart)
            {
                if (order.Item.Number == item.Number)
                {
                    update_cart(order);

                    return;
                }
            }


            var o = new Order(item, (int)quantity_updown.Value);
            Globals.cart.Add(o);

            prev_form.update_cart();
            Close();
        }
    }
}
