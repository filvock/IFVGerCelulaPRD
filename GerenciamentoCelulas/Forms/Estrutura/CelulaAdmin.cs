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
    public partial class CelulaAdmin : Form
    {
        public CelulaAdmin()
        {
            InitializeComponent();
            LockFields();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "HH:mm tt";
        }

        private void LockFields()
        {
            codeTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            ruaTextBox.Enabled = false;
            numTextBox.Enabled = false;
            diaSemanaComboBox.Enabled = false;
            dateTimePicker.Enabled = false;
            codTextBox.Enabled = false;
            respTextBox.Enabled = false;
            foneTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            obsTextBox.Enabled = false;
            searchMemberButton.Enabled = false;
            cidadeTextBox.Enabled = false;
        }

        private void UnlockFields()
        {
            nameTextBox.Enabled = true;
            obsTextBox.Enabled = true;
            searchMemberButton.Enabled = true;
            ruaTextBox.Enabled = true;
            numTextBox.Enabled = true;
            diaSemanaComboBox.Enabled = true;
            dateTimePicker.Enabled = true;
            cidadeTextBox.Enabled = true;
        }

        private void RedesAdd_Load(object sender, EventArgs e)
        {
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.celulasTableAdapter1.Fill(this.igrejafont10DataSet.Celulas1);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter1.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter1.Fill(this.igrejafont10DataSet.Igrejas);
            this.membrosTableAdapter.Fill(this.igrejafont10DataSet.Membros);
            
            loginInfo login = new loginInfo();

            igrejaComboBox.SelectedValue = login.GetIgreja();

            if (login.GetRole().Equals("Igreja Local"))
            {                
                igrejaComboBox.Enabled = false;
            }
            FiltraCheckBox();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
        }

        private void RedeWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedeWindowAddRede_Click(object sender, EventArgs e)
        {
            if (setorCheckBox.Checked == true)
            {
                MessageBox.Show("Escolha um Setor para criação da Célula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GerenciamentoCelulas.Igrejafont10DataSet.CelulasRow newRow = igrejafont10DataSet.Celulas.NewCelulasRow();
            Igrejafont10DataSetTableAdapters.CelulasTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.CelulasTableAdapter();
            loginInfo info = new loginInfo();

            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Por favor, digite um nome para criação da Célula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {

                if (codeTextBox.Text.ToString().Equals(""))
                {
                    newRow.Nome = nameTextBox.Text;
                    newRow.Igreja = igrejaComboBox.SelectedValue.ToString();
                    newRow.Rede = "";
                    newRow.Distrito = "";
                    newRow.Area = "";
                    newRow.Setor = setorComboBox.SelectedValue.ToString();
                    newRow.Responsavel = codTextBox.Text;
                    newRow.Obs = obsTextBox.Text;
                    newRow.Ativa = "Yes";
                    newRow.Fone = "";
                    newRow.Email = "";
                    
                    newRow.Rua = ruaTextBox.Text;
                    if (numTextBox.Text.Length != 0) newRow.Numero = Convert.ToInt32(numTextBox.Text);
                    if (diaSemanaComboBox.Text.Length != 0) newRow.DiaSemana = diaSemanaComboBox.Text;
                    newRow.Horario = dateTimePicker.Text.ToString();
                    newRow.Cidade = cidadeTextBox.Text;
                    igrejafont10DataSet.Celulas.Rows.Add(newRow);
                }
                else
                {
                    celulasBindingSource1.Position = celulasBindingSource1.Find("Codigo", codeTextBox.Text);
                    DataRowView row = (DataRowView)celulasBindingSource1.Current;

                    row["Nome"] = nameTextBox.Text;
                    row["Responsavel"] = codTextBox.Text;
                    row["DiaSemana"] = diaSemanaComboBox.Text;
                    row["Horario"] = dateTimePicker.Text;
                    row["Rua"] = ruaTextBox.Text;
                    if (numTextBox.Text.Length != 0) row["Numero"] = Convert.ToInt32(numTextBox.Text);
                    row["Obs"] = obsTextBox.Text;
                    row["fone"] = "";
                    row["email"] = "";
                    row["Cidade"] = cidadeTextBox.Text;
                }

                try
                {
                    celulasBindingSource1.EndEdit();
                    celulasTableAdapter1.Update(igrejafont10DataSet.Celulas1);
                    celulasBindingSource.EndEdit();
                    celulasTableAdapter.Update(igrejafont10DataSet.Celulas);
                    ClearFields();
                    LockFields();
                    this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
                    celulasBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed /n"+ ex.ToString());
                }
                
                FiltraCelulas();
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
        }

        private void ClearFields()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            ruaTextBox.Clear();
            numTextBox.Clear();
            foneTextBox.Clear();
            emailTextBox.Clear();
            codTextBox.Clear();
            respTextBox.Clear();
            obsTextBox.Clear();
            cidadeTextBox.Clear();
        }

        private void RedeWindowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }

        private void FillDataFields()
        {
            LockFields();
            codeTextBox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            ruaTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            numTextBox.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            diaSemanaComboBox.SelectedIndex = diaSemanaComboBox.FindString(dataGridView.CurrentRow.Cells[4].Value.ToString());
            dateTimePicker.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            codTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            respTextBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            foneTextBox.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            emailTextBox.Text = dataGridView.CurrentRow.Cells[10].Value.ToString();
            obsTextBox.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            cidadeTextBox.Text = dataGridView.CurrentRow.Cells[11].Value.ToString();
        }

        private void RedeWindowEditRede_Click(object sender, EventArgs e)
        {
            if(codeTextBox.Text.Length == 0) MessageBox.Show("Por favor, selecione uma célula para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else UnlockFields();

        }

        private void RedeWindowDeactivateRede_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover a Célula: " + codeTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DialogResult result1 = MessageBox.Show("Todos os membros da célula serão movidos para -Sem Célula (Cod=0)- Confirma?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        SetMembersToNoCell(codeTextBox.Text);
                        try
                        {
                            celulasBindingSource1.RemoveAt(celulasBindingSource1.Find("Codigo", codeTextBox.Text));
                            celulasBindingSource1.EndEdit();
                            celulasTableAdapter1.Update(igrejafont10DataSet.Celulas1);
                            celulasTableAdapter1.Fill(igrejafont10DataSet.Celulas1);
                            celulasTableAdapter.Update(igrejafont10DataSet.Celulas);
                            celulasTableAdapter.Fill(igrejafont10DataSet.Celulas);

                            cellMembersLabel.Text = dataGridView.RowCount.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed /n" + ex.ToString());
                        }
                    }
                }
            }
            else
                MessageBox.Show("Selecione um membro para ser removido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            ClearFields();
            LockFields();
        }

        private void SetMembersToNoCell(String codCell)
        {
            membrosBindingSource.Filter = "Celula= '" + codCell + "'";
            int j = membrosBindingSource.Count;
            membrosBindingSource.MoveFirst();
            for (int i=0; i<j; i++)
            {
                DataRowView row = (DataRowView)membrosBindingSource.Current;
                row["Celula"] = "0";
                membrosBindingSource.MoveNext();
            }

            try
            {
                membrosBindingSource.EndEdit();
                membrosTableAdapter.Update(this.igrejafont10DataSet.Membros);
                this.membrosTableAdapter.FillBy(this.igrejafont10DataSet.Membros);
                membrosBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed /n" + ex.ToString());
            }

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

        private void areaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraSetorPorArea();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void setorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraCelulas();
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
                FiltraCelulas();
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
                FiltraCelulas();
            }
        }

        private void FiltraAreaPorDistrito()
        {
            if (areaCheckBox.Checked == false)
            {
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
            else
            {
                FiltraCelulas();
            }
        }

        private void FiltraSetorPorArea()
        {
            if (setorCheckBox.Checked == false)
            {
                if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
                else if (igrejaComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                }
            }
            else
            {
                FiltraCelulas();
            }
        }

        private void FiltraCelulas()
        {
            ClearFields();

            if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
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

                areasBindingSource.Filter = "";
                areaComboBox.SelectedIndex = -1;
                areaComboBox.Enabled = false;
                areaCheckBox.Checked = true;

                setoresBindingSource.Filter = "";
                setorComboBox.SelectedIndex = -1;
                setorComboBox.Enabled = false;
                setorCheckBox.Checked = true;

                FiltraCelulas();

            }
            else
            {
                FiltraRedePorIgreja();
                FiltraCelulas();
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

                areasBindingSource.Filter = "";
                areaComboBox.SelectedIndex = -1;
                areaComboBox.Enabled = false;
                areaCheckBox.Checked = true;

                setoresBindingSource.Filter = "";
                setorComboBox.SelectedIndex = -1;
                setorComboBox.Enabled = false;
                setorCheckBox.Checked = true;

                FiltraCelulas();


            }
            else
            {
                distritoComboBox.Enabled = true;
                FiltraDistritoPorRede();
                FiltraCelulas();
            }
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void areaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (areaCheckBox.Checked == true)
            {
                areasBindingSource.Filter = "";
                areaComboBox.SelectedIndex = -1;
                areaComboBox.Enabled = false;

                setoresBindingSource.Filter = "";
                setorComboBox.SelectedIndex = -1;
                setorComboBox.Enabled = false;
                setorCheckBox.Checked = true;

                FiltraCelulas();


            }
            else
            {
                areaComboBox.Enabled = true;
                FiltraAreaPorDistrito();
                FiltraCelulas();
            }
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void setorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (setorCheckBox.Checked == true)
            {
                setoresBindingSource.Filter = "";
                setorComboBox.SelectedIndex = -1;
                setorComboBox.Enabled = false;

                celulasBindingSource.Filter = "";

            }
            else
            {
                setorComboBox.Enabled = true;
                FiltraSetorPorArea();
                FiltraCelulas();
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

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }
    }
}

