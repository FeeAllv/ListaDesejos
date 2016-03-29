using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Visualizar_Desejo : Form

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_desejo order by id_amigo_solicitante where IDDesejo=@id_desejo";
            comando.Parameters.AddWithValue("@id_desejo", Solicitante);
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
}
