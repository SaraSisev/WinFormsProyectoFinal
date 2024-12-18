namespace WinFormsProyectoFinal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxUAA = new PictureBox();
            labelMateria = new Label();
            labelProfesor = new Label();
            labelSistema = new Label();
            button1 = new Button();
            label1 = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUAA
            // 
            pictureBoxUAA.BackColor = Color.Transparent;
            pictureBoxUAA.Image = (Image)resources.GetObject("pictureBoxUAA.Image");
            pictureBoxUAA.Location = new Point(491, 226);
            pictureBoxUAA.Margin = new Padding(2);
            pictureBoxUAA.Name = "pictureBoxUAA";
            pictureBoxUAA.Size = new Size(160, 81);
            pictureBoxUAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUAA.TabIndex = 0;
            pictureBoxUAA.TabStop = false;
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.BackColor = Color.Transparent;
            labelMateria.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMateria.Location = new Point(169, 88);
            labelMateria.Margin = new Padding(2, 0, 2, 0);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(350, 36);
            labelMateria.TabIndex = 1;
            labelMateria.Text = "Programacion II\r\nProgramacion Orientada a Objetos (POO)\r\n";
            labelMateria.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelProfesor
            // 
            labelProfesor.AutoSize = true;
            labelProfesor.BackColor = Color.Transparent;
            labelProfesor.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelProfesor.Location = new Point(226, 126);
            labelProfesor.Margin = new Padding(2, 0, 2, 0);
            labelProfesor.Name = "labelProfesor";
            labelProfesor.Size = new Size(230, 14);
            labelProfesor.TabIndex = 2;
            labelProfesor.Text = "Maestra Georgina Salazar Partida";
            labelProfesor.TextAlign = ContentAlignment.TopCenter;
            labelProfesor.Click += labelProfesor_Click;
            // 
            // labelSistema
            // 
            labelSistema.AutoSize = true;
            labelSistema.BackColor = Color.Transparent;
            labelSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSistema.ForeColor = Color.DarkRed;
            labelSistema.Location = new Point(256, 161);
            labelSistema.Margin = new Padding(2, 0, 2, 0);
            labelSistema.Name = "labelSistema";
            labelSistema.Size = new Size(183, 25);
            labelSistema.TabIndex = 3;
            labelSistema.Text = "Tricotera Shop";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 231, 231);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(45, 31, 4);
            button1.Location = new Point(306, 188);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 24, 24);
            label1.Location = new Point(12, 244);
            label1.Name = "label1";
            label1.Size = new Size(174, 80);
            label1.TabIndex = 5;
            label1.Text = "Integrantes:\r\nSara Alexandra Chamorro Cuevas\r\nMaría Fernanda Resendíz Mejía\r\nMiguel de Jesus Zavala Romo\r\nEliseo Villalobos Reveles";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.FromArgb(18, 18, 18);
            lblFecha.Location = new Point(415, 309);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.No;
            lblFecha.Size = new Size(235, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            lblFecha.Click += lblFecha_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 335);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(labelSistema);
            Controls.Add(labelProfesor);
            Controls.Add(labelMateria);
            Controls.Add(pictureBoxUAA);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxUAA;
        private Label labelMateria;
        private Label labelProfesor;
        private Label labelSistema;
        private Button button1;
        private Label label1;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}
