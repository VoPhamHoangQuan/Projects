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
    public partial class ListProduct : Form
    {
        public ListProduct()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void listPr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ptbweb_Click(object sender, EventArgs e)
        {

        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            FillPanel(new SqlCommand("Select * from SanPham"));
        }

        Products products = new Products();
        public void FillPanel(SqlCommand command)
        {
            listPr.Controls.Clear();
            DataTable table = products.getSanPham(command);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                FlowLayoutPanel infpro = new FlowLayoutPanel();
                infpro.Name = table.Rows[i][0].ToString();
                PictureBox pc = new PictureBox();
                pc.Name = table.Rows[i][0].ToString();
                float Soluong = float.Parse(table.Rows[i][4].ToString());
                Label price = new Label();
                Label des = new Label();
                Label MS = new Label();

                des.Size = new Size(265, 25);
                des.AutoSize = false;
                des.TabStop = false;
                des.BorderStyle = BorderStyle.None;
                des.TextAlign = ContentAlignment.TopCenter;
                des.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string description = (string)table.Rows[i][1].ToString();
                des.Text = description;

                price.ForeColor = Color.Goldenrod;
                price.AutoSize = false;
                price.TabStop = false;
                price.BorderStyle = BorderStyle.None;
                price.Size = new Size(264, 40);
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new System.Drawing.Font("Bookman Old Style", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string temp = table.Rows[i][6].ToString();
                price.Text = Convert.ToDecimal(temp).ToString("#,##0") + "đ";

                MS.ForeColor = Color.Red;
                MS.AutoSize = false;
                MS.TabStop = false;
                MS.BorderStyle = BorderStyle.None;
                MS.Size = new Size(264, 40);
                MS.TextAlign = ContentAlignment.MiddleCenter;
                MS.Font = new System.Drawing.Font("Bookman Old Style", 15.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                MS.Text = "Hết hàng";

                byte[] pic;
                pic = (byte[])table.Rows[i][7];
                MemoryStream picture = new MemoryStream(pic);
                pc.Image = Image.FromStream(picture);
                pc.SizeMode = PictureBoxSizeMode.Zoom;
                pc.Size = new Size(250, 290);
                infpro.Height = 400;
                infpro.Width = 270;


                infpro.Controls.Add(pc);
                infpro.Controls.Add(des);
                infpro.Controls.Add(price);
                if (Soluong == 0)
                {
                    infpro.Controls.Add(MS);
                }
                listPr.Controls.Add(infpro);
                listPr.FlowDirection = FlowDirection.LeftToRight;

                infpro.MouseEnter += Infpro_MouseEnter;
                infpro.MouseLeave += Infpro_MouseLeave;
                pc.MouseEnter += Pc_MouseEnter;
                pc.MouseLeave += Pc_MouseLeave;              
                if (Soluong > 0)
                {
                    pc.Click += Pc_Click;
                }
                infpro.Click += Infpro_Click;
            }
        }

        private void Infpro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Pc_Click(object sender, EventArgs e)
        {
            BuyProduct infProduct = new BuyProduct();
            PictureBox pc = sender as PictureBox;
            String ms = pc.Name.ToString();
            DataTable table = products.getProductById(ms);
            infProduct.lblname.Text = table.Rows[0][1].ToString();
            infProduct.temp.Text = table.Rows[0][6].ToString();
            //infProduct.temp.Text = Convert.ToDecimal(temp).ToString("#,##0") + "đ";
            //infProduct.lblprice.Text = table.Rows[0][3].ToString();
            infProduct.lblms.Text = table.Rows[0][0].ToString();
            infProduct.lbldes.Text = table.Rows[0][1].ToString();
            byte[] pic;
            pic = (byte[])table.Rows[0][7];
            MemoryStream picture = new MemoryStream(pic);
            infProduct.picture.Image = Image.FromStream(picture);
            infProduct.picture.SizeMode = PictureBoxSizeMode.Zoom;
            infProduct.Show(this);
            IdSpGlobal.SetGlobalFlagSPId(ms);
        }

        private void Pc_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pc = sender as PictureBox;
            pc.BackColor = Color.White;
        }

        private void Pc_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pc = sender as PictureBox;
            pc.BackColor = Color.AntiqueWhite;
        }

        private void Infpro_MouseLeave(object sender, EventArgs e)
        {
            FlowLayoutPanel d = sender as FlowLayoutPanel;
            d.BackColor = Color.White;

        }

        private void Infpro_MouseEnter(object sender, EventArgs e)
        {
            FlowLayoutPanel d = sender as FlowLayoutPanel;
            d.BackColor = Color.AntiqueWhite;
        }

        private void listPr_MouseEnter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void lAPTOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillPanel((new SqlCommand("SELECT * FROM SanPham WHERE Loaisp like 'Laptop'")));
        
        }

        private void đIỆNTHOẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillPanel(new SqlCommand("SELECT * FROM SanPham WHERE Loaisp like 'Smartphone'"));
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from SanPham where concat(Idsp,Tensp) like '%" + FindProduct.Text + "%'");
            FillPanel(command);
        }

        private void sAMSUNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillPanel(new SqlCommand("SELECT * FROM SanPham WHERE Hang like 'SamSung'"));
        }

        private void aPPLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillPanel(new SqlCommand("SELECT * FROM SanPham WHERE Hang like 'Apple' and Loaisp like 'Smartphone'"));
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
