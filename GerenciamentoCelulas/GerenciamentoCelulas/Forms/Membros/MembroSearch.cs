using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GerenciamentoCelulas.Forms.Membros
{
    public partial class MembroSearch : Form
    {        
        public int code;
        public String igreja;

        public MembroSearch(String church)
        {
            InitializeComponent();
            igreja = church;
        }

        public int MemberCode
        {
            get { return code; }
            
        }

        private void MembroSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Membros' table. You can move, or remove it, as needed.
            this.membrosTableAdapter.Fill(this.igrejafont10DataSet.Membros);

            this.dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            loginInfo info = new loginInfo();

            membrosBindingSource.Filter = "Igreja = '" + this.igreja + "'";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            code = (int) dataGridView.CurrentRow.Cells[0].Value;
            this.Close();

        }

        private void memberSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            membrosBindingSource.Filter = "Igreja = '" + this.igreja + "' AND Nome like '%" + memberSearchTextBox.Text + "%'";
            
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            code = (int)dataGridView.CurrentRow.Cells[0].Value;
            this.Close();
        }
    }
}
