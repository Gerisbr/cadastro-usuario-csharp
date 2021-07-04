using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroDeUsuario
{
    public partial class FrmCadastrarUsuarios : Form
    {
        public FrmCadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        

        
       
            string bancoDeDados = "server=localhost;user id=root;password=;database=BD_CORPORATION";

            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try

            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;
            
                cmd.CommandText = $"insert into tb_usuarios ( nome , sobrenome , telefone , email ) values('{txtNome.Text}','{txtSobrenome.Text}','{txtTelefone.Text}','{txtEmail.Text}')"; 


                    cmd.ExecuteNonQuery();

                conexao.Close();
           MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (MySqlException erro)
                {
                MessageBox.Show("Não foi possivel conectar com o banco de dados: " + erro.Message);
            }


        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastrarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
