using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms.Admin
{
    public partial class cidadesAdmin : Form
    {
        private int isEdit = 0;

        public cidadesAdmin()
        {
            InitializeComponent();
            cidadesAdminTextBox.Enabled = false;
            cidadesAdminComboBox.Enabled = false;
            cidadesAdminComboBox.Text = "";
            cidadesAdminTextBox.Text = "";
        }

        private void CidadesAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }

        }

        private void CidadeAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cidadesAdminTextBox.Text = cidadesAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            cidadesAdminComboBox.Text = cidadesAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void cidadeAdminEditButton_Click(object sender, EventArgs e)
        {
            if (cidadesAdminTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cidadesAdminTextBox.Enabled = true;
                cidadesAdminComboBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void cidadeAdminAddButton_Click(object sender, EventArgs e)
        {
            cidadesAdminTextBox.Enabled = true;
            cidadesAdminComboBox.Enabled = true;
            cidadesAdminComboBox.Text = "";
            cidadesAdminTextBox.Text = "";
            isEdit = 0;
        }

        private void cidadeAdminRemoveButton_Click(object sender, EventArgs e)
        {
            Igrejafont10DataSetTableAdapters.CidadesTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.CidadesTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover a cidade: " + cidadesAdminTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cidadesAdminDataGridView.Rows.RemoveAt(cidadesAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont10DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
                else
                {
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();
        }

        private void cidadeAdminSaveButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.CidadesRow newRow = igrejafont10DataSet.Cidades.NewCidadesRow();
            Igrejafont10DataSetTableAdapters.CidadesTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.CidadesTableAdapter();

            newRow.Estado = cidadesAdminComboBox.Text;
            newRow.Nome = cidadesAdminTextBox.Text;

            if (isEdit == 0)
            {
                try
                {
                    cidadesBindingSource.EndEdit();
                    igrejafont10DataSet.Cidades.AddCidadesRow(newRow);
                    tableAdapter.Update(igrejafont10DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            else
            {
                try
                {

                    cidadesAdminDataGridView.CurrentRow.Cells[0].Value = cidadesAdminTextBox.Text;
                    cidadesAdminDataGridView.CurrentRow.Cells[1].Value = cidadesAdminComboBox.Text;
                    
                    cidadesBindingSource.EndEdit();
                    tableAdapter.Update(igrejafont10DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;
                    isEdit = 0;

                }
                catch
                {
                    MessageBox.Show("Update failed");
                }

            }
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();
        }

        private void cidadeAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
