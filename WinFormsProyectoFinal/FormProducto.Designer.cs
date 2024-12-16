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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            pictureBoxImagenProd = new PictureBox();
            labelDescripcionProd = new Label();
            labelPrecioProd = new Label();
            labelExistenciasProd = new Label();
            btnRegresar = new PictureBox();
            lblNombreProd = new Label();
            buttonComprar = new Button();
            labelNombreUsu = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagenProd
            // 
            pictureBoxImagenProd.Location = new Point(184, 20);
            pictureBoxImagenProd.Name = "pictureBoxImagenProd";
            pictureBoxImagenProd.Size = new Size(186, 135);
            pictureBoxImagenProd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenProd.TabIndex = 0;
            pictureBoxImagenProd.TabStop = false;
            // 
            // labelDescripcionProd
            // 
            labelDescripcionProd.Location = new Point(139, 282);
            labelDescripcionProd.Name = "labelDescripcionProd";
            labelDescripcionProd.Size = new Size(287, 100);
            labelDescripcionProd.TabIndex = 1;
            labelDescripcionProd.Text = "Descripción";
            labelDescripcionProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPrecioProd
            // 
            labelPrecioProd.AutoSize = true;
            labelPrecioProd.Location = new Point(247, 217);
            labelPrecioProd.Name = "labelPrecioProd";
            labelPrecioProd.Size = new Size(60, 25);
            labelPrecioProd.TabIndex = 2;
            labelPrecioProd.Text = "Precio";
            // 
            // labelExistenciasProd
            // 
            labelExistenciasProd.AutoSize = true;
            labelExistenciasProd.Location = new Point(229, 242);
            labelExistenciasProd.Name = "labelExistenciasProd";
            labelExistenciasProd.Size = new Size(95, 25);
            labelExistenciasProd.TabIndex = 3;
            labelExistenciasProd.Text = "Existencias";
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(17, 20);
            btnRegresar.Margin = new Padding(4, 5, 4, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 47);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 4;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblNombreProd
            // 
            lblNombreProd.AutoSize = true;
            lblNombreProd.Location = new Point(247, 175);
            lblNombreProd.Margin = new Padding(4, 0, 4, 0);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(78, 25);
            lblNombreProd.TabIndex = 5;
            lblNombreProd.Text = "Nombre";
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(408, 348);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(112, 34);
            buttonComprar.TabIndex = 6;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // labelNombreUsu
            // 
            labelNombreUsu.AutoSize = true;
            labelNombreUsu.Location = new Point(435, 20);
            labelNombreUsu.Name = "labelNombreUsu";
            labelNombreUsu.Size = new Size(59, 25);
            labelNombreUsu.TabIndex = 7;
            labelNombreUsu.Text = "label1";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 410);
            Controls.Add(labelNombreUsu);
            Controls.Add(buttonComprar);
            Controls.Add(lblNombreProd);
            Controls.Add(btnRegresar);
            Controls.Add(labelExistenciasProd);
            Controls.Add(labelPrecioProd);
            Controls.Add(labelDescripcionProd);
            Controls.Add(pictureBoxImagenProd);
            Name = "FormProducto";
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
    }
}