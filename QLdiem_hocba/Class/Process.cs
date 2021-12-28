using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLdiem_hocba
{
    class Process : Connect
    {
        public DataTable lay_loai_tk(string ten_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_tk,mat_khau,loai_tk from TAIKHOAN where ten_tk = @ten_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten_tk", ten_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_hocky()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select hoc_ky from PHANCONG_GIANGDAY group by hoc_ky order by hoc_ky desc ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        
        public DataTable tim_nguoidung(string matk, string noidung)
        {
            noidung = '%' + noidung + '%';
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_tk,ten_nguoi_dung,loai_tk,gioi_tinh " +
                        "from TAIKHOAN " +
                        "where (ma_tk like @noidung " +
                                "or ten_nguoi_dung like @noidung " +
                                "or email like @noidung " +
                                "or sdt like @noidung) " +
                                "and not ma_tk = @matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@noidung", noidung);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_gv_mon(string mapc)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_nguoi_dung,ten_mon " +
                            "from TAIKHOAN, PHANCONG_GIANGDAY pc,MONHOC mh " +
                            "where ma_tk=ma_gv and pc.ma_mon= mh.ma_mon and ma_phancong=@mapc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mapc", mapc);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public string lay_ten_ngdung(string ma_tk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ten_nguoi_dung from TAIKHOAN where ma_tk=@ma_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_tk", ma_tk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            string ten_ng_dung = bang.Rows[0][0].ToString();
            return ten_ng_dung;
        }
        public string lay_mapc(string mahs, string mamon, string hocky)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select pc.ma_phancong " +
                            "from PHANCONG_GIANGDAY pc, DIEM d, MONHOC mh " +
                            "where ma_hs = @mahs and pc.ma_phancong=d.ma_phancong and mh.ma_mon=pc.ma_mon " +
                                "and mh.ma_mon = @mamon " +
                                "and hoc_ky = @hocky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahs", mahs);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            string mapc = bang.Rows[0][0].ToString();
            return mapc;
        }
        public void Sua_thongtin(string matk, string ten,DateTime ngaysinh,string gt, string email, string sdt)
        {
            openConnect();
            string sql = " Update TAIKHOAN set ten_nguoi_dung=@ten, ngay_sinh=@ngaysinh, gioi_tinh=@gt, email = @email, sdt = @sdt where ma_tk = @matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gt", gt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sdt", sdt); ;
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_soyeulylich(string matk, string dantoc, string cmnd, string diachi, string noi_o_hientai)
        {
            openConnect();
            string sql = " update SOYEULYLICH set dan_toc=@dantoc, " +
                            "cmnd=@cmnd, diachi_baotin =@diachi , noi_o_hien_tai=@noi_o_hientai " +
                            "where ma_tk=@matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@dantoc", dantoc);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@noi_o_hientai", noi_o_hientai);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_diem(string mapc, float diem15p, float diem1t, float diemgiuaky, float diemcuoiky)
        {
            openConnect();
            string sql = " update DIEM set diem_15p = @diem15p, diem_1tiet = @diem1t , " +
                    "diem_giuaky = @diemgiuaky, diem_cuoiky= @diemcuoiky " +
                    "where ma_phancong = @mapc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mapc", mapc);
            cmd.Parameters.AddWithValue("@diem15p", diem15p);
            cmd.Parameters.AddWithValue("@diem1t", diem1t);
            cmd.Parameters.AddWithValue("@diemgiuaky", diemgiuaky);
            cmd.Parameters.AddWithValue("@diemcuoiky", diemcuoiky);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable lay_lop(int khoa)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_lop as 'Tên Lớp',ten_nguoi_dung as 'GV chủ nhiệm' " +
                            "from LOP, TAIKHOAN " +
                            "where ma_gv_cn=ma_tk and khoa_hoc=@khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_lop_nam(int khoa)
        {
            string x = "%" + khoa;
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_lop,ten_nguoi_dung " +
                            "from LOP, TAIKHOAN " +
                            "where ma_gv_cn=ma_tk and khoa_hoc like @khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@khoa", x);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_mon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_mon " +
                        "from MONHOC ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_hs_mon(string mamon, string hocky, string malop)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select hs.ma_hs as 'Mã HS' , tk.ten_nguoi_dung as 'Họ Tên' ,ngay_sinh as 'Ngày Sinh' ,  " +
                "diem_15p as '15p',diem_1tiet as '1 Tiết',diem_giuaky as 'Giữa Kỳ',diem_cuoiky as 'Cuối Kỳ'  " +
                "from PHANCONG_GIANGDAY pc, MONHOC mh, HOCSINH hs, LOP l, TAIKHOAN tk, DIEM d " +
                "where hs.ma_hs = tk.ma_tk and hs.ma_lop = @malop and pc.ma_mon = mh.ma_mon " +
                "and pc.ma_phancong = d.ma_phancong and hs.ma_lop=l.ma_lop " +
                "and pc.ma_mon = @mamon and hoc_ky = @hocky and pc.ma_hs = hs.ma_hs";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable tim_mon_theo_to(string tobomon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_mon,ten_mon " +
                        "from MONHOC mh, TOBOMON t where t.ma_to=mh.thong_tin_mon and t.ma_to=@tobomon ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tobomon", tobomon);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Sua_giadinh_bo(string matk,string tenbo, string dantoc, string quoctich, string nghenghiep)
        {
            openConnect();
            string sql = " update GIADINH set dantocb=@dantoc, ten_bo=@tenbo, " +
                            "nghe_nghiepb=@nghenghiep, quoc_tichb =@quoctich " +
                            "where mahs=@matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@tenbo", tenbo);
            cmd.Parameters.AddWithValue("@dantoc", dantoc);
            cmd.Parameters.AddWithValue("@quoctich", quoctich);
            cmd.Parameters.AddWithValue("@nghenghiep", nghenghiep);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_giadinh_me(string matk, string tenme, string dantoc, string quoctich, string nghenghiep)
        {
            openConnect();
            string sql = " update GIADINH set dantocm=@dantoc, ten_me=@tenme, " +
                            "nghe_nghiepm=@nghenghiep, quoc_tichm =@quoctich " +
                            "where mahs=@matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@tenme", tenme);
            cmd.Parameters.AddWithValue("@dantoc", dantoc);
            cmd.Parameters.AddWithValue("@quoctich", quoctich);
            cmd.Parameters.AddWithValue("@nghenghiep", nghenghiep);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_giadinh_gh(string matk, string tengh, string dantoc, string quoctich, string nghenghiep)
        {
            openConnect();
            string sql = " update GIADINH set dantocgh=@dantoc, ten_giamho=@tengh, " +
                            "nghe_nghiepgh=@nghenghiep, quoc_tichgh =@quoctich " +
                            "where mahs=@matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@tengh", tengh);
            cmd.Parameters.AddWithValue("@dantoc", dantoc);
            cmd.Parameters.AddWithValue("@quoctich", quoctich);
            cmd.Parameters.AddWithValue("@nghenghiep", nghenghiep);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
    }
}
