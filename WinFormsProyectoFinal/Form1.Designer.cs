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
            pictureBoxUAA = new PictureBox();
            labelMateria = new Label();
            labelProfesor = new Label();
            labelSistema = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUAA
            // 
            pictureBoxUAA.Image = Properties.Resources.uaa;
            pictureBoxUAA.Location = new Point(33, 38);
            pictureBoxUAA.Name = "pictureBoxUAA";
            pictureBoxUAA.Size = new Size(150, 75);
            pictureBoxUAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUAA.TabIndex = 0;
            pictureBoxUAA.TabStop = false;
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(542, 66);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(138, 25);
            labelMateria.TabIndex = 1;
            labelMateria.Text = "Programacion II";
            // 
            // labelProfesor
            // 
            labelProfesor.AutoSize = true;
            labelProfesor.Location = new Point(275, 271);
            labelProfesor.Name = "labelProfesor";
            labelProfesor.Size = new Size(208, 25);
            labelProfesor.TabIndex = 2;
            labelProfesor.Text = "Georgina Salazar Partida ";
            // 
            // labelSistema
            // 
            labelSistema.AutoSize = true;
            labelSistema.Location = new Point(327, 193);
            labelSistema.Name = "labelSistema";
            labelSistema.Size = new Size(74, 25);
            labelSistema.TabIndex = 3;
            labelSistema.Text = "Sistema";
            // 
            // button1
            // 
            button1.Location = new Point(640, 384);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelSistema);
            Controls.Add(labelProfesor);
            Controls.Add(labelMateria);
            Controls.Add(pictureBoxUAA);
            Name = "Form1";
            Text = "Form1";
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
    }
}
