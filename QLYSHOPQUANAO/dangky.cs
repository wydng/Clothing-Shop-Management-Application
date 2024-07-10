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
    public partial class dangky : Form
    {
        xulydulieu xldu = new xulydulieu();
        public dangky()
        {
            InitializeComponent();
            cbgt.Text = "--Chọn giới tính--";
            cb_cv.Text = "--Chọn chức vụ--";
        }

        

        private void dn__Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap dn = new dangnhap();
            dn.Show();
        }
        
        private void dk__Click(object sender, EventArgs e)
        {
            string ngayvaolam = String.Format("{0:MM/dd/yyyy}",date.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string manv = txtmanv.Text;
            string hoten = txtten.Text;
            string gioitinh = cbgt.Text;
            string sodt = txtsdt.Text;
            string taikhoan = txttk.Text;
            string matkhau = txtpass.Text;
            string chucvu = cb_cv.Text;
            try
            {
                xldu.ThemNhanVien(manv, hoten,gioitinh,sodt,ngayvaolam, taikhoan,matkhau,chucvu);
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            { 
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
