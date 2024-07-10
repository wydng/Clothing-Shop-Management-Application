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
    public partial class trangchu : Form
    {
        xulydulieu nv = new xulydulieu();
        public trangchu()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOLock.Text = DateTime.Now.ToString("G");

        }
        public string tenNV { get; set; }
        public string chucVuNV { get; set; }
        public void SetTenNhanVien(string tenNhanVien)
        {
            tenNV = tenNhanVien;
            label1.Text = "Họ tên:  " + tenNhanVien;
        }
        public void SetCV(string CVNhanVien)
        {
            chucVuNV = CVNhanVien;
            lb_chucvu.Text = chucVuNV;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblOLock.Text = DateTime.Now.ToString("G");
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            form_khachhang kh = new form_khachhang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if(lb_chucvu.Text== "Quản lý") {
                form_nhanvien nv = new form_nhanvien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
                MessageBox.Show("Không thể vào quản lý nhân viên");
        }

        private void btnSanPhamm_Click(object sender, EventArgs e)
        {
            form_sanpham sp = new form_sanpham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            Form_hoadon hd = new Form_hoadon();
            hd.MdiParent = this;
            hd.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Form_banhang  bh= new Form_banhang();
            bh.MdiParent = this;
            bh.Show();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
