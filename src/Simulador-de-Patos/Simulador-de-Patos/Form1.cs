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
            comboBox1.Items.AddRange(new string[] { "Pato Tonto", "Pato de Madeira", "Pato Filhote", "Pato Selvagem", "Pato Mudo", "Pato Vermelho", "Pato Foguete", "Pato de Borracha", "Super Pato" });
            comboBox1.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GerenciadorDePatos gerenciador = new GerenciadorDePatos();
            var patos = gerenciador.ObterTodosPatos();

            foreach (var pato in patos)
            {
                comboBox1.Items.Add($"{pato.Tipo} (ID: {pato.Id})");
            }

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
            comboBox2.Items.Clear();


            string selectedDuck = comboBox1.SelectedItem.ToString();
            List<string> habilidades = new List<string>();

            switch (selectedDuck)
            {
                case "Pato de Madeira":
                    habilidades.AddRange(new[] { "Swim", "Breaking" });
                    break;
                case "Pato Filhote":
                    habilidades.AddRange(new[] { "Quack", "Swim" });
                    break;
                case "Pato Selvagem":
                    habilidades.AddRange(new[] { "Swim", "Fly", "Quack" });
                    break;
                case "Pato Tonto":
                    habilidades.AddRange(new[] { "Quack", "Spin" });
                    break;
                case "Pato Mudo":
                    habilidades.AddRange(new[] { "Fly", "Swim" });
                    break;
                case "Pato Vermelho":
                    habilidades.AddRange(new[] { "Fly", "Quack", "Swim" });
                    break;
                case "Pato Foguete":
                    habilidades.AddRange(new[] { "1 - Fly" });
                    break;
                case "Pato de Borracha":
                    habilidades.AddRange(new[] { "Swim", "Quack" });
                    break;
                case "Super Pato":
                    habilidades.AddRange(new[] { "Swim", "Quack", "Fly" });
                    break;

            }

            comboBox2.Items.AddRange(habilidades.ToArray());
            comboBox2.SelectedIndex = -1;
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
            // Verificar se um pato foi selecionado
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um pato antes de iniciar a batalha.",
                                "Seleção de Pato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o ID do pato selecionado no ComboBox
            int idPatoSelecionado = comboBox1.SelectedIndex + 1;

            // Inicializar o gerenciador de patos
            GerenciadorDePatos gerenciador = new GerenciadorDePatos();
            Duck patoJogador = gerenciador.ObterPatoPorId(idPatoSelecionado);
            Duck patoInimigo = gerenciador.ObterPatoAleatorio(idPatoSelecionado);


            // Mostrar a batalha no console
            Console.WriteLine($"\nBatalha: {patoJogador.Tipo} vs {patoInimigo.Tipo}");
            Battle.CompararHabilidades(patoJogador, patoInimigo, habJogador, habInimigoStr);


            // Exibir resultado no formulário
            MessageBox.Show($"Batalha entre {patoJogador.Tipo} e {patoInimigo.Tipo} iniciada! Confira o console para o resultado.",
                            "Batalha", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
