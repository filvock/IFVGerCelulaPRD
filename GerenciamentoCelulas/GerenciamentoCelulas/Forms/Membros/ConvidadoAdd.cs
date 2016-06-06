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

namespace GerenciamentoCelulas.Forms.Membros
{
    public partial class ConvidadoAdd : Form
    {
        public int discipCode = 0;
        public int toUpdate = 0;

        public ConvidadoAdd(int codeToUpdate){
            InitializeComponent();
            toUpdate = codeToUpdate;
        }

        private void ConvidadoAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Setores' table. You can move, or remove it, as needed.
            this.setoresTableAdapter.Fill(this.igrejafont10DataSet.Setores);
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Celulas' table. You can move, or remove it, as needed.
            this.celulasTableAdapter.Fill(this.igrejafont10DataSet.Celulas);
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.igrejafont10DataSet.Areas);
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Distritos' table. You can move, or remove it, as needed.
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Redes' table. You can move, or remove it, as needed.
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            // TODO: This line of code loads data into the 'gerenciaCelulasDataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            FiltraRedePorIgreja();

            if (toUpdate != 0)
            {
                FillUserInfo();

            }

        }

        private void FillUserInfo()
        {
            loginInfo info = new loginInfo();
            int discipulador = 0;
            SqlConnection conn = new SqlConnection(info.GetStringConnection());
            conn.Open();


            SqlCommand comm1 = new SqlCommand("select * from membros where codigo=@code", conn);
            comm1.Parameters.Add("@code", SqlDbType.VarChar).Value = toUpdate;

            try
            {
                SqlDataReader usrRdr = null;
                usrRdr = comm1.ExecuteReader();
              

                if (usrRdr.HasRows)
                {
                    while (usrRdr.Read())
                    {
                        ConvidadoAddNomeTextBox.Text = usrRdr.GetString(1);
                        ConvidadoAddAniversarioDateTimePicker.Value = usrRdr.GetDateTime(3);
                        ConvidadoAddRuaRextBox.Text = usrRdr.GetString(4);
                        ConvidadoAddNumTextBox.Text = usrRdr.GetString(5);
                        ConvidadoAddCompTextBox.Text = usrRdr.GetString(6);
                        ConvidadoAddBairroTextBox.Text = usrRdr.GetString(7);
                        CEPTextBox.Text = usrRdr.GetString(8);
                        ConvidadoAddCidadeTextBox.Text = usrRdr.GetString(9);
                        ConvidadoAddEstadoComboBox.SelectedValue = usrRdr.GetString(10);

                        ConvidadoAddCel1TextBox.Text = usrRdr.GetString(13);
                        if (usrRdr.GetString(14) != null) ConvidadoAddOp1ComboBox.SelectedItem = usrRdr.GetString(14);
                        if (usrRdr.GetString(20) == "M") ConvidadoAddMRadioButton.Checked = true;
                        else ConvidadoAddFRadioButton.Checked = true;
                        ConvidadoAddEmailTextBox.Text = usrRdr.GetString(21);
                        ConvidadoAddEstadoCivilComboBox.SelectedItem = usrRdr.GetString(22);
                        redeComboBox.SelectedValue = usrRdr.GetString(24);
                        distritoComboBox.SelectedValue = usrRdr.GetString(25);
                        areaComboBox.SelectedValue = usrRdr.GetString(26);
                        setorComboBox.SelectedValue = usrRdr.GetString(27);
                        celulaComboBox.SelectedValue = usrRdr.GetString(28);
                        discipulador = usrRdr.GetInt32(2);

                    }
                }
            
            }
            catch
            {
                MessageBox.Show("Erro ao carregar dados do membro, tente novamente!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            ConvidadoAddCodeTextBox.Text = toUpdate.ToString();

        }

        private void ConvidadoAddOkButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.MembrosRow newmember = igrejafont10DataSet.Membros.NewMembrosRow();
            Igrejafont10DataSetTableAdapters.MembrosTableAdapter adapter = new Igrejafont10DataSetTableAdapters.MembrosTableAdapter();
            loginInfo login = new loginInfo();

            if (ConvidadoAddCodeTextBox.Text == "")
            {
                newmember.Aniversario = ConvidadoAddAniversarioDateTimePicker.Value;
                newmember.Ativo = 1;
                newmember.Bairro = ConvidadoAddBairroTextBox.Text;
                newmember.Celular = ConvidadoAddCel1TextBox.Text;
                newmember.CEP = CEPTextBox.Text;
                newmember.Cidade = ConvidadoAddCidadeTextBox.Text;
                newmember.Complemento = ConvidadoAddCompTextBox.Text;
                newmember.Discipulador = discipCode;
                newmember.Email = ConvidadoAddEmailTextBox.Text;
                if (ConvidadoAddEstadoCivilComboBox.SelectedItem != null)
                {
                    if (ConvidadoAddEstadoCivilComboBox.SelectedItem.ToString().Equals("Outro"))
                    {
                        newmember.EstadoCivil = ConvidadoAddEstadoCivilTextBox.Text;
                    }
                    else
                    {
                        newmember.EstadoCivil = ConvidadoAddEstadoCivilComboBox.SelectedItem.ToString();
                    }
                }
                else
                {
                    newmember.EstadoCivil = "";
                }
                newmember.Igreja = login.GetIgreja();
                newmember.Nome = ConvidadoAddNomeTextBox.Text;
                newmember.Num = ConvidadoAddNumTextBox.Text;
                if (ConvidadoAddOp1ComboBox.SelectedItem != null)
                { newmember.Operadora = ConvidadoAddOp1ComboBox.SelectedItem.ToString(); }
                else newmember.Operadora = "";
                newmember.Rua = ConvidadoAddRuaRextBox.Text;
                if (ConvidadoAddMRadioButton.Checked == true)
                    newmember.Sexo = "M";
                else newmember.Sexo = "F";
                newmember.UF = ConvidadoAddEstadoComboBox.SelectedValue.ToString();


                if (redeComboBox.SelectedValue != null) newmember.Rede = redeComboBox.SelectedValue.ToString();
                else newmember.Rede = "";
                if (distritoComboBox.SelectedValue != null) newmember.Distrito = distritoComboBox.SelectedValue.ToString();
                else newmember.Distrito = "";
                if (areaComboBox.SelectedValue != null) newmember.Area = areaComboBox.SelectedValue.ToString();
                else newmember.Area = "";
                if (setorComboBox.SelectedValue != null) newmember.Setor = setorComboBox.SelectedValue.ToString();
                else newmember.Setor = "";
                if (celulaComboBox.SelectedValue != null) newmember.Celula = celulaComboBox.SelectedValue.ToString();
                else newmember.Celula = "";

                igrejafont10DataSet.Membros.Rows.Add(newmember);
                MessageBox.Show("Novo Convidado Adicionado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                System.Data.DataRow[] newrow;

                newrow = igrejafont10DataSet.Membros.Select("Codigo = " + toUpdate.ToString());

                 
                newrow[0]["Aniversario"] = ConvidadoAddAniversarioDateTimePicker.Value;
                newrow[0]["Ativo"] = 1;
                newrow[0]["Bairro"] = ConvidadoAddBairroTextBox.Text;
                newrow[0]["Celular"] = ConvidadoAddCel1TextBox.Text;
                newrow[0]["CEP"] = CEPTextBox.Text;
                newrow[0]["Cidade"] = ConvidadoAddCidadeTextBox.Text;
                newrow[0]["Complemento"] = ConvidadoAddCompTextBox.Text;
                newrow[0]["Discipulador"] = discipCode;
                newrow[0]["Email"] = ConvidadoAddEmailTextBox.Text;
                if (ConvidadoAddEstadoCivilComboBox.SelectedItem != null)
                {
                    if (ConvidadoAddEstadoCivilComboBox.SelectedItem.ToString().Equals("Outro"))
                    {
                        newrow[0]["EstadoCivil"] = ConvidadoAddEstadoCivilTextBox.Text;
                    }
                    else
                    {
                        newrow[0]["EstadoCivil"] = ConvidadoAddEstadoCivilComboBox.SelectedItem.ToString();
                    }
                }
                else
                {
                    newrow[0]["EstadoCivil"] = "";
                }
                newrow[0]["Igreja"] = login.GetIgreja();
                newrow[0]["Nome"] = ConvidadoAddNomeTextBox.Text;
                newrow[0]["Num"] = ConvidadoAddNumTextBox.Text;
                if (ConvidadoAddOp1ComboBox.SelectedItem != null)
                { newrow[0]["Operadora"] = ConvidadoAddOp1ComboBox.SelectedItem.ToString(); }
                else newrow[0]["Operadora"] = "";
                newrow[0]["Rua"] = ConvidadoAddRuaRextBox.Text;
                if (ConvidadoAddMRadioButton.Checked == true)
                    newrow[0]["Sexo"] = "M";
                else newrow[0]["Sexo"] = "F";
                newrow[0]["UF"] = ConvidadoAddEstadoComboBox.SelectedValue.ToString();


                if (redeComboBox.SelectedValue != null) newrow[0]["Rede"] = redeComboBox.SelectedValue.ToString();
                else newrow[0]["Rede"] = "";
                if (distritoComboBox.SelectedValue != null) newrow[0]["Distrito"] = distritoComboBox.SelectedValue.ToString();
                else newrow[0]["Distrito"] = "";
                if (areaComboBox.SelectedValue != null) newrow[0]["Area"] = areaComboBox.SelectedValue.ToString();
                else newrow[0]["Area"] = "";
                if (setorComboBox.SelectedValue != null) newrow[0]["Setor"] = setorComboBox.SelectedValue.ToString();
                else newrow[0]["Setor"] = "";
                if (celulaComboBox.SelectedValue != null) newrow[0]["Celula"] = celulaComboBox.SelectedValue.ToString();
                else newrow[0]["Celula"] = "";
            }
            


            
            adapter.Update(igrejafont10DataSet.Membros);


            CleanFields();
        
        
        }

        private void CleanFields()
        {
            ConvidadoAddBairroTextBox.Clear();
            ConvidadoAddCel1TextBox.Clear();
            ConvidadoAddCidadeTextBox.Clear();
            ConvidadoAddCompTextBox.Clear();
            ConvidadoAddEmailTextBox.Clear();
            ConvidadoAddEstadoCivilTextBox.Clear();
            ConvidadoAddNomeTextBox.Clear();
            ConvidadoAddNumTextBox.Clear();
            ConvidadoAddRuaRextBox.Clear();
            CEPTextBox.Clear();

            
        }

        private void ConvidadoAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FiltraRedePorIgreja()
        {
            loginInfo info = new loginInfo();
            redesBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
            
        }

        private void FiltraDistritoPorRede()
        {
            loginInfo info = new loginInfo();
            if (distritoCheckBox.Checked == false)
            {
                if (redeComboBox.SelectedValue != null)
                {
                    distritosBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else
                {
                    distritosBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
                }
            }
            else
            {
                FiltraCelulas();
            }
        }

        private void FiltraAreaPorDistrito()
        {
            loginInfo info = new loginInfo();
            if (areaCheckBox.Checked == false)
            {
                if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    areasBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (redeComboBox.SelectedValue != null)
                {
                    areasBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else 
                {
                    areasBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
                }
            }
            else
            {
                FiltraCelulas();
            }
        }

        private void FiltraSetorPorArea()
        {
            loginInfo info = new loginInfo();
            if (setorCheckBox.Checked == false)
            {
                if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (redeComboBox.SelectedValue != null)
                {
                    setoresBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else 
                {
                    setoresBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
                }
            }
            else
            {
                FiltraCelulas();
            }
        }

        private void FiltraCelulas()
        {
            if (celulaCheckBox.Checked != true)
            {
                loginInfo info = new loginInfo();
                if (setorComboBox.SelectedValue != null && areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    celulasBindingSource.Filter = "Setor = '" + setorComboBox.SelectedValue.ToString() + "'" + "AND Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (areaComboBox.SelectedValue != null && distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    celulasBindingSource.Filter = "Area = '" + areaComboBox.SelectedValue.ToString() + "'" + "AND Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (distritoComboBox.SelectedValue != null && redeComboBox.SelectedValue != null)
                {
                    celulasBindingSource.Filter = "Distrito  = '" + distritoComboBox.SelectedValue.ToString() + "'" + "AND Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else if (redeComboBox.SelectedValue != null)
                {
                    celulasBindingSource.Filter = "Rede = '" + redeComboBox.SelectedValue.ToString() + "'" + "AND Igreja = '" + info.GetIgreja() + "'";
                }
                else
                {
                    celulasBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
                }
            }
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
            }
        }

        public void ConvidadoAddEstadoCivilComboBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (ConvidadoAddEstadoCivilComboBox.SelectedItem != null)
            {
                if (ConvidadoAddEstadoCivilComboBox.SelectedItem.ToString().Equals("Outro"))
                {
                    ConvidadoAddEstadoCivilTextBox.Enabled = true;
                }
                else
                {
                    ConvidadoAddEstadoCivilTextBox.Enabled = false;
                }
            }
        }

    }
}
