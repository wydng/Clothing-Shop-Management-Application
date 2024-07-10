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
    public partial class form_khachhang : Form
    {
        xulydulieu xldu = new xulydulieu();
        public form_khachhang()
        {
            InitializeComponent();
            cbxGioiTinh.Text = "--Chọn giới tính--";
            setnull();
            HienthiKhachHang();
        }
        void HienthiKhachHang()
        {
            data_khachhang.Rows.Clear();
            DataTable dt = xldu.LayDSkhach();

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_khachhang.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_khachhang.Rows[rowIndex].Cells[0].Value = row[0].ToString(); 
                data_khachhang.Rows[rowIndex].Cells[1].Value = row[1].ToString(); 
                data_khachhang.Rows[rowIndex].Cells[2].Value = row[2].ToString(); 
                data_khachhang.Rows[rowIndex].Cells[3].Value = row[3].ToString(); 
                data_khachhang.Rows[rowIndex].Cells[4].Value = row[4].ToString(); 
             
            }
        }
        void setnull()
        {
            txtMaKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenKhachHang.Enabled = false;
            cbxGioiTinh.Enabled = false;
            
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            cbxGioiTinh.Text = "--Chọn giới tính--";
        }
        void setnotnull()
        {
            txtDiaChi.Enabled = true;
            txtMaKhachHang.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtSoDienThoai.Enabled = true;
            cbxGioiTinh.Enabled = true;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setnotnull();
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            cbxGioiTinh.Text = "--Chọn giới tính--";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manv = txtMaKhachHang.Text;
            string hoten = txtTenKhachHang.Text;
            string gioitinh = cbxGioiTinh.Text;
            string sodt = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            try
            {
                xldu.ThemKHachHang(manv, hoten, gioitinh, diachi,sodt);
                HienthiKhachHang();
                setnull();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (data_khachhang.SelectedRows.Count > 0)
            {
                string selectedMAKH = data_khachhang.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Gọi phương thức xóa trong điều khiển
                xldu.XoakhachHang(selectedMAKH);
                MessageBox.Show("Xóa thành công");
                HienthiKhachHang();
            }
            else
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
        }

        private void data_khachhang_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy hàng được chọn từ DataGridView
            DataGridView.HitTestInfo hitTestInfo = data_khachhang.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_khachhang.Rows[hitTestInfo.RowIndex];

                // Gán giá trị từ hàng được chọn vào các TextBox
                txtMaKhachHang.Text = selectedRow.Cells["Column1"].Value.ToString();
                txtTenKhachHang.Text = selectedRow.Cells["Column2"].Value.ToString();
                cbxGioiTinh.Text = selectedRow.Cells["Column3"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["Column4"].Value.ToString();
                txtSoDienThoai.Text = selectedRow.Cells["Column5"].Value.ToString();
            }
        }

        private void data_khachhang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setnotnull();
            txtMaKhachHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (data_khachhang.SelectedRows.Count > 0)
            {
                string selectedMAKH = data_khachhang.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Lấy giá trị mới từ các ô nhập liệu hoặc các điều khiển khác
                string newHoten = txtMaKhachHang.Text;
                
                string newGioitinh = cbxGioiTinh.Text;
                string newSodt = txtSoDienThoai.Text;
                string newdiachi = txtDiaChi.Text;

                // Gọi phương thức sửa đổi trong điều khiển
                xldu.SuaThongTinkhach(selectedMAKH, newHoten, newGioitinh, newSodt, newdiachi);
                setnull();

                // Cập nhật hiển thị hoặc thực hiện các bước khác sau khi sửa đổi
                HienthiKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa đổi");
            }
        }
        
        private void btntim_Click(object sender, EventArgs e)
        {
            string ht = txttim.Text.Trim();
            DataTable dt = xldu.TimKH(ht);
            data_khachhang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_khachhang.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_khachhang.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_khachhang.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_khachhang.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_khachhang.Rows[rowIndex].Cells[3].Value = row[3].ToString();
                data_khachhang.Rows[rowIndex].Cells[4].Value = row[4].ToString();

            }
        }

        private void grbkhachhang_Enter(object sender, EventArgs e)
        {

        }
    }
}
