namespace Quản_lý_siêu_thị
{
    partial class ExportStorageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportStorageForm));
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtSlCuahang = new System.Windows.Forms.TextBox();
            this.txtIdspXuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlKho = new System.Windows.Forms.TextBox();
            this.txtSlXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerXuat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdXuat = new System.Windows.Forms.TextBox();
            this.pictureBoxResetS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExport
            // 
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewExport.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.RowTemplate.Height = 24;
            this.dataGridViewExport.Size = new System.Drawing.Size(949, 313);
            this.dataGridViewExport.TabIndex = 0;
            this.dataGridViewExport.DoubleClick += new System.EventHandler(this.dataGridViewExport_DoubleClick);
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(702, 316);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(200, 36);
            this.LabelTotal.TabIndex = 187;
            this.LabelTotal.Text = "Số Sản Phẩm:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(15, 528);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(143, 45);
            this.btnExport.TabIndex = 189;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 193;
            this.label5.Text = "Số lượng ở cửa hàng";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(52, 347);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(91, 18);
            this.labelID.TabIndex = 192;
            this.labelID.Text = "ID sản phẩm";
            // 
            // txtSlCuahang
            // 
            this.txtSlCuahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlCuahang.Location = new System.Drawing.Point(177, 393);
            this.txtSlCuahang.Multiline = true;
            this.txtSlCuahang.Name = "txtSlCuahang";
            this.txtSlCuahang.Size = new System.Drawing.Size(183, 26);
            this.txtSlCuahang.TabIndex = 191;
            // 
            // txtIdspXuat
            // 
            this.txtIdspXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdspXuat.Location = new System.Drawing.Point(177, 347);
            this.txtIdspXuat.Multiline = true;
            this.txtIdspXuat.Name = "txtIdspXuat";
            this.txtIdspXuat.Size = new System.Drawing.Size(183, 26);
            this.txtIdspXuat.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 193;
            this.label1.Text = "Số lượng trong kho";
            // 
            // txtSlKho
            // 
            this.txtSlKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlKho.Location = new System.Drawing.Point(177, 435);
            this.txtSlKho.Multiline = true;
            this.txtSlKho.Name = "txtSlKho";
            this.txtSlKho.Size = new System.Drawing.Size(183, 26);
            this.txtSlKho.TabIndex = 191;
            // 
            // txtSlXuat
            // 
            this.txtSlXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlXuat.Location = new System.Drawing.Point(521, 393);
            this.txtSlXuat.Multiline = true;
            this.txtSlXuat.Name = "txtSlXuat";
            this.txtSlXuat.Size = new System.Drawing.Size(172, 26);
            this.txtSlXuat.TabIndex = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 192;
            this.label2.Text = "Ngày Xuất";
            // 
            // dateTimePickerXuat
            // 
            this.dateTimePickerXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerXuat.Location = new System.Drawing.Point(521, 351);
            this.dateTimePickerXuat.Name = "dateTimePickerXuat";
            this.dateTimePickerXuat.Size = new System.Drawing.Size(175, 22);
            this.dateTimePickerXuat.TabIndex = 194;
            this.dateTimePickerXuat.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 192;
            this.label3.Text = "Số lượng xuất";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(177, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 45);
            this.btnExit.TabIndex = 189;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 192;
            this.label4.Text = "ID Xuất";
            // 
            // txtIdXuat
            // 
            this.txtIdXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdXuat.Location = new System.Drawing.Point(521, 435);
            this.txtIdXuat.Multiline = true;
            this.txtIdXuat.Name = "txtIdXuat";
            this.txtIdXuat.Size = new System.Drawing.Size(172, 26);
            this.txtIdXuat.TabIndex = 190;
            // 
            // pictureBoxResetS
            // 
            this.pictureBoxResetS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResetS.Image")));
            this.pictureBoxResetS.Location = new System.Drawing.Point(908, 316);
            this.pictureBoxResetS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxResetS.Name = "pictureBoxResetS";
            this.pictureBoxResetS.Size = new System.Drawing.Size(41, 36);
            this.pictureBoxResetS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResetS.TabIndex = 188;
            this.pictureBoxResetS.TabStop = false;
            this.pictureBoxResetS.Click += new System.EventHandler(this.pictureBoxResetS_Click);
            // 
            // ExportStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 585);
            this.Controls.Add(this.dateTimePickerXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtSlKho);
            this.Controls.Add(this.txtIdXuat);
            this.Controls.Add(this.txtSlXuat);
            this.Controls.Add(this.txtSlCuahang);
            this.Controls.Add(this.txtIdspXuat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pictureBoxResetS);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.dataGridViewExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportStorageForm";
            this.Text = "ExportStorageForm";
            this.Load += new System.EventHandler(this.ExportStorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExport;
        private System.Windows.Forms.PictureBox pictureBoxResetS;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtSlCuahang;
        private System.Windows.Forms.TextBox txtIdspXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlKho;
        private System.Windows.Forms.TextBox txtSlXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdXuat;
    }
}