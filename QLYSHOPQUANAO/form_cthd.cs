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
    public partial class form_cthd : Form
    {
        xulydulieu xldl = new xulydulieu();
        DataTable dtChiTietHoaDon, dtNV, dtKH, dtSP,dthd;
        DataColumn[] key = new DataColumn[1];
        public form_cthd()
        {
            InitializeComponent();
        }
        
        private void form_cthd_Load(object sender, EventArgs e)
        {
            dtChiTietHoaDon = xldl.LayCTHDh();
            dataGridView1.DataSource = dtChiTietHoaDon;
            loadTxtSoDon();
            loadTxtTongTien();
            loadTxtTongSP();
            loadTxtSoDonHomNay();
            loadComboBoxSoHD();
            loadComboBoxNV();
            loadComboBoxKH();
            loadComboBoxSanPham();
        }
        void loadComboBoxSanPham()
        {
            dtSP = xldl.LayDSSanPham();
            cbxSP.DataSource = dtSP;
            cbxSP.DisplayMember = "MASP";
            cbxSP.ValueMember = "MASP";
        }
        void loadComboBoxSoHD()
        {
            dthd = xldl.LayDSHOADON();
            cbxSoHD.DataSource = dthd;
            cbxSoHD.DisplayMember = "SOHD";
            cbxSoHD.ValueMember = "SOHD";
        }
        void loadTxtSoDon()
        {
            txtSoDon.Text = dtChiTietHoaDon.Rows.Count.ToString();
        }
        void loadTxtTongTien()
        {
            int s = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                s += Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            txtTongTien.Text = s.ToString();
        }
        void loadTxtTongSP()
        {
            int s = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                s += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            txtTongSP.Text = s.ToString();
        }
        void loadTxtSoDonHomNay()
        {
            DateTime dateTime = DateTime.Now;
            DataView dv = dtChiTietHoaDon.AsDataView();
            dv.RowFilter = string.Format("NGHD = #{0}# ", dateTime);
            txtDonHomNay.Text = dv.Count.ToString();
        }

        private void btnLocNV_Click(object sender, EventArgs e)
        {
            string nv = cbxNV.SelectedValue.ToString();
            DataView dv = dtChiTietHoaDon.AsDataView();
            dv.RowFilter = string.Format("MANV = '{0}'", nv);
            dataGridView1.DataSource = dv;
        }

        private void btnLocHD_Click(object sender, EventArgs e)
        {
            string n = cbxSoHD.SelectedValue.ToString();
            DataView dv = dtChiTietHoaDon.AsDataView();
            dv.RowFilter = string.Format("SOHD = '{0}'", n);
            dataGridView1.DataSource = dv;
        }

        private void btnLocKH_Click(object sender, EventArgs e)
        {
            string kh = cbxKH.SelectedValue.ToString();
            DataView dv = dtChiTietHoaDon.AsDataView();
            dv.RowFilter = string.Format("MAKH = '{0}'", kh);
            dataGridView1.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtChiTietHoaDon = xldl.LayCTHDh();
            dataGridView1.DataSource = dtChiTietHoaDon;
            cbxKH.Text = "--Chọn thông tin--"; cbxNV.Text = "--Chọn thông tin--"; cbxSoHD.Text = "--Chọn thông tin--"; cbxSP.Text = "--Chọn thông tin--";
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocSP_Click(object sender, EventArgs e)
        {
            string sp = cbxSP.SelectedValue.ToString();
            DataView dv = dtChiTietHoaDon.AsDataView();
            dv.RowFilter = string.Format("MASP = '{0}'", sp);
            dataGridView1.DataSource = dv;
        }

        private void btnlocngay_Click(object sender, EventArgs e)
        {
            DataView dv = dtChiTietHoaDon.AsDataView();
            string from = Convert.ToDateTime(dateTimePicker1.Text).ToString("MM/dd/yyyy");
            string to = Convert.ToDateTime(dateTimePicker2.Text).ToString("MM/dd/yyyy");
            dv.RowFilter = string.Format("NGHD >= #{0}# AND NGHD <= #{1}#", from, to);
            dataGridView1.DataSource = dv;
        }

        void loadComboBoxNV()
        {
            dtNV = xldl.LayDSNhanvien();
            cbxNV.DataSource = dtNV;
            cbxNV.DisplayMember = "HOTEN";
            cbxNV.ValueMember = "MANV";
        }

        void loadComboBoxKH()
        {
            dtKH = xldl.LayDSkhach();
            cbxKH.DataSource = dtKH;
            cbxKH.DisplayMember = "HOTEN";
            cbxKH.ValueMember = "MAKH";
        }
        
    }
}
