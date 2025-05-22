using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simulador_de_Patos
{
    public partial class Form1 : Form
    {
        private List<string> habilidadesSelecionadas = new();

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[]
            {
                "Pato Selvagem", "Pato Mudo", "Pato Vermelho",
                "Pato de Borracha", "Pato Foguete", "Super Pato",
                "Pato Filhote", "Pato Tonto", "Pato de Madeira"
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesabilitarBotoesHabilidades();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidadesSelecionadas.Clear();
            textBox1.Clear();
            AtualizarBotoesHabilidades();
        }

        private void AtualizarBotoesHabilidades()
        {
            DesabilitarBotoesHabilidades();

            var patoSelecionado = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(patoSelecionado))
                return;

            var botoes = GetHabilidadesPorPato(patoSelecionado);

            foreach (var botao in botoes)
                botao.Enabled = true;
        }

        private void DesabilitarBotoesHabilidades()
        {
            Fly.Enabled = Swin.Enabled = Quack.Enabled = Breaking.Enabled = Spin.Enabled = false;
        }

        private List<Button> GetHabilidadesPorPato(string pato)
        {
            var mapa = new Dictionary<string, List<Button>>
            {
                ["Pato Selvagem"] = new() { Fly, Swin, Quack },
                ["Pato Mudo"] = new() { Fly, Swin },
                ["Pato Vermelho"] = new() { Fly, Swin, Quack },
                ["Pato de Borracha"] = new() { Swin, Quack },
                ["Pato Foguete"] = new() { Fly },
                ["Super Pato"] = new() { Fly, Swin, Quack },
                ["Pato Filhote"] = new() { Swin, Quack },
                ["Pato Tonto"] = new() { Quack, Spin },
                ["Pato de Madeira"] = new() { Swin, Breaking }
            };

            return mapa.ContainsKey(pato) ? mapa[pato] : new List<Button>();
        }

        private void Habilidade_Click(object sender, EventArgs e)
        {
            if (sender is Button botao)
            {
                habilidadesSelecionadas.Add(botao.Text);
                textBox1.AppendText($"Habilidade adicionada: {botao.Text}\r\n");
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            string pato = comboBox1.SelectedItem?.ToString() ?? "Nenhum";
            string habilidades = string.Join(", ", habilidadesSelecionadas);
            textBox2.Text = $"O {pato} entrou na batalha com as habilidades: {habilidades}!";
        }

        private void Desistir_Click(object sender, EventArgs e)
        {
            textBox2.Text = "O pato desistiu da batalha!";
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            habilidadesSelecionadas.Clear();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
