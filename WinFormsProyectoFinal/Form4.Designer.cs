namespace WinFormsProyectoFinal
{
    partial class Form4
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
            buttonAltas = new Button();
            buttonBajas = new Button();
            buttonListado = new Button();
            buttonConsultas = new Button();
            buttonGrafica = new Button();
            SuspendLayout();
            // 
            // buttonAltas
            // 
            buttonAltas.Location = new Point(37, 377);
            buttonAltas.Name = "buttonAltas";
            buttonAltas.Size = new Size(112, 34);
            buttonAltas.TabIndex = 0;
            buttonAltas.Text = "Agregar";
            buttonAltas.UseVisualStyleBackColor = true;
            buttonAltas.Click += buttonAltas_Click;
            // 
            // buttonBajas
            // 
            buttonBajas.Location = new Point(185, 377);
            buttonBajas.Name = "buttonBajas";
            buttonBajas.Size = new Size(112, 34);
            buttonBajas.TabIndex = 1;
            buttonBajas.Text = "Eliminar";
            buttonBajas.UseVisualStyleBackColor = true;
            buttonBajas.Click += buttonBajas_Click;
            // 
            // buttonListado
            // 
            buttonListado.Location = new Point(334, 377);
            buttonListado.Name = "buttonListado";
            buttonListado.Size = new Size(112, 34);
            buttonListado.TabIndex = 2;
            buttonListado.Text = "Listado";
            buttonListado.UseVisualStyleBackColor = true;
            buttonListado.Click += buttonListado_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.Location = new Point(479, 377);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(112, 34);
            buttonConsultas.TabIndex = 3;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.UseVisualStyleBackColor = true;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // buttonGrafica
            // 
            buttonGrafica.Location = new Point(633, 377);
            buttonGrafica.Name = "buttonGrafica";
            buttonGrafica.Size = new Size(112, 34);
            buttonGrafica.TabIndex = 4;
            buttonGrafica.Text = "Grafica";
            buttonGrafica.UseVisualStyleBackColor = true;
            buttonGrafica.Click += buttonGrafica_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGrafica);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonListado);
            Controls.Add(buttonBajas);
            Controls.Add(buttonAltas);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAltas;
        private Button buttonBajas;
        private Button buttonListado;
        private Button buttonConsultas;
        private Button buttonGrafica;
    }
}