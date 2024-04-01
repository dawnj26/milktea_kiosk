using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using milktea_kiosk_quinto.Helpers;

namespace milktea_kiosk_quinto
{
    class Globals
    {
        public static Color backgroundColor = Color.FromArgb(254, 253, 237);
        public static Color accentColor = Color.FromArgb(250, 112, 112);
        public static Color textDarkColor = Color.FromArgb(161, 195, 152);
        public static Color textColor = Color.FromArgb(198, 235, 197);

        public static List<Order> cart = new List<Order>();

        public static List<Item> items = DBHelper.get_items();
    }
}
