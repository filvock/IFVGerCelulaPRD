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
    public partial class OffersReport : Form
    {
        public OffersReport()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }

        private void MemberAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'igrejafont10DataSet.OfertasCelulas'. Você pode movê-la ou removê-la conforme necessário.
            this.ofertasCelulas1TableAdapter.FillBy(this.igrejafont10DataSet.OfertasCelulas1);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.FrequenciaCelula11' table. You can move, or remove it, as needed.
            this.frequenciaCelula11TableAdapter.FillByDistinct(this.igrejafont10DataSet.FrequenciaCelula11);
            this.frequenciaCelula1TableAdapter.FillBy(this.igrejafont10DataSet.FrequenciaCelula1);
            
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.celulasTableAdapter1.FillBy(this.igrejafont10DataSet.Celulas);
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

            FiltraCelulas();

            this.dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


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
            FiltraCelulas();

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

            FiltraCelulasOfertas();


        }

        private void FiltraCelulasOfertas()
        {
            if (celulaComboBox.SelectedValue != null && setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
            {
                celulasBindingSource1.Filter = "Codigo = '" + celulaComboBox.SelectedValue.ToString() + "'" + "AND Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            else if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null && igrejaComboBox.SelectedValue != null)
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
            SetOfferData();
        }


        

        private void SetOfferData()
        {
            foreach (DataGridViewRow myRow in dataGridView.Rows)
            {
                myRow.Cells[1].Value = "";
                myRow.Cells[2].Value = "";
                myRow.Cells[3].Value = "";
                myRow.Cells[4].Value = "";
                myRow.Cells[5].Value = "";
                myRow.Cells[6].Value = "";
            }

            var firstDayOfMonth = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            
            if (igrejaComboBox.SelectedValue != null)
            {
                ofertasCelulas1BindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'" + " AND Data >= '" + firstDayOfMonth + "' AND Data <= '" + lastDayOfMonth + "'";
            }


            if (ofertasCelulas1BindingSource.Count > 0)
            {
                int count = ofertasCelulas1BindingSource.Count;
                ofertasCelulas1BindingSource.MoveFirst();

                for (int i = 0; i <= count; i++)
                {
                    DataRowView row = (DataRowView)ofertasCelulas1BindingSource.Current;

                    int j = 0;
                    bool notFound = true;

                    while (notFound && j < dataGridView.Rows.Count)
                    {
                        if (dataGridView.Rows[j].Cells[0].Value.ToString().Equals(row[2].ToString()))
                        {
                            notFound = false;
                            int dia = Convert.ToInt32(row[9].ToString().Substring(0, 2));
                            int week = Convert.ToInt32((1 + (dia / 7)).ToString("0"));

                            dataGridView.Rows[j].Cells[week].Value = row[8].ToString();
                        }
                        j++;
                    }
                    ofertasCelulas1BindingSource.MoveNext();
                }

                double week1 = 0;
                double week2 = 0;
                double week3 = 0;
                double week4 = 0;
                double week5 = 0;
                double total = 0;

                if (dataGridView.RowCount > 0)
                {
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        week1 = 0;
                        week2 = 0;
                        week3 = 0;
                        week4 = 0;
                        week5 = 0;
                        total = 0;

                        if (dataGridView.Rows[i].Cells[1].Value.ToString().Length > 0) week1 = Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value.ToString());
                        if (dataGridView.Rows[i].Cells[2].Value.ToString().Length > 0) week2 = Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value.ToString());
                        if (dataGridView.Rows[i].Cells[3].Value.ToString().Length > 0) week3 = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value.ToString());
                        if (dataGridView.Rows[i].Cells[4].Value.ToString().Length > 0) week4 = Convert.ToDouble(dataGridView.Rows[i].Cells[4].Value.ToString());
                        if (dataGridView.Rows[i].Cells[5].Value.ToString().Length > 0) week5 = Convert.ToDouble(dataGridView.Rows[i].Cells[5].Value.ToString());
                        
                        if (week1 > 0) dataGridView.Rows[i].Cells[1].Value = Convert.ToDouble(week1).ToString("C");
                        if (week2 > 0) dataGridView.Rows[i].Cells[2].Value = Convert.ToDouble(week2).ToString("C");
                        if (week3 > 0) dataGridView.Rows[i].Cells[3].Value = Convert.ToDouble(week3).ToString("C");
                        if (week4 > 0) dataGridView.Rows[i].Cells[4].Value = Convert.ToDouble(week4).ToString("C");
                        if (week5 > 0) dataGridView.Rows[i].Cells[5].Value = Convert.ToDouble(week5).ToString("C");

                        total = week1 + week2 + week3 + week4 + week5;
                        dataGridView.Rows[i].Cells[6].Value = Convert.ToDouble(total).ToString("C");


                    }
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

                FiltraCelulas();

            }
            else
            {
                FiltraRedePorIgreja();
                FiltraCelulas();
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

                FiltraCelulas();


            }
            else
            {
                distritoComboBox.Enabled = true;
                FiltraDistritoPorRede();
                FiltraCelulas();
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

                FiltraCelulas();


            }
            else
            {
                areaComboBox.Enabled = true;
                FiltraAreaPorDistrito();
                FiltraCelulas();
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

                FiltraCelulas();

            }
            else
            {
                setorComboBox.Enabled = true;
                FiltraSetorPorArea();
                FiltraCelulas();
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
                FiltraCelulas();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SetOfferData();
        }
    }
}
