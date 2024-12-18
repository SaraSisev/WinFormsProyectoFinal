namespace WinFormsProyectoFinal
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            buttonAltas = new Button();
            buttonBajas = new Button();
            buttonListado = new Button();
            buttonConsultas = new Button();
            buttonGrafica = new Button();
            button1 = new Button();
            btnMusica = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelNomSistema = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAltas
            // 
            buttonAltas.BackColor = Color.FromArgb(239, 231, 229);
            buttonAltas.FlatStyle = FlatStyle.Flat;
            buttonAltas.ForeColor = Color.FromArgb(65, 135, 100);
            buttonAltas.Location = new Point(26, 211);
            buttonAltas.Margin = new Padding(2);
            buttonAltas.Name = "buttonAltas";
            buttonAltas.Size = new Size(78, 35);
            buttonAltas.TabIndex = 0;
            buttonAltas.Text = "Agregar";
            buttonAltas.UseVisualStyleBackColor = false;
            buttonAltas.Click += buttonAltas_Click;
            // 
            // buttonBajas
            // 
            buttonBajas.BackColor = Color.FromArgb(239, 231, 229);
            buttonBajas.FlatStyle = FlatStyle.Flat;
            buttonBajas.ForeColor = Color.FromArgb(65, 135, 100);
            buttonBajas.Location = new Point(130, 211);
            buttonBajas.Margin = new Padding(2);
            buttonBajas.Name = "buttonBajas";
            buttonBajas.Size = new Size(78, 35);
            buttonBajas.TabIndex = 1;
            buttonBajas.Text = "Eliminar";
            buttonBajas.UseVisualStyleBackColor = false;
            buttonBajas.Click += buttonBajas_Click;
            // 
            // buttonListado
            // 
            buttonListado.BackColor = Color.FromArgb(239, 231, 229);
            buttonListado.FlatStyle = FlatStyle.Flat;
            buttonListado.ForeColor = Color.FromArgb(65, 135, 100);
            buttonListado.Location = new Point(234, 211);
            buttonListado.Margin = new Padding(2);
            buttonListado.Name = "buttonListado";
            buttonListado.Size = new Size(78, 35);
            buttonListado.TabIndex = 2;
            buttonListado.Text = "Listado";
            buttonListado.UseVisualStyleBackColor = false;
            buttonListado.Click += buttonListado_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.BackColor = Color.FromArgb(239, 231, 229);
            buttonConsultas.FlatStyle = FlatStyle.Flat;
            buttonConsultas.ForeColor = Color.FromArgb(65, 135, 100);
            buttonConsultas.Location = new Point(335, 211);
            buttonConsultas.Margin = new Padding(2);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(78, 35);
            buttonConsultas.TabIndex = 3;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.UseVisualStyleBackColor = false;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // buttonGrafica
            // 
            buttonGrafica.BackColor = Color.FromArgb(239, 231, 229);
            buttonGrafica.FlatStyle = FlatStyle.Flat;
            buttonGrafica.ForeColor = Color.FromArgb(65, 135, 100);
            buttonGrafica.Location = new Point(439, 211);
            buttonGrafica.Margin = new Padding(2);
            buttonGrafica.Name = "buttonGrafica";
            buttonGrafica.Size = new Size(78, 35);
            buttonGrafica.TabIndex = 4;
            buttonGrafica.Text = "Grafica";
            buttonGrafica.UseVisualStyleBackColor = false;
            buttonGrafica.Click += buttonGrafica_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(494, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 44);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMusica
            // 
            btnMusica.BackColor = Color.FromArgb(239, 231, 229);
            btnMusica.FlatStyle = FlatStyle.Flat;
            btnMusica.ForeColor = Color.Peru;
            btnMusica.Location = new Point(12, 12);
            btnMusica.Name = "btnMusica";
            btnMusica.Size = new Size(121, 23);
            btnMusica.TabIndex = 6;
            btnMusica.Text = "Pausar Música";
            btnMusica.UseVisualStyleBackColor = false;
            btnMusica.Click += btnMusica_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 16);
            label1.TabIndex = 9;
            label1.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 31);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.BackColor = Color.Transparent;
            labelNomSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomSistema.Location = new Point(191, 144);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 7;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(542, 276);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelNomSistema);
            Controls.Add(btnMusica);
            Controls.Add(button1);
            Controls.Add(buttonGrafica);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonListado);
            Controls.Add(buttonBajas);
            Controls.Add(buttonAltas);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAltas;
        private Button buttonBajas;
        private Button buttonListado;
        private Button buttonConsultas;
        private Button buttonGrafica;
        private Button button1;
        private Button btnMusica;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelNomSistema;
    }
}