using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLYSHOPQUANAO
{
    public partial class Form_banhang : Form
    {
        xulydulieu xldl = new xulydulieu();
        public Form_banhang()
        {
            InitializeComponent();
            Hienthinv();
            Hienthikhach();
            Hienthisp();
            
        }
        void Hienthinv()
        {
            DataTable dt = xldl.LayDSNhanvien();
            cboTenNV.DataSource = dt;
            cboTenNV.DisplayMember = "HOTEN";
            cboTenNV.ValueMember = "MANV";
        }
        void Hienthikhach()
        {
            DataTable dt = xldl.LayDSkhach();
            cboTenKH.DataSource = dt;
            cboTenKH.DisplayMember = "HOTEN";
            cboTenKH.ValueMember = "MAKH";
        }
        void Hienthisp()
        {
            DataTable dt = xldl.LayDSSanPham();
            cboTenSP.DataSource = dt;
            cboTenSP.DisplayMember = "TENSP";
            cboTenSP.ValueMember = "MASP";
        }
        private void btnTTNV_Click(object sender, EventArgs e)
        {
            if (cboTenNV.SelectedValue != null)
            {
                string selectedValue = cboTenNV.SelectedValue.ToString();
                DataTable nv = xldl.LayTTNV(selectedValue);
                if (nv.Rows.Count > 0)
                {
                    txtMaNV.Text = nv.Rows[0]["MANV"].ToString();
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin cho nhân viên này.");
            }
            else
                MessageBox.Show("Vui lòng chọn một nhân viên.");
        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            if (cboTenKH.SelectedValue != null)
            {
                string selectedValue = cboTenKH.SelectedValue.ToString();
                DataTable kh = xldl.LayTTKH(selectedValue);
                if (kh.Rows.Count > 0)
                {
                    txtMaKH.Text = kh.Rows[0]["MAKH"].ToString();
                    txtDiaChi.Text = kh.Rows[0]["DCHI"].ToString();
                    txtSoDT.Text = kh.Rows[0]["SODT"].ToString();
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin cho khách hàng này.");
            }
            else
                MessageBox.Show("Vui lòng chọn một khách hàng.");
        }

        private void btnLayThongTinSP_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtSoLuong.Clear();
            txtSoLuong.Enabled = true;
            btnThanhTien.Enabled = true;
            txtThanhTien.Clear();
            if (cboTenSP.SelectedValue != null)
            {
                string selectedValue = cboTenSP.SelectedValue.ToString();
                DataTable sp = xldl.LayTTSP(selectedValue);
                if (sp.Rows.Count > 0)
                {
                    txtMaSP.Text = sp.Rows[0]["MASP"].ToString();
                    txtGiaBan.Text = sp.Rows[0]["GIABAN"].ToString();
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin cho sản phẩm này.");
            }
            else
                MessageBox.Show("Vui lòng chọn một sản phẩm.");
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                if (Regex.IsMatch(txtSoLuong.Text, @"^\d+$"))
                {
                    int sl = Convert.ToInt32(txtSoLuong.Text);
                    int giaban = Convert.ToInt32(txtGiaBan.Text);
                    int thanhtien = giaban * sl;
                    txtThanhTien.Text = thanhtien.ToString();
                }
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            string ngayhd = String.Format("{0:MM/dd/yyyy}", date.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string sohd = txtMaDonHang.Text;
            string makh = txtMaKH.Text;
            string manv = txtMaNV.Text;
            try
            {
                xldl.ThemHoaDon(sohd, ngayhd, makh, manv);
                //hienthihoadon();
                //setnull();
                MessageBox.Show("Tạo hóa đơn thành công");
            }
            catch
            {
                MessageBox.Show("Tạo hóa đơn thất bại");
            }
        }
        int tongtien;
        private void btnThem_Click(object sender, EventArgs e)
        {
            //tongtien
            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                tongtien += Convert.ToInt32(txtThanhTien.Text);
                txtTongTien.Text = tongtien.ToString(); ;
            }

            if (!string.IsNullOrEmpty(txtMaDonHang.Text))
            {

                //them dong moi vao datagrid
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = txtMaDonHang.Text;

                if (!string.IsNullOrEmpty(cboTenKH.Text))
                {
                    row.Cells[1].Value = cboTenKH.SelectedValue.ToString();
                }
                else
                {
                    row.Cells[1].Value = null;
                }
                row.Cells[2].Value = cboTenNV.SelectedValue.ToString();
                row.Cells[3].Value = date.Value;
                row.Cells[4].Value = txtGiaBan.Text;
                row.Cells[5].Value = cboTenSP.SelectedValue.ToString();
                row.Cells[6].Value = txtSoLuong.Text;
                row.Cells[7].Value = txtThanhTien.Text;
                dataGridView1.Rows.Add(row);
            }
            else
                MessageBox.Show("Kiem tra lai ma don hang");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //tru gia san pham da xoa trong tong tien
            int sotiencantru = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            tongtien -= sotiencantru;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sohd = txtMaDonHang.Text;
            string masp = txtMaSP.Text;
            string sl = txtSoLuong.Text;
            string dongia = txtGiaBan.Text;
            string tt = txtThanhTien.Text;
            try
            {
                xldl.ThemCTHD(sohd, masp, sl, dongia,tt);
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnThemMoiHoaDon_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();txtMaDonHang.Clear();txtMaKH.Clear();txtMaNV.Clear();
            cboTenKH.Text = "--Chọn tên khách hàng--";cboTenNV.Text = "--Chọn tên nhân viên--";
            txtSoDT.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
