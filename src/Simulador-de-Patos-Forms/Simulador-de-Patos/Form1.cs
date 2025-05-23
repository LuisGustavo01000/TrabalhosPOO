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
        private Duck patoJogador;
        private Duck patoInimigo;
        private string tipoJogador;
        private string tipoInimigo;
        private int rodadaAtual = 0;
        private int maxRodadas = 3;
        private int pontosJogador = 0;
        private int pontosInimigo = 0;
        private StringBuilder batalhaCompleta = new();
        private bool batalhaEmAndamento = false;

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

        private void Iniciar_Click(object sender, EventArgs e)
        {
            tipoJogador = comboBox1.SelectedItem?.ToString() ?? "Nenhum";
            if (tipoJogador == "Nenhum")
            {
                MessageBox.Show("Selecione um pato.");
                return;
            }

            patoJogador = CriarPatoPorTipo(tipoJogador);

            List<string> tiposPossiveis = new List<string>
            {
                "Pato Selvagem", "Pato Mudo", "Pato Vermelho",
                "Pato de Borracha", "Pato Foguete", "Super Pato",
                "Pato Filhote", "Pato Tonto", "Pato de Madeira"
            };
            tiposPossiveis.Remove(tipoJogador);

            Random random = new Random();
            tipoInimigo = tiposPossiveis[random.Next(tiposPossiveis.Count)];

            List<Button> botoesHabilidadesInimigo = GetHabilidadesPorPato(tipoInimigo);
            List<string> habilidadesInimigo = botoesHabilidadesInimigo.Select(btn => btn.Text).ToList();

            patoInimigo = CriarPatoPorTipo(tipoInimigo);
            patoInimigo.HabilidadesList.AddRange(habilidadesInimigo);

            maxRodadas = 3;
            rodadaAtual = 0;
            pontosJogador = 0;
            pontosInimigo = 0;
            batalhaCompleta = new StringBuilder();
            batalhaCompleta.AppendLine($"Início da batalha: {tipoJogador} vs {tipoInimigo}");
            batalhaCompleta.AppendLine(new string('-', 40));
            batalhaEmAndamento = true;

            habilidadesSelecionadas.Clear(); 

            textBox2.Text = batalhaCompleta.ToString();
            MessageBox.Show("Batalha iniciada! Escolha uma habilidade para a primeira rodada.");
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
            batalhaEmAndamento = false;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Habilidade_Click(object sender, EventArgs e)
        {
            if (sender is Button botao)
            {
                string habJogador = botao.Text;
                string descricao = "";

                if (patoJogador == null)
                {
                    var tipo = comboBox1.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(tipo))
                        patoJogador = CriarPatoPorTipo(tipo);
                }

                if (patoJogador != null)
                {
                    switch (habJogador)
                    {
                        case "Fly":
                            if (patoJogador is Simulador_de_Patos.Interfaces.IFlyable flyable)
                                descricao = flyable.fly();
                            break;
                        case "Swin":
                            if (patoJogador is Simulador_de_Patos.Interfaces.ISwimable swimable)
                                descricao = swimable.swim();
                            break;
                        case "Quack":
                            if (patoJogador is Simulador_de_Patos.Interfaces.IQuackable quackable)
                                descricao = quackable.quack();
                            break;
                        case "Spin":
                            if (patoJogador is Simulador_de_Patos.Interfaces.IDizzy dizzy)
                                descricao = dizzy.spin();
                            break;
                        case "Breaking":
                            if (patoJogador is Simulador_de_Patos.Interfaces.IBroken broken)
                                descricao = broken.breaking();
                            break;
                        default:
                            descricao = "Habilidade não implementada.";
                            break;
                    }
                    textBox1.AppendText(descricao + "\r\n");
                }

                if (!batalhaEmAndamento)
                {
                    return;
                }

                if (!patoJogador.HabilidadesList.Contains(habJogador))
                    patoJogador.HabilidadesList.Add(habJogador);

                if (!patoJogador.HabilidadesList.Contains(habJogador))
                {
                    textBox1.AppendText("Habilidade inválida para este pato.\r\n");
                    return;
                }
                if (rodadaAtual >= maxRodadas)
                {
                    textBox1.AppendText("A batalha já terminou.\r\n");
                    return;
                }

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

                if (rodadaAtual >= maxRodadas)
                {
                    string vencedorFinal = pontosJogador > pontosInimigo ? "Jogador venceu a batalha!" :
                                           pontosInimigo > pontosJogador ? "Inimigo venceu a batalha!" :
                                           "A batalha terminou empatada!";
                    batalhaCompleta.AppendLine($"\nResultado Final: {vencedorFinal}");
                    batalhaEmAndamento = false;
                }
                else
                {
                    MessageBox.Show("Selecione outra habilidade para a próxima rodada.");
                }
                textBox2.Text = batalhaCompleta.ToString();
            }
        }
    }
}
