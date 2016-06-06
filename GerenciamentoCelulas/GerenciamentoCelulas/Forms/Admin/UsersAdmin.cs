using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms.Admin
{
    public partial class UsersAdmin : Form
    {
        private int isEdit = 0;

        public UsersAdmin()
        {
            InitializeComponent();
            usersAdminLoginTextBox.Enabled = false;
            usersAdminSenhaTextBox.Enabled = false;
            usersAdminCidadeComboBox.Enabled = false;
            usersAdminEstadoComboBox.Enabled = false;
            usersAdminIgrejaComboBox.Enabled = false;
            usersAdminRoleComboBox.Enabled = false;
            usersAdminIgrejaComboBox.Text = "";
            usersAdminCidadeComboBox.Text = "";
            usersAdminEstadoComboBox.Text = "";
            usersAdminRoleComboBox.Text = "";
            usersAdminLoginTextBox.Text = "";
            usersAdminSenhaTextBox.Text = "";


        }

        private void IgrejasAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.igrejafont10DataSet.Usuarios);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.

            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();
        }

        private void IgrejasAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usersAdminLoginTextBox.Text = usersAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            usersAdminIgrejaComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            usersAdminRoleComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[2].Value.ToString();
            usersAdminCidadeComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[3].Value.ToString();
            usersAdminEstadoComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void IgrejasAdminEditButton_Click(object sender, EventArgs e)
        {
            if (usersAdminLoginTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usersAdminLoginTextBox.Enabled = true;
                usersAdminSenhaTextBox.Enabled = true;
                usersAdminCidadeComboBox.Enabled = true;
                usersAdminEstadoComboBox.Enabled = true;
                usersAdminIgrejaComboBox.Enabled = true;
                usersAdminRoleComboBox.Enabled = true;
                isEdit = 1;                
            }
        }

        private void IgrejasAdminAddButton_Click(object sender, EventArgs e)
        {
            usersAdminLoginTextBox.Enabled = true;
            usersAdminSenhaTextBox.Enabled = true;
            usersAdminCidadeComboBox.Enabled = true;
            usersAdminEstadoComboBox.Enabled = true;
            usersAdminIgrejaComboBox.Enabled = true;
            usersAdminRoleComboBox.Enabled = true;
            usersAdminIgrejaComboBox.Text = "";
            usersAdminCidadeComboBox.Text = "";
            usersAdminEstadoComboBox.Text = "";
            usersAdminRoleComboBox.Text = "";
            usersAdminLoginTextBox.Text = "";
            usersAdminSenhaTextBox.Text = "";
            isEdit = 0;


        }

        private void IgrejasAdminRemoveButton_Click(object sender, EventArgs e)
        {
            Igrejafont10DataSetTableAdapters.UsuariosTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.UsuariosTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o usuário: " + usersAdminLoginTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usersAdminDataGridView.Rows.RemoveAt(usersAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont10DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";

                }
                else
                {
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();
        }

        private void IgrejasAdminSaveButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.UsuariosRow newRow = igrejafont10DataSet.Usuarios.NewUsuariosRow();
            Igrejafont10DataSetTableAdapters.UsuariosTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.UsuariosTableAdapter();


            if (isEdit == 0)
            {
                newRow.Nome = usersAdminLoginTextBox.Text;
                newRow.Senha = usersAdminSenhaTextBox.Text;
                newRow.Igreja = usersAdminIgrejaComboBox.Text;
                newRow.Role = usersAdminRoleComboBox.Text;
                newRow.Cidade = usersAdminCidadeComboBox.Text;
                newRow.Estado = usersAdminEstadoComboBox.Text;
                newRow.IsLogged = "No";
                newRow.FirstLogin = "yes";
                            
                try
                {
                    usuariosBindingSource.EndEdit();
                    igrejafont10DataSet.Usuarios.AddUsuariosRow(newRow);
                    tableAdapter.Update(igrejafont10DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            else
            {
                try
                {
                    usersAdminDataGridView.CurrentRow.Cells[0].Value = usersAdminLoginTextBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[1].Value = usersAdminIgrejaComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[2].Value = usersAdminRoleComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[3].Value = usersAdminCidadeComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[4].Value = usersAdminEstadoComboBox.Text;

                    usuariosBindingSource.EndEdit();
                    tableAdapter.Update(igrejafont10DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";
                    isEdit = 0;
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }

            }
            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();

        }

        private void IgrejasAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
