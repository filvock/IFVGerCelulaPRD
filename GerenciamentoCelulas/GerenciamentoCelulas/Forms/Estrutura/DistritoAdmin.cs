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

namespace GerenciamentoCelulas.Forms.Estrutura
{
    public partial class DistritoAdmin : Form
    {
        public DistritoAdmin()
        {
            InitializeComponent();
            LockFields();

        }

        private void LockFields()
        {
            codeTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            codTextBox.Enabled = false;
            respTextBox.Enabled = false;
            foneTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            obsTextBox.Enabled = false;
            searchMemberButton.Enabled = false;
        }

        private void UnlockFields()
        {
            nameTextBox.Enabled = true;
            obsTextBox.Enabled = true;
            searchMemberButton.Enabled = true;

        }

        private void RedesAdd_Load(object sender, EventArgs e)
        {
            this.distritosTableAdapter1.Fill(this.igrejafont10DataSet.Distritos1);
            this.distritosTableAdapter.FillBy(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter1.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter1.Fill(this.igrejafont10DataSet.Igrejas);
            
            loginInfo login = new loginInfo();

            igrejaComboBox.SelectedValue = login.GetIgreja();

            if (login.GetRole().Equals("Igreja Local"))
            {
                igrejaComboBox.Enabled = false;
            }

            FiltraCheckBox();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();

        }

        private void RedeWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedeWindowAddRede_Click(object sender, EventArgs e)
        {
            if (redeCheckBox.Checked == true)
            {
                MessageBox.Show("Escolha uma Rede para criação do distrito", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                ClearFields();
                UnlockFields();
            }

        }

        private void RedesAdminCleanButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RedesAdminSaveButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.DistritosRow newRow = igrejafont10DataSet.Distritos.NewDistritosRow();
            
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Por favor, digite um nome para criação do Distrito.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                if (codeTextBox.Text.ToString().Equals(""))
                {
                    newRow.Nome = nameTextBox.Text;
                    newRow.Igreja = igrejaComboBox.SelectedValue.ToString();
                    newRow.Rede = redeComboBox.SelectedValue.ToString();
                    newRow.Responsavel = codTextBox.Text;
                    newRow.Fone = "";
                    newRow.Email = "";
                    newRow.Obs = obsTextBox.Text;
                    newRow.Meta = "";
                    newRow.Ativa = "Yes";
                    igrejafont10DataSet.Distritos.Rows.Add(newRow);
                }
                else
                {
                    distritosBindingSource1.Position = distritosBindingSource1.Find("Codigo", codeTextBox.Text);
                    DataRowView row = (DataRowView)distritosBindingSource1.Current;

                    row["Nome"] = nameTextBox.Text;
                    row["Responsavel"] = codTextBox.Text;
                    row["Obs"] = obsTextBox.Text;
                }

                try
                {
                    distritosBindingSource1.EndEdit();
                    distritosTableAdapter1.Update(igrejafont10DataSet.Distritos1);
                    distritosBindingSource.EndEdit();
                    distritosTableAdapter.Update(igrejafont10DataSet.Distritos);
                    ClearFields();
                    LockFields();
                    this.distritosTableAdapter.FillBy(this.igrejafont10DataSet.Distritos);
                    distritosBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed /n" + ex.ToString());
                }

                FiltraDistritoPorRede();
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
        }

        private void ClearFields()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            codTextBox.Clear();
            respTextBox.Clear();
            foneTextBox.Clear();
            emailTextBox.Clear();
            obsTextBox.Clear();
        }

       

        private void RedeWindowEditRede_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length == 0) MessageBox.Show("Por favor, selecione um Distrito para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else UnlockFields();
        }

        private void RedeWindowDeactivateRede_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.DistritosRow newRow = igrejafont10DataSet.Distritos.NewDistritosRow();
            Igrejafont10DataSetTableAdapters.DistritosTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.DistritosTableAdapter();
            dataGridView.CurrentRow.Cells[9].Value = "No";
            tableAdapter.Update(igrejafont10DataSet.Distritos);
            ClearFields();
            LockFields();
        }

        private void igrejaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraRedePorIgreja();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void redeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraDistritoPorRede();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }


        private void FiltraRedePorIgreja()
        {
            if (redeCheckBox.Checked == false)
            {
                if (igrejaComboBox.SelectedValue != null)
                {
                    redesBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
            }
            else
            {
                FiltraDistritoPorRede();
            }
        }

        private void FiltraDistritoPorRede()
        {
            ClearFields();
            if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                distritosBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                distritosBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
        }



        private void redeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FiltraCheckBox();

        }

        private void FiltraCheckBox()
        {
            if (redeCheckBox.Checked == true)
            {
                redesBindingSource.Filter = "";
                redeComboBox.SelectedIndex = -1;
                redeComboBox.Enabled = false;

                FiltraDistritoPorRede();

            }
            else
            {
                FiltraRedePorIgreja();
                FiltraDistritoPorRede();
                redeComboBox.Enabled = true;
            }

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void searchMemberButton_Click(object sender, EventArgs e)
        {
            Membros.MembroSearch search = new Membros.MembroSearch(igrejaComboBox.Text);

            search.ShowDialog();

            int code = search.MemberCode;

            if (code != 0)
            {
                loginInfo info = new loginInfo();
                SqlDataReader usrRdr = null;
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("select * from Membros where Codigo=@codigo", conn);
                comm1.Parameters.Add("@codigo", SqlDbType.VarChar).Value = code;


                usrRdr = comm1.ExecuteReader();

                if (usrRdr.HasRows)
                {
                    while (usrRdr.Read())
                    {
                        int codigo = usrRdr.GetInt32(0);
                        codTextBox.Text = Convert.ToString(codigo);
                        respTextBox.Text = (string)usrRdr.GetString(1);
                        foneTextBox.Text = (string)usrRdr.GetString(13);
                        emailTextBox.Text = (string)usrRdr.GetString(21);
                    }
                }
            }


        }

        private void RedeWindowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }

        private void FillDataFields()
        {
            LockFields();
            codeTextBox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            codTextBox.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            respTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            foneTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            emailTextBox.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            obsTextBox.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
        }

       
    }



}

