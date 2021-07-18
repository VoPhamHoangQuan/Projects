namespace Quản_lý_siêu_thị
{
    partial class OrderStorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStorageForm));
            this.DataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtSlOrder = new System.Windows.Forms.TextBox();
            this.txtIdspOrder = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.DateTimePickerNhapKho = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdNhapKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxResetS = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetS)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewOrder
            // 
            this.DataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewOrder.Name = "DataGridViewOrder";
            this.DataGridViewOrder.RowHeadersWidth = 51;
            this.DataGridViewOrder.RowTemplate.Height = 24;
            this.DataGridViewOrder.Size = new System.Drawing.Size(949, 369);
            this.DataGridViewOrder.TabIndex = 150;
            this.DataGridViewOrder.DoubleClick += new System.EventHandler(this.DataGridViewOrder_DoubleClick_1);
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(702, 372);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(200, 36);
            this.LabelTotal.TabIndex = 191;
            this.LabelTotal.Text = "Số Sản Phẩm:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 190;
            this.label5.Text = "Số lượng ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 390);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(91, 18);
            this.labelID.TabIndex = 189;
            this.labelID.Text = "ID sản phẩm";
            // 
            // txtSlOrder
            // 
            this.txtSlOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlOrder.Location = new System.Drawing.Point(134, 480);
            this.txtSlOrder.Multiline = true;
            this.txtSlOrder.Name = "txtSlOrder";
            this.txtSlOrder.Size = new System.Drawing.Size(198, 26);
            this.txtSlOrder.TabIndex = 188;
            // 
            // txtIdspOrder
            // 
            this.txtIdspOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdspOrder.Location = new System.Drawing.Point(134, 382);
            this.txtIdspOrder.Multiline = true;
            this.txtIdspOrder.Name = "txtIdspOrder";
            this.txtIdspOrder.Size = new System.Drawing.Size(198, 26);
            this.txtIdspOrder.TabIndex = 187;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Lime;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Location = new System.Drawing.Point(394, 511);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(143, 45);
            this.btnOrder.TabIndex = 193;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // DateTimePickerNhapKho
            // 
            this.DateTimePickerNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePickerNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerNhapKho.Location = new System.Drawing.Point(134, 530);
            this.DateTimePickerNhapKho.Name = "DateTimePickerNhapKho";
            this.DateTimePickerNhapKho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerNhapKho.Size = new System.Drawing.Size(198, 26);
            this.DateTimePickerNhapKho.TabIndex = 194;
            this.DateTimePickerNhapKho.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 190;
            this.label1.Text = "Ngày nhập kho";
            // 
            // txtIdNhapKho
            // 
            this.txtIdNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdNhapKho.Location = new System.Drawing.Point(134, 434);
            this.txtIdNhapKho.Multiline = true;
            this.txtIdNhapKho.Name = "txtIdNhapKho";
            this.txtIdNhapKho.Size = new System.Drawing.Size(198, 26);
            this.txtIdNhapKho.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 189;
            this.label2.Text = "ID nhập kho";
            // 
            // pictureBoxResetS
            // 
            this.pictureBoxResetS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResetS.Image")));
            this.pictureBoxResetS.Location = new System.Drawing.Point(908, 372);
            this.pictureBoxResetS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxResetS.Name = "pictureBoxResetS";
            this.pictureBoxResetS.Size = new System.Drawing.Size(41, 36);
            this.pictureBoxResetS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResetS.TabIndex = 192;
            this.pictureBoxResetS.TabStop = false;
            this.pictureBoxResetS.Click += new System.EventHandler(this.pictureBoxResetS_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(572, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 45);
            this.btnExit.TabIndex = 195;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // OrderStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 585);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.DateTimePickerNhapKho);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pictureBoxResetS);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtIdNhapKho);
            this.Controls.Add(this.txtSlOrder);
            this.Controls.Add(this.txtIdspOrder);
            this.Controls.Add(this.DataGridViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderStorageForm";
            this.Text = "OrderStorageForm";
            this.Load += new System.EventHandler(this.OrderStorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewOrder;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtSlOrder;
        private System.Windows.Forms.TextBox txtIdspOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DateTimePicker DateTimePickerNhapKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdNhapKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxResetS;
        private System.Windows.Forms.Button btnExit;
    }
}