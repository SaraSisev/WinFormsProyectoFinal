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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultas));
            buttonLogoutC = new Button();
            labelVentasTotales = new Label();
            dataGridViewProductosOrdenados = new DataGridView();
            labelProductosMasVendi = new Label();
            labelMejoresClientes = new Label();
            dataGridViewMejoresCli = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            labelNomSistema = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosOrdenados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMejoresCli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutC
            // 
            buttonLogoutC.BackColor = Color.Transparent;
            buttonLogoutC.FlatAppearance.BorderSize = 0;
            buttonLogoutC.FlatStyle = FlatStyle.Flat;
            buttonLogoutC.Image = (Image)resources.GetObject("buttonLogoutC.Image");
            buttonLogoutC.Location = new Point(512, 12);
            buttonLogoutC.Margin = new Padding(2);
            buttonLogoutC.Name = "buttonLogoutC";
            buttonLogoutC.Size = new Size(36, 44);
            buttonLogoutC.TabIndex = 0;
            buttonLogoutC.UseVisualStyleBackColor = false;
            buttonLogoutC.Click += buttonLogoutC_Click;
            // 
            // labelVentasTotales
            // 
            labelVentasTotales.AutoSize = true;
            labelVentasTotales.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelVentasTotales.Location = new Point(258, 292);
            labelVentasTotales.Margin = new Padding(2, 0, 2, 0);
            labelVentasTotales.Name = "labelVentasTotales";
            labelVentasTotales.Size = new Size(51, 16);
            labelVentasTotales.TabIndex = 1;
            labelVentasTotales.Text = "label1";
            // 
            // dataGridViewProductosOrdenados
            // 
            dataGridViewProductosOrdenados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductosOrdenados.Location = new Point(19, 126);
            dataGridViewProductosOrdenados.Margin = new Padding(2);
            dataGridViewProductosOrdenados.Name = "dataGridViewProductosOrdenados";
            dataGridViewProductosOrdenados.RowHeadersWidth = 62;
            dataGridViewProductosOrdenados.RowTemplate.Height = 33;
            dataGridViewProductosOrdenados.Size = new Size(252, 135);
            dataGridViewProductosOrdenados.TabIndex = 2;
            // 
            // labelProductosMasVendi
            // 
            labelProductosMasVendi.AutoSize = true;
            labelProductosMasVendi.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductosMasVendi.Location = new Point(25, 99);
            labelProductosMasVendi.Margin = new Padding(2, 0, 2, 0);
            labelProductosMasVendi.Name = "labelProductosMasVendi";
            labelProductosMasVendi.Size = new Size(246, 16);
            labelProductosMasVendi.TabIndex = 3;
            labelProductosMasVendi.Text = "Lista de productos mas vendidos";
            // 
            // labelMejoresClientes
            // 
            labelMejoresClientes.AutoSize = true;
            labelMejoresClientes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMejoresClientes.Location = new Point(364, 99);
            labelMejoresClientes.Margin = new Padding(2, 0, 2, 0);
            labelMejoresClientes.Name = "labelMejoresClientes";
            labelMejoresClientes.Size = new Size(128, 16);
            labelMejoresClientes.TabIndex = 4;
            labelMejoresClientes.Text = "Mejores Clientes";
            // 
            // dataGridViewMejoresCli
            // 
            dataGridViewMejoresCli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMejoresCli.Location = new Point(296, 126);
            dataGridViewMejoresCli.Margin = new Padding(2);
            dataGridViewMejoresCli.Name = "dataGridViewMejoresCli";
            dataGridViewMejoresCli.RowHeadersWidth = 62;
            dataGridViewMejoresCli.RowTemplate.Height = 33;
            dataGridViewMejoresCli.Size = new Size(252, 135);
            dataGridViewMejoresCli.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(470, 285);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(78, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(231, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 16);
            label7.TabIndex = 25;
            label7.Text = "Tejiendo sueños, un punto a la vez";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(155, -6);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // labelNomSistema
            // 
            labelNomSistema.AutoSize = true;
            labelNomSistema.BackColor = Color.Transparent;
            labelNomSistema.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomSistema.Location = new Point(231, 13);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 23;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 320);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(labelNomSistema);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridViewMejoresCli);
            Controls.Add(labelMejoresClientes);
            Controls.Add(labelProductosMasVendi);
            Controls.Add(dataGridViewProductosOrdenados);
            Controls.Add(labelVentasTotales);
            Controls.Add(buttonLogoutC);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultas";
            Load += FormConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosOrdenados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMejoresCli).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private Label labelNomSistema;
    }
}