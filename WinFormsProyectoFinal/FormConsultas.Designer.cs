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
            dataGridViewProductosOrdenados = new DataGridView();
            labelProductosMasVendi = new Label();
            labelMejoresClientes = new Label();
            dataGridViewMejoresCli = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosOrdenados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMejoresCli).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutC
            // 
            buttonLogoutC.Location = new Point(654, 405);
            buttonLogoutC.Name = "buttonLogoutC";
            buttonLogoutC.Size = new Size(111, 33);
            buttonLogoutC.TabIndex = 0;
            buttonLogoutC.Text = "LogOut";
            buttonLogoutC.UseVisualStyleBackColor = true;
            buttonLogoutC.Click += buttonLogoutC_Click;
            // 
            // labelVentasTotales
            // 
            labelVentasTotales.AutoSize = true;
            labelVentasTotales.Location = new Point(210, 9);
            labelVentasTotales.Name = "labelVentasTotales";
            labelVentasTotales.Size = new Size(59, 25);
            labelVentasTotales.TabIndex = 1;
            labelVentasTotales.Text = "label1";
            // 
            // dataGridViewProductosOrdenados
            // 
            dataGridViewProductosOrdenados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductosOrdenados.Location = new Point(33, 121);
            dataGridViewProductosOrdenados.Name = "dataGridViewProductosOrdenados";
            dataGridViewProductosOrdenados.RowHeadersWidth = 62;
            dataGridViewProductosOrdenados.RowTemplate.Height = 33;
            dataGridViewProductosOrdenados.Size = new Size(360, 225);
            dataGridViewProductosOrdenados.TabIndex = 2;
            // 
            // labelProductosMasVendi
            // 
            labelProductosMasVendi.AutoSize = true;
            labelProductosMasVendi.Location = new Point(33, 77);
            labelProductosMasVendi.Name = "labelProductosMasVendi";
            labelProductosMasVendi.Size = new Size(275, 25);
            labelProductosMasVendi.TabIndex = 3;
            labelProductosMasVendi.Text = "Lista de productos mas vendidos";
            // 
            // labelMejoresClientes
            // 
            labelMejoresClientes.AutoSize = true;
            labelMejoresClientes.Location = new Point(470, 77);
            labelMejoresClientes.Name = "labelMejoresClientes";
            labelMejoresClientes.Size = new Size(141, 25);
            labelMejoresClientes.TabIndex = 4;
            labelMejoresClientes.Text = "Mejores Clientes";
            // 
            // dataGridViewMejoresCli
            // 
            dataGridViewMejoresCli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMejoresCli.Location = new Point(428, 121);
            dataGridViewMejoresCli.Name = "dataGridViewMejoresCli";
            dataGridViewMejoresCli.RowHeadersWidth = 62;
            dataGridViewMejoresCli.RowTemplate.Height = 33;
            dataGridViewMejoresCli.Size = new Size(360, 225);
            dataGridViewMejoresCli.TabIndex = 5;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMejoresCli);
            Controls.Add(labelMejoresClientes);
            Controls.Add(labelProductosMasVendi);
            Controls.Add(dataGridViewProductosOrdenados);
            Controls.Add(labelVentasTotales);
            Controls.Add(buttonLogoutC);
            Name = "FormConsultas";
            Text = "FormConsultas";
            Load += FormConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosOrdenados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMejoresCli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutC;
        private Label labelVentasTotales;
        private DataGridView dataGridViewProductosOrdenados;
        private Label labelProductosMasVendi;
        private Label labelMejoresClientes;
        private DataGridView dataGridViewMejoresCli;
    }
}