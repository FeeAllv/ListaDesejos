using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Controller
{
    public class ControllerAmigo
    {

        public bool GravarAmigo(Amigo amigo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
           
            SqlCommand comando = conexao.CreateCommand();

            if (amigo.IDAmigo == 0)
            {
                comando.CommandText = "insert into tbl_amigo (nome,email,data_nascimento) values(@nome,@email,@datanascimento)";
                comando.Parameters.AddWithValue("@nome", amigo.Nome);
                comando.Parameters.AddWithValue("@email", amigo.Email);
                comando.Parameters.AddWithValue("@datanascimento", amigo.DataNascimento);
            }
            else
            {
                comando.CommandText = "update tbl_amigo set nome=@nome, email=@email, data_nascimento=@datanascimento where id_amigo=@idamigo";
                comando.Parameters.AddWithValue("@nome", amigo.Nome);
                comando.Parameters.AddWithValue("@email", amigo.Email);
                comando.Parameters.AddWithValue("@datanascimento", amigo.DataNascimento);
                comando.Parameters.AddWithValue("@idamigo", amigo.IDAmigo);
            }
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }

        public bool ExcluirAmigo(int idAmigo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from tbl_amigo where id_amigo=@idamigo";
            comando.Parameters.AddWithValue("@id_amigo", idAmigo);
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }

        public List<Amigo> ListarAmigos()
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_amigo order by nome";
            List<Amigo> listaAmigos = new List<Amigo>();
            Amigo amigo;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    amigo = new Amigo();
                    amigo.IDAmigo = reader.GetInt32(0);
                    amigo.Nome = reader.GetString(1);
                    amigo.Email = reader.GetString(2);
                    amigo.DataNascimento = reader.GetDateTime(3);
                    listaAmigos.Add(amigo);
                }
                conexao.Close();
            }
            return listaAmigos;
        }

        public Amigo ListarAmigoPorId(int idAmigo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_amigo order by nome where id_amigo=@idamigo";
            comando.Parameters.AddWithValue("@idamigo", idAmigo);
            Amigo amigo = null ;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if(reader.Read())
                {
                    amigo = new Amigo();
                    amigo.IDAmigo = reader.GetInt32(0);
                    amigo.Nome = reader.GetString(1);
                    amigo.Email = reader.GetString(2);
                    amigo.DataNascimento = reader.GetDateTime(3);
                   
                }
                conexao.Close();
            }
            return amigo;
        }

        public bool GravarDesejo(Desejo desejo)
        {
            SqlConnection conexao = ADODBConnection.Connection();

            SqlCommand comando = conexao.CreateCommand();

            if (desejo.IDDesejo == 0)
            {
                comando.CommandText = "insert into tbl_desejo (id_desejo,id_amigo_solicitante,id_amigo_solicitado,data_desejo,valor,descricao_desejo) values(@id_desejo,@id_amigo_solicitante,@id_amigo_solicitado,@data_desejo,@valor,@descricao_desejo)";
                comando.Parameters.AddWithValue("@id_desejo", desejo.IDDesejo);
                comando.Parameters.AddWithValue("@id_amigo_solicitante", desejo.Solicitante);
                comando.Parameters.AddWithValue("@id_amigo_solicitado", desejo.Solicitado);
                comando.Parameters.AddWithValue("@data_desejo", desejo.DataDesejo);
                comando.Parameters.AddWithValue("@valor", desejo.Valor);
                comando.Parameters.AddWithValue("@descricao_desejo", desejo.Descricao);
            }
            else
            {
                comando.CommandText = "update tbl_desejo set id_desejo=@id_desejo, id_amigo_solicitante=@id_amigo_solicitante, id_amigo_solicitado=@id_amigo_solicitado, data_desejo=@data_desejo, valor=@valor, descricao_desejo=@descricao_desejo where id_desejo=@id_desejo";
                comando.Parameters.AddWithValue("@id_desejo", desejo.IDDesejo);
                comando.Parameters.AddWithValue("@id_amigo_solicitante", desejo.Solicitante);
                comando.Parameters.AddWithValue("@id_amigo_solicitado", desejo.Solicitado);
                comando.Parameters.AddWithValue("@data_desejo", desejo.DataDesejo);
                comando.Parameters.AddWithValue("@valor", desejo.Valor);
                comando.Parameters.AddWithValue("@descricao_desejo", desejo.Descricao);
            }
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }
        public Amigo ListarDesejoPorAmigo(int idDesejo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_desejo order by nome where id_amigo=@idamigo";
            comando.Parameters.AddWithValue("@id_desejo", idDesejo);
            Desejo desejo = null;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if (reader.Read())
                {
                    desejo = new Desejo();
                    desejo.IDDesejo = reader.GetInt32(0);
                    desejo.Solicitante = reader.GetString(1);
                    desejo.Solicitado = reader.GetString(2);
                    desejo.Valor = reader.GetFloat(3);
                    desejo.DataDesejo = reader.GetDateTime(3);
                    desejo.Descricao = reader.GetString(3);

                }
                conexao.Close();
            }
            return Desejo;
        }
    }
}
