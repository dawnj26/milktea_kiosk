using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milktea_kiosk_quinto
{
    public class Item
    {
        private int _number;
        private string _description;
        private decimal _price;
        private Image _image;

        public Item(int number, string description, decimal price)
        {
            _number = number;
            _description = description;
            _price = price;
        }

        public int Number { get => _number; set => _number = value; }
        public string Description { get => _description; set => _description = value; }
        public decimal Price { get => _price; set => _price = value; }
        public Image Image { get => _image; set => _image = value; }
    }

    public class Order
    {
        private Item _item;
        private int _quantity;

        public Order(Item item, int quantity)
        {
            _item = item;
            this._quantity = quantity;
        }

        public Item Item { get => _item; set => _item = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
