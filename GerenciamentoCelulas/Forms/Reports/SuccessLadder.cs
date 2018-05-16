using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms.Reports
{
    public partial class SuccessLadder : Form
    {
        public SuccessLadder()
        {
            InitializeComponent();
        }

        private void MemberAdmin_Load(object sender, EventArgs e)
        {
            this.escadaSucessoTableAdapter.FillBy(this.igrejafont10DataSet.EscadaSucesso);
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            this.membrosTableAdapter.FillBy(this.igrejafont10DataSet.Membros);

            
            loginInfo login = new loginInfo();

            igrejaComboBox.SelectedValue = login.GetIgreja();


            if (login.GetRole().Equals("Igreja Local"))
            {
                igrejaComboBox.SelectedValue = login.GetIgreja(); 
                igrejaComboBox.Enabled = false;
            }
            else if (login.GetRole().Equals("Presidente Estadual"))
            {
                igrejasBindingSource.Filter = "Estado = '" + login.GetEstado() + "'";
            }

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

            this.dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
        }

        private void MemberAdminClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                escadaSucessoBindingSource.Filter = "Celula = '" + celulaComboBox.SelectedValue.ToString() + "'" + " AND Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                escadaSucessoBindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                escadaSucessoBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                escadaSucessoBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                escadaSucessoBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                escadaSucessoBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
            
        }

        private void redeCheckBox_CheckedChanged(object sender, EventArgs e)
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


        private void es1scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es1scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND OracaoEntrega = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND OracaoEntrega = 'X'", "");

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es1ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es1ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND OracaoEntrega = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND OracaoEntrega = ' '", "");

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es2scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es2scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND DecisaoIgreja = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND DecisaoIgreja = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es2ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es2ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND DecisaoIgreja = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND DecisaoIgreja = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es3scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es3scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Discipulado = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Discipulado = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es3ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es3ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Discipulado = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Discipulado = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es4scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es4scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND PreEncontro = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND PreEncontro = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es4ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es4ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND PreEncontro = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND PreEncontro = ' '", "");

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es5scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es5scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Encontro = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Encontro = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es5ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es5ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Encontro = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Encontro = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es6scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es6scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND PosEncontro = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND PosEncontro = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es6ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es6ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND PosEncontro = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND PosEncontro = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es7scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es7scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Encontreiro = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Encontreiro = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es7ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es7ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Encontreiro = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Encontreiro = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es8scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es8scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Batismo = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Batismo = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es8ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es8ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND Batismo = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND Batismo = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es9scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es9scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND EM = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND EM = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es9ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es9ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND EM = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND EM = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es10scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es10scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND DizimosOfertas = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND DizimosOfertas = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es10ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es10ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND DizimosOfertas = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND DizimosOfertas = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es11scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es11scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND CasamentoLegal = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND CasamentoLegal = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es11ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es11ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND CasamentoLegal = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND CasamentoLegal = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es12scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es12scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND TADEL = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND TADEL = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es12ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es12ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND TADEL = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND TADEL = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es13scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es13scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND MDA2 = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND MDA2 = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es13ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es13ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND MDA2 = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND MDA2 = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es14scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es14scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND TLC = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND TLC = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es14ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es14ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND TLC = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND TLC = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es15scheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es15scheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND CoLider = 'X'";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND CoLider = 'X'", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void es15ncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (es15ncheckBox.Checked) escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter + " AND CoLider = ' '";
            else escadaSucessoBindingSource.Filter = escadaSucessoBindingSource.Filter.Replace(" AND CoLider = ' '", "");
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }
    }
}
