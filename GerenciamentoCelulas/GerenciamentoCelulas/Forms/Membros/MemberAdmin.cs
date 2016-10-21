using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms.Membros
{
    public partial class MemberAdmin : Form
    {
        public MemberAdmin()
        {
            InitializeComponent();

        }

        private void MemberAdmin_Load(object sender, EventArgs e)
        {
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            this.membrosTableAdapter.FillBy(this.igrejafont10DataSet.Membros);
            this.membrosTableAdapter1.Fill(this.igrejafont10DataSet.Membros1);

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }

            loginInfo login = new loginInfo();
            igrejaComboBox.SelectedValue = login.GetIgreja();

            if (login.GetRole().Equals("Igreja Local"))
            {
                igrejaComboBox.SelectedValue = login.GetIgreja(); 
                igrejaComboBox.Enabled = false;
            }

            FiltraCheckBox();
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void MemberAdminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MemberAdminAddMember_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Membros.MemberAdd newmember = new MemberAdd(0);
            newmember.ShowDialog();
            membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);
            membrosBindingSource.ResetBindings(false);
            FiltraMembros();
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
        }

        private void celulaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
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

            if (celulaCheckBox.Checked == false)
            {

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
            else
            {
                FiltraMembros();
            }
        }

        private void FiltraMembros()
        {
            if (celulaComboBox.SelectedValue != null && setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Celula = '" + celulaComboBox.SelectedValue.ToString() + "'" + " AND Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                membrosBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
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

                celulasBindingSource.Filter = "";
                celulaComboBox.SelectedIndex = -1;
                celulaComboBox.Enabled = false;
                celulaCheckBox.Checked = true;

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

                celulasBindingSource.Filter = "";
                celulaComboBox.SelectedIndex = -1;
                celulaComboBox.Enabled = false;
                celulaCheckBox.Checked = true;

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

                celulasBindingSource.Filter = "";
                celulaComboBox.SelectedIndex = -1;
                celulaComboBox.Enabled = false;
                celulaCheckBox.Checked = true;

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

                celulasBindingSource.Filter = "";
                celulaComboBox.SelectedIndex = -1;
                celulaComboBox.Enabled = false;
                celulaCheckBox.Checked = true;

                FiltraMembros();
            }
            else
            {
                setorComboBox.Enabled = true;
                FiltraSetorPorArea();
                FiltraMembros();
            }
        }

        private void celulaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (celulaCheckBox.Checked == true)
            {
                celulasBindingSource.Filter = "";
                celulaComboBox.SelectedIndex = -1;
                celulaComboBox.Enabled = false;
            }
            else
            {
                celulaComboBox.Enabled = true;
                FiltraCelulas();
                FiltraMembros();
            }
        }

        private void MemberAdminDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GerenciamentoCelulas.Forms.Membros.MemberAdd newmember = new MemberAdd((int)dataGridView.CurrentRow.Cells[0].Value);
            newmember.ShowDialog();
            membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);
        }

        private void comCelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (comCelCheckBox.Checked)
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter + " AND Celula<>'0'";
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
            else
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter.Replace(" AND Celula<>'0'", "");
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }

        }

        private void MemberAdminSemCelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (semCelCheckBox.Checked)
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter + " AND Celula='0'";
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
            else
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter.Replace(" AND Celula='0'", "");
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
        }

        private void comDiscCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (comDiscCheckBox.Checked)
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter + " AND Discipulador<>'0'";
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
            else
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter.Replace(" AND Discipulador<>'0'", "");
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }

        }

        private void MemberAdminSemDiscCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (semDiscCheckBox.Checked)
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter + " AND Discipulador='0'";
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
            else
            {
                membrosBindingSource.Filter = membrosBindingSource.Filter.Replace(" AND Discipulador='0'", "");
                cellMembersLabel.Text = dataGridView.RowCount.ToString();
            }
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[0].Value.ToString().Length > 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o membro: " + dataGridView.CurrentRow.Cells[1].Value.ToString(), "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        System.Windows.Forms.BindingSource escadaSucesso;
                        Igrejafont10DataSetTableAdapters.EscadaSucessoTableAdapter escadaTableAdapter;
                        escadaSucesso = new System.Windows.Forms.BindingSource(this.components);
                        ((System.ComponentModel.ISupportInitialize)(escadaSucesso)).BeginInit();
                        escadaSucesso.DataMember = "EscadaSucesso";
                        escadaSucesso.DataSource = this.igrejafont10DataSet;
                        ((System.ComponentModel.ISupportInitialize)(escadaSucesso)).EndInit();
                        escadaTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EscadaSucessoTableAdapter();
                        escadaTableAdapter.ClearBeforeFill = true;
                        
                        membrosBindingSource1.RemoveAt(membrosBindingSource1.Find("Codigo", dataGridView.CurrentRow.Cells[0].Value.ToString()));
                        escadaSucesso.RemoveAt(escadaSucesso.Find("Codigo", dataGridView.CurrentRow.Cells[0].Value.ToString()));
                        membrosBindingSource1.EndEdit();
                        membrosTableAdapter1.Update(igrejafont10DataSet.Membros1);
                        escadaSucesso.EndEdit();
                        escadaTableAdapter.Update(igrejafont10DataSet.EscadaSucesso);
                        
                        membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);
                        cellMembersLabel.Text = dataGridView.RowCount.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed /n" + ex.ToString());
                    }
            }
            }
            else
                MessageBox.Show("Selecione um membro para ser removido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
