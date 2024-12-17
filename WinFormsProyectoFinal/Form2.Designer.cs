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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.Location = new Point(309, 68);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(125, 25);
            labelNomSistema.TabIndex = 0;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(294, 223);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(106, 23);
            textBoxCuenta.TabIndex = 1;
            // 
            // textBoxConstrasena
            // 
            textBoxConstrasena.Location = new Point(294, 292);
            textBoxConstrasena.Name = "textBoxConstrasena";
            textBoxConstrasena.PlaceholderText = "Contrasena";
            textBoxConstrasena.Size = new Size(106, 23);
            textBoxConstrasena.TabIndex = 2;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(574, 388);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(111, 33);
            buttonIngresar.TabIndex = 3;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 5;
            label1.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(48, 388);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(112, 34);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxConstrasena);
            Controls.Add(textBoxCuenta);
            Controls.Add(labelNomSistema);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
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
    }
}