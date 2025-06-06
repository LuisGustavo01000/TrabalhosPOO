using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPato.Models;
using Simulador_de_Patos.Models;
using Simulador_de_Patos.Services;

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
        private GerenciadorDePatos gerenciadorDePatos;
        private Battle battle = new Battle();



        public Form1()
        {
            InitializeComponent();

            var patos = new List<Duck>
            {
                DuckFactory.CriarPato("Pato Selvagem", 1),
                DuckFactory.CriarPato("Pato Mudo", 2),
                DuckFactory.CriarPato("Pato Vermelho", 3),
                DuckFactory.CriarPato("Pato de Borracha", 4),
                DuckFactory.CriarPato("Pato Foguete", 5),
                DuckFactory.CriarPato("Super Pato", 6),
                DuckFactory.CriarPato("Pato Filhote", 7),
                DuckFactory.CriarPato("Pato Tonto", 8),
                DuckFactory.CriarPato("Pato de Madeira", 9)
            };
            gerenciadorDePatos = new GerenciadorDePatos(patos);

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
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um pato.");
                return;
            }

            int idJogador = comboBox1.SelectedIndex + 1;
            patoJogador = gerenciadorDePatos.ObterPatoPorId(idJogador);

            if (patoJogador == null)
            {
                MessageBox.Show("Tipo de pato inválido.");
                return;
            }

            patoInimigo = gerenciadorDePatos.ObterPatoAleatorio(idJogador);
            tipoJogador = patoJogador.Tipo;
            tipoInimigo = patoInimigo?.Tipo ?? "Desconhecido";

            // Preenche as habilidades do inimigo
            List<Button> botoesHabilidadesInimigo = GetHabilidadesPorPato(tipoInimigo);
            List<string> habilidadesInimigo = botoesHabilidadesInimigo.Select(btn => btn.Text).ToList();
            patoInimigo.HabilidadesList.Clear();
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

        private string ExecutarHabilidade(Duck pato, string habilidade)
        {
            return habilidade switch
            {
                "Fly" => pato is Simulador_de_Patos.Interfaces.IFlyable f ? f.fly() : "Habilidade não disponível.",
                "Swin" => pato is Simulador_de_Patos.Interfaces.ISwimable s ? s.swim() : "Habilidade não disponível.",
                "Quack" => pato is Simulador_de_Patos.Interfaces.IQuackable q ? q.quack() : "Habilidade não disponível.",
                "Spin" => pato is Simulador_de_Patos.Interfaces.IDizzy d ? d.spin() : "Habilidade não disponível.",
                "Breaking" => pato is Simulador_de_Patos.Interfaces.IBroken b ? b.breaking() : "Habilidade não disponível.",
                _ => "Habilidade não implementada."
            };
        }

        private void Habilidade_Click(object sender, EventArgs e)
        {
            if (sender is not Button botao) return;

            string habJogador = botao.Text;

            // Garante que o pato do jogador está selecionado
            if (patoJogador == null)
            {
                int idJogador = comboBox1.SelectedIndex + 1;
                patoJogador = gerenciadorDePatos.ObterPatoPorId(idJogador);
                if (patoJogador == null)
                {
                    textBox1.AppendText("Selecione um pato válido.\r\n");
                    return;
                }
            }

            // Só permite habilidades válidas para o pato
            if (!GetHabilidadesPorPato(patoJogador.Tipo).Any(b => b.Text == habJogador))
            {
                textBox1.AppendText("Habilidade inválida para este pato.\r\n");
                return;
            }

            // Executa a habilidade e exibe a descrição
            string descricao = ExecutarHabilidade(patoJogador, habJogador);
            textBox1.AppendText(descricao + "\r\n");

            if (!batalhaEmAndamento) return;
            if (rodadaAtual >= maxRodadas)
            {
                textBox1.AppendText("A batalha já terminou.\r\n");
                return;
            }

            // Adiciona a habilidade à lista do pato, se ainda não estiver
            if (!patoJogador.HabilidadesList.Contains(habJogador))
                patoJogador.HabilidadesList.Add(habJogador);

            // Habilidade do inimigo e resultado da rodada
            string habInimigo = battle.ObterHabilidadeAleatoria(patoInimigo);
            string resultadoRodada = battle.CompararHabilidades(patoJogador, patoInimigo, habJogador, habInimigo);



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
    }
}
