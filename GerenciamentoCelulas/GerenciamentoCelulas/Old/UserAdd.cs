using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
 
        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.UsuariosRow newUser = igrejafont10DataSet.Usuarios.NewUsuariosRow();
            Igrejafont10DataSetTableAdapters.UsuariosTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.UsuariosTableAdapter();

            newUser.Nome = formUserAddNomeTextBox.Text;
            newUser.Senha = formUserAddSenhaTextBox.Text;
            newUser.Igreja = formUserAddIgrejaComboBox.SelectedValue.ToString();
            newUser.Role = formUserAddRoleComboBox.Text;
            newUser.IsLogged = "No";
            newUser.FirstLogin = "yes";
            newUser.Cidade = formUserAddCidadeComboBox.SelectedValue.ToString();
            newUser.Estado = formUserAddEstadoComboBox.SelectedValue.ToString();

            igrejafont10DataSet.Usuarios.Rows.Add(newUser);
            tableAdapter.Update(igrejafont10DataSet.Usuarios);

            formUserAddNomeTextBox.Clear();
            formUserAddSenhaTextBox.Clear();
        }


    }
}
