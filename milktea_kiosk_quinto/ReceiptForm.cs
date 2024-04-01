using Microsoft.Reporting.WinForms;
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
    public partial class ReceiptForm : Form
    {
        private int order_no;
        private string order_date;
        private string cash;
        private string change;
        public ReceiptForm(int o, string d, string c, string g)
        {
            InitializeComponent();
            order_no = o;
            order_date = d;
            cash = c;
            change = g;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            ReportParameter paramID = new ReportParameter("order_no", order_no.ToString());
            ReportParameter paramdate = new ReportParameter("order_date", order_date);
            ReportParameter paramcash = new ReportParameter("cash", cash);
            ReportParameter paramchange = new ReportParameter("change", change);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { paramID, paramdate, paramcash, paramchange });
            // TODO: This line of code loads data into the 'teatea_milkDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.teatea_milkDataSet.DataTable1, order_no);
            reportViewer1.RefreshReport();
        }

        private void close_app_btn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Create new order?", "New order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                Application.Restart();

            } else
            {
                Application.Exit();
            }

            
        }
    }
}
