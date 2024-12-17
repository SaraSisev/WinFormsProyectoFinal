namespace WinFormsProyectoFinal
{
    partial class FormGrafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafica));
            buttonLogoutG = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            btnRegresar = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            labelNomSistema = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutG
            // 
            buttonLogoutG.BackColor = Color.Transparent;
            buttonLogoutG.FlatAppearance.BorderSize = 0;
            buttonLogoutG.FlatStyle = FlatStyle.Flat;
            buttonLogoutG.Image = (Image)resources.GetObject("buttonLogoutG.Image");
            buttonLogoutG.Location = new Point(625, 15);
            buttonLogoutG.Margin = new Padding(2);
            buttonLogoutG.Name = "buttonLogoutG";
            buttonLogoutG.Size = new Size(36, 44);
            buttonLogoutG.TabIndex = 0;
            buttonLogoutG.UseVisualStyleBackColor = false;
            buttonLogoutG.Click += buttonLogoutG_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.Transparent;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(21, 114);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(640, 291);
            formsPlot1.TabIndex = 1;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 9);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 2;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 94);
            label1.Name = "label1";
            label1.Size = new Size(221, 17);
            label1.TabIndex = 3;
            label1.Text = "Ventas Anuales por Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(306, 40);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 16);
            label7.TabIndex = 25;
            label7.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, -4);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.BackColor = Color.Transparent;
            labelNomSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomSistema.Location = new Point(306, 15);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 23;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 434);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(labelNomSistema);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(formsPlot1);
            Controls.Add(buttonLogoutG);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormGrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGrafica";
            Load += FormGrafica_Load;
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutG;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private PictureBox btnRegresar;
        private Label label1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelNomSistema;
    }
}