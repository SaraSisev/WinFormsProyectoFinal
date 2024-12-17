namespace WinFormsProyectoFinal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelNomSistema = new Label();
            textBoxCuenta = new TextBox();
            textBoxConstrasena = new TextBox();
            buttonIngresar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonSalir = new Button();
            btnMusica = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.BackColor = Color.Transparent;
            labelNomSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomSistema.Location = new Point(213, 85);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 0;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.BackColor = Color.FromArgb(239, 231, 229);
            textBoxCuenta.BorderStyle = BorderStyle.FixedSingle;
            textBoxCuenta.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxCuenta.Location = new Point(247, 144);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(121, 23);
            textBoxCuenta.TabIndex = 1;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxConstrasena
            // 
            textBoxConstrasena.BackColor = Color.FromArgb(239, 231, 229);
            textBoxConstrasena.BorderStyle = BorderStyle.FixedSingle;
            textBoxConstrasena.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxConstrasena.Location = new Point(247, 176);
            textBoxConstrasena.Name = "textBoxConstrasena";
            textBoxConstrasena.PlaceholderText = "Contraseña";
            textBoxConstrasena.Size = new Size(121, 23);
            textBoxConstrasena.TabIndex = 2;
            textBoxConstrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.FromArgb(239, 231, 229);
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.ForeColor = Color.DarkCyan;
            buttonIngresar.Location = new Point(452, 248);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(112, 34);
            buttonIngresar.TabIndex = 3;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, -13);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 16);
            label1.TabIndex = 5;
            label1.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.FromArgb(239, 231, 229);
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.ForeColor = Color.Maroon;
            buttonSalir.Location = new Point(12, 247);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(112, 34);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // btnMusica
            // 
            btnMusica.FlatStyle = FlatStyle.Flat;
            btnMusica.ForeColor = Color.Peru;
            btnMusica.Location = new Point(455, 12);
            btnMusica.Name = "btnMusica";
            btnMusica.Size = new Size(114, 28);
            btnMusica.TabIndex = 7;
            btnMusica.Text = "Pausar Música";
            btnMusica.UseVisualStyleBackColor = false;
            btnMusica.Click += btnMusica_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 231, 229);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 293);
            Controls.Add(btnMusica);
            Controls.Add(buttonSalir);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxConstrasena);
            Controls.Add(textBoxCuenta);
            Controls.Add(labelNomSistema);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomSistema;
        private TextBox textBoxCuenta;
        private TextBox textBoxConstrasena;
        private Button buttonIngresar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonSalir;
        private Button btnMusica;
    }
}