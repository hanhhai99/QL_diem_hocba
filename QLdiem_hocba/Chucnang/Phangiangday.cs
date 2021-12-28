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
    public partial class Phangiangday : Form
    {
        Process x = new Process();
        Nhanvien nhanvien = new Nhanvien();
        Giaovien giaovien = new Giaovien();
        string tobomon;
        string hocky;
        string mamon="";
        string malop="";
        string magv = "";
        public Phangiangday(string tobomon,string hocky)
        {
            this.hocky = hocky;
            this.tobomon = tobomon;
            InitializeComponent();

            dataGridView1.DataSource = nhanvien.lay_gv(tobomon);
            int year = DateTime.Now.Year;
            if (DateTime.Now.Month < 7)
            {
                year--;
            }
            dataGridView3.DataSource = x.lay_lop(year);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            magv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            dataGridView2.DataSource = x.tim_mon_theo_to(tobomon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Equals(mamon, ""))
            {
                MessageBox.Show("Hãy chọn một môn học", "Thông Báo");
            }
            else if(Equals(malop, ""))
            {
                MessageBox.Show("Hãy chọn một lớp học", "Thông Báo");
            }
            else
            {
                int m = nhanvien.lay_pc_moi();
                DialogResult dlr = MessageBox.Show("Hãy xác nhận tạo",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    if (nhanvien.check_hslop(malop))
                    {
                        DataTable data = nhanvien.tim_hslop(malop);
                        int n = data.Rows.Count;
                        string mahs = data.Rows[0][0].ToString();
                        if (nhanvien.kiemtra_pc(mamon, magv, mahs, hocky))
                        {
                            for (int i = 0; i < n; i++)
                            {
                                mahs = data.Rows[i][0].ToString();
                                nhanvien.Tao_phancong(m+i, mamon, magv, mahs, hocky);
                            }
                            MessageBox.Show("Thành công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi! Bộ dữ liệu này đã tồn tại", "Thông Báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Lớp này không có học sinh", "Thông Báo");
                    }
                    
                }
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            mamon = dataGridView2.Rows[index].Cells[0].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView3.CurrentCell.RowIndex;
            malop = dataGridView3.Rows[index].Cells[0].Value.ToString();
        }
    }
}
