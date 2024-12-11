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
            labelNomSistema = new Label();
            textBoxCuenta = new TextBox();
            textBoxConstrasena = new TextBox();
            buttonIngresar = new Button();
            SuspendLayout();
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.Location = new Point(308, 69);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(74, 25);
            labelNomSistema.TabIndex = 0;
            labelNomSistema.Text = "Sistema";
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(295, 224);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(150, 31);
            textBoxCuenta.TabIndex = 1;
            // 
            // textBoxConstrasena
            // 
            textBoxConstrasena.Location = new Point(295, 291);
            textBoxConstrasena.Name = "textBoxConstrasena";
            textBoxConstrasena.PlaceholderText = "Contrasena";
            textBoxConstrasena.Size = new Size(150, 31);
            textBoxConstrasena.TabIndex = 2;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(575, 388);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(112, 34);
            buttonIngresar.TabIndex = 3;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxConstrasena);
            Controls.Add(textBoxCuenta);
            Controls.Add(labelNomSistema);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomSistema;
        private TextBox textBoxCuenta;
        private TextBox textBoxConstrasena;
        private Button buttonIngresar;
    }
}