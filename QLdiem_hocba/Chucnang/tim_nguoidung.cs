using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLdiem_hocba.Chucnang;

namespace QLdiem_hocba
{
    public partial class tim_nguoidung : Form
    {
        Process x = new Process();
        string matk;
        public tim_nguoidung(string matk)
        {
            this.matk = matk;

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(tbnoidung.Text!="" && tbnoidung.Text!=" ")
            {
                dataGridView1.DataSource = x.tim_nguoidung(matk, tbnoidung.Text);
            }
            else
            {
                dataGridView1.DataSource = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string ma_ngdung = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (Equals(ma_ngdung.Substring(0, 2),"HS"))
            {
                gioithieu gioithieu = new gioithieu(ma_ngdung,false);
                gioithieu.Show();
            }
            else
            {
                nv_gioithieu gioithieu = new nv_gioithieu(ma_ngdung,false);
                gioithieu.Show();
            }
        }
    }
}
