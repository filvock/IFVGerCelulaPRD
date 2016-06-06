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
    public partial class MemberAdd : Form
    {
        public int discipCode = 0;
        public int toUpdate = 0;

        public MemberAdd(int codeToUpdate){
            InitializeComponent();
            toUpdate = codeToUpdate;
        }

        private void MemberAdd_Load(object sender, EventArgs e)
        {
            this.setoresTableAdapter.FillBy(this.igrejafont10DataSet.Setores);
            this.celulasTableAdapter.FillBy(this.igrejafont10DataSet.Celulas);
            this.areasTableAdapter.FillBy(this.igrejafont10DataSet.Areas);
            this.distritosTableAdapter.Fill(this.igrejafont10DataSet.Distritos);
            this.redesTableAdapter.Fill(this.igrejafont10DataSet.Redes);
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            this.membrosTableAdapter.FillBy(this.igrejafont10DataSet.Membros);
            this.membrosTableAdapter1.Fill(this.igrejafont10DataSet.Membros1);
            
            FiltraRedePorIgreja();

            if (toUpdate != 0)
            {
                FillUserInfo();
            }
        }

        private void FillUserInfo()
        {
            membrosBindingSource.Position = membrosBindingSource.Find("Codigo", toUpdate.ToString());
            DataRowView row = (DataRowView)membrosBindingSource.Current;
           
            MemberAddCodeTextBox.Text = toUpdate.ToString();
            MemberAddNomeTextBox.Text = row["Nome"].ToString();
            MemberAddAniversarioDateTimePicker.Text = row["Aniversario"].ToString();
            MemberAddRuaTextBox.Text = row["Rua"].ToString();
            MemberAddNumTextBox.Text = row["Num"].ToString();
            MemberAddCompTextBox.Text = row["Complemento"].ToString();
            MemberAddBairroTextBox.Text = row["Bairro"].ToString();
            CEPTextBox.Text = row["CEP"].ToString();
            MemberAddCidadeTextBox.Text = row["Cidade"].ToString();
            MemberAddEstadoComboBox.SelectedValue = row["UF"].ToString();
            MemberAddCPFTextBox.Text = row["CPF"].ToString();
            MemberAddRGTextBox.Text = row["RG"].ToString();

            MemberAddCel1TextBox.Text = row["Celular"].ToString();
            if (row["Operadora"].ToString() != null) MemberAddOp1ComboBox.SelectedItem = row["Operadora"].ToString();
            MemberAddCel2TextBox.Text = row["Celular1"].ToString();
            if (row["Operadora1"].ToString() != null) MemberAddOp2ComboBox.SelectedItem = row["Operadora1"].ToString();
            MemberAddCel3TextBox.Text = row["Celular2"].ToString();
            if (row["Operadora2"].ToString() != null) MemberAddOp3ComboBox.SelectedItem = row["Operadora2"].ToString();
            MemberAddFoneTextBox.Text = row["Fone"].ToString();
            if (row["Sexo"].ToString().Contains("M")) MemberAddMRadioButton.Checked = true;
            else MemberAddFRadioButton.Checked = true;
            MemberAddEmailTextBox.Text = row["Email"].ToString();
            MemberAddEstadoCivilComboBox.SelectedItem = row["EstadoCivil"].ToString();
            redeComboBox.SelectedValue = row["Rede"];
            distritoComboBox.SelectedValue = row["Distrito"];
            areaComboBox.SelectedValue = row["Area"];
            setorComboBox.SelectedValue = row["Setor"];
            celulaComboBox.SelectedValue = row["Celula"];
            discipCode = Int32.Parse(row["Discipulador"].ToString());
            
            if (discipCode != 0)
            {
                membrosBindingSource1.Position = membrosBindingSource1.Find("Codigo", discipCode.ToString());
                DataRowView row1 = (DataRowView)membrosBindingSource1.Current;

                MemberAddDiscTextBox.Text = row1["Nome"].ToString();

            }
        }

        private void MemberAddOkButton_Click(object sender, EventArgs e)
        {
            

            if (MemberAddCodeTextBox.Text == "")
            {
                AddNewMember();
            }

            else
            {
                UpdateMember();
            }

            CleanFields();             
        }

        private void UpdateMember()
        {
            membrosBindingSource1.Position = membrosBindingSource1.Find("Codigo", toUpdate.ToString());
            DataRowView row = (DataRowView)membrosBindingSource1.Current;
            
            row["Nome"] = MemberAddNomeTextBox.Text;
            row["Aniversario"] = MemberAddAniversarioDateTimePicker.Text;
            row["Rua"] = MemberAddRuaTextBox.Text;
            row["Num"] = MemberAddNumTextBox.Text;
            row["Complemento"] = MemberAddCompTextBox.Text;
            row["Bairro"] = MemberAddBairroTextBox.Text;
            row["CEP"] = CEPTextBox.Text;
            row["Cidade"] = MemberAddCidadeTextBox.Text;
            row["UF"] = MemberAddEstadoComboBox.SelectedValue;
            row["CPF"] = MemberAddCPFTextBox.Text;
            row["RG"] = MemberAddRGTextBox.Text;

            row["Celular"] = MemberAddCel1TextBox.Text;
            if (MemberAddOp1ComboBox.SelectedValue != null) row["Operadora"] = MemberAddOp1ComboBox.SelectedValue;
            row["Celular1"] = MemberAddCel2TextBox.Text;
            if (MemberAddOp2ComboBox.SelectedValue != null) row["Operadora1"] = MemberAddOp2ComboBox.SelectedValue;
            row["Celular2"] = MemberAddCel3TextBox.Text;
            if (MemberAddOp3ComboBox.SelectedValue != null)  row["Operadora2"] = MemberAddOp3ComboBox.SelectedValue;
            row["Fone"] = MemberAddFoneTextBox.Text;
            if (MemberAddMRadioButton.Checked) row["Sexo"] = "M";
            else row["Sexo"] = "F";
            row["Email"] = MemberAddEmailTextBox.Text;
            row["EstadoCivil"] = MemberAddEstadoCivilComboBox.SelectedItem;
            row["Celula"] = celulaComboBox.SelectedValue;
            row["Discipulador"] = discipCode.ToString();

            membrosBindingSource1.EndEdit();
            membrosTableAdapter1.Update(igrejafont10DataSet.Membros1);

            MessageBox.Show("Dados do membro atualizados.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }

        private void AddNewMember()
        {
            GerenciamentoCelulas.Igrejafont10DataSet.Membros1Row newmember = igrejafont10DataSet.Membros1.NewMembros1Row();
            loginInfo login = new loginInfo();
            newmember.Aniversario = MemberAddAniversarioDateTimePicker.Value;
            newmember.Ativo = 1;
            newmember.Bairro = MemberAddBairroTextBox.Text;
            newmember.Celular = MemberAddCel1TextBox.Text;
            newmember.Celular1 = MemberAddCel2TextBox.Text;
            newmember.Celular2 = MemberAddCel3TextBox.Text;
            newmember.CEP = CEPTextBox.Text;
            newmember.Cidade = MemberAddCidadeTextBox.Text;
            newmember.Complemento = MemberAddCompTextBox.Text;
            newmember.CPF = MemberAddCPFTextBox.Text;
            newmember.Discipulador = discipCode;
            newmember.Email = MemberAddEmailTextBox.Text;
            if (MemberAddEstadoCivilComboBox.SelectedItem != null)
            {
                if (MemberAddEstadoCivilComboBox.SelectedItem.ToString().Equals("Outro"))
                {
                    newmember.EstadoCivil = MemberAddEstadoCivilTextBox.Text;
                }
                else
                {
                    newmember.EstadoCivil = MemberAddEstadoCivilComboBox.SelectedItem.ToString();
                }
            }
            else
            {
                newmember.EstadoCivil = "";
            }
            newmember.Fone = MemberAddFoneTextBox.Text;
            newmember.Igreja = login.GetIgreja();
            newmember.Nome = MemberAddNomeTextBox.Text;
            newmember.Num = MemberAddNumTextBox.Text;
            if (MemberAddOp1ComboBox.SelectedItem != null)
            { newmember.Operadora = MemberAddOp1ComboBox.SelectedItem.ToString(); }
            else newmember.Operadora = "";
            if (MemberAddOp2ComboBox.SelectedItem != null)
            { newmember.Operadora1 = MemberAddOp2ComboBox.SelectedItem.ToString(); }
            else newmember.Operadora1 = "";
            if (MemberAddOp3ComboBox.SelectedItem != null)
            { newmember.Operadora2 = MemberAddOp3ComboBox.SelectedItem.ToString(); }
            else newmember.Operadora2 = "";
            newmember.RG = MemberAddRGTextBox.Text;
            newmember.Rua = MemberAddRuaTextBox.Text;
            if (MemberAddMRadioButton.Checked == true)
                newmember.Sexo = "M";
            else newmember.Sexo = "F";
            newmember.UF = MemberAddEstadoComboBox.SelectedValue.ToString();


            newmember.Rede = "";
            newmember.Distrito = "";
            newmember.Area = "";
            newmember.Setor = "";
            if (celulaComboBox.SelectedValue != null && celulaComboBox.SelectedValue.ToString().Length != 0)
                newmember.Celula = celulaComboBox.SelectedValue.ToString();
            else newmember.Celula = "0";
            
            igrejafont10DataSet.Membros1.Rows.Add(newmember);
            membrosBindingSource1.EndEdit();
            membrosTableAdapter1.Update(igrejafont10DataSet.Membros1);

            membrosBindingSource1.Position = membrosBindingSource1.Count - 1;
            DataRowView row = (DataRowView)membrosBindingSource1.Current;

            AddEscada(Convert.ToInt32(row["Codigo"]));

            MessageBox.Show("Novo Membro Adicionado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddEscada(int code)
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

            GerenciamentoCelulas.Igrejafont10DataSet.EscadaSucessoRow newmember = igrejafont10DataSet.EscadaSucesso.NewEscadaSucessoRow();

            newmember.Codigo = code;
            newmember.OracaoEntrega = "";
            newmember.DecisaoIgreja = "";
            newmember.Discipulado = "";
            newmember.PreEncontro = "";
            newmember.Encontro = "";
            newmember.PosEncontro = "";
            newmember.Encontreiro = "";
            newmember.Batismo = "";
            newmember.EM = "";
            newmember.DizimosOfertas = "";
            newmember.CasamentoLegal = "";
            newmember.TADEL = "";
            newmember.MDA2 = "";
            newmember.TLC = "";
            newmember.CoLider = "";
            
            igrejafont10DataSet.EscadaSucesso.Rows.Add(newmember);
            escadaSucesso.EndEdit();
            escadaTableAdapter.Update(igrejafont10DataSet.EscadaSucesso);
        }

        private void CleanFields()
        {
            MemberAddBairroTextBox.Clear();
            MemberAddCel1TextBox.Clear();
            MemberAddCel2TextBox.Clear();
            MemberAddCel3TextBox.Clear();
            MemberAddCidadeTextBox.Clear();
            MemberAddCompTextBox.Clear();
            MemberAddCPFTextBox.Clear();
            MemberAddEmailTextBox.Clear();
            MemberAddEstadoCivilTextBox.Clear();
            MemberAddFoneTextBox.Clear();
            MemberAddNomeTextBox.Clear();
            MemberAddNumTextBox.Clear();
            MemberAddRGTextBox.Clear();
            MemberAddRuaTextBox.Clear();
            CEPTextBox.Clear();
            MemberAddDiscTextBox.Clear();
            MemberAddCodeTextBox.Clear();
            
            MemberAddAniversarioDateTimePicker.Value = DateTime.Now;
            MemberAddEstadoComboBox.SelectedItem = -1;
            MemberAddOp1ComboBox.SelectedItem = -1;
            MemberAddOp2ComboBox.SelectedItem = -1;
            MemberAddOp3ComboBox.SelectedItem = -1;
            MemberAddMRadioButton.Checked = false;
            MemberAddFRadioButton.Checked = false;
            MemberAddEstadoCivilComboBox.SelectedItem = -1;

            redeComboBox.SelectedItem = -1;
            distritoComboBox.SelectedItem = -1;
            areaComboBox.SelectedItem = -1;
            setorComboBox.SelectedItem = -1;
            celulaComboBox.SelectedItem = -1;
        }

        private void MemberAddCancelButton_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            loginInfo info = new loginInfo();
            MembroSearch search = new MembroSearch(info.GetIgreja());

            search.ShowDialog();

            discipCode = search.MemberCode;

            if (discipCode != 0)
            {
                membrosBindingSource1.Position = membrosBindingSource1.Find("Codigo", discipCode.ToString());
                DataRowView row = (DataRowView)membrosBindingSource1.Current;

                MemberAddDiscTextBox.Text = row["Nome"].ToString();
            }
        }
        

        public void MemberAddEstadoCivilComboBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (MemberAddEstadoCivilComboBox.SelectedItem != null)
            {
                if (MemberAddEstadoCivilComboBox.SelectedItem.ToString().Equals("Outro"))
                {
                    MemberAddEstadoCivilTextBox.Enabled = true;
                }
                else
                {
                    MemberAddEstadoCivilTextBox.Enabled = false;
                }
            }
        }
    }
}
