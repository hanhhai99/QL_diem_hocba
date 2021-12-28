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
using QLdiem_hocba.Chucnang;

namespace QLdiem_hocba
{
    public partial class quanlymon : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        string mamon="";
        public quanlymon()
        {
            InitializeComponent();
            dataGridView1.DataSource = nhanvien.lay_mon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            mamon = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themmon themmon = new Themmon();
            themmon.ShowDialog();
            dataGridView1.DataSource = nhanvien.lay_mon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Equals(mamon, ""))
            {
                if (nhanvien.kt_mon(mamon) == 0)
                {
                    nhanvien.Xoa_mon(mamon);
                    MessageBox.Show("Môn học :" + mamon + " đã được xóa", "Thông Báo");
                    mamon = "";
                    dataGridView1.DataSource = nhanvien.lay_mon();
                }
                else
                {
                    MessageBox.Show("Môn học đã được phân công, không thể xóa", "Thông Báo");
                    mamon = "";
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một môn học", "Thông Báo");
            }
        }
    }
}
