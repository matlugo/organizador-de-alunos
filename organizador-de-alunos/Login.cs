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
namespace organizador_de_alunos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public object PictureBox1 { get; private set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Define a imagem da picture box via codigo
            pictureBox1.Image = Image.FromFile("../../imagens/user.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 MEU_BD bancoDeDados = new MEU_BD();


            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
                    MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes` WHERE `username` = @usn AND `senha` = @psd", bancoDeDados.getConexao);
        
        comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtusuario.Text;
            comando.Parameters.Add("@psd", MySqlDbType.VarChar).Value = txtusuario.Text;

            adaptador.SelectCommand= comando;
            adaptador.Fill(tabela);

            if( tabela.Rows.Count > 0 )
            {
                //MessageBox.Show("SIM");
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nome de usuario ou senha errado","Erro de login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
