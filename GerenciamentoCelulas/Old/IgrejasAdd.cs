using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCelulas.Forms
{
    public partial class IgrejasAdd : Form
    {
        public IgrejasAdd()
        {
            InitializeComponent();
        }

        private void FormIgrejasAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet1.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            // TODO: This line of code loads data into the 'Igrejafont10DataSet1.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Estados' table. You can move, or remove it, as needed.
            //this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);
            //// TODO: This line of code loads data into the 'Igrejafont10DataSet.Cidades' table. You can move, or remove it, as needed.
            //this.cidadesTableAdapter.Fill(this.igrejafont10DataSet.Cidades);

        }

        private void formIgrejasAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formIgrejasAddOkButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.IgrejasRow newIgrejaRow = igrejafont10DataSet.Igrejas.NewIgrejasRow();
            Igrejafont10DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();

            newIgrejaRow.Cidade = formIgrejasAddComboBox.SelectedValue.ToString();
            newIgrejaRow.Nome = formIgrejasAddTextBox.Text;
            newIgrejaRow.Estado = formIgrejaAddEstadoComboBox.SelectedValue.ToString();

            igrejafont10DataSet.Igrejas.Rows.Add(newIgrejaRow);
            tableAdapter.Update(igrejafont10DataSet.Igrejas);

            formIgrejasAddTextBox.Clear();
            formIgrejasAddComboBox.Refresh();
        }
    }
}
