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
    public partial class AreaAdmin : Form
    {
        public AreaAdmin()
        {
            InitializeComponent();
            LockFields();
            InitiateFilters();
            
        }

        private void InitiateFilters()
        {
            igrejasBindingSource.Filter = "";
            redesBindingSource.Filter = "";
            distritosBindingSource.Filter = "";
            areasBindingSource.Filter = "";

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
            this.areasTableAdapter1.Fill(this.igrejafont10DataSet.Areas1);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
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
            if (distritoCheckBox.Checked == true)
            {
                MessageBox.Show("Escolha um Distrito para criação da Área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GerenciamentoCelulas.Igrejafont10DataSet.AreasRow newRow = igrejafont10DataSet.Areas.NewAreasRow();
            
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Por favor, digite um nome para criação da Área.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                if (codeTextBox.Text.ToString().Equals(""))
                {
                    newRow.Nome = nameTextBox.Text;
                    newRow.Igreja = igrejaComboBox.SelectedValue.ToString();
                    newRow.Rede = "";
                    newRow.Distrito = distritoComboBox.SelectedValue.ToString();
                    newRow.Responsavel = codTextBox.Text;
                    newRow.Fone = "";
                    newRow.Email = "";
                    newRow.Obs = obsTextBox.Text;
                    newRow.Meta = "";
                    newRow.Ativa = "Yes";
                    igrejafont10DataSet.Areas.Rows.Add(newRow);
                    try
                    {                        
                        areasBindingSource.EndEdit();
                        areasTableAdapter.Update(igrejafont10DataSet.Areas);
                        ClearFields();
                        LockFields();
                        this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
                        areasBindingSource.ResetBindings(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed /n" + ex.ToString());
                    }
                }
                else
                {
                    areasBindingSource1.Position = areasBindingSource1.Find("Codigo", codeTextBox.Text);
                    DataRowView row = (DataRowView)areasBindingSource1.Current;

                    row["Nome"] = nameTextBox.Text;
                    row["Responsavel"] = codTextBox.Text;
                    row["Obs"] = obsTextBox.Text;
                    try
                    {
                        areasBindingSource1.EndEdit();
                        areasTableAdapter1.Update(igrejafont10DataSet.Areas1);
                        ClearFields();
                        LockFields();
                        this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
                        areasBindingSource.ResetBindings(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed /n" + ex.ToString());
                    }
                }
                
                FiltraAreaPorDistrito();
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

        private void RedeWindowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
                       
        }

        private void RedeWindowEditRede_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length == 0) MessageBox.Show("Por favor, selecione uma Área para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void distritoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraAreaPorDistrito();
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
                FiltraAreaPorDistrito();
            }
        }

        private void FiltraDistritoPorRede()
        {
            if (distritoCheckBox.Checked == false)
            {
                if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    distritosBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (igrejaComboBox.SelectedValue != null)
                {
                    distritosBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
            }
            else
            {
                FiltraAreaPorDistrito();
            }
        }

        private void FiltraAreaPorDistrito()
        {
            ClearFields();
            if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    areasBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    areasBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (igrejaComboBox.SelectedValue != null)
                {
                    areasBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
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

                distritosBindingSource.Filter = "";
                distritoComboBox.SelectedIndex = -1;
                distritoComboBox.Enabled = false;
                distritoCheckBox.Checked = true;

                FiltraAreaPorDistrito();

            }
            else
            {
                FiltraRedePorIgreja();
                FiltraAreaPorDistrito();
                redeComboBox.Enabled = true;
            }
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void distritoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (distritoCheckBox.Checked == true)
            {
                distritosBindingSource.Filter = "";
                distritoComboBox.SelectedIndex = -1;
                distritoComboBox.Enabled = false;

                FiltraAreaPorDistrito();


            }
            else
            {
                distritoComboBox.Enabled = true;
                FiltraDistritoPorRede();
                FiltraAreaPorDistrito();
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

        private void FillDataFields()
        {
            LockFields();
            codeTextBox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            codTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            respTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            foneTextBox.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            emailTextBox.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            obsTextBox.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }
    }
}
