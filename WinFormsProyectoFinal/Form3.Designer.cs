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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 179);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 164);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 287);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonlogout);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogout;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}