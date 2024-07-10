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
    public partial class form_sanpham : Form
    {
        xulydulieu xldu = new xulydulieu();
        public form_sanpham()
        {
            InitializeComponent();
            HienthiSanPham();
            setnull();
            cbxLoai.Text = "--Chọn loại sản phẩm--";
        }
        void HienthiSanPham()
        {
            data_sanpham.Rows.Clear();
            DataTable dt = xldu.LayDSSanPham();

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_sanpham.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_sanpham.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_sanpham.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_sanpham.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_sanpham.Rows[rowIndex].Cells[3].Value = row[3].ToString();
                data_sanpham.Rows[rowIndex].Cells[4].Value = row[4].ToString();
                data_sanpham.Rows[rowIndex].Cells[5].Value = row[5].ToString();
                data_sanpham.Rows[rowIndex].Cells[6].Value = row[6].ToString();
                data_sanpham.Rows[rowIndex].Cells[7].Value = row[7].ToString();
                data_sanpham.Rows[rowIndex].Cells[8].Value = row[8].ToString();
            }
        }
        void setnull()
        {
            txtMaSanPham.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtSoLuong.Enabled = false;
            date.Enabled = false;
            txtGiaBan.Enabled = false;
            cbtt.Enabled = false;
            cbxLoai.Enabled = false;
            txtChatLieu.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtNhaSanXuat.Clear();
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear(); txtChatLieu.Clear();
            txtTenSanPham.Focus();
            txtGiaBan.Clear();
            cbtt.Text = "--Chọn tình trạng--";
            cbxLoai.Text = "--Chọn loại sản phẩm--";
        }
        void setnotnull()
        {
            txtMaSanPham.Enabled = true;
            txtTenSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            date.Enabled = true;
            txtGiaBan.Enabled = true;
            cbtt.Enabled = true;
            cbxLoai.Enabled = true;
            txtChatLieu.Enabled = true;
            txtNhaSanXuat.Enabled = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtNhaSanXuat.Clear();
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear(); txtChatLieu.Clear();
            txtTenSanPham.Focus();
            txtGiaBan.Clear();
            cbtt.Text = "--Chọn tình trạng--";
            cbxLoai.Text = "--Chọn loại sản phẩm--";
            setnotnull();
        }
        private void data_sanpham_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy hàng được chọn từ DataGridView
            DataGridView.HitTestInfo hitTestInfo = data_sanpham.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_sanpham.Rows[hitTestInfo.RowIndex];

                // Gán giá trị từ hàng được chọn vào các TextBox
                txtMaSanPham.Text = selectedRow.Cells["Column1"].Value.ToString();
                txtTenSanPham.Text = selectedRow.Cells["Column2"].Value.ToString();
                date.Text = selectedRow.Cells["Column3"].Value.ToString();
                cbtt.Text = selectedRow.Cells["Column4"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["Column5"].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells["Column6"].Value.ToString();
                txtChatLieu.Text = selectedRow.Cells["Column7"].Value.ToString();
                txtNhaSanXuat.Text = selectedRow.Cells["Column8"].Value.ToString();
                cbxLoai.Text = selectedRow.Cells["Column9"].Value.ToString();
            }
        }

        private void data_sanpham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setnotnull();
            txtMaSanPham.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngaynhap = String.Format("{0:MM/dd/yyyy}", date.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string masp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            string sol = txtSoLuong.Text;
            string tinhtrang = cbtt.Text;
            string giaban = txtGiaBan.Text;
            string chatlieu = txtChatLieu.Text;
            string nhasx = txtChatLieu.Text;
            string maloai = cbxLoai.Text;
            try
            {
                xldu.ThemSP(masp, tensp, ngaynhap, tinhtrang, sol, giaban, chatlieu, nhasx,maloai);
                HienthiSanPham();
                setnull();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (data_sanpham.SelectedRows.Count > 0)
            {
                string selectedMASP = data_sanpham.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Gọi phương thức xóa trong điều khiển
                xldu.XoaSP(selectedMASP);
                MessageBox.Show("Xóa thành công");
                HienthiSanPham();
            }
            else
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (data_sanpham.SelectedRows.Count > 0)
            {
                string selectedMASP = data_sanpham.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Lấy giá trị mới từ các ô nhập liệu hoặc các điều khiển khác
                string ngaynhap = String.Format("{0:MM/dd/yyyy}", date.Value);
                string tensp = txtTenSanPham.Text;
                string sol = txtSoLuong.Text;
                string tinhtrang = cbtt.Text;
                string giaban = txtGiaBan.Text;
                string chatlieu = txtChatLieu.Text;
                string nhasx = txtChatLieu.Text;
                string maloai = cbxLoai.Text;

                // Gọi phương thức sửa đổi trong điều khiển
                xldu.SuaThongTinSP(selectedMASP, tensp, ngaynhap, tinhtrang, sol, giaban, chatlieu, nhasx, maloai);
                setnull();
                MessageBox.Show("Sửa sản phẩm thành công");
                // Cập nhật hiển thị hoặc thực hiện các bước khác sau khi sửa đổi
                HienthiSanPham();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa đổi");
            }
        }
        
        private void btntim_Click(object sender, EventArgs e)
        {
            data_sanpham.Rows.Clear();
            string ten = txttim.Text.Trim();
            DataTable dt = xldu.TimSP(ten);

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_sanpham.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_sanpham.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_sanpham.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_sanpham.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_sanpham.Rows[rowIndex].Cells[3].Value = row[3].ToString();
                data_sanpham.Rows[rowIndex].Cells[4].Value = row[4].ToString();
                data_sanpham.Rows[rowIndex].Cells[5].Value = row[5].ToString();
                data_sanpham.Rows[rowIndex].Cells[6].Value = row[6].ToString();
                data_sanpham.Rows[rowIndex].Cells[7].Value = row[7].ToString();
                data_sanpham.Rows[rowIndex].Cells[8].Value = row[8].ToString();
            }
        }
    }
}
