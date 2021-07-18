using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class TotalDaySale : Form
    {
        public TotalDaySale()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        Bill bill = new Bill();

        //hàm fill dữ liệu cho datagridview
        private void fillGrip(SqlCommand command)
        {
            dataGridViewTotalPrice.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridViewTotalPrice.RowTemplate.Height = 60;
            dataGridViewTotalPrice.DataSource = bill.getBill(command);
            //piCol = (DataGridViewImageColumn)dataGridViewTotalPrice.Columns[1];
            //piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewTotalPrice.AllowUserToAddRows = false;

        }

        //form load
        private void TotalDaySale_Load(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("select nv.Fname +' '+ nv.lname as N'Họ tên', bd.Ngay as N'Ngày ',bd.Tensp as N'Sản phẩm', bd.Slmua as N'Số lượng', bd.Tien as N'Thành tiền' from BillDetail as bd join NhanVien as nv on bd.Idnv = nv.Idnv"));
            int TotalPrice = 0;
            for (int i = 0; i < dataGridViewTotalPrice.Rows.Count; i++)
            {
                TotalPrice += Convert.ToInt32(dataGridViewTotalPrice.Rows[i].Cells[4].Value.ToString());
            }
            textBoxTotalPrice.Text = TotalPrice.ToString() + " $";
        }

        //nút xác nhận doanh thu
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận doanh thu", "Doanh Thu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                bill.deleteTotalBill();
                fillGrip(new SqlCommand("select nv.Fname +' '+ nv.lname as N'Họ tên', bd.Ngay as N'Ngày ',bd.Tensp as N'Sản phẩm', bd.Slmua as N'Số lượng', bd.Tien as N'Thành tiền' from BillDetail as bd join NhanVien as nv on bd.Idnv = nv.Idnv"));
                textBoxTotalPrice.Text = "$";
            }
        }
    }
}
