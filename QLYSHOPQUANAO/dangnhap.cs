using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYSHOPQUANAO
{
    public partial class dangnhap : Form
    {
        xulydulieu xldu = new xulydulieu();
        public dangnhap()
        {
            InitializeComponent();
            cbcv.Text = "--Chọn chức vụ--";
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string taiKhoan = txttk.Text.Trim();
            string matKhau = txtpass.Text.Trim();
            string chucvu = cbcv.Text.Trim();

            if (xldu.KiemTraDangNhap(taiKhoan, matKhau,chucvu))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                trangchu mainForm = new trangchu();
                mainForm.SetTenNhanVien(taiKhoan);
                mainForm.SetCV(chucvu);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
        }

        private void t_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dk_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangky dk = new dangky();
            dk.Show();
        }
    }
}
