    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLYSHOPQUANAO
{
    class xulydulieu
    {
        ketnoi db;
        public xulydulieu()
        {
            db = new ketnoi();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "select * from nhanvien";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool KiemTraDangNhap(string taiKhoan, string matKhau, string chucvu)
        {
            // Thực hiện truy vấn kiểm tra đăng nhập trong CSDL
            string query = string.Format("SELECT COUNT(*) FROM nhanvien WHERE taikhoan = '{0}' AND matkhau = '{1}' AND chucvu = N'{2}'", taiKhoan,matKhau, chucvu);
            DataTable result = db.Execute(query);

            // Kiểm tra nếu có ít nhất một dòng trong kết quả
            if (result.Rows.Count > 0)
            {
                // Lấy giá trị trong cột đầu tiên của dòng đầu tiên
                int count = Convert.ToInt32(result.Rows[0][0]);

                return count > 0;
            }

            return false;
        }
        public void ThemNhanVien(string manv, string hoten,string gioitinh, string sodt, string ngayvaolam,string taikhoan,string matkhau,string chucvu)
        {
            string sql = "INSERT INTO NhanVien VALUES(@Manv, @Hoten, @Gioitinh, @Sodt, @Ngayvaolam, @Taikhoan, @Matkhau, @Chucvu)";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@Manv", manv);
            cmd.Parameters.AddWithValue("@Hoten", hoten);
            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@Sodt", sodt);
            cmd.Parameters.AddWithValue("@Ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@Taikhoan", taikhoan);
            cmd.Parameters.AddWithValue("@Matkhau", matkhau);
            cmd.Parameters.AddWithValue("@Chucvu", chucvu);

            db.ExecuteNonQuery(cmd);
        }
        public DataTable LayDSkhach()
        {
            string strSQL = "select * from khachhang";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayCTHDh()
        {
            string strSQL = "select * from XuatHoaDon";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayDSSanPham()
        {
            string strSQL = "select * from sanpham";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable TimSP(string tensp)
        {
            string strSQL = "SELECT * FROM SANPHAM WHERE TENSP LIKE '%' + @ten + '%'";
            SqlCommand cmd = new SqlCommand(strSQL, db.GetConnection());
            cmd.Parameters.AddWithValue("@ten", tensp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDSHOADON()
        {
            string strSQL = "select * from HOADON";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayTTNV(string tennv)
        {
            string strSQL = "select * from NHANVIEN where MANV = @manv";
            SqlCommand cmd = new SqlCommand(strSQL,db.GetConnection());
            cmd.Parameters.AddWithValue("@manv", tennv);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayTTSP(string tensp)
        {
            string strSQL = "select * from SANPHAM where MASP = @masp";
            SqlCommand cmd = new SqlCommand(strSQL, db.GetConnection());
            cmd.Parameters.AddWithValue("@masp", tensp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayTTKH(string tenkh)
        {
            string strSQL = "select * from KhachHang where MAKH = @makh";
            SqlCommand cmd = new SqlCommand(strSQL, db.GetConnection());
            cmd.Parameters.AddWithValue("@makh", tenkh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimNV(string tennv)
        {
            string strSQL = "SELECT * FROM NHANVIEN WHERE HOTEN LIKE '%' + @tennv + '%'";
            SqlCommand cmd = new SqlCommand(strSQL, db.GetConnection());
            cmd.Parameters.AddWithValue("@tennv", tennv);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimKH(string tenkh)
        {
            string strSQL = "SELECT * FROM KHACHHANG WHERE HOTEN LIKE '%' + @tenkh + '%'";
            SqlCommand cmd = new SqlCommand(strSQL, db.GetConnection());
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool XoaNhanVien(string manv)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MANV = @manv";
                SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@manv", manv);

                db.ExecuteNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void SuaThongTinNhanVien(string manv, string newHoten, string newGioitinh, string newSodt, string newNgayvaolam, string newTaikhoan, string newMatkhau, string newChucvu)
        {
            string sql = "UPDATE NhanVien SET HOTEN = @hoten, GIOITINH = @gioitinh, SODT = @sodt, NGAYVAOLAM = @ngayvaolam, TAIKHOAN = @taikhoan, MATKHAU = @matkhau, CHUCVU = @chucvu WHERE MANV = @manv";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            // Thêm tham số để tránh lỗ hổng SQL Injection
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@hoten", newHoten);
            cmd.Parameters.AddWithValue("@gioitinh", newGioitinh);
            cmd.Parameters.AddWithValue("@sodt", newSodt);
            cmd.Parameters.AddWithValue("@ngayvaolam", newNgayvaolam);
            cmd.Parameters.AddWithValue("@taikhoan", newTaikhoan);
            cmd.Parameters.AddWithValue("@matkhau", newMatkhau);
            cmd.Parameters.AddWithValue("@chucvu", newChucvu);

            db.ExecuteNonQuery(cmd);
        }
        public void ThemKHachHang(string manv, string hoten, string gioitinh, string diachi, string sodt)
        {
            string sql = "INSERT INTO KhachHang VALUES(@Manv, @Hoten, @Gioitinh, @DChi, @SODT)";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@Manv", manv);
            cmd.Parameters.AddWithValue("@Hoten", hoten);
            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@Sodt", sodt);
            cmd.Parameters.AddWithValue("@DChi", diachi);

            db.ExecuteNonQuery(cmd);
        }
        public bool XoakhachHang(string makh)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MAKH = @makh";
                SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@makh", makh);

                db.ExecuteNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void SuaThongTinkhach(string makh, string newHoten, string newGioitinh, string newSodt, string newdiachi)
        {
            string sql = "UPDATE KhachHang SET HOTEN = @hoten, GIOITINH = @gioitinh, DCHI=@dchi,SODT = @sodt WHERE MAKH = @makh";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            // Thêm tham số để tránh lỗ hổng SQL Injection
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@hoten", newHoten);
            cmd.Parameters.AddWithValue("@gioitinh", newGioitinh);
            cmd.Parameters.AddWithValue("@sodt", newSodt);
            cmd.Parameters.AddWithValue("@dchi", newdiachi);

            db.ExecuteNonQuery(cmd);
        }
        public void ThemSP(string masp, string tensp, string ngaynhap, string tinhtrang, string sol,string giaban,string chatlieu,string nhasx,string loai)
        {
            string sql = "INSERT INTO SANPHAM VALUES(@masp, @tensp, @ngaynhap, @tinhtrang, @soluong,@giaban,@chatlieu,@nhasx,@maloai)";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);
            cmd.Parameters.AddWithValue("@soluong", sol);
            cmd.Parameters.AddWithValue("@giaban", giaban);
            cmd.Parameters.AddWithValue("@chatlieu", chatlieu);
            cmd.Parameters.AddWithValue("@nhasx", nhasx);
            cmd.Parameters.AddWithValue("@maloai", loai);

            db.ExecuteNonQuery(cmd);
        }
        public bool XoaSP(string masp)
        {
            try
            {
                string sql = "DELETE FROM SANPHAM WHERE MASP = @masp";
                SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@masp", masp);

                db.ExecuteNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void SuaThongTinSP(string masp, string tensp, string ngaynhap, string tinhtrang, string sol, string giaban, string chatlieu, string nhasx, string loai)
        {
            string sql = "UPDATE SANPHAM SET tensp = @tensp, ngaynhap = @ngaynhap, tinhtrang=@tinhtrang,soluong = @soluong,giaban=@giaban,chatlieu=@chatlieu,nhasx=@nhasx,maloai=@maloai WHERE MASP = @masp";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            // Thêm tham số để tránh lỗ hổng SQL Injection
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);
            cmd.Parameters.AddWithValue("@soluong", sol);
            cmd.Parameters.AddWithValue("@giaban", giaban);
            cmd.Parameters.AddWithValue("@chatlieu", chatlieu);
            cmd.Parameters.AddWithValue("@nhasx", nhasx);
            cmd.Parameters.AddWithValue("@maloai", loai);

            db.ExecuteNonQuery(cmd);
        }
        public void ThemHoaDon(string sohd, string ngayhd, string makh, string manv)
        {
            string sql = "INSERT INTO HOADON VALUES(@SOHD, @NGHD, @MAKH, @MANV)";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@SOHD", sohd);
            cmd.Parameters.AddWithValue("@NGHD", ngayhd);
            cmd.Parameters.AddWithValue("@MAKH", makh);
            cmd.Parameters.AddWithValue("@MANV", manv);

            db.ExecuteNonQuery(cmd);
        }
        public bool XoaHD(string sohd)
        {
            try
            {
                string sql = "DELETE FROM HOADON WHERE SOHD = @sohd";
                SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@sohd", sohd);

                db.ExecuteNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void SuaThongTinHD(string sohd, string ngayhd,  string makh, string manv)
        {
            string sql = "UPDATE HOADON SET NGHD = @NGHD, MAKH=@MAKH,MANV = @MANV WHERE SOHD = @SOHD";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@SOHD", sohd);
            cmd.Parameters.AddWithValue("@NGHD", ngayhd);
            cmd.Parameters.AddWithValue("@MAKH", makh);
            cmd.Parameters.AddWithValue("@MANV", manv);

            db.ExecuteNonQuery(cmd);
        }
        public void ThemCTHD(string sohd, string masp, string sl, string dongia, string thanhtien)
        {
            string sql = "INSERT INTO CTHD VALUES(@SOHD, @MASP, @SL, @DONGIA, @THANHTIEN)";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@SOHD", sohd);
            cmd.Parameters.AddWithValue("@MASP", masp);
            cmd.Parameters.AddWithValue("@SL", sl);
            cmd.Parameters.AddWithValue("@DONGIA", dongia);
            cmd.Parameters.AddWithValue("@THANHTIEN", thanhtien);

            db.ExecuteNonQuery(cmd);
        }
    }
}
