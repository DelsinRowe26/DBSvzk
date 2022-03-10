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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delsinRowe26DataSet.DRTable". При необходимости она может быть перемещена или удалена.
            this.dRTableTableAdapter.Fill(this.delsinRowe26DataSet.DRTable);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dRTableTableAdapter.Update(delsinRowe26DataSet);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
               dr = DialogResult.Cancel;
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }
    }
}
