namespace Simulador_de_Patos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            Fly = new Button();
            Quack = new Button();
            Swin = new Button();
            Breaking = new Button();
            Spin = new Button();
            textBox1 = new TextBox();
            Iniciar = new Button();
            button8 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Jogador 1";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 38);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 3;
            label2.Text = "Selecionar um tipo de Pato : ";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(904, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Fly
            // 
            Fly.Location = new Point(33, 132);
            Fly.Name = "Fly";
            Fly.Size = new Size(75, 23);
            Fly.TabIndex = 12;
            Fly.Text = "Fly";
            Fly.UseVisualStyleBackColor = true;
            Fly.Click += button1_Click;
            // 
            // Quack
            // 
            Quack.Location = new Point(114, 132);
            Quack.Name = "Quack";
            Quack.Size = new Size(75, 23);
            Quack.TabIndex = 13;
            Quack.Text = "Quack";
            Quack.UseVisualStyleBackColor = true;
            // 
            // Swin
            // 
            Swin.Location = new Point(195, 132);
            Swin.Name = "Swin";
            Swin.Size = new Size(75, 23);
            Swin.TabIndex = 14;
            Swin.Text = "Swin";
            Swin.UseVisualStyleBackColor = true;
            // 
            // Breaking
            // 
            Breaking.Location = new Point(276, 132);
            Breaking.Name = "Breaking";
            Breaking.Size = new Size(75, 23);
            Breaking.TabIndex = 15;
            Breaking.Text = "Breaking";
            Breaking.UseVisualStyleBackColor = true;
            // 
            // Spin
            // 
            Spin.Location = new Point(357, 132);
            Spin.Name = "Spin";
            Spin.Size = new Size(75, 23);
            Spin.TabIndex = 16;
            Spin.Text = "Spin";
            Spin.UseVisualStyleBackColor = true;
            Spin.Click += Spin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 186);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 218);
            textBox1.TabIndex = 17;
            // 
            // Iniciar
            // 
            Iniciar.Location = new Point(281, 240);
            Iniciar.Name = "Iniciar";
            Iniciar.Size = new Size(75, 23);
            Iniciar.TabIndex = 18;
            Iniciar.Text = "Iniciar";
            Iniciar.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(281, 292);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 19;
            button8.Text = "Desistir ";
            button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 208);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 20;
            label3.Text = "Vai querer lutar?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(398, 186);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(468, 229);
            textBox2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 104);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 22;
            label4.Text = "Habilidades :";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(Iniciar);
            Controls.Add(textBox1);
            Controls.Add(Spin);
            Controls.Add(Breaking);
            Controls.Add(Swin);
            Controls.Add(Quack);
            Controls.Add(Fly);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Simulador de Patos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button Fly;
        private Button Quack;
        private Button Swin;
        private Button Breaking;
        private Button Spin;
        private TextBox textBox1;
        private Button Iniciar;
        private Button button8;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}
