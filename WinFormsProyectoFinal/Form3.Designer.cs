namespace WinFormsProyectoFinal
{
    partial class Form3
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
            buttonlogout = new Button();
            SuspendLayout();
            // 
            // buttonlogout
            // 
            buttonlogout.Location = new Point(643, 389);
            buttonlogout.Name = "buttonlogout";
            buttonlogout.Size = new Size(112, 34);
            buttonlogout.TabIndex = 0;
            buttonlogout.Text = "Logout";
            buttonlogout.UseVisualStyleBackColor = true;
            buttonlogout.Click += buttonlogout_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonlogout);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonlogout;
    }
}