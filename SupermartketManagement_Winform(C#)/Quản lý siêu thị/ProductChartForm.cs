using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class ProductChartForm : Form
    {
        public ProductChartForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        Products SP = new Products();
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ProductChartForm_Load(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(SP.totalSP());
            double Laptop = Convert.ToDouble(SP.totalLaptop());
            double Smartphone = Convert.ToDouble(SP.totalSmartphone());
            double CountLaptop = (Laptop * (100 / total));
            double CountSmartphone = (Smartphone * (100 / total));

            chart1.Series["Biểu Đồ"].Points.AddXY("Laptop: " + CountLaptop.ToString("0.00") + "%", CountLaptop);
            chart1.Series["Biểu Đồ"].Points.AddXY("Smartphone: " + CountSmartphone.ToString("0.00") + "%", CountSmartphone);
        }
    }
}
