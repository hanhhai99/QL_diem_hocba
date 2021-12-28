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
    public partial class xembaocaoloi : Form
    {
        Giaovien giaovien = new Giaovien();
        string matk;
        public xembaocaoloi(string matk)
        {
            this.matk = matk;
            InitializeComponent();
            dataGridView1.DataSource = giaovien.xem_baoloi(matk);
            dataGridView1.Columns[3].Width = 215;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                string noidung = dataGridView1.Rows[index].Cells[5].Value.ToString();
                MessageBox.Show(noidung,"Nội dung kiến");
            }
            else
            {
                string mahs = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string mon = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string hocky = dataGridView1.Rows[index].Cells[4].Value.ToString();
                suadiemloi suadiemloi = new suadiemloi(mahs,mon,hocky);
                suadiemloi.Show();
            }
        }
    }
}
