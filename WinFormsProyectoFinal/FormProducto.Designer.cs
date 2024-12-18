namespace WinFormsProyectoFinal
{
    partial class FormProducto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            pictureBoxImagenProd = new PictureBox();
            labelDescripcionProd = new Label();
            labelPrecioProd = new Label();
            labelExistenciasProd = new Label();
            btnRegresar = new PictureBox();
            lblNombreProd = new Label();
            buttonComprar = new Button();
            labelNombreUsu = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagenProd
            // 
            pictureBoxImagenProd.Location = new Point(129, 69);
            pictureBoxImagenProd.Margin = new Padding(2);
            pictureBoxImagenProd.Name = "pictureBoxImagenProd";
            pictureBoxImagenProd.Size = new Size(120, 120);
            pictureBoxImagenProd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenProd.TabIndex = 0;
            pictureBoxImagenProd.TabStop = false;
            // 
            // labelDescripcionProd
            // 
            labelDescripcionProd.BackColor = Color.Transparent;
            labelDescripcionProd.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcionProd.Location = new Point(50, 229);
            labelDescripcionProd.Margin = new Padding(2, 0, 2, 0);
            labelDescripcionProd.Name = "labelDescripcionProd";
            labelDescripcionProd.Size = new Size(283, 80);
            labelDescripcionProd.TabIndex = 1;
            labelDescripcionProd.Text = "Descripción";
            labelDescripcionProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPrecioProd
            // 
            labelPrecioProd.BackColor = Color.Transparent;
            labelPrecioProd.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecioProd.Location = new Point(147, 193);
            labelPrecioProd.Margin = new Padding(2, 0, 2, 0);
            labelPrecioProd.Name = "labelPrecioProd";
            labelPrecioProd.Size = new Size(82, 19);
            labelPrecioProd.TabIndex = 2;
            labelPrecioProd.Text = "Precio";
            labelPrecioProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelExistenciasProd
            // 
            labelExistenciasProd.BackColor = Color.Transparent;
            labelExistenciasProd.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelExistenciasProd.Location = new Point(136, 210);
            labelExistenciasProd.Margin = new Padding(2, 0, 2, 0);
            labelExistenciasProd.Name = "labelExistenciasProd";
            labelExistenciasProd.Size = new Size(106, 19);
            labelExistenciasProd.TabIndex = 3;
            labelExistenciasProd.Text = "Existencias";
            labelExistenciasProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(30, 30);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 4;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblNombreProd
            // 
            lblNombreProd.BackColor = Color.Transparent;
            lblNombreProd.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreProd.Location = new Point(133, 49);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(112, 18);
            lblNombreProd.TabIndex = 5;
            lblNombreProd.Text = "Nombre";
            lblNombreProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.FromArgb(221, 234, 238);
            buttonComprar.FlatStyle = FlatStyle.Flat;
            buttonComprar.ForeColor = Color.FromArgb(23, 41, 46);
            buttonComprar.Location = new Point(293, 328);
            buttonComprar.Margin = new Padding(2);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(78, 27);
            buttonComprar.TabIndex = 6;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = false;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // labelNombreUsu
            // 
            labelNombreUsu.BackColor = Color.Transparent;
            labelNombreUsu.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelNombreUsu.ForeColor = Color.FromArgb(35, 35, 35);
            labelNombreUsu.Location = new Point(112, 9);
            labelNombreUsu.Margin = new Padding(2, 0, 2, 0);
            labelNombreUsu.Name = "labelNombreUsu";
            labelNombreUsu.Size = new Size(162, 30);
            labelNombreUsu.TabIndex = 7;
            labelNombreUsu.Text = "Nombre Usuario";
            labelNombreUsu.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(35, 35, 35);
            lblFecha.Location = new Point(12, 343);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(42, 14);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(150, 195);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 9;
            label1.Text = "$";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 366);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(labelNombreUsu);
            Controls.Add(buttonComprar);
            Controls.Add(lblNombreProd);
            Controls.Add(btnRegresar);
            Controls.Add(labelExistenciasProd);
            Controls.Add(labelPrecioProd);
            Controls.Add(labelDescripcionProd);
            Controls.Add(pictureBoxImagenProd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImagenProd;
        private Label labelDescripcionProd;
        private Label labelPrecioProd;
        private Label labelExistenciasProd;
        private PictureBox btnRegresar;
        private Label lblNombreProd;
        private Button buttonComprar;
        private Label labelNombreUsu;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}