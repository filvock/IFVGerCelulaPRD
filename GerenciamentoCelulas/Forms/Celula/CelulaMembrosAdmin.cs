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

namespace GerenciamentoCelulas.Forms.Celula
{
    public partial class CelulaMembrosAdmin : Form
    {
        public CelulaMembrosAdmin()
        {
            InitializeComponent();    
           
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
        }

        private void RedesAdd_Load(object sender, EventArgs e)
        {
            this.membrosTableAdapter.FillBy(this.igrejafont10DataSet.Membros);
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter1.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter1.Fill(this.igrejafont10DataSet.Igrejas);
            
            loginInfo login = new loginInfo();
            igrejaComboBox.SelectedValue = login.GetIgreja();

            if (login.GetRole().Equals("Igreja Local"))
            {
                igrejaComboBox.SelectedValue = login.GetIgreja();
                igrejaComboBox.Enabled = false;
            }
            FiltraCheckBox();
            LockFields();

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

        private void FillCellFields()
        {

            if (celulaComboBox.SelectedValue != null && celulaCheckBox.Checked == false)
            {
                celulasBindingSource.Position = celulasBindingSource.Find("Codigo", celulaComboBox.SelectedValue);
                DataRowView row = (DataRowView)celulasBindingSource.Current;
                LockFields();
                                
                codeTextBox.Text = row["Codigo"].ToString();
                respTextBox.Text = row["NomeResp"].ToString();
                foneTextBox.Text = row["Fone"].ToString();
                emailTextBox.Text = row["Email"].ToString();
                obsTextBox.Text = row["Obs"].ToString();
                codTextBox.Text = row["Responsavel"].ToString();
                nameTextBox.Text = row["Nome"].ToString();
            }
        }

        private void RedeWindowEditRede_Click(object sender, EventArgs e)
        {
            UnlockFields();

        }

        private void UnlockFields()
        {
            nameTextBox.Enabled = true;
            codTextBox.Enabled = true;
            respTextBox.Enabled = true;
            foneTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            obsTextBox.Enabled = true;
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
            FillCellFields();            
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
                membrosBindingSource.Filter = "Celula = '"+celulaComboBox.SelectedValue.ToString() +"'"+" AND Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
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

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == "0")
                    row.Cells[2].Value = "Sem Célula";
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
                ClearFields();

                
            }
            else
            {
                FillCellFields();
                celulaComboBox.Enabled = true;
                FiltraCelulas();
                FiltraMembros();
            }
        }


        private void RedeWindowSearchMember_Click(object sender, EventArgs e)
        {
            if (celulaComboBox.SelectedValue != null)
            {
                GerenciamentoCelulas.Forms.Membros.MembroSearch search = new Membros.MembroSearch(igrejaComboBox.Text);

                search.ShowDialog();

                int newMember = search.MemberCode;
                if (newMember != 0)
                {
                    System.Windows.Forms.BindingSource membros;
                    Igrejafont10DataSetTableAdapters.Membros1TableAdapter membrosTableAdapter1;
                    membros = new System.Windows.Forms.BindingSource(this.components);
                    ((System.ComponentModel.ISupportInitialize)(membros)).BeginInit();
                    membros.DataMember = "Membros1";
                    membros.DataSource = this.igrejafont10DataSet;
                    ((System.ComponentModel.ISupportInitialize)(membros)).EndInit();
                    membrosTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.Membros1TableAdapter();
                    membrosTableAdapter1.ClearBeforeFill = true;

                    membrosTableAdapter1.Fill(igrejafont10DataSet.Membros1);

                    membros.Position = membros.Find("Codigo", newMember.ToString());
                    DataRowView row = (DataRowView)membros.Current;

                    row["Celula"] = celulaComboBox.SelectedValue.ToString();

                    membros.EndEdit();
                    membrosTableAdapter1.Update(igrejafont10DataSet.Membros1);

                    membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);                  

                    FiltraMembros();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma célula!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            System.Windows.Forms.BindingSource membros;
            Igrejafont10DataSetTableAdapters.Membros1TableAdapter membrosTableAdapter1;
            membros = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(membros)).BeginInit();
            membros.DataMember = "Membros1";
            membros.DataSource = this.igrejafont10DataSet;
            ((System.ComponentModel.ISupportInitialize)(membros)).EndInit();
            membrosTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.Membros1TableAdapter();
            membrosTableAdapter1.ClearBeforeFill = true;

            membrosTableAdapter1.Fill(igrejafont10DataSet.Membros1);

            membros.Position = membros.Find("Codigo", dataGridView.CurrentRow.Cells[0].Value.ToString());
            DataRowView row = (DataRowView)membros.Current;

            row["Celula"] = "0";

            membros.EndEdit();
            membrosTableAdapter1.Update(igrejafont10DataSet.Membros1);

            membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);

            FiltraMembros();            
            
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GerenciamentoCelulas.Forms.Membros.MemberAdd newmember = new GerenciamentoCelulas.Forms.Membros.MemberAdd((int)dataGridView.CurrentRow.Cells[0].Value, igrejaComboBox.SelectedValue.ToString());
            newmember.ShowDialog();
            membrosTableAdapter.FillBy(igrejafont10DataSet.Membros);
        }
    }
}
            