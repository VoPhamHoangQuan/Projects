namespace Quản_lý_siêu_thị
{
    partial class ConfirmExportForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.DateTimePickerXuatKho = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtIdXuatkho = new System.Windows.Forms.TextBox();
            this.txtSlExport = new System.Windows.Forms.TextBox();
            this.txtIdspExport = new System.Windows.Forms.TextBox();
            this.txtIdql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(251, 311);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(304, 45);
            this.btnConfirm.TabIndex = 214;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // DateTimePickerXuatKho
            // 
            this.DateTimePickerXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePickerXuatKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerXuatKho.Location = new System.Drawing.Point(546, 145);
            this.DateTimePickerXuatKho.Name = "DateTimePickerXuatKho";
            this.DateTimePickerXuatKho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerXuatKho.Size = new System.Drawing.Size(198, 26);
            this.DateTimePickerXuatKho.TabIndex = 213;
            this.DateTimePickerXuatKho.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 210;
            this.label1.Text = "Ngày xuất kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 211;
            this.label3.Text = "ID Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 212;
            this.label5.Text = "Số lượng xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 208;
            this.label2.Text = "ID xuất kho";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(62, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(91, 18);
            this.labelID.TabIndex = 209;
            this.labelID.Text = "ID sản phẩm";
            // 
            // txtIdXuatkho
            // 
            this.txtIdXuatkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdXuatkho.Location = new System.Drawing.Point(184, 104);
            this.txtIdXuatkho.Multiline = true;
            this.txtIdXuatkho.Name = "txtIdXuatkho";
            this.txtIdXuatkho.Size = new System.Drawing.Size(198, 26);
            this.txtIdXuatkho.TabIndex = 204;
            // 
            // txtSlExport
            // 
            this.txtSlExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlExport.Location = new System.Drawing.Point(546, 95);
            this.txtSlExport.Multiline = true;
            this.txtSlExport.Name = "txtSlExport";
            this.txtSlExport.Size = new System.Drawing.Size(198, 26);
            this.txtSlExport.TabIndex = 207;
            // 
            // txtIdspExport
            // 
            this.txtIdspExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdspExport.Location = new System.Drawing.Point(184, 52);
            this.txtIdspExport.Multiline = true;
            this.txtIdspExport.Name = "txtIdspExport";
            this.txtIdspExport.Size = new System.Drawing.Size(198, 26);
            this.txtIdspExport.TabIndex = 205;
            // 
            // txtIdql
            // 
            this.txtIdql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdql.Location = new System.Drawing.Point(546, 52);
            this.txtIdql.Multiline = true;
            this.txtIdql.Name = "txtIdql";
            this.txtIdql.Size = new System.Drawing.Size(198, 26);
            this.txtIdql.TabIndex = 215;
            // 
            // ConfirmExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdql);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.DateTimePickerXuatKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtIdXuatkho);
            this.Controls.Add(this.txtSlExport);
            this.Controls.Add(this.txtIdspExport);
            this.Name = "ConfirmExportForm";
            this.Text = "ConfirmExportForm";
            this.Load += new System.EventHandler(this.ConfirmExportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker DateTimePickerXuatKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtIdXuatkho;
        private System.Windows.Forms.TextBox txtSlExport;
        private System.Windows.Forms.TextBox txtIdspExport;
        private System.Windows.Forms.TextBox txtIdql;
    }
}