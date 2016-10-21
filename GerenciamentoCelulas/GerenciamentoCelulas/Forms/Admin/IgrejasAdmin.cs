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
    public partial class IgrejasAdmin : Form
    {

        private int isEdit = 0;

        public IgrejasAdmin()
        {
            InitializeComponent();
            igrejasAdminTextBox.Enabled = false;
            igrejasAdminCidadeComboBox.Enabled = false;
            igrejasAdminEstadoComboBox.Enabled = false;
            igrejasAdminEstadoComboBox.Text = "";
            igrejasAdminTextBox.Text = "";
            igrejasAdminCidadeComboBox.Text = "";
        }

        private void IgrejasAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont10DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont10DataSet.Igrejas);
            cellMembersLabel.Text = igrejasAdminDataGridView.RowCount.ToString();

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
        }

        private void IgrejasAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            igrejasAdminTextBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            igrejasAdminCidadeComboBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            igrejasAdminEstadoComboBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void IgrejasAdminEditButton_Click(object sender, EventArgs e)
        {
            if (igrejasAdminTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                igrejasAdminTextBox.Enabled = true;
                igrejasAdminCidadeComboBox.Enabled = true;
                igrejasAdminEstadoComboBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void IgrejasAdminAddButton_Click(object sender, EventArgs e)
        {
            igrejasAdminTextBox.Enabled = true;
            igrejasAdminCidadeComboBox.Enabled = true;
            igrejasAdminEstadoComboBox.Enabled = true;
            igrejasAdminEstadoComboBox.Text = "";
            igrejasAdminTextBox.Text = "";
            igrejasAdminCidadeComboBox.Text = "";
            isEdit = 0;
        }

        private void IgrejasAdminRemoveButton_Click(object sender, EventArgs e)
        {
            Igrejafont10DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover a igreja: " + igrejasAdminTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    igrejasAdminDataGridView.Rows.RemoveAt(igrejasAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont10DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;

                }
                else
                {
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            cellMembersLabel.Text = igrejasAdminDataGridView.RowCount.ToString();
        }

        private void IgrejasAdminSaveButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.IgrejasRow newRow = igrejafont10DataSet.Igrejas.NewIgrejasRow();
            Igrejafont10DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();

            newRow.Cidade = igrejasAdminCidadeComboBox.Text;
            newRow.Estado = igrejasAdminEstadoComboBox.Text;
            newRow.Nome = igrejasAdminTextBox.Text;

            if (isEdit == 0)
            {
                try
                {
                    igrejasBindingSource.EndEdit();
                    igrejafont10DataSet.Igrejas.AddIgrejasRow(newRow);
                    tableAdapter.Update(igrejafont10DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;
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
                    igrejasAdminDataGridView.CurrentRow.Cells[0].Value = igrejasAdminTextBox.Text;
                    igrejasAdminDataGridView.CurrentRow.Cells[1].Value = igrejasAdminCidadeComboBox.Text;
                    igrejasAdminDataGridView.CurrentRow.Cells[2].Value = igrejasAdminEstadoComboBox.Text;
                    igrejasBindingSource.EndEdit();
                    tableAdapter.Update(igrejafont10DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            cellMembersLabel.Text = igrejasAdminDataGridView.RowCount.ToString();
        }

        private void IgrejasAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
