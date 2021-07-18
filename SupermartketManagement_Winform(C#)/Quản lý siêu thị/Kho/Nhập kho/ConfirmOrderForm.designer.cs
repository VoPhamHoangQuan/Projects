namespace Quản_lý_siêu_thị
{
    partial class ConfirmOrderForm
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
            this.DateTimePickerNhapKho = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtIdNhapKho = new System.Windows.Forms.TextBox();
            this.txtSlOrder = new System.Windows.Forms.TextBox();
            this.txtIdspOrder = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtIdql = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePickerNhapKho
            // 
            this.DateTimePickerNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePickerNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerNhapKho.Location = new System.Drawing.Point(510, 108);
            this.DateTimePickerNhapKho.Name = "DateTimePickerNhapKho";
            this.DateTimePickerNhapKho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerNhapKho.Size = new System.Drawing.Size(198, 26);
            this.DateTimePickerNhapKho.TabIndex = 202;
            this.DateTimePickerNhapKho.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 200;
            this.label1.Text = "Ngày nhập kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 201;
            this.label5.Text = "Số lượng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 198;
            this.label2.Text = "ID nhập kho";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(26, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(91, 18);
            this.labelID.TabIndex = 199;
            this.labelID.Text = "ID sản phẩm";
            // 
            // txtIdNhapKho
            // 
            this.txtIdNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdNhapKho.Location = new System.Drawing.Point(148, 67);
            this.txtIdNhapKho.Multiline = true;
            this.txtIdNhapKho.Name = "txtIdNhapKho";
            this.txtIdNhapKho.Size = new System.Drawing.Size(198, 26);
            this.txtIdNhapKho.TabIndex = 195;
            // 
            // txtSlOrder
            // 
            this.txtSlOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlOrder.Location = new System.Drawing.Point(510, 58);
            this.txtSlOrder.Multiline = true;
            this.txtSlOrder.Name = "txtSlOrder";
            this.txtSlOrder.Size = new System.Drawing.Size(198, 26);
            this.txtSlOrder.TabIndex = 197;
            // 
            // txtIdspOrder
            // 
            this.txtIdspOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdspOrder.Location = new System.Drawing.Point(148, 15);
            this.txtIdspOrder.Multiline = true;
            this.txtIdspOrder.Name = "txtIdspOrder";
            this.txtIdspOrder.Size = new System.Drawing.Size(198, 26);
            this.txtIdspOrder.TabIndex = 196;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(215, 274);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(304, 45);
            this.btnConfirm.TabIndex = 203;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtIdql
            // 
            this.txtIdql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdql.Location = new System.Drawing.Point(510, 15);
            this.txtIdql.Multiline = true;
            this.txtIdql.Name = "txtIdql";
            this.txtIdql.Size = new System.Drawing.Size(198, 26);
            this.txtIdql.TabIndex = 197;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 201;
            this.label3.Text = "ID Nhân viên";
            // 
            // ConfirmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 405);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.DateTimePickerNhapKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtIdNhapKho);
            this.Controls.Add(this.txtIdql);
            this.Controls.Add(this.txtSlOrder);
            this.Controls.Add(this.txtIdspOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfirmOrderForm";
            this.Text = "ConfirmOrderForm";
            this.Load += new System.EventHandler(this.ConfirmOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerNhapKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtIdNhapKho;
        private System.Windows.Forms.TextBox txtSlOrder;
        private System.Windows.Forms.TextBox txtIdspOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtIdql;
        private System.Windows.Forms.Label label3;
    }
}