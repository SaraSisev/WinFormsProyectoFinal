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
            labelNombreUsuario = new Label();
            dataGridViewProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
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
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Location = new Point(685, 24);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(59, 25);
            labelNombreUsuario.TabIndex = 1;
            labelNombreUsuario.Text = "label1";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(257, 109);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(360, 225);
            dataGridViewProductos.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProductos);
            Controls.Add(labelNombreUsuario);
            Controls.Add(buttonlogout);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogout;
        private Label labelNombreUsuario;
        private DataGridView dataGridViewProductos;
    }
}