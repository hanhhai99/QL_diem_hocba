using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLdiem_hocba.Class;

namespace QLdiem_hocba.Chucnang
{
    
    public partial class Baoloidiem : Form
    {
        Process x = new Process();
        Hocsinh hocsinh = new Hocsinh();
        string mapc;
        public Baoloidiem(string mapc, float diem15p, float diem1t, float diemgiuaky, float diemcuoiky)
        {
            this.mapc = mapc;
            InitializeComponent();
            DataTable data = x.lay_gv_mon(mapc);
            lbmon.Text = "MÔN HỌC : " + data.Rows[0][1].ToString();
            lbgv.Text = "GIÁO VIÊN : " + data.Rows[0][0].ToString();
            lb15p.Text = "ĐIỂM 15' : " + diem15p;
            lb1t.Text = "ĐIỂM 1 TIẾT : " + diem1t;
            lbgiuaky.Text = "ĐIỂM GIỮA KỲ : " + diemgiuaky;
            lbcuoiky.Text = "ĐIỂM CUỐI KỲ : " + diemcuoiky;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hocsinh.tim_baoloi(mapc))
            {
                hocsinh.Them_baoloi(mapc, textBox1.Text);
                DialogResult dlr = MessageBox.Show("Gửi Thành Công",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã gửi thông báo cho môn học này trước đó !","Thông báo");
                this.Close();
            }
        }
    }
}
