namespace WinFormsProyectoFinal
{
    partial class FormBajas
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
            buttonLogoutB = new Button();
            SuspendLayout();
            // 
            // buttonLogoutB
            // 
            buttonLogoutB.Location = new Point(676, 404);
            buttonLogoutB.Name = "buttonLogoutB";
            buttonLogoutB.Size = new Size(112, 34);
            buttonLogoutB.TabIndex = 0;
            buttonLogoutB.Text = "LogOut";
            buttonLogoutB.UseVisualStyleBackColor = true;
            buttonLogoutB.Click += buttonLogoutB_Click;
            // 
            // FormBajas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogoutB);
            Name = "FormBajas";
            Text = "FormBajas";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogoutB;
    }
}