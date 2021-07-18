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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            CustomizeDesign();  //chạy khởi tạo trạng thái cho các panel

        }


        #region các hàm giao diện panel        
        //hàm khởi tạo trạng thái ban đầu của các panel chức năng (panelNv,...)
        //tắt hết tất cả panel chức năng
        private void CustomizeDesign()
        {
            PanelSanPham.Visible = false;
            PanelNhanVien.Visible = false;
            PanelQlKho.Visible = false;
            PanelTienIch.Visible = false;
            PanelGiaoDich.Visible = false;
        }

        //hàm giấu các panel chức năng
        private void HidePanel()
        {
            if (PanelSanPham.Visible == true)
                PanelSanPham.Visible = false;
            if (PanelNhanVien.Visible == true)
                PanelNhanVien.Visible = false;
            if (PanelQlKho.Visible == true)
                PanelQlKho.Visible = false;
            if (PanelTienIch.Visible == true)
                PanelTienIch.Visible = false;
            if (PanelGiaoDich.Visible == true)
                PanelGiaoDich.Visible = false;
        }

        //hàm show các panel
        private void ShowPanel(Panel PanelName)
        {
            if (PanelName.Visible == false)
            {
                HidePanel();
                PanelName.Visible = true;
            }
            //khi panel đang mở nhấn vào lần nữa sẽ đóng panel
            else 
            {
                PanelName.Visible = false;
            }
        }


        //hàm mở các form chức năng trên paneldisplay
        private Form ActiveForm = null;     //khai báo biến Form Đang hoạt động 
        private void OpenDisplayForm(Form NameForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = NameForm;

            NameForm.TopLevel = false;
            NameForm.FormBorderStyle = FormBorderStyle.None;
            NameForm.Dock = DockStyle.Fill;

            PanelDisplay.Controls.Add(NameForm);
            PanelDisplay.Tag = NameForm;

            NameForm.BringToFront();
            NameForm.Show();
        }
        #endregion


        #region Sản Phẩm
        private void btnSp_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelSanPham);
        }

        private void btnQuanLiSp_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new ManageProductForm());
            HidePanel();
        }

        private void btnInSp_Click(object sender, EventArgs e)
        {
            //...code here
            OpenDisplayForm(new PrintProductForm());
            HidePanel();
        }
        #endregion


        #region Nhân Viên
        private void btnNv_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelNhanVien);
        }

        private void btnQuanLiNv_Click(object sender, EventArgs e)
        {
            //...code here
            OpenDisplayForm(new ManageEmployeeForm());
            HidePanel();
        }

        private void btnSapXepNv_Click(object sender, EventArgs e)
        {
            //...code here

            HidePanel();
        }

        private void btnTimNv_Click(object sender, EventArgs e)
        {
            //...code here
            OpenDisplayForm(new SearchEmployee());
            HidePanel();
        }

        private void btnTinhLuongNv_Click(object sender, EventArgs e)
        {
            //...code here
            OpenDisplayForm(new TimeInAndTimeOut());
            HidePanel();
        }
        #endregion


        #region Giao dịch
   
        private void btnGiaoDich_Click_1(object sender, EventArgs e)
        {
            ShowPanel(PanelGiaoDich);
        }

        private void btnXuatbill_Click(object sender, EventArgs e)
        {
            ListProduct product = new ListProduct();
            product.Show();
            HidePanel();
        }

        private void btnDsGiaoDich_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new TotalDaySale());
            HidePanel();
        }

        #endregion


        #region Kho
        private void btnKho_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelQlKho);
        }

        private void btnQlkho_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new StorageManagerForm());
            HidePanel();
  
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new OrderStorageForm());
            HidePanel();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new ExportStorageForm());
            HidePanel();
        }

        private void btnKhoReport_Click(object sender, EventArgs e)
        {
            OpenDisplayForm(new XuatNhapReportForm());
            HidePanel();
        }

        #endregion


        #region Tiện ích
        private void btnTienIch_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelTienIch);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "WINWORD.EXE";
            System.Diagnostics.Process.Start(st);
            HidePanel();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "EXCEL.EXE";
            System.Diagnostics.Process.Start(st);
            HidePanel();
        }

        private void btnCaculater_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
            HidePanel();
        }

        private void btnPp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "POWERPOINT.EXE";
            System.Diagnostics.Process.Start(st);
            HidePanel();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "notepad.exe";
            System.Diagnostics.Process.Start(st);
            HidePanel();
        }
        #endregion


        Timer t = new Timer();
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
            LabelWelcome.Text = "WELCOME TO OUR SUPERMARTKET "+"___"+ NameUserGlobal.NameUser+"___";
            LabelTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (CheckPartLoginGlobal.FlagUser == "Director")
            {
                btnLuongNv.Hide();
                //btnGiaoDich.Hide();
            }
            else if (CheckPartLoginGlobal.FlagUser == "Sell Manager")
            {
                btnSp.Hide();
                btnNv.Hide();
                btnKho.Hide();
                btnDsGiaoDich.Hide();
            }
            else if(CheckPartLoginGlobal.FlagUser == "Store Manager")
            {
                btnGiaoDich.Hide();
                btnNv.Hide();
                btnSp.Hide();
            }
        }

       

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            //int MM = DateTime.Now.Month;

            string time = "";
            string time2 = " ";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time2 += ":";
            if (mm < 10)
            {
                time2 += "0" + mm;
            }
            else
            {
                time2 += mm;
            }
            time2 += ":";
            if (ss < 10)
            {
                time2 += "0" + ss;
            }
            else
            {
                time2 += ss;
            }

            label2.Text = time;
            labelTime2.Text = time2;
        }

      

        private void PanelQlKho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelTime_Click(object sender, EventArgs e)
        {

        }

       
    }
}
