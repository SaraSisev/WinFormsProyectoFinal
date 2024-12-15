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
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutG
            // 
            buttonLogoutG.Location = new Point(471, 11);
            buttonLogoutG.Margin = new Padding(2);
            buttonLogoutG.Name = "buttonLogoutG";
            buttonLogoutG.Size = new Size(78, 20);
            buttonLogoutG.TabIndex = 0;
            buttonLogoutG.Text = "LogOut";
            buttonLogoutG.UseVisualStyleBackColor = true;
            buttonLogoutG.Click += buttonLogoutG_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(31, 56);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(426, 247);
            formsPlot1.TabIndex = 1;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(505, 263);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(44, 40);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 2;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 3;
            label1.Text = "Ventas Anuales por Producto";
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 333);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(formsPlot1);
            Controls.Add(buttonLogoutG);
            Margin = new Padding(2);
            Name = "FormGrafica";
            Text = "FormGrafica";
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutG;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private PictureBox btnRegresar;
        private Label label1;
    }
}