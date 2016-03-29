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
            comando.Parameters.AddWithValue("@id_amigo_solicitante", Solicitante);
            Desejo IDDesejo = null ;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if(reader.Read())
                {
                    IDDesejo = new IDDesejo();
                    IDDesejo.Solicitante = reader.GetString(1);
                    IDDesejo.Descricao = reader.GetString(2);
                   
                }
                conexao.Close();
            }
            return IDDesejo;
        }
}
