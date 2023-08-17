using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizador_de_alunos
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnenviarfoto_Click(object sender, EventArgs e)
        {
            // Pesquisa pela imagem no coputador 

            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Seleciona a foto( *. jpg*;*.png;*.gif)|**.jpg;*.png;*.gif";          
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void btncadastrar_Click(object sender, EventArgs e);
        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
                (textBoxSobrenome.Text.Trim() == "") ||
                (textBoxTelefone.Text.Trim() == "") ||
                (textBoxEndereco.Text.Trim() == "") ||
                (pictureBoxFoto.Image == null))



            {
                return false;   
            }
            else
            {
                return true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // Insere um estudante.
            Estudante estudante = new Estudante();
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
                MemoryStream foto = new MemoryStream();

                // Verifica se o estudante é maior de 10 anos.
                int anoDeNascimento = dateTimePickerNascimento.Value.Year;
                // Pega o ano no qual estamos.
                int anoAtual = DateTime.Now.Year;
                if (
                    (anoAtual - anoDeNascimento) < 10 ||
                    (anoAtual - anoDeNascimento) > 100
                    )
                {
                    MessageBox.Show("A idade precisa ser entre 10 e 100 anos.",
                        "Idade Inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Verificar())
                {
                    pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                    if (estudante.inserirEstudante(nome, sobrenome, nascimento,
                        telefone, genero, endereco, foto))
                    {
                        MessageBox.Show("Novo Estudante Cadastrado", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
