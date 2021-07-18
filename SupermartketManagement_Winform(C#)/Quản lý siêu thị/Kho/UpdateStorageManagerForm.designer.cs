namespace Quản_lý_siêu_thị
{
    partial class UpdateStorageManagerForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.DataGridViewStorage = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtSlS = new System.Windows.Forms.TextBox();
            this.txtIdspS = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.Location = new System.Drawing.Point(201, 535);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 45);
            this.btnRemove.TabIndex = 183;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(749, 379);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(200, 36);
            this.LabelTotal.TabIndex = 181;
            this.LabelTotal.Text = "Số Sản Phẩm:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewStorage
            // 
            this.DataGridViewStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStorage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewStorage.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewStorage.Name = "DataGridViewStorage";
            this.DataGridViewStorage.RowHeadersWidth = 51;
            this.DataGridViewStorage.RowTemplate.Height = 24;
            this.DataGridViewStorage.Size = new System.Drawing.Size(949, 378);
            this.DataGridViewStorage.TabIndex = 180;
            this.DataGridViewStorage.DoubleClick += new System.EventHandler(this.DataGridViewStorage_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1580, -155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 177;
            this.label3.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 176;
            this.label5.Text = "Số lượng ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(49, 391);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 18);
            this.labelID.TabIndex = 169;
            this.labelID.Text = "ID";
            // 
            // txtSlS
            // 
            this.txtSlS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSlS.Location = new System.Drawing.Point(93, 437);
            this.txtSlS.Multiline = true;
            this.txtSlS.Name = "txtSlS";
            this.txtSlS.Size = new System.Drawing.Size(198, 26);
            this.txtSlS.TabIndex = 166;
            // 
            // txtIdspS
            // 
            this.txtIdspS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdspS.Location = new System.Drawing.Point(93, 391);
            this.txtIdspS.Multiline = true;
            this.txtIdspS.Name = "txtIdspS";
            this.txtIdspS.Size = new System.Drawing.Size(198, 26);
            this.txtIdspS.TabIndex = 163;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(52, 535);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 45);
            this.btnAdd.TabIndex = 160;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // comboBoxUpdate
            // 
            this.comboBoxUpdate.FormattingEnabled = true;
            this.comboBoxUpdate.Items.AddRange(new object[] {
            "Sản phẩm trong kho",
            "Sản phẩm mới cần cập nhật vào kho"});
            this.comboBoxUpdate.Location = new System.Drawing.Point(530, 391);
            this.comboBoxUpdate.Name = "comboBoxUpdate";
            this.comboBoxUpdate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUpdate.TabIndex = 187;
            this.comboBoxUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 169;
            this.label1.Text = "Chọn môi trường";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(350, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 45);
            this.btnExit.TabIndex = 188;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UpdateStorageManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 585);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBoxUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.DataGridViewStorage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtSlS);
            this.Controls.Add(this.txtIdspS);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStorageManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessStorageManagerForm";
            this.Load += new System.EventHandler(this.UpdateStorageManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.DataGridView DataGridViewStorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtSlS;
        private System.Windows.Forms.TextBox txtIdspS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}