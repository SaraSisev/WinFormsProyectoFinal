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
            buttonLogoutA = new Button();
            SuspendLayout();
            // 
            // buttonLogoutA
            // 
            buttonLogoutA.Location = new Point(628, 374);
            buttonLogoutA.Name = "buttonLogoutA";
            buttonLogoutA.Size = new Size(112, 34);
            buttonLogoutA.TabIndex = 0;
            buttonLogoutA.Text = "LogOut";
            buttonLogoutA.UseVisualStyleBackColor = true;
            buttonLogoutA.Click += buttonLogoutA_Click;
            // 
            // FormAltas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogoutA);
            Name = "FormAltas";
            Text = "FormAltas";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogoutA;
    }
}