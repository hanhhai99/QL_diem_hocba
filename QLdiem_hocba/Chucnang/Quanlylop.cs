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
    public partial class Quanlylop : Form
    {
        Process x = new Process();
        Nhanvien nhanvien = new Nhanvien();
        public Quanlylop()
        {
            InitializeComponent();

            DataTable data = x.lay_hocky();
            bool a;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string x = data.Rows[i][0].ToString().Substring(8, 5);
                a = true;
                for (int j = 0; j < cbkyhoc.Items.Count; j++)
                {
                    if (Equals(x, cbkyhoc.Items[j].ToString()))
                    {
                        a = false;
                    }
                }
                if (a == true)
                {
                    cbkyhoc.Items.Add(x);
                }
            }
            if (cbkyhoc.Items.Count == 0)
            {
                if (DateTime.Now.Month < 7)
                {
                    cbkyhoc.Items.Add(DateTime.Now.Year-1);
                }
                else
                {
                    cbkyhoc.Items.Add(DateTime.Now.Year);
                }
            }
            else
            {
                cbkyhoc.Items.Add(int.Parse(cbkyhoc.Items[0].ToString()) + 1);
            }
            cbkyhoc.Text = cbkyhoc.Items[0].ToString();
            

        }

        private void cbkyhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = x.lay_lop(int.Parse(cbkyhoc.Text));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            string mahs = dataGridView2.Rows[index].Cells[0].Value.ToString();
            gioithieu gioithieu = new gioithieu(mahs,false);
            gioithieu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string tenlop = dataGridView1.Rows[index].Cells[0].Value.ToString();
            dataGridView2.DataSource = nhanvien.tim_hslop(tenlop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themlop themlop = new Themlop();
            themlop.ShowDialog();
            int year = DateTime.Now.Year;
            if (DateTime.Now.Month < 7)
            {
                year--;
            }
            dataGridView1.DataSource = x.lay_lop(year);
        }
    }
}
