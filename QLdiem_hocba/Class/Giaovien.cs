using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLdiem_hocba.Class
{
    class Giaovien : Connect
    {
        public DataTable lay_tt_gioithieu(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_nguoi_dung,ngay_sinh,gioi_tinh,email,sdt,loai_tk " +
                            "from TAIKHOAN " +
                            "where ma_tk=@ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_lop(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_mon as 'Tên Môn',l.ma_lop as 'Lớp'" +
                        "from PHANCONG_GIANGDAY pc,GIAOVIEN gv, MONHOC mh,HOCSINH hs, LOP l " +
                        "where pc.ma_gv=gv.ma_gv and pc.ma_mon=mh.ma_mon " +
                        "and pc.ma_hs=hs.ma_hs " +
                        "and l.ma_lop=hs.ma_lop and gv.ma_gv = @ma_tk " +
                        "group by  ten_mon,l.ma_lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_mon(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select mh.ma_mon " +
                "from PHANCONG_GIANGDAY pc,GIAOVIEN gv, MONHOC mh " +
                "where pc.ma_gv = gv.ma_gv and pc.ma_mon = mh.ma_mon  and gv.ma_gv = @ma_tk" +
                " group by mh.ma_mon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_mon_day(string ma_tk,string mamon, string hocky, string malop)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select hs.ma_hs as 'Mã HS', tk.ten_nguoi_dung as 'Tên HS',ngay_sinh as 'Ngày Sinh'," +
                "(diem_15p+2*diem_1tiet+2*diem_giuaky+3*diem_cuoiky)/8 as 'Điểm TB', diem_15p as '15p'," +
                "diem_1tiet as '1 Tiết',diem_giuaky as 'Giữa Kỳ',diem_cuoiky as 'Cuối Kỳ' " +
                "from PHANCONG_GIANGDAY pc,GIAOVIEN gv, MONHOC mh,HOCSINH hs, LOP l,TAIKHOAN tk, DIEM d " +
                "where  hs.ma_hs = tk.ma_tk and pc.ma_gv=gv.ma_gv and pc.ma_hs=hs.ma_hs " +
                "and pc.ma_mon=mh.ma_mon and pc.ma_phancong=d.ma_phancong and gv.ma_gv = @ma_tk " +
                "and  hs.ma_lop=@malop and mh.ma_mon = @mamon and hoc_ky = @hocky and hs.ma_lop=l.ma_lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_hslop(string ma_tk,string malop)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_nguoi_dung as 'Họ Tên',ngay_sinh as 'Ngày Sinh',gioi_tinh  as 'Giới Tính' " +
                "from HOCSINH hs,LOP l, TAIKHOAN tk, PHANCONG_GIANGDAY pc " +
                "where tk.ma_tk = hs.ma_hs and pc.ma_hs=hs.ma_hs " +
                "and hs.ma_lop=l.ma_lop and l.ma_lop = @ma_lop and ma_gv = @ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            cmd.Parameters.AddWithValue("@ma_lop", malop);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable xem_baoloi(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select hs.ma_hs as 'Mã HS' ,ma_mon as 'Mã Môn' ,ten_nguoi_dung as 'Họ Tên' ,l.ma_lop as 'Lớp' ,hoc_ky as 'Học Kỳ' , noi_dung  as 'Nội Dung' " +
                "from HOCSINH hs,LOP l, TAIKHOAN tk, PHANCONG_GIANGDAY pc, PHANHOI ph " +
                "where tk.ma_tk = hs.ma_hs and pc.ma_hs = hs.ma_hs and l.ma_lop = hs.ma_lop " +
                "and ph.ma_phancong = pc.ma_phancong and ma_gv = @ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public string lay_tobomon(string magv)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_to " +
                "from GIAOVIEN gv, TOBOMON t " +
                "where gv.to_bo_mon=t.ma_to and ma_gv = @magv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            string x = bang.Rows[0][0].ToString();
            return x;
            
        }
    }
}
