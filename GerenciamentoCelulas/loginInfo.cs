using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciamentoCelulas
{
    class loginInfo
    {
        public static string nome = "";
        public static string senha = "";
        public static string igreja = "";
        public static string role = "";
        public static string isLogged = "";
        public static string cidade = "";
        public static string estado = "";
        public static string regiao = "";


        public void SetNome(string text)
        {
            nome = text;
        }

        public void SetSenha(string text)
        {
            senha = text;
        }
        public void SetIgreja(string text)
        {
            igreja = text;
        }
        public void SetRole(string text)
        {
            role = text;
        }
        public void SetIsLogged(string text)
        {
            isLogged = text;
        }
        public void SetCidade(string text)
        {
            cidade = text;
        }
        public void SetEstado(string text)
        {
            estado = text;
        }
        public void SetRegiao(string text)
        {
            regiao = text;
        }
        public string GetNome()
        {
            return nome;
        }

        public string GetSenha()
        {
            return senha;

        }
        public string GetIgreja()
        {
            return igreja;
        }
        public string GetRole()
        {
            return role;
        }
        public string GetIsLogged()
        {
            return isLogged;
        }
        public string GetCidade()
        {
            return cidade;
        }
        public string GetEstado()
        {
            return estado;
        }
        public string GetRegiao()
        {
            return regiao;
        }
        public void SetLoggedToYes()
        {
            SqlConnection conn = new SqlConnection(GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("update Usuarios set IsLogged=@yes where nome=@Nome", conn);
            comm1.Parameters.Add("@Yes", SqlDbType.VarChar).Value = "yes";
            comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = this.GetNome();
            comm1.ExecuteReader();
        }

        public void SetLoggedToNo()
        {
            SqlConnection conn = new SqlConnection(GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("update Usuarios set IsLogged=@No where nome=@Nome", conn);
            comm1.Parameters.Add("@No", SqlDbType.VarChar).Value = "No";
            comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = this.GetNome();
            comm1.ExecuteReader();
        }

        public string GetStringConnection()
        {
            return "Data Source=dbsq0015.whservidor.com; Initial Catalog=igrejafont10; Persist Security Info=True; User ID=igrejafont10; Password=Fre1del.";
            //return "Data Source=FDV;Initial Catalog=GerenciaCelulas;Integrated Security=True";
            //"Data Source=FDV;Initial Catalog=GerenciaCelulas;Integrated Security=True"
            //"Data Source=SERVIDOR;Initial Catalog=GerenciaCelulas;Integrated Security=True"
            //return "Data Source=IFV-NB;Initial Catalog=GerenciaCelulas;Integrated Security=True";
        }


    }
}
