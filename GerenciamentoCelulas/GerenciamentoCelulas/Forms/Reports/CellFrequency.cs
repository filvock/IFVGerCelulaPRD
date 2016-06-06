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
    public partial class CellFrequency : Form
    {
        public CellFrequency()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }

        private void MemberAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont10DataSet.FrequenciaCelula11' table. You can move, or remove it, as needed.
            this.frequenciaCelula11TableAdapter.FillByDistinct(this.igrejafont10DataSet.FrequenciaCelula11);
            this.frequenciaCelula1TableAdapter.FillBy(this.igrejafont10DataSet.FrequenciaCelula1);
            
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            
            loginInfo login = new loginInfo(); 

            igrejaComboBox.SelectedValue = login.GetIgreja();


            if (login.GetRole().Equals("Igreja Local"))
            {
                igrejaComboBox.SelectedValue = login.GetIgreja(); 
                igrejaComboBox.Enabled = false;
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
                frequenciaCelula11BindingSource.Filter = "Celula = '" + celulaComboBox.SelectedValue.ToString() + "'" + " AND Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                frequenciaCelula11BindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                frequenciaCelula11BindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                frequenciaCelula11BindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                frequenciaCelula11BindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (igrejaComboBox.SelectedValue != null)
            {
                frequenciaCelula11BindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }

            cellMembersLabel.Text = dataGridView.RowCount.ToString();
            SetFrequencyData();
            
        }

        private void SetFrequencyData()
        {
            foreach (DataGridViewRow myRow in dataGridView.Rows)
            {
                myRow.Cells[2].Value = "";
                myRow.Cells[3].Value = "";
                myRow.Cells[4].Value = "";
                myRow.Cells[5].Value = "";
                myRow.Cells[6].Value = "";
            }
            
            var firstDayOfMonth = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            if (frequenciaCelula11BindingSource.Filter != null)
            {
                if (frequenciaCelula11BindingSource.Filter.ToString().Length > 0) frequenciaCelula1BindingSource.Filter = frequenciaCelula11BindingSource.Filter + "AND Data >= '" + firstDayOfMonth + "' AND Data <= '" + lastDayOfMonth + "'";
                else frequenciaCelula1BindingSource.Filter = "Data >= '" + firstDayOfMonth + "' AND Data <= '" + lastDayOfMonth + "'";

                if (frequenciaCelula1BindingSource.Count > 0)
                {

                    int count = frequenciaCelula1BindingSource.Count;
                    frequenciaCelula1BindingSource.MoveFirst();
                    int s = 0, n = 0, pi = 0, r = 0, aa = 0, o = 0, nl = 0;

                    for (int i = 0; i <= count; i++)
                    {
                        DataRowView row = (DataRowView)frequenciaCelula1BindingSource.Current;

                        int j = 0;
                        bool notFound = true;

                        while (notFound && j <dataGridView.Rows.Count)
                        {
                            if (dataGridView.Rows[j].Cells[0].Value.ToString().Equals(row[1].ToString()))
                            {
                                notFound = false;
                                int dia = Convert.ToInt32(row[4].ToString().Substring(0, 2));
                                int week = Convert.ToInt32((1 + (dia / 7)).ToString("0"));

                                
                                    if (row[3].ToString().Equals("0"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "N";
                                        n++;
                                    }
                                    else if (row[3].ToString().Equals("1"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "S";
                                        s++;
                                    }
                                    else if (row[3].ToString().Equals("2"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "PI";
                                        pi++;
                                    }
                                    else if (row[3].ToString().Equals("3"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "R";
                                        r++;
                                    }
                                    else if (row[3].ToString().Equals("4"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "AA";
                                        aa++;
                                    }
                                    else if (row[3].ToString().Equals("5"))
                                    {
                                        dataGridView.Rows[j].Cells[week + 1].Value = "O";
                                        o++;
                                    }                                
                            }
                            j++;
                        }
                        frequenciaCelula1BindingSource.MoveNext();
                    }

                    nl = dataGridView.Rows.Count  * 5 - s - n - pi - r - aa - o;

                     double[] yValues = {s,n,pi,r,aa,o,nl};
                    String[] xValues = { "S", "N", "PI", "R", "AA", "O", "NL" };
                    
                    chart1.Series["Data"].Points.DataBindXY(xValues, yValues);
                    chart1.Series["Data"].LegendText = "#AXISLABEL - #PERCENT" ;

                }
            }
        }

        private void SetWeekValue(String week, DataRowView row)
        {
           
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SetFrequencyData();
        }
    }
}
