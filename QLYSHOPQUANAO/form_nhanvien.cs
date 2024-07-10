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
    public partial class form_nhanvien : Form
    {
        xulydulieu xldu = new xulydulieu();
        public form_nhanvien()
        {
            InitializeComponent();
            cbxGioiTinh.Text = "--Chọn giới tính--";
            cbcv.Text = "--Chọn chức vụ--";
            HienthiNhanVien();
            setnull();
        }
        void HienthiNhanVien()
        {
            data_nhanvien.Rows.Clear();
            DataTable dt = xldu.LayDSNhanvien();

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_nhanvien.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_nhanvien.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_nhanvien.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_nhanvien.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_nhanvien.Rows[rowIndex].Cells[3].Value = row[3].ToString();
                data_nhanvien.Rows[rowIndex].Cells[4].Value = row[4].ToString();
                data_nhanvien.Rows[rowIndex].Cells[5].Value = row[5].ToString();
                data_nhanvien.Rows[rowIndex].Cells[6].Value = row[6].ToString();
                data_nhanvien.Rows[rowIndex].Cells[7].Value = row[7].ToString();

            }
        }
        void setnull()
        {
            txtMaNV.Enabled = false;
            txtmk.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtSDT.Enabled = false;
            txttk.Enabled = false;
            date.Enabled = false;
            cbcv.Enabled = false;
            cbxGioiTinh.Enabled = false;
            txtMaNV.Clear();
            txtTenNhanVien.Clear();
            txtSDT.Clear();
            txttk.Clear(); txtmk.Clear();
            txtMaNV.Focus();
            date.DataBindings.Clear();
            cbcv.Text = "--Chọn chức vụ--";
            cbxGioiTinh.Text = "--Chọn giới tính--";
        }
        void setnotnull()
        {
            txtMaNV.Enabled = true;
            txtmk.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtSDT.Enabled = true;
            txttk.Enabled = true;
            date.Enabled = true;
            cbcv.Enabled = true;
            cbxGioiTinh.Enabled = true;
            
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnotnull();
            txtMaNV.Clear();
            txtTenNhanVien.Clear();
            txtSDT.Clear();
            txttk.Clear(); txtmk.Clear();
            txtMaNV.Focus();
            date.DataBindings.Clear();
            cbcv.Text = "--Chọn chức vụ--";
            cbxGioiTinh.Text = "--Chọn giới tính--";
        }

        private void data_nhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy hàng được chọn từ DataGridView
            DataGridView.HitTestInfo hitTestInfo = data_nhanvien.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_nhanvien.Rows[hitTestInfo.RowIndex];

                // Gán giá trị từ hàng được chọn vào các TextBox
                txtMaNV.Text = selectedRow.Cells["Column1"].Value.ToString();
                txtTenNhanVien.Text = selectedRow.Cells["Column2"].Value.ToString();
                cbxGioiTinh.Text = selectedRow.Cells["Column3"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["Column4"].Value.ToString();
                date.Text = selectedRow.Cells["Column5"].Value.ToString();
                txttk.Text = selectedRow.Cells["Column6"].Value.ToString();
                txtmk.Text = selectedRow.Cells["Column7"].Value.ToString();
                cbcv.Text = selectedRow.Cells["Column8"].Value.ToString();
                
            }
        }

        private void data_nhanvien_DoubleClick(object sender, EventArgs e)
        {
            setnotnull();
            txtMaNV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayvaolam = String.Format("{0:MM/dd/yyyy}", date.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string manv = txtMaNV.Text;
            string hoten = txtTenNhanVien.Text;
            string gioitinh = cbxGioiTinh.Text;
            string sodt = txtSDT.Text;
            string taikhoan = txttk.Text;
            string matkhau = txtmk.Text;
            string chucvu = cbcv.Text;
            try
            {
                xldu.ThemNhanVien(manv, hoten, gioitinh, sodt, ngayvaolam, taikhoan, matkhau, chucvu);
                HienthiNhanVien();
                setnull();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (data_nhanvien.SelectedRows.Count > 0)
            {
                string selectedMANV = data_nhanvien.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Gọi phương thức xóa trong điều khiển
                xldu.XoaNhanVien(selectedMANV);
                MessageBox.Show("Xóa thành công");
                HienthiNhanVien();
            }
            else
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (data_nhanvien.SelectedRows.Count > 0)
            {
                string selectedMANV = data_nhanvien.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Lấy giá trị mới từ các ô nhập liệu hoặc các điều khiển khác
                string newHoten = txtTenNhanVien.Text;
                string newGioitinh = cbxGioiTinh.Text;
                string newSodt = txtSDT.Text;
                string newNgayvaolam = String.Format("{0:MM/dd/yyyy}", date.Value);
                string newTaikhoan = txttk.Text;
                string newMatkhau = txtmk.Text;
                string newChucvu = cbcv.Text;

                // Gọi phương thức sửa đổi trong điều khiển
                xldu.SuaThongTinNhanVien(selectedMANV, newHoten, newGioitinh, newSodt, newNgayvaolam, newTaikhoan, newMatkhau, newChucvu);
                setnull();
                
                // Cập nhật hiển thị hoặc thực hiện các bước khác sau khi sửa đổi
                HienthiNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa đổi");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string ht = txttim.Text.Trim();
            data_nhanvien.Rows.Clear();
            DataTable dt = xldu.TimNV(ht);

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_nhanvien.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_nhanvien.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_nhanvien.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_nhanvien.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_nhanvien.Rows[rowIndex].Cells[3].Value = row[3].ToString();
                data_nhanvien.Rows[rowIndex].Cells[4].Value = row[4].ToString();
                data_nhanvien.Rows[rowIndex].Cells[5].Value = row[5].ToString();
                data_nhanvien.Rows[rowIndex].Cells[6].Value = row[6].ToString();
                data_nhanvien.Rows[rowIndex].Cells[7].Value = row[7].ToString();

            }
        }
    }
}
