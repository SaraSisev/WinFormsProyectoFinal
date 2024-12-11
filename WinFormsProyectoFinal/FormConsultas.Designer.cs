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
            SuspendLayout();
            // 
            // buttonLogoutC
            // 
            buttonLogoutC.Location = new Point(664, 404);
            buttonLogoutC.Name = "buttonLogoutC";
            buttonLogoutC.Size = new Size(112, 34);
            buttonLogoutC.TabIndex = 0;
            buttonLogoutC.Text = "LogOut";
            buttonLogoutC.UseVisualStyleBackColor = true;
            buttonLogoutC.Click += buttonLogoutC_Click;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogoutC);
            Name = "FormConsultas";
            Text = "FormConsultas";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogoutC;
    }
}