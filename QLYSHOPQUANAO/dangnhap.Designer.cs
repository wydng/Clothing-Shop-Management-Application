
namespace QLYSHOPQUANAO
{
    partial class dangnhap
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
            this.cbcv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Button();
            this.dn = new System.Windows.Forms.Button();
            this.dk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbcv
            // 
            this.cbcv.FormattingEnabled = true;
            this.cbcv.Items.AddRange(new object[] {
            "--Chọn chức vụ--",
            "Quản lý",
            "Nhân viên"});
            this.cbcv.Location = new System.Drawing.Point(184, 139);
            this.cbcv.Name = "cbcv";
            this.cbcv.Size = new System.Drawing.Size(233, 24);
            this.cbcv.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tài khoản";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(184, 82);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(233, 22);
            this.txtpass.TabIndex = 13;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(184, 28);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(233, 22);
            this.txttk.TabIndex = 12;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(473, 220);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(101, 36);
            this.t.TabIndex = 11;
            this.t.Text = "Thoát";
            this.t.UseVisualStyleBackColor = true;
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(259, 220);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(101, 36);
            this.dn.TabIndex = 10;
            this.dn.Text = "Đăng nhập";
            this.dn.UseVisualStyleBackColor = true;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // dk
            // 
            this.dk.Location = new System.Drawing.Point(366, 220);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(101, 36);
            this.dk.TabIndex = 9;
            this.dk.Text = "Đăng ký";
            this.dk.UseVisualStyleBackColor = true;
            this.dk.Click += new System.EventHandler(this.dk_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 325);
            this.Controls.Add(this.cbcv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.t);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.dk);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbcv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.Button dk;
    }
}