using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSvzk
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if(main != null)
            {
                DataRow nRow = main.delsinRowe26DataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbPassw.Text;
                main.delsinRowe26DataSet.Tables[0].Rows.Add(nRow);
                main.dRTableTableAdapter.Update(main.delsinRowe26DataSet.DRTable);
                main.delsinRowe26DataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPassw.Text = "";
            }
        }
    }
}
