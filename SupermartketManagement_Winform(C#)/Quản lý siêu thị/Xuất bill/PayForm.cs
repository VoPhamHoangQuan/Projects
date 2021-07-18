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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        Bill bill = new Bill();
        Products products = new Products();
        ManageProductForm Mpf = new ManageProductForm();
        private void fillGrip(SqlCommand command)
        {
            dataGridViewTotalPrice.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridViewTotalPrice.RowTemplate.Height = 60;
            dataGridViewTotalPrice.DataSource = bill.getBill(command);
            //piCol = (DataGridViewImageColumn)dataGridViewTotalPrice.Columns[0];
            //piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewTotalPrice.AllowUserToAddRows = false;

        }

        //form load
        private void PayForm_Load(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("SELECT Idbill AS 'Mã đơn',Sp AS 'Tên SP',Sl AS 'Số lượng',Tongtien AS 'Thành tiền' FROM Bill"));
            int TotalPrice = 0;
            for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
            {
                TotalPrice += Convert.ToInt32(dataGridViewTotalPrice.Rows[i].Cells[3].Value.ToString());
            }
            textBoxTotalPrice.Text = TotalPrice.ToString();
        }

        //double click vào datagridview sẽ hiện số lượng sp lên numericupdown
        private void dataGridViewTotalPrice_DoubleClick_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToInt32(dataGridViewTotalPrice.CurrentRow.Cells[2].Value.ToString());
        }

        //nút thanh toán
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán những sản phẩm này", "Buy Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // đưa dữ liệu vài billdetail
                    for (int k = 0; k < dataGridViewTotalPrice.Rows.Count; k++)
                    {
                        Bill bill = new Bill();
                        String idnv = IdNVGlobal.FlagUserId;
                        int stt = Convert.ToInt32(dataGridViewTotalPrice.Rows[k].Cells[0].Value);
                        String tensp = dataGridViewTotalPrice.Rows[k].Cells[1].Value.ToString();
                        int soluong = int.Parse(dataGridViewTotalPrice.Rows[k].Cells[2].Value.ToString());
                        float tien = float.Parse(textBoxTotalPrice.Text);
                        bill.insertTotalBill( DateTime.Now, tensp, idnv, soluong, tien);
                    }
                    SaveFileDialog save = new SaveFileDialog() { Filter = "word|.doc", ValidateNames = true };

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter write = new StreamWriter(File.Create(save.FileName));
                        write.WriteLine("--------------------------SUPERMARKET--------------------------");
                        write.WriteLine("                        PHIẾU THU NGÂN                         ");
                        write.Write("Mã đơn hàng:");
                        for (int j = 0; j < dataGridViewTotalPrice.Rows.Count; j++)
                        {
                            write.WriteLine(dataGridViewTotalPrice.Rows[j].Cells[0].Value.ToString());
                        }

                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Ngày: " + DateTime.Now);
                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Nhân viên:" + NameUserGlobal.NameUser);
                        write.WriteLine("---------------------------------------------------------------");
                        write.Write("Tên sản phẩm");
                        write.Write("\t\t\t");
                        write.Write("Số lượng");
                        write.Write("\t\t");
                        write.WriteLine("Giá");
                        for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
                        {
                            write.Write(dataGridViewTotalPrice.Rows[i].Cells[1].Value.ToString());
                            write.Write("\t\t\t");
                            write.Write(dataGridViewTotalPrice.Rows[i].Cells[2].Value.ToString());
                            write.Write("\t\t\t");
                            write.Write(dataGridViewTotalPrice.Rows[i].Cells[3].Value.ToString());
                            write.WriteLine();
                            //fillGrip(new SqlCommand("update SanPham set Sltrenke = Sltrenke - " + dataGridViewTotalPrice.Rows[i].Cells[2].Value + "where Tensp like '%" + dataGridViewTotalPrice.Rows[i].Cells[1].Value.ToString() + "'"));
                        }
                        int a = Convert.ToInt32(textBoxNhan.Text) - Convert.ToInt32(textBoxTotalPrice.Text);


                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Tổng tiền:        " + textBoxTotalPrice.Text);
                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Tiền mặt:         " + textBoxNhan.Text);
                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Trả lại:          " + a.ToString());
                        write.WriteLine("---------------------------------------------------------------");
                        write.WriteLine("Chân thành cảm ơn quí khách!");


                        write.Dispose();
                        //MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //update lại số lượng trong kho
                    //for (int j = 0; j <= dataGridViewTotalPrice.Rows.Count; j++)
                    //{
                    //    String ten = dataGridViewTotalPrice.Rows[j].Cells[1].Value.ToString();
                    //    float sl = float.Parse(dataGridViewTotalPrice.Rows[j].Cells[2].Value.ToString());
                    //    //fillGrip(new SqlCommand("update SanPham set Sltrenke = Sltrenke - " + sl + "where Tensp like '%" + ten + "%'"));

                    //    SqlCommand command = new SqlCommand("update SanPham set Sltrenke = Sltrenke - " + sl + "where Tensp like '%" + ten + "%'");
                    //    products.updateSoluongSP(command);
                    //}
                    
                    if (bill.deleteBill())
                    {
                        MessageBox.Show("Mua hàng thành công", "Buy Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }                                      
                    textBoxTotalPrice.Text = "0";
                    numericUpDown1.Value = 0;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buy Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //xác nhận đổi số lượng món hàng
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            float sl = float.Parse(dataGridViewTotalPrice.CurrentRow.Cells[2].Value.ToString());
            int tam = Convert.ToInt32(dataGridViewTotalPrice.CurrentRow.Cells[3].Value.ToString()) / Convert.ToInt32(dataGridViewTotalPrice.CurrentRow.Cells[2].Value.ToString());
            int amount = Convert.ToInt32(numericUpDown1.Value.ToString());
            string name = dataGridViewTotalPrice.CurrentRow.Cells[1].Value.ToString();
            int price = tam * amount;
            if (MessageBox.Show("Bạn có chắc muốn thay đổi", "Change Amounts", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bill.updateBill(name, amount, price))
                {
                    if (amount != 0)
                    {
                        SqlCommand command = new SqlCommand("update SanPham set Sltrenke = Sltrenke - " + amount + "where Tensp like '%" + name + "%'");
                        products.updateSoluongSP(command);
                        fillGrip(new SqlCommand("SELECT Idbill AS 'Mã đơn ',Sp AS 'Tên SP',Sl AS 'Số lượng',Tongtien AS 'Thành tiền' FROM Bill"));
                        int TotalPrice = 0;
                        for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
                        {
                            TotalPrice += Convert.ToInt32(dataGridViewTotalPrice.Rows[i].Cells[3].Value.ToString());
                        }
                        textBoxTotalPrice.Text = TotalPrice.ToString() ;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("update SanPham set Sltrenke = Sltrenke + " + sl + "where Tensp like '%" + name + "%'");
                        products.updateSoluongSP(command);
                        if (bill.DeleteBill(name))
                        {
                            fillGrip(new SqlCommand("SELECT Idbill AS 'Mã đơn ',Sp AS 'Tên SP',Sl AS 'Số lượng',Tongtien AS 'Thành tiền' FROM Bill"));
                            int TotalPrice = 0;
                            for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
                            {
                                TotalPrice += Convert.ToInt32(dataGridViewTotalPrice.Rows[i].Cells[3].Value.ToString());
                            }
                            textBoxTotalPrice.Text = TotalPrice.ToString();
                        }
                    }
                }

            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog save = new SaveFileDialog() { Filter = "Text Document|.txt", ValidateNames = true };

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(save.FileName));
                    write.WriteLine("--------------------------SUPERMARKET--------------------------");
                    write.WriteLine("                        PHIẾU THU NGÂN                         ");
                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Ngày: " + DateTime.Now);
                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Nhân viên:" + NameUserGlobal.NameUser);
                    write.WriteLine("---------------------------------------------------------------");
                    write.Write("Tên sản phẩm");
                    write.Write("\t");
                    write.Write("Số lượng");
                    write.Write("\t");
                    write.WriteLine("Giá");
                    for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
                    {
                        write.Write(dataGridViewTotalPrice.Rows[i].Cells[1].Value.ToString());
                        write.Write("\t");
                        write.Write(dataGridViewTotalPrice.Rows[i].Cells[2].Value.ToString());
                        write.Write("\t\t");
                        write.Write(dataGridViewTotalPrice.Rows[i].Cells[3].Value.ToString());
                        write.Write("\t");
                        write.WriteLine();
                    }
                    int a = Convert.ToInt32(textBoxNhan.Text) - Convert.ToInt32(textBoxTotalPrice.Text);


                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Tổng tiền:        " + textBoxTotalPrice.Text);
                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Tiền mặt:         " + textBoxNhan.Text);
                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Trả lại:          " + a.ToString());
                    write.WriteLine("---------------------------------------------------------------");
                    write.WriteLine("Chân thành cảm ơn quí khách!");


                    write.Dispose();
                    MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conection Failue!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
