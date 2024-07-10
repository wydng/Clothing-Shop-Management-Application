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
    public partial class Form_hoadon : Form
    {
        xulydulieu xldl = new xulydulieu();
        public Form_hoadon()
        {
            InitializeComponent();
            hienthihoadon();
            Hienthimakh();
            setnull();
            Hienthimanv();
        }
        void hienthihoadon()
        {
            data_hoadon.Rows.Clear();
            DataTable dt = xldl.LayDSHOADON();

            foreach (DataRow row in dt.Rows)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = data_hoadon.Rows.Add();

                // Gán giá trị từ DataTable vào các ô tương ứng trong DataGridView
                data_hoadon.Rows[rowIndex].Cells[0].Value = row[0].ToString();
                data_hoadon.Rows[rowIndex].Cells[1].Value = row[1].ToString();
                data_hoadon.Rows[rowIndex].Cells[2].Value = row[2].ToString();
                data_hoadon.Rows[rowIndex].Cells[3].Value = row[3].ToString();
            }
        }
        void setnull()
        {
            txtsohd.Enabled = false;
            date.Enabled = false;
            cbxKH.Enabled = false;
            cbxNV.Enabled = false;
            txtsohd.Clear();
            cbxNV.Text = "--Chọn nhân viên--";
            cbxKH.Text = "--Chọn khách hàng--";
        }
        void setnotnull()
        {
            txtsohd.Enabled = true;
            date.Enabled = true;
            cbxKH.Enabled = true;
            cbxNV.Enabled = true;
        }
        private void data_hoadon_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy hàng được chọn từ DataGridView
            DataGridView.HitTestInfo hitTestInfo = data_hoadon.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_hoadon.Rows[hitTestInfo.RowIndex];

                // Gán giá trị từ hàng được chọn vào các TextBox
                txtsohd.Text = selectedRow.Cells["Column1"].Value.ToString();
                date.Text = selectedRow.Cells["Column2"].Value.ToString();
                cbxNV.Text = selectedRow.Cells["Column4"].Value.ToString();
                cbxKH.Text = selectedRow.Cells["Column3"].Value.ToString();
            }
        }

        private void data_hoadon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setnotnull();
            txtsohd.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            setnotnull();
            txtsohd.Clear();
            cbxNV.Text = "--Chọn nhân viên--";
            cbxKH.Text = "--Chọn khách hàng--";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayhd = String.Format("{0:MM/dd/yyyy}", date.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string sohd = txtsohd.Text;
            string makh = cbxKH.Text;
            string manv = cbxNV.Text;
            try
            {
                xldl.ThemHoaDon(sohd,ngayhd,makh,manv);
                hienthihoadon();
                setnull();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (data_hoadon.SelectedRows.Count > 0)
            {
                string selectedSOHD = data_hoadon.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Gọi phương thức xóa trong điều khiển
                xldl.XoaHD(selectedSOHD);
                MessageBox.Show("Xóa thành công");
                hienthihoadon();
            }
            else
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa");
        }
        void Hienthimakh()
        {
            DataTable dt = xldl.LayDSkhach();
            cbxKH.DataSource = dt;
            cbxKH.DisplayMember = "MAKH";
            cbxKH.ValueMember = "MAKH";
        }
        void Hienthimanv()
        {
            DataTable dt = xldl.LayDSNhanvien();
            cbxNV.DataSource = dt;
            cbxNV.DisplayMember = "MANV";
            cbxNV.ValueMember = "MANV";
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (data_hoadon.SelectedRows.Count > 0)
            {
                string selectedHD = data_hoadon.SelectedRows[0].Cells["Column1"].Value.ToString();

                // Lấy giá trị mới từ các ô nhập liệu hoặc các điều khiển khác
                
                string newNgay = String.Format("{0:MM/dd/yyyy}", date.Value);
                string makh = cbxKH.Text;
                string manv= cbxNV.Text;

                // Gọi phương thức sửa đổi trong điều khiển
                xldl.SuaThongTinHD(selectedHD,newNgay,makh,manv);
                setnull();
                MessageBox.Show("Sửa thành công");
                // Cập nhật hiển thị hoặc thực hiện các bước khác sau khi sửa đổi
                hienthihoadon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa đổi");
            }
        }

        private void btncthd_Click(object sender, EventArgs e)
        {
            form_cthd cthd_ = new form_cthd();
            cthd_.Show();
        }
    }
}
