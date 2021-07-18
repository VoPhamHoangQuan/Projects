namespace Quản_lý_siêu_thị
{
    partial class ManageProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductForm));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.DataGridViewPro = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLoaiSP = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtKindPro = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBoxReset = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOriginPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePickerHsd = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerNsx = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtIdsp = new System.Windows.Forms.TextBox();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.Location = new System.Drawing.Point(303, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 45);
            this.btnRemove.TabIndex = 116;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Location = new System.Drawing.Point(154, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 45);
            this.btnEdit.TabIndex = 115;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(1, 285);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(200, 36);
            this.LabelTotal.TabIndex = 112;
            this.LabelTotal.Text = "Số Sản Phẩm:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewPro
            // 
            this.DataGridViewPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewPro.Location = new System.Drawing.Point(0, 323);
            this.DataGridViewPro.Name = "DataGridViewPro";
            this.DataGridViewPro.RowHeadersWidth = 51;
            this.DataGridViewPro.RowTemplate.Height = 24;
            this.DataGridViewPro.Size = new System.Drawing.Size(949, 262);
            this.DataGridViewPro.TabIndex = 111;
            this.DataGridViewPro.DoubleClick += new System.EventHandler(this.DataGridViewPro_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 110;
            this.label8.Text = "Picture";
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(634, 122);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(68, 18);
            this.labelGia.TabIndex = 109;
            this.labelGia.Text = "Giá Gốc ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(-2, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(106, 18);
            this.labelName.TabIndex = 108;
            this.labelName.Text = "Tên Sản Phẩm";
            // 
            // labelLoaiSP
            // 
            this.labelLoaiSP.AutoSize = true;
            this.labelLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiSP.Location = new System.Drawing.Point(61, 122);
            this.labelLoaiSP.Name = "labelLoaiSP";
            this.labelLoaiSP.Size = new System.Drawing.Size(43, 18);
            this.labelLoaiSP.TabIndex = 107;
            this.labelLoaiSP.Text = "Hãng";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(82, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 18);
            this.labelID.TabIndex = 106;
            this.labelID.Text = "ID";
            // 
            // txtKindPro
            // 
            this.txtKindPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKindPro.Location = new System.Drawing.Point(120, 83);
            this.txtKindPro.Multiline = true;
            this.txtKindPro.Name = "txtKindPro";
            this.txtKindPro.Size = new System.Drawing.Size(198, 26);
            this.txtKindPro.TabIndex = 102;
            this.txtKindPro.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(400, 157);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(210, 28);
            this.btnUpload.TabIndex = 100;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(5, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 45);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxImage.Location = new System.Drawing.Point(400, 13);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(213, 138);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 101;
            this.PictureBoxImage.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(523, 281);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 36);
            this.txtSearch.TabIndex = 118;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(843, 276);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 45);
            this.btnSearch.TabIndex = 117;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxReset
            // 
            this.pictureBoxReset.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReset.Image")));
            this.pictureBoxReset.Location = new System.Drawing.Point(207, 285);
            this.pictureBoxReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxReset.Name = "pictureBoxReset";
            this.pictureBoxReset.Size = new System.Drawing.Size(41, 36);
            this.pictureBoxReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReset.TabIndex = 119;
            this.pictureBoxReset.TabStop = false;
            this.pictureBoxReset.Click += new System.EventHandler(this.pictureBoxReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(321, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 194);
            this.panel1.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(619, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 194);
            this.panel2.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 109;
            this.label2.Text = "HSD";
            // 
            // txtSl
            // 
            this.txtSl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSl.Location = new System.Drawing.Point(721, 83);
            this.txtSl.Multiline = true;
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(198, 26);
            this.txtSl.TabIndex = 102;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1296, -92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 109;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 109;
            this.label4.Text = "NSX";
            // 
            // txtOriginPrice
            // 
            this.txtOriginPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOriginPrice.Location = new System.Drawing.Point(721, 118);
            this.txtOriginPrice.Multiline = true;
            this.txtOriginPrice.Name = "txtOriginPrice";
            this.txtOriginPrice.Size = new System.Drawing.Size(198, 26);
            this.txtOriginPrice.TabIndex = 102;
            this.txtOriginPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 109;
            this.label5.Text = "Số lượng ";
            // 
            // DateTimePickerHsd
            // 
            this.DateTimePickerHsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePickerHsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerHsd.Location = new System.Drawing.Point(721, 7);
            this.DateTimePickerHsd.Name = "DateTimePickerHsd";
            this.DateTimePickerHsd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerHsd.Size = new System.Drawing.Size(198, 26);
            this.DateTimePickerHsd.TabIndex = 127;
            this.DateTimePickerHsd.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // DateTimePickerNsx
            // 
            this.DateTimePickerNsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePickerNsx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerNsx.Location = new System.Drawing.Point(721, 45);
            this.DateTimePickerNsx.Name = "DateTimePickerNsx";
            this.DateTimePickerNsx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerNsx.Size = new System.Drawing.Size(198, 26);
            this.DateTimePickerNsx.TabIndex = 127;
            this.DateTimePickerNsx.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "Giá Bán";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSellPrice.Location = new System.Drawing.Point(721, 157);
            this.txtSellPrice.Multiline = true;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(198, 26);
            this.txtSellPrice.TabIndex = 102;
            this.txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 107;
            this.label7.Text = "Phân Loại";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBrand.Location = new System.Drawing.Point(120, 118);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(198, 26);
            this.txtBrand.TabIndex = 102;
            // 
            // txtIdsp
            // 
            this.txtIdsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdsp.Location = new System.Drawing.Point(120, 9);
            this.txtIdsp.Multiline = true;
            this.txtIdsp.Name = "txtIdsp";
            this.txtIdsp.Size = new System.Drawing.Size(198, 26);
            this.txtIdsp.TabIndex = 102;
            // 
            // txtNamePro
            // 
            this.txtNamePro.AllowDrop = true;
            this.txtNamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNamePro.Location = new System.Drawing.Point(120, 47);
            this.txtNamePro.Multiline = true;
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(198, 26);
            this.txtNamePro.TabIndex = 102;
            // 
            // ManageProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(949, 585);
            this.Controls.Add(this.DateTimePickerNsx);
            this.Controls.Add(this.DateTimePickerHsd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxReset);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.DataGridViewPro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelLoaiSP);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtOriginPrice);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtNamePro);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtIdsp);
            this.Controls.Add(this.txtKindPro);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageProductForm";
            this.Text = "ManageProductForm";
            this.Load += new System.EventHandler(this.ManageProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.DataGridView DataGridViewPro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLoaiSP;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtKindPro;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBoxReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOriginPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimePickerHsd;
        private System.Windows.Forms.DateTimePicker DateTimePickerNsx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtIdsp;
        private System.Windows.Forms.TextBox txtNamePro;
    }
}