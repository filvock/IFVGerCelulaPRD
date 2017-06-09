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

namespace GerenciamentoCelulas.Forms
{
    public partial class CidadeRemove : Form
    {
        public CidadeRemove()
        {
            InitializeComponent();
        }

        private void formCidadesRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCidadeRemove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            //this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);

        }

        private void formCidadesRemoveOkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover a Cidade: " + formCidadeRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            GerenciamentoCelulas.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM Cidades WHERE Nome = @Nome", conn);
                comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = formCidadeRemoveComboBox.SelectedValue.ToString();
                comm1.ExecuteReader();

                cidadesBindingSource.RemoveAt(formCidadeRemoveComboBox.SelectedIndex);

                formCidadeRemoveComboBox.DataSource = null;
                formCidadeRemoveComboBox.DataSource = cidadesBindingSource;
                formCidadeRemoveComboBox.DisplayMember = "Nome";
                formCidadeRemoveComboBox.ValueMember = "Nome";

                formCidadeRemoveComboBox.Update();
                formCidadeRemoveComboBox.Refresh();
            }
        }
    }
}
