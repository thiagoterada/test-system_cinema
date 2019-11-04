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

        public void cadastrarSessoes(DateTime dt, DateTime hr, string nroSala, string idFilme, string capSala, string tipo, string valor)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "INSERT INTO `cinema`.`SESSAO` (`dt`, `hr`, `nroSala`, `idFilme`, `capSala`, `tipo`, `valor`) VALUES ('"+dt.ToString("yyyy-MM-dd")+"', '"+hr.ToString("hh:mm:ss")+"', '"+nroSala+"', '"+idFilme+"', '"+capSala+"', '"+tipo+"', '"+valor+"');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void atualizarFilmes(string id, string nm, string classif, string categ, string durac, string ano, string diretor)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "UPDATE `cinema`.`FILME` SET `nm` = '"+nm+"', `classif` = '"+classif+"', `categ` = '"+categ+"', `durac` = '"+durac+"', `ano` = '"+ano+"', `diretor` = '"+diretor+"' WHERE (`idFilme` = '"+id+"');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void atualizarSessoes(string id, DateTime dt, DateTime hr, string nroSala, string idFilme, string capSala, string tipo, string valor)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "UPDATE `cinema`.`SESSAO` SET `dt` = '"+dt.ToString("yyyy-MM-dd") + "', `hr` = '"+ hr.ToString("hh:mm:ss") + "', `nroSala` = '"+nroSala+"', `idFilme` = '"+idFilme+"', `capSala` = '"+capSala+"', `tipo` = '"+tipo+"', `valor` = '"+valor+"' WHERE (`idSessao` = '"+id+"');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void deletarFilmes(string id)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "DELETE FROM `cinema`.`FILME` WHERE (`idFilme` = '"+id+"');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

        public void deletarSessoes(string id)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=cinema";
            msc.Open();
            string consulta = "DELETE FROM `cinema`.`SESSAO` WHERE (`idSessao` = '" + id + "');";
            MySqlCommand msco = new MySqlCommand(consulta, msc);
            msco.ExecuteNonQuery();
            msc.Close();
        }

    }
}
