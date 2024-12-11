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
            buttonLogoutG = new Button();
            SuspendLayout();
            // 
            // buttonLogoutG
            // 
            buttonLogoutG.Location = new Point(650, 388);
            buttonLogoutG.Name = "buttonLogoutG";
            buttonLogoutG.Size = new Size(112, 34);
            buttonLogoutG.TabIndex = 0;
            buttonLogoutG.Text = "LogOut";
            buttonLogoutG.UseVisualStyleBackColor = true;
            buttonLogoutG.Click += buttonLogoutG_Click;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogoutG);
            Name = "FormGrafica";
            Text = "FormGrafica";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogoutG;
    }
}