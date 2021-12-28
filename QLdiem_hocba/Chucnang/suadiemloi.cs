using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLdiem_hocba
{
    public partial class suadiemloi : Form
    {
        string matk;
        string mamon;
        string hocky;
        Hocsinh hocsinh = new Hocsinh();
        Process x = new Process();
        public suadiemloi(string matk,string mamon, string hocky)
        {
            this.matk = matk;
            this.mamon = mamon;
            this.hocky = hocky;
            InitializeComponent();

            DataTable data = hocsinh.lay_tt_gioithieu(matk);
            lbma.Text = "MÃ HS : " + matk;
            lbten.Text = "HỌ TÊN : " + data.Rows[0][0].ToString();
            lbngaysinh.Text = "NGÀY SINH : " + data.Rows[0][1].ToString().Substring(0, 10);
            lbgioitinh.Text = "GIỚI TÍNH : " + data.Rows[0][2].ToString();
            lbhocky.Text = "HỌC KỲ : " + hocky;
            lbmonhoc.Text = "MÔN HỌC : " + mamon;
            data = hocsinh.lay_diem(matk, mamon, hocky);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Học sinh này chưa có điểm ", "Thông Báo");
                
            }
            else
            {
                tb15p.Text = data.Rows[0][0].ToString();
                tb1tiet.Text = data.Rows[0][1].ToString();
                tbgiuaky.Text = data.Rows[0][2].ToString();
                tbcuoiky.Text = data.Rows[0][3].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n;
            if (float.TryParse(tb15p.Text,out n) && float.TryParse(tb1tiet.Text, out n) && float.TryParse(tbgiuaky.Text, out n) && float.TryParse(tbcuoiky.Text, out n))
            {
                if (float.Parse(tb15p.Text) >= 0 && float.Parse(tb1tiet.Text) >= 0 && float.Parse(tbgiuaky.Text) >= 0 && float.Parse(tbcuoiky.Text) >= 0) 
                {
                    if (float.Parse(tb15p.Text) < 11 && float.Parse(tb1tiet.Text) < 11 && float.Parse(tbgiuaky.Text) < 11 && float.Parse(tbcuoiky.Text) < 11) 
                    {
                        string mapc = x.lay_mapc(matk, mamon, hocky);
                        x.Sua_diem(mapc, float.Parse(tb15p.Text), float.Parse(tb1tiet.Text), float.Parse(tbgiuaky.Text), float.Parse(tbcuoiky.Text));
                        MessageBox.Show("Lưu thành công", "Thông Báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Điểm phải nhỏ hơn hoặc bằng 10", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Điểm phải lớn hơn 0", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Điểm phải là một số", "Thông Báo");
            }
        }
    }
}
