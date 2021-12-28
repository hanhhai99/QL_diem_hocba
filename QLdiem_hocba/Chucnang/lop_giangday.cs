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

namespace QLdiem_hocba
{
    public partial class lop_giangday : Form
    {
        Process x = new Process();
        Giaovien giaovien = new Giaovien();
        string matk;
        public lop_giangday(string matk)
        {
            this.matk = matk;
            InitializeComponent();

            DataTable data = x.lay_hocky();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbkyhoc.Items.Add(data.Rows[i][0]);
            }
            cbkyhoc.Text = cbkyhoc.Items[0].ToString();

            
        }

        private void cbkyhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = giaovien.tim_lop(matk);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string tenlop = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dataGridView2.DataSource = giaovien.tim_hslop(matk,tenlop);
        }
    }
}
