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
            labelMateria.Location = new Point(379, 40);
            labelMateria.Margin = new Padding(2, 0, 2, 0);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(91, 15);
            labelMateria.TabIndex = 1;
            labelMateria.Text = "Programacion II";
            // 
            // labelProfesor
            // 
            labelProfesor.AutoSize = true;
            labelProfesor.Location = new Point(192, 163);
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
            labelSistema.Size = new Size(48, 15);
            labelSistema.TabIndex = 3;
            labelSistema.Text = "Sistema";
            // 
            // button1
            // 
            button1.Location = new Point(448, 230);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
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
