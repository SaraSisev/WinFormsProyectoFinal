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
            pictureBoxUAA.Image = Properties.Resources.uaa;
            pictureBoxUAA.Location = new Point(23, 23);
            pictureBoxUAA.Margin = new Padding(2);
            pictureBoxUAA.Name = "pictureBoxUAA";
            pictureBoxUAA.Size = new Size(105, 45);
            pictureBoxUAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUAA.TabIndex = 0;
            pictureBoxUAA.TabStop = false;
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(154, 9);
            labelMateria.Margin = new Padding(2, 0, 2, 0);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(226, 30);
            labelMateria.TabIndex = 1;
            labelMateria.Text = "Programacion II\r\nProgramacion Orientada a Objetos (POO)\r\n";
            labelMateria.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelProfesor
            // 
            labelProfesor.AutoSize = true;
            labelProfesor.Location = new Point(206, 53);
            labelProfesor.Margin = new Padding(2, 0, 2, 0);
            labelProfesor.Name = "labelProfesor";
            labelProfesor.Size = new Size(137, 15);
            labelProfesor.TabIndex = 2;
            labelProfesor.Text = "Georgina Salazar Partida ";
            // 
            // labelSistema
            // 
            labelSistema.AutoSize = true;
            labelSistema.Location = new Point(229, 116);
            labelSistema.Margin = new Padding(2, 0, 2, 0);
            labelSistema.Name = "labelSistema";
            labelSistema.Size = new Size(82, 15);
            labelSistema.TabIndex = 3;
            labelSistema.Text = "Tricotera Shop";
            // 
            // button1
            // 
            button1.Location = new Point(229, 133);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 186);
            label1.Name = "label1";
            label1.Size = new Size(183, 75);
            label1.TabIndex = 5;
            label1.Text = "Integrantes:\r\nSara Alexandra Chamorro Cuevas\r\nMaría Fernanda Resendíz Mejía\r\nMiguel de Jesus Zavala Romo\r\nEliseo Villalobos Reveles";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(342, 246);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopRight;
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
            ClientSize = new Size(560, 270);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(labelSistema);
            Controls.Add(labelProfesor);
            Controls.Add(labelMateria);
            Controls.Add(pictureBoxUAA);
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
