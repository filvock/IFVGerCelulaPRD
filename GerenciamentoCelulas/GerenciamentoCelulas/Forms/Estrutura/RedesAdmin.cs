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
    public partial class RedesAdmin : Form
    {
        public RedesAdmin()
        {
            InitializeComponent();
            LockFields();

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
            
            this.redesTableAdapter.FillBy(this.igrejafont10DataSet.Redes);
            this.redesTableAdapter1.Fill(this.igrejafont10DataSet.Redes1);
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            

            loginInfo login = new loginInfo();

            redesBindingSource.Filter = "Igreja = '" + login.GetIgreja() + "'";
            igrejaComboBox.SelectedValue = login.GetIgreja();

            if (login.GetRole().Equals("Igreja Local"))
            {                
                igrejaComboBox.Enabled = false;
            }

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
            ClearFields();
            UnlockFields();
        }

        private void RedesAdminCleanButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RedesAdminSaveButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.RedesRow newRedesRow = igrejafont10DataSet.Redes.NewRedesRow();
            
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Por favor, digite um nome para criação da Rede.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                if (codeTextBox.Text.ToString().Equals(""))
                {
                    newRedesRow.Nome = nameTextBox.Text;
                    newRedesRow.Igreja = igrejaComboBox.SelectedValue.ToString();
                    newRedesRow.Responsavel = codTextBox.Text;
                    newRedesRow.Fone = "";
                    newRedesRow.Email = "";
                    newRedesRow.Obs = obsTextBox.Text;
                    newRedesRow.Meta = "";
                    newRedesRow.Ativa = "Yes";
                    igrejafont10DataSet.Redes.Rows.Add(newRedesRow);
                }
                else
                {
                    redesBindingSource1.Position = redesBindingSource1.Find("Codigo", codeTextBox.Text);
                    DataRowView row = (DataRowView)redesBindingSource1.Current;

                    row["Nome"] = nameTextBox.Text;
                    row["Responsavel"] = codTextBox.Text;
                    row["Obs"] = obsTextBox.Text;
                }
                try
                {
                    redesBindingSource1.EndEdit();
                    redesTableAdapter1.Update(igrejafont10DataSet.Redes1);
                    redesBindingSource.EndEdit();
                    redesTableAdapter.Update(igrejafont10DataSet.Redes);
                    ClearFields();
                    LockFields();
                    redesTableAdapter.FillBy(igrejafont10DataSet.Redes);
                    redesBindingSource.ResetBindings(false);
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
                FiltraRede();
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

        private void RedeWindowEditRede_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length == 0) MessageBox.Show("Por favor, selecione uma Rede para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else UnlockFields();
        }
        
        private void RedeWindowIgrejaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltraRede();
        }

        private void FiltraRede()
        {
            ClearFields();
            if (igrejaComboBox.SelectedValue != null)
            {
                redesBindingSource.Filter = "Igreja = '" + igrejaComboBox.SelectedValue.ToString() + "'";
            }
            
            cellMembersLabel.Text = dataGridView.RowCount.ToString();
        }

        private void RedeWindowDeactivateRede_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.RedesRow newRedesRow = igrejafont10DataSet.Redes.NewRedesRow();
            Igrejafont10DataSetTableAdapters.RedesTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.RedesTableAdapter();
            dataGridView.CurrentRow.Cells[7].Value = "No";
            tableAdapter.Update(igrejafont10DataSet.Redes);
            ClearFields();
            LockFields();
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

        private void RedeWindowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }

        private void FillDataFields()
        {
            LockFields();
            codeTextBox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            codTextBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            respTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            foneTextBox.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            emailTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            obsTextBox.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillDataFields();
        }
    }
}