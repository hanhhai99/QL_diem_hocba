using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLdiem_hocba.Class
{
    class Nhanvien: Connect
    {
        public string lay_sltk(string loai)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_tk) " +
                "from TAIKHOAN " +
                "where loai_tk = @loai";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang.Rows[0][0].ToString();
        }
        public DataTable lay_tk(string loai)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_tk as 'Mã TK' ,ten_nguoi_dung as 'Họ Tên' ,ten_tk as 'Tên TK' ,gioi_tinh as 'Giới Tính' ,ngay_sinh  as 'Ngày Sinh' " +
                "from TAIKHOAN " +
                "where loai_tk = @loai";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_mon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from MONHOC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Them_mon(string mamon, string tenmon,int sotiet, string gioithieu)
        {
            openConnect();
            string sql = "Insert into MONHOC values( @mamon,@tenmon,@sotiet,@gioithieu) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@tenmon", tenmon);
            cmd.Parameters.AddWithValue("@sotiet", sotiet);
            cmd.Parameters.AddWithValue("@gioithieu", gioithieu);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Xoa_mon(string mamon)
        {
            openConnect();
            string sql = "Delete MONHOC where ma_mon = @mamon ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public int kt_mon(string mamon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_phancong) " +
                            "from PHANCONG_GIANGDAY " +
                            "where ma_mon=@mamon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return int.Parse(bang.Rows[0][0].ToString());
        }
        public void Tao_tk(string matk, string tentk,string mk,string loai, string tenng,DateTime ngaysinh, string gioitinh)
        {
            openConnect();
            string sql = "insert into TAIKHOAN (ma_tk,ten_tk,mat_khau,loai_tk,ten_nguoi_dung,ngay_sinh,gioi_tinh) " +
                    "values(@matk,@tentk,@mk,@loai,@tenng,@ngaysinh,@gioitinh) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            cmd.Parameters.AddWithValue("@tentk", tentk);
            cmd.Parameters.AddWithValue("@mk", mk);
            cmd.Parameters.AddWithValue("@loai", loai);
            cmd.Parameters.AddWithValue("@tenng", tenng);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Tao_hs(string mahs, string malop, int khoa)
        {
            openConnect();
            string sql = "insert into HOCSINH values (@mahs,@malop,@khoa)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahs", mahs);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Tao_gv(string magv, string mato, string trinhdo)
        {
            openConnect();
            string sql = "insert into GIAOVIEN values (@magv,@mato,@trinhdo)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@mato", mato);
            cmd.Parameters.AddWithValue("@trinhdo", trinhdo);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Tao_nv(string magv, string chuvu)
        {
            openConnect();
            string sql = "insert into NHANVIEN values (@magv,@chuvu)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@chuvu", chuvu);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable lay_lop()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_lop from LOP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_to()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_to from TOBOMON";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public int kiemtra_mataikhoan(string matk)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_tk) from TAIKHOAN where ma_tk=@matk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@matk", matk);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return int.Parse(bang.Rows[0][0].ToString());
        }
        public DataTable tim_hslop( string malop)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select HS.ma_hs  as 'Mã HS' ,ten_nguoi_dung as 'Họ Tên' ,ngay_sinh as 'Ngày Sinh'  " +
                "from HOCSINH hs,LOP l, TAIKHOAN tk " +
                "where tk.ma_tk = hs.ma_hs and l.ma_lop=hs.ma_lop and l.ma_lop = @ma_lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_lop", malop);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool check_hslop(string malop)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select HS.ma_hs,ten_nguoi_dung,ngay_sinh " +
                "from HOCSINH hs,LOP l, TAIKHOAN tk " +
                "where tk.ma_tk = hs.ma_hs and l.ma_lop=hs.ma_lop and l.ma_lop = @ma_lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_lop", malop);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            if (bang.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable lay_gv(string tobomon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select gv.ma_gv as 'Mã GV' ,ten_nguoi_dung as 'Họ Tên',to_bo_mon as 'Tổ' " +
                            "from TOBOMON t,GIAOVIEN gv,TAIKHOAN " +
                            "where gv.ma_gv=ma_tk and t.ma_to=gv.to_bo_mon and to_bo_mon =@tobomon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tobomon", tobomon);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_pc(string tobomon,string hocky)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select mh.ma_mon as 'Mã Môn' ,ma_gv as 'Mã GV',ten_nguoi_dung as 'Họ Tên'" +
                " ,hs.ma_lop as 'Lớp',pc.hoc_ky  as 'Học Kỳ'  " +
                "from PHANCONG_GIANGDAY pc,TAIKHOAN tk, HOCSINH hs,TOBOMON t, MONHOC mh " +
                " where ma_gv = ma_tk and ma_to = @tobomon and pc.hoc_ky = @hocky and " +
                "pc.ma_mon = mh.ma_mon and t.ma_to = mh.thong_tin_mon and hs.ma_hs = pc.ma_hs " +
                "group by mh.ma_mon,ma_gv,ten_nguoi_dung,hs.ma_lop,hoc_ky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tobomon", tobomon);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable lay_tobomon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_to from TOBOMON";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public string lay_hocky_moi()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select hoc_ky from PHANCONG_GIANGDAY order by hoc_ky desc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            string x;
            if (bang.Rows.Count == 0)
            {
                if (DateTime.Now.Month < 7)
                {
                    x= "kỳ 2" + " năm " + (DateTime.Now.Year - 1);
                }
                else
                {
                    x = "kỳ 1" + " năm " + (DateTime.Now.Year);
                }
            }
            else
            {
                x = bang.Rows[0][0].ToString();

            }
            
            string x1 = x.Substring(3, 1);
            string x2 = x.Substring(x.Length-4, 4);
            string x3="";

            int ky = int.Parse(x1);
            int nam = int.Parse(x2);
            if (ky == 1)
            {
                ky = 2;
                x3 += "kỳ " + ky + " Năm " + nam;
            }
            else if (ky == 2)
            {
                ky = 1;
                nam++;
                x3 += "kỳ " + ky + " Năm " + nam;
            }
            
            return x3;
        }
        public int lay_pc_moi()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_phancong from PHANCONG_GIANGDAY order by ma_phancong desc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            int n = 0;
            if (bang.Rows.Count != 0)
            {
                string x = bang.Rows[0][0].ToString();
                n = int.Parse(x);
            }
            n++;
            return n;
        }
        public void Tao_phancong(int mapc,string mamon,string magv,string mahs,string hocky)
        {
            openConnect();
            string sql = "insert into PHANCONG_GIANGDAY " +
                            "values(@mapc,@mamon,@magv,@mahs,@hocky) " +
                        "insert into DIEM(ma_phancong) " +
                            "values(@mapc)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mapc", mapc);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@mahs", mahs);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public bool kiemtra_pc(string mamon, string magv, string mahs, string hocky)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_phancong) " +
                    "from PHANCONG_GIANGDAY " +
                    "where ma_gv=@magv and ma_hs=@mahs and ma_mon=@mamon and hoc_ky=@hocky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@mahs", mahs);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            int n = int.Parse(bang.Rows[0][0].ToString());
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable lay_gv()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select ma_tk as 'Mã GV' ,ten_nguoi_dung as 'Họ Tên' " +
                " from TAIKHOAN " +
                "where loai_tk='GV' and ma_tk not in (select ma_tk " +
                                                        "from TAIKHOAN, LOP " +
                                                        "where loai_tk = 'GV' and ma_tk = ma_gv_cn )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Tao_lop(string malop, int khoa, string gvcn)
        {
            openConnect();
            string sql = "insert into LOP values (@malop,@khoa,@gvcn)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            cmd.Parameters.AddWithValue("@gvcn", gvcn);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public bool check_lop(string malop,int khoa)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_lop) from LOP where ma_lop=@malop and khoa_hoc=@khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            int n = int.Parse(bang.Rows[0][0].ToString());
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check_to(string mato)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select count(ma_to) from TOBOMON where ma_to=@mato";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mato", mato);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            int n = int.Parse(bang.Rows[0][0].ToString());
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Tao_to(string mato, string tento)
        {
            openConnect();
            string sql = "insert into TOBOMON values (@mato,@tento)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mato", mato);
            cmd.Parameters.AddWithValue("@tento", tento);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable lay_to(int i)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from TOBOMON";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
    }
}
