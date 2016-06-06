using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms.Lideres
{
    public partial class LiderCelulaAdmin : Form
    {
        public LiderCelulaAdmin()
        {
            InitializeComponent();
            LockFields();
        }

        private void LockFields()
        {
            respTextBox.Enabled = false;
            loginTextBox.Enabled = false;
            senhaTextBox.Enabled = false;
            celulaComboBox1.Enabled = false;
        }

        private void UnlockFields()
        {
            senhaTextBox.Enabled = true;            
        }


        private void IgrejasAdmin_Load(object sender, EventArgs e)
        {
            this.liderCelula1TableAdapter.FillMemberCell(this.igrejafont10DataSet.LiderCelula1);
            this.liderCelulaTableAdapter.Fill(this.igrejafont10DataSet.LiderCelula);
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);

            GerenciamentoCelulas.loginInfo login = new loginInfo();

            if (login.GetRole().Equals("Igreja Local"))
            {
                liderCelula1BindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
                igrejaComboBox.Enabled = false;
                igrejaComboBox.Text = login.GetIgreja();

            }
            else
            {
                igrejaComboBox.Enabled = true;
                igrejaComboBox.Text = login.GetIgreja();
            }

            FiltraCheckBox();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        
        private void LideresAdminEditButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UnlockFields();
            }
        }

        private void LideresAdminAddButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            loginTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
            celulaComboBox1.Enabled = true;
            FiltraCelulas();
        }

        private void LideresAdminRemoveButton_Click(object sender, EventArgs e)
        {
            liderCelulaBindingSource.Position = liderCelulaBindingSource.Find("UserId", loginTextBox.Text);
            DataRowView row = (DataRowView)liderCelulaBindingSource.Current;

            DialogResult result = MessageBox.Show("Deseja remover o login: " + loginTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                liderCelulaBindingSource.RemoveCurrent();
                liderCelulaBindingSource.EndEdit();
                liderCelulaTableAdapter.Update(igrejafont10DataSet.LiderCelula);
                liderCelula1TableAdapter.FillMemberCell(igrejafont10DataSet.LiderCelula1);
            }
        }

        private void LideresAdminSaveButton_Click(object sender, EventArgs e)
        {

            if (loginTextBox.Enabled)
            {
                if (loginTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Por favor, digite um nome para criação do login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GerenciamentoCelulas.Igrejafont10DataSet.LiderCelulaRow newRow = igrejafont10DataSet.LiderCelula.NewLiderCelulaRow();

                    newRow.UserId = loginTextBox.Text;
                    newRow.Senha = senhaTextBox.Text;
                    newRow.CodCel = Convert.ToInt32(celulaComboBox1.SelectedValue.ToString());
                    celulasBindingSource1.Position = celulasBindingSource1.Find("Codigo", celulaComboBox1.SelectedValue.ToString());
                    DataRowView row = (DataRowView)celulasBindingSource1.Current;
                    newRow.CodMemb = Convert.ToInt32(row["Responsavel"].ToString());

                    igrejafont10DataSet.LiderCelula.Rows.Add(newRow);

                    try
                    {
                        liderCelulaBindingSource.EndEdit();
                        liderCelulaTableAdapter.Update(igrejafont10DataSet.LiderCelula);
                        ClearFields();
                        LockFields();
                        liderCelula1TableAdapter.FillMemberCell(igrejafont10DataSet.LiderCelula1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed /n" + ex.ToString());
                    }
                }
            }
            else if (senhaTextBox.Enabled)
            {

                liderCelulaBindingSource.Position = liderCelulaBindingSource.Find("UserId", loginTextBox.Text);
                DataRowView row = (DataRowView)liderCelulaBindingSource.Current;

                row["UserId"] = loginTextBox.Text;
                row["Senha"] = senhaTextBox.Text;

                try
                {
                    liderCelulaBindingSource.EndEdit();
                    liderCelulaTableAdapter.Update(igrejafont10DataSet.LiderCelula);
                    ClearFields();
                    LockFields();
                    liderCelula1TableAdapter.FillMemberCell(igrejafont10DataSet.LiderCelula1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed /n" + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Por favor, clique Editar ou Adicionar para salvar um registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FiltraMembros();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();

        }
    

        private void LideresAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            loginTextBox.Clear();
            senhaTextBox.Clear();
            respTextBox.Clear();
            //celulaComboBox1.SelectedIndex = -1;
        }


        private void igrejaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            FiltraRedePorIgreja();
        }

        private void redeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            FiltraDistritoPorRede();
        }

        private void distritoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            FiltraAreaPorDistrito();
        }

        private void areaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            FiltraSetorPorArea();
        }

        private void setorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraCelulas();
            FiltraMembros();
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
                FiltraMembros();
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
                FiltraMembros();
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
                FiltraMembros();
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
                FiltraMembros();
            }
        }

        private void FiltraCelulas()
        {


            if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }


        }

        private void FiltraMembros()
        {
            if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                liderCelula1BindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                liderCelula1BindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                liderCelula1BindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                liderCelula1BindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                liderCelula1BindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
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

                //celulasBindingSource.Filter = "";
                //celulaComboBox.SelectedIndex = -1;
                //celulaComboBox.Enabled = false;
                //celulaCheckBox.Checked = true;

                FiltraMembros();

            }
            else
            {
                FiltraRedePorIgreja();
                FiltraMembros();
                redeComboBox.Enabled = true;

            }

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

                //celulasBindingSource.Filter = "";
                //celulaComboBox.SelectedIndex = -1;
                //celulaComboBox.Enabled = false;
                //celulaCheckBox.Checked = true;

                FiltraMembros();


            }
            else
            {
                distritoComboBox.Enabled = true;
                FiltraDistritoPorRede();
                FiltraMembros();
            }

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

                //celulasBindingSource.Filter = "";
                //celulaComboBox.SelectedIndex = -1;
                //celulaComboBox.Enabled = false;
                //celulaCheckBox.Checked = true;

                FiltraMembros();


            }
            else
            {
                areaComboBox.Enabled = true;
                FiltraAreaPorDistrito();
                FiltraMembros();
            }
        }

        private void setorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (setorCheckBox.Checked == true)
            {
                setoresBindingSource.Filter = "";
                setorComboBox.SelectedIndex = -1;
                setorComboBox.Enabled = false;
                //celulasBindingSource.Filter = "";
                //celulaComboBox.SelectedIndex = -1;
                //celulaComboBox.Enabled = false;
                //celulaCheckBox.Checked = true;

                FiltraMembros();

            }
            else
            {
                setorComboBox.Enabled = true;
                FiltraSetorPorArea();
                FiltraMembros();
            }
        }

        //private void celulaCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (celulaCheckBox.Checked == true)
        //    {
        //        celulasBindingSource.Filter = "";
        //        celulaComboBox.SelectedIndex = -1;
        //        celulaComboBox.Enabled = false;


        //    }
        //    else
        //    {
        //        celulaComboBox.Enabled = true;
        //        FiltraCelulas();
        //        FiltraMembros();
        //    }
        //}

        private void IgrejasAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }

        //private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    FillDataFields();
        //}

        private void FillDataFields()
        {
            if (!celulaComboBox1.Enabled)
            {
                loginTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                respTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                celulaComboBox1.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void celulaComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (celulaComboBox1.SelectedValue != null)
            {
                //celulasBindingSource1.MoveFirst();
                celulasBindingSource1.Position = celulasBindingSource1.Find("Codigo", celulaComboBox1.SelectedValue.ToString());
                DataRowView row = (DataRowView)celulasBindingSource1.Current;

                respTextBox.Text = row["NomeResp"].ToString();
                
            }
        }
    }

}
