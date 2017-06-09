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
    public partial class IgrejasRemove : Form
    {
        public IgrejasRemove()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIgrejasRemove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            

        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover a Igreja: " + formIgrejasRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            GerenciamentoCelulas.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM Igrejas WHERE Nome = @Nome", conn);
                comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = formIgrejasRemoveComboBox.SelectedValue.ToString();
                comm1.ExecuteReader();

                igrejasBindingSource.RemoveAt(formIgrejasRemoveComboBox.SelectedIndex);

                formIgrejasRemoveComboBox.DataSource = null;
                formIgrejasRemoveComboBox.DataSource = igrejasBindingSource;
                formIgrejasRemoveComboBox.DisplayMember = "Nome";
                formIgrejasRemoveComboBox.ValueMember = "Nome";

                formIgrejasRemoveComboBox.Update();
                formIgrejasRemoveComboBox.Refresh();
            }
        }
    }
}
