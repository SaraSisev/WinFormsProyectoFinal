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
            textBoxNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            labelNomSistema = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutA
            // 
            buttonLogoutA.BackColor = Color.Transparent;
            buttonLogoutA.FlatAppearance.BorderSize = 0;
            buttonLogoutA.FlatStyle = FlatStyle.Flat;
            buttonLogoutA.ForeColor = Color.Transparent;
            buttonLogoutA.Image = (Image)resources.GetObject("buttonLogoutA.Image");
            buttonLogoutA.Location = new Point(513, 11);
            buttonLogoutA.Margin = new Padding(2);
            buttonLogoutA.Name = "buttonLogoutA";
            buttonLogoutA.Size = new Size(36, 44);
            buttonLogoutA.TabIndex = 0;
            buttonLogoutA.UseVisualStyleBackColor = false;
            buttonLogoutA.Click += buttonLogoutA_Click;
            // 
            // textBoxAlPre
            // 
            textBoxAlPre.BackColor = Color.FromArgb(239, 231, 229);
            textBoxAlPre.Location = new Point(143, 245);
            textBoxAlPre.Margin = new Padding(2);
            textBoxAlPre.Name = "textBoxAlPre";
            textBoxAlPre.PlaceholderText = "Precio";
            textBoxAlPre.Size = new Size(103, 23);
            textBoxAlPre.TabIndex = 3;
            textBoxAlPre.TextChanged += textBox3_TextChanged;
            // 
            // richTextBoxAlDes
            // 
            richTextBoxAlDes.BackColor = Color.FromArgb(239, 231, 229);
            richTextBoxAlDes.BorderStyle = BorderStyle.None;
            richTextBoxAlDes.Location = new Point(49, 407);
            richTextBoxAlDes.Margin = new Padding(2);
            richTextBoxAlDes.Name = "richTextBoxAlDes";
            richTextBoxAlDes.Size = new Size(273, 88);
            richTextBoxAlDes.TabIndex = 5;
            richTextBoxAlDes.Text = "";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(218, 235, 233);
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = Color.FromArgb(40, 87, 72);
            buttonAgregar.Location = new Point(358, 407);
            buttonAgregar.Margin = new Padding(2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(125, 88);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(35, 35);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 7;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(343, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = Color.FromArgb(247, 226, 200);
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.ForeColor = Color.FromArgb(146, 94, 22);
            btnImagen.Location = new Point(358, 305);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(104, 27);
            btnImagen.TabIndex = 9;
            btnImagen.Text = "Agregar Imagen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += button1_Click;
            // 
            // numId
            // 
            numId.BackColor = Color.FromArgb(239, 231, 229);
            numId.BorderStyle = BorderStyle.None;
            numId.Location = new Point(161, 141);
            numId.Name = "numId";
            numId.Size = new Size(64, 19);
            numId.TabIndex = 10;
            // 
            // numExistencias
            // 
            numExistencias.BackColor = Color.FromArgb(239, 231, 229);
            numExistencias.BorderStyle = BorderStyle.None;
            numExistencias.Location = new Point(153, 303);
            numExistencias.Name = "numExistencias";
            numExistencias.Size = new Size(67, 19);
            numExistencias.TabIndex = 11;
            // 
            // numVentas
            // 
            numVentas.BackColor = Color.FromArgb(239, 231, 229);
            numVentas.BorderStyle = BorderStyle.None;
            numVentas.Location = new Point(148, 357);
            numVentas.Name = "numVentas";
            numVentas.Size = new Size(67, 19);
            numVentas.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 285);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 13;
            label1.Text = "Existencias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 339);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "Ventas";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.FromArgb(239, 231, 229);
            textBoxNombre.Location = new Point(145, 192);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(185, 123);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 16;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(165, 174);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(151, 390);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 18;
            label5.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(166, 228);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 19;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(239, 49);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 16);
            label7.TabIndex = 22;
            label7.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.BackColor = Color.Transparent;
            labelNomSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomSistema.Location = new Point(239, 24);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 20;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // FormAltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 515);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(labelNomSistema);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
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
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormAltas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAltas";
            Load += FormAltas_Load;
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBoxNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelNomSistema;
    }
}