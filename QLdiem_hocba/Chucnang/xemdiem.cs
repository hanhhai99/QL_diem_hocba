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
    public partial class xemdiem : Form
    {
        Process x = new Process();
        Hocsinh hocsinh = new Hocsinh();
        string matk;
        public xemdiem(string matk)
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
            dataGridView1.DataSource = hocsinh.xem_diem(matk, cbkyhoc.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string mamon = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string mapc = x.lay_mapc(matk, mamon, cbkyhoc.Text);

            float diem15p = float.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
            float diem1t = float.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
            float diemgiuaky = float.Parse(dataGridView1.Rows[index].Cells[4].Value.ToString());
            float diemcuoiky = float.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());

            Baoloidiem baoloidiem = new Baoloidiem(mapc, diem15p, diem1t, diemgiuaky, diemcuoiky);
            baoloidiem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
