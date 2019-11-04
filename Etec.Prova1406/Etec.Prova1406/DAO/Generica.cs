using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.Prova1406.DAO
{
    class Generica
    {
        public DataTable retornarFilmesCombo()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM FILME ORDER BY nm", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public DataTable retornarFilmes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT idFilme as ID, nm as NOME, classif as CLASSIFICACAO, categ as CATEGORIA, durac as DURACAO, ano as ANO, diretor as DIRETOR FROM FILME", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public DataTable retornarSessoes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT idSessao as ID, dt as DATA, hr as HORA, nroSala as NUMERO_SALA, idFilme as ID_FILME, capSala as CAPACIDADE, tipo as TIPO, valor as VALOR FROM SESSAO", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public void cadastrarFilmes(string nm, string classif, string categ, string durac, string ano, string diretor)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "INSERT INTO `cinema`.`FILME` (`nm`, `classif`, `categ`, `durac`, `ano`, `diretor`) VALUES ('"+nm+"', '"+classif+"', '"+categ+"', '"+durac+"', '"+ano+"', '"+diretor+"');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void cadastrarSessoes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void atualizarFilmes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void atualizarSessoes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void deletarFilmes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void deletarSessoes()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

    }
}
