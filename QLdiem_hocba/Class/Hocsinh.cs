using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLdiem_hocba
{
    class Hocsinh : Connect
    {
        public DataTable lay_tt_gioithieu(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_nguoi_dung as 'Họ Tên' ,ngay_sinh as 'Ngày Sinh',gioi_tinh as 'Giới Tính'" +
                " ,email as 'Email' ,sdt as 'SĐT' ,l.ma_lop as 'Lớp' ,l.khoa_hoc as 'Khóa'  " +
                "from TAIKHOAN tk, LOP l, HOCSINH hs " +
                "where tk.ma_tk = hs.ma_hs and l.ma_lop = hs.ma_lop and ma_tk = @matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable lay_tt_canhan(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from SOYEULYLICH where ma_tk = @ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_tt_giadinh(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from GIADINH where mahs = @ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable xem_diem(string ma_hs, string hocky)
        {
            
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select mh.ma_mon as 'Mã HS',ten_mon as 'Tên Môn',diem_15p as '15p'" +
                ",diem_1tiet as '1 Tiết',diem_giuaky as 'Điểm Giữa Kỳ'," +
                "diem_cuoiky as 'Điểm Cuối Kỳ',noidung_nhanxet  as 'Nội dung' " +
                            "from PHANCONG_GIANGDAY pc,DIEM d,MONHOC mh " +
                            "where pc.ma_phancong=d.ma_phancong and pc.ma_mon=mh.ma_mon and ma_hs=@ma_tk and hoc_ky=@hocky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_hs);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Them_baoloi(string mapc, string noidung)
        {
            openConnect();
            string sql = "Insert into PHANHOI values( @mapc, @noidung) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mapc", mapc);
            cmd.Parameters.AddWithValue("@noidung", noidung);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public bool tim_baoloi(string mapc)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(noi_dung) " +
                "from PHANHOI " +
                "where ma_phancong = @mapc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mapc", mapc);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            int x = int.Parse(bang.Rows[0][0].ToString());
            if (x > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable lay_diem(string ma_hs,string mamon, string hocky)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select diem_15p as '15p',diem_1tiet as '1 Tiết'" +
                ",diem_giuaky as 'Điểm Giữa Kỳ',diem_cuoiky as 'Điểm Cuối Kỳ' " +
                "from PHANCONG_GIANGDAY pc, DIEM d " +
                "where d.ma_phancong=pc.ma_phancong and ma_mon = @mamon and hoc_ky = @hocky and ma_hs = @ma_hs";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_hs", ma_hs);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

    }
}
