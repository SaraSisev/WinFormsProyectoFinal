namespace WinFormsProyectoFinal
{
    partial class FormConsultas
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
            buttonLogoutC = new Button();
            labelVentasTotales = new Label();
            SuspendLayout();
            // 
            // buttonLogoutC
            // 
            buttonLogoutC.Location = new Point(471, 11);
            buttonLogoutC.Margin = new Padding(2, 2, 2, 2);
            buttonLogoutC.Name = "buttonLogoutC";
            buttonLogoutC.Size = new Size(78, 20);
            buttonLogoutC.TabIndex = 0;
            buttonLogoutC.Text = "LogOut";
            buttonLogoutC.UseVisualStyleBackColor = true;
            buttonLogoutC.Click += buttonLogoutC_Click;
            // 
            // labelVentasTotales
            // 
            labelVentasTotales.AutoSize = true;
            labelVentasTotales.Location = new Point(70, 73);
            labelVentasTotales.Margin = new Padding(2, 0, 2, 0);
            labelVentasTotales.Name = "labelVentasTotales";
            labelVentasTotales.Size = new Size(38, 15);
            labelVentasTotales.TabIndex = 1;
            labelVentasTotales.Text = "label1";
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(labelVentasTotales);
            Controls.Add(buttonLogoutC);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormConsultas";
            Text = "FormConsultas";
            Load += FormConsultas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutC;
        private Label labelVentasTotales;
    }
}