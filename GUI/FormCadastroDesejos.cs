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
    public partial class FormCadastroDesejos : Form
    {
        public FormCadastroDesejos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           SqlConnection conexao = ADODBConnection.Connection();
           SqlCommand comando = conexao.CreateCommand();

           comando.CommandText = "select * from tbl_desejo order by nome where Solicitante=@id_amigo_solicitante";
           comando.Parameters.AddWithValue("@id_amigo_solicitado", textBoxAmigoSolicitado);
           comando.Parameters.AddWithValue("@data_desejo", dateTimePickerDataDesejo);
           comando.Parameters.AddWithValue("@valor", textBoxValorDesejo);
           comando.Parameters.AddWithValue("@descricao_desejo", richTextBoxDescricao);

           Desejo IDDesejo = null;

           conexao.Open();

           using (SqlDataReader reader = comando.ExecuteReader())
           {
               if (reader.Read())
               {
                   IDDesejo = new IDDesejo();
                   IDDesejo.IDDesejo = reader.GetInt32(0);
                   IDDesejo.Solicitante = reader.GetString(1);
                   IDDesejo.Solicitado = reader.GetString(2);
                   IDDesejo.Valor = reader.GetFloat(3);
                   IDDesejo.DataDesejo = reader.GetDateTime(3);
                   IDDesejo.Descricao = reader.GetString(3);

               }
               conexao.Close();
           }
           return IDDesejo;
    }

        private void dateTimePickerDataDesejo_ValueChanged(object sender, EventArgs e)
        {
        
        }
}
