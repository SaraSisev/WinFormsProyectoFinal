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
            textBoxAlID = new TextBox();
            textBoxAlPre = new TextBox();
            textBoxAlExi = new TextBox();
            richTextBoxAlDes = new RichTextBox();
            buttonAgregar = new Button();
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
            // textBoxAlID
            // 
            textBoxAlID.Location = new Point(68, 78);
            textBoxAlID.Name = "textBoxAlID";
            textBoxAlID.PlaceholderText = "ID";
            textBoxAlID.Size = new Size(146, 31);
            textBoxAlID.TabIndex = 1;
            // 
            // textBoxAlPre
            // 
            textBoxAlPre.Location = new Point(68, 284);
            textBoxAlPre.Name = "textBoxAlPre";
            textBoxAlPre.PlaceholderText = "Precio";
            textBoxAlPre.Size = new Size(146, 31);
            textBoxAlPre.TabIndex = 3;
            textBoxAlPre.TextChanged += textBox3_TextChanged;
            // 
            // textBoxAlExi
            // 
            textBoxAlExi.Location = new Point(68, 340);
            textBoxAlExi.Name = "textBoxAlExi";
            textBoxAlExi.PlaceholderText = "Existencia";
            textBoxAlExi.Size = new Size(146, 31);
            textBoxAlExi.TabIndex = 4;
            // 
            // richTextBoxAlDes
            // 
            richTextBoxAlDes.Location = new Point(68, 115);
            richTextBoxAlDes.Name = "richTextBoxAlDes";
            richTextBoxAlDes.Size = new Size(150, 144);
            richTextBoxAlDes.TabIndex = 5;
            richTextBoxAlDes.Text = "";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(79, 395);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // FormAltas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregar);
            Controls.Add(richTextBoxAlDes);
            Controls.Add(textBoxAlExi);
            Controls.Add(textBoxAlPre);
            Controls.Add(textBoxAlID);
            Controls.Add(buttonLogoutA);
            Name = "FormAltas";
            Text = "FormAltas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutA;
        private TextBox textBoxAlID;
        private TextBox textBoxAlPre;
        private TextBox textBoxAlExi;
        private RichTextBox richTextBoxAlDes;
        private Button buttonAgregar;
    }
}