using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public partial class Cadastro_de_Amigos : Form
    {
        public Cadastro_de_Amigos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
