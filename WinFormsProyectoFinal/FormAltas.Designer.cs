namespace WinFormsProyectoFinal
{
    partial class FormAltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltas));
            buttonLogoutA = new Button();
            textBoxAlPre = new TextBox();
            richTextBoxAlDes = new RichTextBox();
            buttonAgregar = new Button();
            btnRegresar = new PictureBox();
            pictureBox2 = new PictureBox();
            btnImagen = new Button();
            numId = new NumericUpDown();
            numExistencias = new NumericUpDown();
            numVentas = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutA
            // 
            buttonLogoutA.Location = new Point(471, 11);
            buttonLogoutA.Margin = new Padding(2);
            buttonLogoutA.Name = "buttonLogoutA";
            buttonLogoutA.Size = new Size(78, 20);
            buttonLogoutA.TabIndex = 0;
            buttonLogoutA.Text = "LogOut";
            buttonLogoutA.UseVisualStyleBackColor = true;
            buttonLogoutA.Click += buttonLogoutA_Click;
            // 
            // textBoxAlPre
            // 
            textBoxAlPre.Location = new Point(48, 170);
            textBoxAlPre.Margin = new Padding(2);
            textBoxAlPre.Name = "textBoxAlPre";
            textBoxAlPre.PlaceholderText = "Precio";
            textBoxAlPre.Size = new Size(103, 23);
            textBoxAlPre.TabIndex = 3;
            textBoxAlPre.TextChanged += textBox3_TextChanged;
            // 
            // richTextBoxAlDes
            // 
            richTextBoxAlDes.Location = new Point(48, 69);
            richTextBoxAlDes.Margin = new Padding(2);
            richTextBoxAlDes.Name = "richTextBoxAlDes";
            richTextBoxAlDes.Size = new Size(106, 88);
            richTextBoxAlDes.TabIndex = 5;
            richTextBoxAlDes.Text = "";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(11, 327);
            buttonAgregar.Margin = new Padding(2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(78, 20);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(503, 305);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(45, 42);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 7;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(261, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(295, 199);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(104, 23);
            btnImagen.TabIndex = 9;
            btnImagen.Text = "Agregar Imagen";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += button1_Click;
            // 
            // numId
            // 
            numId.Location = new Point(48, 41);
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 10;
            // 
            // numExistencias
            // 
            numExistencias.Location = new Point(48, 231);
            numExistencias.Name = "numExistencias";
            numExistencias.Size = new Size(120, 23);
            numExistencias.TabIndex = 11;
            // 
            // numVentas
            // 
            numVentas.Location = new Point(48, 285);
            numVentas.Name = "numVentas";
            numVentas.Size = new Size(120, 23);
            numVentas.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 213);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 13;
            label1.Text = "Existencias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 267);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "Ventas";
            // 
            // FormAltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 358);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numVentas);
            Controls.Add(numExistencias);
            Controls.Add(numId);
            Controls.Add(btnImagen);
            Controls.Add(pictureBox2);
            Controls.Add(btnRegresar);
            Controls.Add(buttonAgregar);
            Controls.Add(richTextBoxAlDes);
            Controls.Add(textBoxAlPre);
            Controls.Add(buttonLogoutA);
            Margin = new Padding(2);
            Name = "FormAltas";
            Text = "FormAltas";
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutA;
        private TextBox textBoxAlPre;
        private RichTextBox richTextBoxAlDes;
        private Button buttonAgregar;
        private PictureBox btnRegresar;
        private PictureBox pictureBox2;
        private Button btnImagen;
        private NumericUpDown numId;
        private NumericUpDown numExistencias;
        private NumericUpDown numVentas;
        private Label label1;
        private Label label2;
    }
}