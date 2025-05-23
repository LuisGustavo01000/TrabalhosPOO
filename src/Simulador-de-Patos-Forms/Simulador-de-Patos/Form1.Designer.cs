namespace Simulador_de_Patos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Fly;
        private System.Windows.Forms.Button Swin;
        private System.Windows.Forms.Button Quack;
        private System.Windows.Forms.Button Breaking;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Desistir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Limpar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fly = new System.Windows.Forms.Button();
            this.Swin = new System.Windows.Forms.Button();
            this.Quack = new System.Windows.Forms.Button();
            this.Breaking = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Desistir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // comboBox1
            //
            this.comboBox1.Location = new System.Drawing.Point(30, 50);
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Text = "Selecionar um tipo de Pato:";
            //
            // Habilidade Buttons
            //
            this.Fly.Location = new System.Drawing.Point(30, 100);
            this.Fly.Size = new System.Drawing.Size(75, 23);
            this.Fly.Text = "Fly";
            this.Fly.Click += new System.EventHandler(this.Habilidade_Click);
            //
            this.Swin.Location = new System.Drawing.Point(110, 100);
            this.Swin.Size = new System.Drawing.Size(75, 23);
            this.Swin.Text = "Swin";
            this.Swin.Click += new System.EventHandler(this.Habilidade_Click);
            //
            this.Quack.Location = new System.Drawing.Point(190, 100);
            this.Quack.Size = new System.Drawing.Size(75, 23);
            this.Quack.Text = "Quack";
            this.Quack.Click += new System.EventHandler(this.Habilidade_Click);
            //
            this.Breaking.Location = new System.Drawing.Point(270, 100);
            this.Breaking.Size = new System.Drawing.Size(75, 23);
            this.Breaking.Text = "Breaking";
            this.Breaking.Click += new System.EventHandler(this.Habilidade_Click);
            //
            this.Spin.Location = new System.Drawing.Point(350, 100);
            this.Spin.Size = new System.Drawing.Size(75, 23);
            this.Spin.Text = "Spin";
            this.Spin.Click += new System.EventHandler(this.Habilidade_Click);
            //
            // textBox1 (Log)
            //
            this.textBox1.Location = new System.Drawing.Point(30, 150);
            this.textBox1.Size = new System.Drawing.Size(250, 200);
            this.textBox1.Multiline = true;
            //
            // Iniciar
            //
            this.Iniciar.Location = new System.Drawing.Point(300, 150);
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            //
            // Desistir
            //
            this.Desistir.Location = new System.Drawing.Point(300, 190);
            this.Desistir.Text = "Desistir";
            this.Desistir.Click += new System.EventHandler(this.Desistir_Click);
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(300, 130);
            this.label3.Text = "Vai querer lutar?";
            //
            // textBox2 (Resultado)
            //
            this.textBox2.Location = new System.Drawing.Point(450, 30);
            this.textBox2.Size = new System.Drawing.Size(300, 320);
            this.textBox2.Multiline = true;
            this.textBox2.Multiline = true;
            this.textBox2.ScrollBars = ScrollBars.Vertical;
            this.textBox2.WordWrap = true;
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(30, 80);
            this.label4.Text = "Habilidades:";
            //
            // Sair
            //
            this.Sair.Location = new System.Drawing.Point(700, 370);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            //
            // Limpar
            //
            this.Limpar.Location = new System.Drawing.Point(30, 370);
            this.Limpar.Text = "Limpar";
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                comboBox1, label2, Fly, Swin, Quack, Breaking, Spin,
                textBox1, Iniciar, Desistir, label3, textBox2, label4, Sair, Limpar
            });
            this.Text = "Simulador de Patos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
