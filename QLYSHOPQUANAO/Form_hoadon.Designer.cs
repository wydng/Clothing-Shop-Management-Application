
namespace QLYSHOPQUANAO
{
    partial class Form_hoadon
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
            this.data_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbthongtinhoadon = new System.Windows.Forms.GroupBox();
            this.btncthd = new System.Windows.Forms.Button();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).BeginInit();
            this.grbthongtinhoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_hoadon
            // 
            this.data_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_hoadon.Location = new System.Drawing.Point(41, 456);
            this.data_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_hoadon.Name = "data_hoadon";
            this.data_hoadon.RowHeadersWidth = 51;
            this.data_hoadon.RowTemplate.Height = 24;
            this.data_hoadon.Size = new System.Drawing.Size(1383, 207);
            this.data_hoadon.TabIndex = 6;
            this.data_hoadon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_hoadon_MouseClick);
            this.data_hoadon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_hoadon_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhân viên lập HĐ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // grbthongtinhoadon
            // 
            this.grbthongtinhoadon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbthongtinhoadon.Controls.Add(this.btncthd);
            this.grbthongtinhoadon.Controls.Add(this.cbxKH);
            this.grbthongtinhoadon.Controls.Add(this.cbxNV);
            this.grbthongtinhoadon.Controls.Add(this.date);
            this.grbthongtinhoadon.Controls.Add(this.btnLuu);
            this.grbthongtinhoadon.Controls.Add(this.btnsua);
            this.grbthongtinhoadon.Controls.Add(this.btnxoa);
            this.grbthongtinhoadon.Controls.Add(this.btnthem);
            this.grbthongtinhoadon.Controls.Add(this.txtsohd);
            this.grbthongtinhoadon.Controls.Add(this.txtmasp);
            this.grbthongtinhoadon.Controls.Add(this.label5);
            this.grbthongtinhoadon.Controls.Add(this.label4);
            this.grbthongtinhoadon.Controls.Add(this.label3);
            this.grbthongtinhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtinhoadon.Location = new System.Drawing.Point(41, 97);
            this.grbthongtinhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbthongtinhoadon.Name = "grbthongtinhoadon";
            this.grbthongtinhoadon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbthongtinhoadon.Size = new System.Drawing.Size(1383, 355);
            this.grbthongtinhoadon.TabIndex = 5;
            this.grbthongtinhoadon.TabStop = false;
            this.grbthongtinhoadon.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // btncthd
            // 
            this.btncthd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncthd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncthd.ImageKey = "details_page_window_icon_177272.ico";
            this.btncthd.Location = new System.Drawing.Point(1139, 235);
            this.btncthd.Margin = new System.Windows.Forms.Padding(4);
            this.btncthd.Name = "btncthd";
            this.btncthd.Size = new System.Drawing.Size(211, 57);
            this.btncthd.TabIndex = 18;
            this.btncthd.Text = "Chi Tiết Hóa Đơn";
            this.btncthd.UseVisualStyleBackColor = false;
            this.btncthd.Click += new System.EventHandler(this.btncthd_Click);
            // 
            // cbxKH
            // 
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(831, 113);
            this.cbxKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(249, 30);
            this.cbxKH.TabIndex = 17;
            // 
            // cbxNV
            // 
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(831, 48);
            this.cbxNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(249, 30);
            this.cbxNV.TabIndex = 17;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(249, 123);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 30);
            this.date.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "icons8-save-60.png";
            this.btnLuu.Location = new System.Drawing.Point(716, 235);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 59);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.ImageKey = "353430-checkbox-edit-pen-pencil_107516.png";
            this.btnsua.Location = new System.Drawing.Point(513, 235);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 66);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.ImageKey = "1486564399-close_81512.png";
            this.btnxoa.Location = new System.Drawing.Point(301, 235);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 66);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "XÓA ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.ImageKey = "add_plus_insert_more_icon_134652.png";
            this.btnthem.Location = new System.Drawing.Point(93, 235);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 66);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(249, 48);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(249, 30);
            this.txtsohd.TabIndex = 6;
            // 
            // txtmasp
            // 
            this.txtmasp.AutoSize = true;
            this.txtmasp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasp.Location = new System.Drawing.Point(628, 123);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(148, 19);
            this.txtmasp.TabIndex = 3;
            this.txtmasp.Text = "MÃ KHÁCH HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = " NHÂN VIÊN LẬP HĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "NGÀY LẬP HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "SỐ HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1503, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLOTHING SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 747);
            this.Controls.Add(this.data_hoadon);
            this.Controls.Add(this.grbthongtinhoadon);
            this.Controls.Add(this.label1);
            this.Name = "Form_hoadon";
            this.Text = "Form_hoadon";
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).EndInit();
            this.grbthongtinhoadon.ResumeLayout(false);
            this.grbthongtinhoadon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_hoadon;
        private System.Windows.Forms.GroupBox grbthongtinhoadon;
        private System.Windows.Forms.Button btncthd;
        private System.Windows.Forms.ComboBox cbxKH;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label txtmasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbxNV;
    }
}