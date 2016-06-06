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
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            SetWindowToRole();
        }

        private void SetWindowToRole()
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                administraçãoToolStripMenuItem.Enabled = false;

            }
        }


        //private void adicionarCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.CidadeAdd cidadeAdd = new CidadeAdd();
        //    cidadeAdd.Show();
        //}

        //private void removerCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.CidadeRemove cidadeRemove = new CidadeRemove();
        //    cidadeRemove.Show();
        //}

        //private void adicionarIgrejaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.IgrejasAdd igrejasAdd = new IgrejasAdd();
        //    igrejasAdd.Show();
        //}

        //private void removerIgrejaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.IgrejasRemove igrejasRemove = new IgrejasRemove();
        //    igrejasRemove.Show();
        //}

        //private void adicionarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.UserAdd userAdd = new UserAdd();
        //    userAdd.Show();

        //}

        //private void removerUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GerenciamentoCelulas.Forms.UserRemove userRemove = new UserRemove();
        //    userRemove.Show();
        //}

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginInfo info = new loginInfo();
            info.SetLoggedToNo();
        }

        private void MainFormAdminButton_Click(object sender, EventArgs e)
        {

        }       

        private void membrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Membros.MemberAdmin members = new Membros.MemberAdmin();
            members.Show();
        }
        private void redesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Estrutura.RedesAdmin redes = new Estrutura.RedesAdmin();
            redes.Show();
        }
        private void distritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Estrutura.DistritoAdmin distritos = new Estrutura.DistritoAdmin();
            distritos.Show();

        }

        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Estrutura.AreaAdmin areas = new Estrutura.AreaAdmin();
            areas.Show();
        }

        private void setoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Estrutura.SetorAdmin setor = new Estrutura.SetorAdmin();
            setor.Show();
        }



        private void célulasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Celula.CelulaMembrosAdmin celula = new Celula.CelulaMembrosAdmin();
            celula.Show();

        }

        private void célulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Estrutura.CelulaAdmin celula = new Estrutura.CelulaAdmin();
            celula.Show();
        }

        private void cidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Admin.cidadesAdmin cidades = new Admin.cidadesAdmin();
            cidades.Show();
        }

        private void igrejasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Admin.IgrejasAdmin igrejas = new Admin.IgrejasAdmin();
            igrejas.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Admin.UsersAdmin users = new Admin.UsersAdmin();
            users.Show();
        }

        private void líderesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Lideres.LiderCelulaAdmin lideres = new Lideres.LiderCelulaAdmin();
            lideres.Show();
        }

        private void convidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Membros.ConvidadoAdd convidado = new Membros.ConvidadoAdd(0);
            convidado.Show();
        }

        private void escadaDoSucessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Reports.SuccessLadder window = new Reports.SuccessLadder();
            window.Show();
        }

        private void frequênciaCélulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Reports.CellFrequency window = new Reports.CellFrequency();
            window.Show();
        }
    }

           
}
