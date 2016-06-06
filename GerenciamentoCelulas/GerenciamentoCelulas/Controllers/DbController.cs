using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCelulas.Controllers
{
    public class DbController
    {
        public Igrejafont10DataSet gerenciaCelulasDataSet;
        public igrejafont10DataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        public igrejafont10DataSetTableAdapters.CelulasTableAdapter celulasTableAdapter;
        public igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        public igrejafont10DataSetTableAdapters.DistritosTableAdapter distritosTableAdapter;
        public igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        public igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        //public GerenciaCelulasDataSetTableAdapters.LiderCelulaTableAdapter liderCelulaTableAdapter;
        public igrejafont10DataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        public igrejafont10DataSetTableAdapters.RedesTableAdapter redesTableAdapter;
        public igrejafont10DataSetTableAdapters.SetoresTableAdapter setoresTableAdapter;
        public igrejafont10DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public igrejafont10DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;

        public Igrejafont10DataSet.AreasRow newAreaRow;
        public Igrejafont10DataSet.CelulasRow newCelulasRow;
        public Igrejafont10DataSet.CidadesRow newCidadesRow;
        public Igrejafont10DataSet.DistritosRow newDistritosRow;
        public Igrejafont10DataSet.EstadosRow newEstadosRow;
        public Igrejafont10DataSet.IgrejasRow newIgrejasRow;
        public Igrejafont10DataSet.LiderCelulaRow  newLiderCelulaRow;
        public Igrejafont10DataSet.MembrosRow newMembrosRow;
        public Igrejafont10DataSet.RedesRow newRedesRow;
        public Igrejafont10DataSet.SetoresRow newSetoresRow;
        public Igrejafont10DataSet.UsuariosRow newUsuariosRow;
        

        public DbController()
        {
            gerenciaCelulasDataSet = new Igrejafont10DataSet();
            areasTableAdapter = new igrejafont10DataSetTableAdapters.AreasTableAdapter();
            celulasTableAdapter = new igrejafont10DataSetTableAdapters.CelulasTableAdapter();
            cidadesTableAdapter = new igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            distritosTableAdapter = new igrejafont10DataSetTableAdapters.DistritosTableAdapter();
            estadosTableAdapter = new igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            igrejasTableAdapter = new igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            //liderCelulaTableAdapter = new GerenciaCelulasDataSetTableAdapters.MembrosTableAdapter();
            membrosTableAdapter = new igrejafont10DataSetTableAdapters.MembrosTableAdapter();
            redesTableAdapter = new igrejafont10DataSetTableAdapters.RedesTableAdapter();
            setoresTableAdapter = new igrejafont10DataSetTableAdapters.SetoresTableAdapter();
            tableAdapterManager = new igrejafont10DataSetTableAdapters.TableAdapterManager();
            usuariosTableAdapter = new igrejafont10DataSetTableAdapters.UsuariosTableAdapter();

            newAreaRow = gerenciaCelulasDataSet.Areas.NewAreasRow();
            newCelulasRow = gerenciaCelulasDataSet.Celulas.NewCelulasRow();
            newCidadesRow = gerenciaCelulasDataSet.Cidades.NewCidadesRow();
            newDistritosRow = gerenciaCelulasDataSet.Distritos.NewDistritosRow();
            newEstadosRow = gerenciaCelulasDataSet.Estados.NewEstadosRow();
            newIgrejasRow = gerenciaCelulasDataSet.Igrejas.NewIgrejasRow();
            newLiderCelulaRow = gerenciaCelulasDataSet.LiderCelula.NewLiderCelulaRow();
            newMembrosRow = gerenciaCelulasDataSet.Membros.NewMembrosRow();
            newRedesRow = gerenciaCelulasDataSet.Redes.NewRedesRow();
            newSetoresRow = gerenciaCelulasDataSet.Setores.NewSetoresRow();
            newUsuariosRow = gerenciaCelulasDataSet.Usuarios.NewUsuariosRow();




        }


    }
}
