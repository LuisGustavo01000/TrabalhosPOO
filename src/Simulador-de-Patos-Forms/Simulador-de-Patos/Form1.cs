using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPato.Models;
using Simulador_de_Patos.Models;

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

        private Duck CriarPatoPorTipo(string tipo)
        {
            return tipo switch
            {
                "Pato Selvagem" => new MallardDuck(1),
                "Pato Mudo" => new MuteDuck(2),
                "Pato Vermelho" => new RedHeadDuck(3),
                "Pato de Borracha" => new RuberDuck(4),
                "Pato Foguete" => new RocketDuck(5),
                "Super Pato" => new SuperDuck(6),
                "Pato Filhote" => new DuckLing(7),
                "Pato Tonto" => new DizzyDuck(8),
                "Pato de Madeira" => new DecoyDuck(9),
                _ => throw new ArgumentException("Tipo de pato desconhecido.")
            };
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
            if (string.IsNullOrEmpty(patoSelecionado)) return;

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
            string tipoJogador = comboBox1.SelectedItem?.ToString() ?? "Nenhum";
            if (tipoJogador == "Nenhum" || habilidadesSelecionadas.Count == 0)
            {
                MessageBox.Show("Selecione um pato e pelo menos uma habilidade.");
                return;
            }

            Duck patoJogador = CriarPatoPorTipo(tipoJogador);
            patoJogador.HabilidadesList.AddRange(habilidadesSelecionadas);

            List<string> tiposPossiveis = new List<string>
            {
                "Pato Selvagem", "Pato Mudo", "Pato Vermelho",
                "Pato de Borracha", "Pato Foguete", "Super Pato",
                "Pato Filhote", "Pato Tonto", "Pato de Madeira"
            };
            Random random = new Random();
            string tipoInimigo = tiposPossiveis[random.Next(tiposPossiveis.Count)];

            List<Button> botoesHabilidadesInimigo = GetHabilidadesPorPato(tipoInimigo);
            List<string> habilidadesInimigo = botoesHabilidadesInimigo.Select(btn => btn.Text).ToList();

            Duck patoInimigo = CriarPatoPorTipo(tipoInimigo);
            patoInimigo.HabilidadesList.AddRange(habilidadesInimigo);

            int maxRodadas = 3;
            int rodadaAtual = 0;
            int pontosJogador = 0;
            int pontosInimigo = 0;

            StringBuilder batalhaCompleta = new StringBuilder();
            batalhaCompleta.AppendLine($"Início da batalha: {tipoJogador} vs {tipoInimigo}");
            batalhaCompleta.AppendLine(new string('-', 40));

            foreach (var habJogador in patoJogador.HabilidadesList)
            {
                if (rodadaAtual >= maxRodadas || patoInimigo.HabilidadesList.Count == 0)
                    break;

                string habInimigo = Battle.ObterHabilidadeAleatoria(patoInimigo);
                string resultadoRodada = Battle.CompararHabilidades(patoJogador, patoInimigo, habJogador, habInimigo);

                batalhaCompleta.AppendLine($"\nRodada {rodadaAtual + 1}");
                batalhaCompleta.AppendLine($"Jogador: {tipoJogador} - Habilidade: {habJogador}");
                batalhaCompleta.AppendLine($"Inimigo: {tipoInimigo} - Habilidade: {habInimigo}");
                batalhaCompleta.AppendLine($"Resultado: {resultadoRodada}");
                batalhaCompleta.AppendLine(new string('-', 40));

                if (resultadoRodada.Contains("Vitória do jogador")) pontosJogador++;
                else if (resultadoRodada.Contains("Vitória do inimigo")) pontosInimigo++;

                rodadaAtual++;
            }

            string vencedorFinal = pontosJogador > pontosInimigo ? "Jogador venceu a batalha!" :
                                   pontosInimigo > pontosJogador ? "Inimigo venceu a batalha!" :
                                   "A batalha terminou empatada!";

            batalhaCompleta.AppendLine($"\nResultado Final: {vencedorFinal}");
            textBox2.Text = batalhaCompleta.ToString();
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
