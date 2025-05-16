using System.IO;
using Simulador_de_Patos.Models;
using System.Text;
using Simulador_de_Patos;
using Simulador_de_Patos.Services;
using Simulador_de_Patos.Interfaces;

namespace Simulador_de_Patos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Pato Selvagem", "Pato Mudo", "Pato Vermelho", "Pato de Borracha", "Pato Foguete", "Super Pato", "Pato Filhote", "Pato Tonto", "Pato de Madeira" });
            comboBox1.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Fly.Visible = false;
            Quack.Visible = false;
            Swin.Visible = false;
            Breaking.Visible = false;
            Spin.Visible = false;

            if (comboBox1.SelectedItem == null)
                return;

            string selectedDuck = comboBox1.SelectedItem.ToString();

            switch (selectedDuck)
            {
                case "Pato Selvagem":
                    Fly.Visible = true;
                    Swin.Visible = true;
                    Quack.Visible = true;
                    break;

                case "Pato Mudo":
                    Swin.Visible = true;
                    Fly.Visible = true;
                    break;

                case "Pato Vermelho":
                    Swin.Visible = true;
                    Fly.Visible = true;
                    Quack.Visible = true;
                    break;

                case "Pato de Borracha":
                    Swin.Visible = true;
                    Quack.Visible = true;
                    break;

                case "Pato Foguete":
                    Fly.Visible = true;
                    break;

                case "Super Pato":
                    Fly.Visible = true;
                    Quack.Visible = true;
                    Swin.Visible = true;
                    break;

                case "Pato Filhote":
                    Swin.Visible = true;
                    Quack.Visible = true;
                    break;

                case "Pato Tonto":
                    Quack.Visible = true;
                    Spin.Visible = true;
                    break;

                case "Pato de Madeira":
                    Swin.Visible = true;
                    Breaking.Visible = true;
                    break;

                default:

                    break;
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciarBatalha_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um pato antes de iniciar a batalha.", "Seleção de Pato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPatoSelecionado = comboBox1.SelectedIndex + 1;
            GerenciadorDePatos gerenciador = new GerenciadorDePatos();

            Duck patoJogador = gerenciador.ObterPatoPorId(idPatoSelecionado);
            Duck patoInimigo = gerenciador.ObterPatoAleatorio(idPatoSelecionado);

            string habJogador = Battle.ObterHabilidadeAleatoria(patoJogador);
            string habInimigo = Battle.ObterHabilidadeAleatoria(patoInimigo);

            // Aqui pega a string com resultado
            string resultadoBatalha = Battle.CompararHabilidades(patoJogador, patoInimigo, habJogador, habInimigo);

            // Mostra no TextBox multilinha no formulário
            textBox1.AppendText(resultadoBatalha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;


            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Spin_Click(object sender, EventArgs e)
        {

        }
    }
}
