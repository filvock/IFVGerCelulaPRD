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
    public partial class UserRemove : Form
    {
        public UserRemove()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUserRemove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.igrejafont10DataSet.Usuarios);
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.igrejafont10DataSet.Usuarios);

        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover o Usuário: " + formUserRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            GerenciamentoCelulas.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM Usuarios WHERE Nome = @Nome", conn);
                comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = formUserRemoveComboBox.SelectedValue.ToString();
                comm1.ExecuteReader();

                usuariosBindingSource.RemoveAt(formUserRemoveComboBox.SelectedIndex);

                formUserRemoveComboBox.DataSource = null;
                formUserRemoveComboBox.DataSource = usuariosBindingSource;
                formUserRemoveComboBox.DisplayMember = "Nome";
                formUserRemoveComboBox.ValueMember = "Nome";

                formUserRemoveComboBox.Update();
                formUserRemoveComboBox.Refresh();
            }
        }
    }
}
