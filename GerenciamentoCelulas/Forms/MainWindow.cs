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

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);

            this.administraçãoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            this.CelulasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", CelulasToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            this.estruturaDeLíderesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", estruturaDeLíderesToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            this.cadastroDeMembrosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", cadastroDeMembrosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            this.célulasToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", célulasToolStripMenuItem1.Font.SizeInPoints * heightRatio * widthRatio);
            this.célulasToolStripMenuItem2.Font = new Font("Microsoft Sans Serif", célulasToolStripMenuItem2.Font.SizeInPoints * heightRatio * widthRatio);
            this.célulasToolStripMenuItem3.Font = new Font("Microsoft Sans Serif", célulasToolStripMenuItem3.Font.SizeInPoints * heightRatio * widthRatio);
            this.relatóriosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", relatóriosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            
            
            //this.mainWindowMenuStrip.Font = new Font("Microsoft Sans Serif", mainWindowMenuStrip.Font.SizeInPoints * heightRatio * widthRatio);
            //this.cidadesToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", cidadesToolStripMenuItem1.Font.SizeInPoints * heightRatio * widthRatio);
            //this.igrejasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", igrejasToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.usuáriosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", usuáriosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.redesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", redesToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.distritosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", distritosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.áreasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", áreasToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.setoresToolStripMenuItem.Font = new Font("Microsoft Sans Serif", setoresToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.célulasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", célulasToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.pastoresToolStripMenuItem.Font = new Font("Microsoft Sans Serif", pastoresToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.supervisoresToolStripMenuItem.Font = new Font("Microsoft Sans Serif", supervisoresToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.líderesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", líderesToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.membrosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", membrosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.convidadosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", convidadosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.novosNascidosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", novosNascidosToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.escadaDoSucessoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", escadaDoSucessoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.frequênciaCélulaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", frequênciaCélulaToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //this.frequênciaCultoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", frequênciaCultoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);

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

        private void frequênciaCultoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Reports.ServiceFrequency window = new Reports.ServiceFrequency();
            window.Show();
        }

        private void ofertasNaCélulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoCelulas.Forms.Reports.OffersReport window = new Reports.OffersReport();
            window.Show();
        }
    }

           
}
