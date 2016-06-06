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
    public partial class CidadeAdd : Form
    {
        public CidadeAdd()
        {
            InitializeComponent();
        }

        private void FormCidadeAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet.Estados' table. You can move, or remove it, as needed.
            //this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);

        }

        private void formCidadesAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCidadesAddOkButton_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Igrejafont10DataSet.CidadesRow newCidadeRow = igrejafont10DataSet.Cidades.NewCidadesRow();
                
            Igrejafont10DataSetTableAdapters.CidadesTableAdapter tableAdapter = new Igrejafont10DataSetTableAdapters.CidadesTableAdapter();

            newCidadeRow.Estado = formCidadesAddComboBox.SelectedValue.ToString();
            newCidadeRow.Nome = formCidadesAddTextBox.Text;

            igrejafont10DataSet.Cidades.Rows.Add(newCidadeRow);
            tableAdapter.Update(igrejafont10DataSet.Cidades);

            formCidadesAddTextBox.Clear();
            
        }

        private void FormCidadeAdd_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Igrejafont10DataSet1.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont10DataSet.Estados);

        }
    }
}
