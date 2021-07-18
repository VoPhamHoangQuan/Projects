using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class BuyProduct : Form
    {
        public BuyProduct()
        {
            InitializeComponent();
        }
        
        private void BuyProduct_Load(object sender, EventArgs e)
        {

        }
        Products products = new Products();
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
            Bill bill = new Bill();
            //int idbill = 0;
            String id = IdKHGlobal.IdKH;
            string name = lblname.Text;
            int amount = Convert.ToInt32(nsl.Value);
            float price = Convert.ToInt32(temp.Text);
            
            string idnv = "nv01";
            MemoryStream pic = new MemoryStream();
            picture.Image.Save(pic, picture.Image.RawFormat);
            if (amount != 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn mua sản phẩm này", "Buy Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // cập nhật lại số lượng sp
                    SqlCommand command = new SqlCommand("update SanPham set Sltrenke = Sltrenke - " + amount + "where Tensp like '%" + name + "%'");
                    products.updateSoluongSP(command);
                    //if (bill.insertTotalBill(DateTime.Now, name, idnv, amount, price))
                    //{
                        if (bill.insertBill(name, amount, price))
                        {

                            this.Close();
                            PayForm pay = new PayForm();
                            pay.Show();
                        }
                    //}
                }
                //idbill = idbill + 1;
            }
            else
            {
                if (MessageBox.Show("Số lượng không đủ", "Buy Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void nsl_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
