using Seriator.Model.Model.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookYourself.Model.DAO
{
    class ReceitaDAO
    {
        MySqlConnection con = null;

        public bool CadastroReceita(ModelReceita receita)
        {           

            bool i = false;

            try
            {

                string sql = @"insert into tbl_receita(receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6, receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento, receita_tempoPreparo, receita_custoTotal)
                values('" + receita.Ingrediente1 + "', '" +receita.Ingrediente2 + "', '" + receita.Ingrediente3 + "', '" + receita.Ingrediente4 + "', '" + receita.Ingrediente5
                + "', '" + receita.Ingrediente6 + "', '" + receita.Ingrediente7 + "', '" + receita.Ingrediente8 + "', '" + receita.Ingrediente9 + "', '" + receita.Ingrediente10 
                + "', '" + receita.Titulo + "', '" + receita.Preparo +  "', '" + receita.Tipo + "', '" + receita.Rendimento + "', '" + receita.TempoPreparo + "', '" + receita.CustoTotal + "');";

                con = ConnectionFactory.Connection();

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.ExecuteNonQuery();

                con.Close();

                sql = "select receita_titulo from tbl_receita where receita_titulo = '" + receita.Titulo + "';";

                con.Open();

                cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    i = true;
                }
                else {
                    i = false;
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu durante o cadastro. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return i;

        }

        public List<ModelMensagens> CarregarMensagens()
        {


            List<ModelMensagens> x = new List<ModelMensagens>();
            try
            {
                string sql = "select mensagem_id, mensagem_autor, mensagem_email, mensagem_conteudo from tbl_mensagens;";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                while (dtreader.Read())//If there's any data.
                {
                    ModelMensagens m = new ModelMensagens();

                    m.MensagemCodigo = dtreader.GetInt16("mensagem_id");
                    m.MensagemAutor = dtreader.GetString("mensagem_autor");
                    m.MensagemEmail = dtreader.GetString("mensagem_email");
                    m.MensagemConteudo = dtreader.GetString("mensagem_conteudo");

                    x.Add(m);
                }

                con.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu ao carregar as mensagens. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }

            return x;


        }


        public List<ModelReceita> CarregarReceitas(string tipo)
        {


            List<ModelReceita> x = new List<ModelReceita>();
            try
            {
                string sql = "select receita_titulo, receita_rendimento, receita_tempoPreparo, receita_custoTotal from tbl_receita where receita_tipo = '" + tipo + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                while (dtreader.Read())//If there's any data.
                {
                    ModelReceita receita = new ModelReceita();

                    receita.Titulo = dtreader.GetString("receita_titulo");
                    receita.Rendimento = dtreader.GetString("receita_rendimento");
                    receita.TempoPreparo = dtreader.GetString("receita_tempoPreparo");
                    receita.CustoTotal = dtreader.GetString("receita_custoTotal");

                    x.Add(receita);
                }

                con.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu ao as receitas. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }

            return x;


        }

        public ModelReceita Selection(string titulo)
        {
            ModelReceita receita = new ModelReceita();

            string sql = @"select receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6,
            receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento,
            receita_tempoPreparo, receita_custoTotal from tbl_receita where receita_titulo = '" + titulo + "';";
            con = ConnectionFactory.Connection();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    receita.Ingrediente1 = dt.GetString("receita_ingrediente1");
                    receita.Ingrediente2 = dt.GetString("receita_ingrediente2");
                    receita.Ingrediente3 = dt.GetString("receita_ingrediente3");
                    receita.Ingrediente4 = dt.GetString("receita_ingrediente4");
                    receita.Ingrediente5 = dt.GetString("receita_ingrediente5");
                    receita.Ingrediente6 = dt.GetString("receita_ingrediente6");
                    receita.Ingrediente7 = dt.GetString("receita_ingrediente7");
                    receita.Ingrediente8 = dt.GetString("receita_ingrediente8");
                    receita.Ingrediente9 = dt.GetString("receita_ingrediente9");
                    receita.Ingrediente10 = dt.GetString("receita_ingrediente10");
                    receita.Titulo = dt.GetString("receita_titulo");
                    receita.Preparo = dt.GetString("receita_preparo");
                    receita.Tipo = dt.GetString("receita_tipo");
                    receita.Rendimento = dt.GetString("receita_rendimento");
                    receita.TempoPreparo = dt.GetString("receita_tempoPreparo");
                    receita.CustoTotal = dt.GetString("receita_custoTotal");
                }
                con.Close();

            }

            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu durante a seleção. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }
            return receita;
        }

        public bool DeletarReceita(string titulo)
        {
            bool i = false;
            try
            {
                string sql = "delete from tbl_receita where receita_titulo = '" + titulo + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                if (dtreader.Read())
                {
                    i = false;
                }
                else
                {
                    i = true;
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu durante a exclusão. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;

        }

        public List<ModelReceita> Filtrar(string title, string tipo)
        {
            List<ModelReceita> x = new List<ModelReceita>();

            string sql = @"select receita_titulo, receita_rendimento, receita_tempoPreparo, receita_custoTotal from tbl_receita where receita_titulo = '" + title + "%' and receita_tipo = '" + tipo + "';";
            con = ConnectionFactory.Connection();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
                {
                    ModelReceita receita = new ModelReceita();

                    receita.Titulo = dt.GetString("receita_titulo");
                    receita.Rendimento = dt.GetString("receita_rendimento");
                    receita.TempoPreparo = dt.GetString("receita_tempoPreparo");
                    receita.CustoTotal = dt.GetString("receita_custoTotal");


                    x.Add(receita);

                }
                con.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Algo errado aconteceu durante a filtragem. Por favor, tente novamente mais tarde.", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                throw new Exception(e.Message);
            }
            return x;

        }

    }
}
