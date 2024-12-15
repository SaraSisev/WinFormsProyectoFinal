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
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagenProd
            // 
            pictureBoxImagenProd.Location = new Point(129, 12);
            pictureBoxImagenProd.Margin = new Padding(2);
            pictureBoxImagenProd.Name = "pictureBoxImagenProd";
            pictureBoxImagenProd.Size = new Size(130, 81);
            pictureBoxImagenProd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenProd.TabIndex = 0;
            pictureBoxImagenProd.TabStop = false;
            // 
            // labelDescripcionProd
            // 
            labelDescripcionProd.Location = new Point(97, 169);
            labelDescripcionProd.Margin = new Padding(2, 0, 2, 0);
            labelDescripcionProd.Name = "labelDescripcionProd";
            labelDescripcionProd.Size = new Size(201, 60);
            labelDescripcionProd.TabIndex = 1;
            labelDescripcionProd.Text = "Descripción";
            labelDescripcionProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPrecioProd
            // 
            labelPrecioProd.AutoSize = true;
            labelPrecioProd.Location = new Point(173, 130);
            labelPrecioProd.Margin = new Padding(2, 0, 2, 0);
            labelPrecioProd.Name = "labelPrecioProd";
            labelPrecioProd.Size = new Size(40, 15);
            labelPrecioProd.TabIndex = 2;
            labelPrecioProd.Text = "Precio";
            // 
            // labelExistenciasProd
            // 
            labelExistenciasProd.AutoSize = true;
            labelExistenciasProd.Location = new Point(160, 145);
            labelExistenciasProd.Margin = new Padding(2, 0, 2, 0);
            labelExistenciasProd.Name = "labelExistenciasProd";
            labelExistenciasProd.Size = new Size(64, 15);
            labelExistenciasProd.TabIndex = 3;
            labelExistenciasProd.Text = "Existencias";
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(28, 28);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 4;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblNombreProd
            // 
            lblNombreProd.AutoSize = true;
            lblNombreProd.Location = new Point(173, 105);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(51, 15);
            lblNombreProd.TabIndex = 5;
            lblNombreProd.Text = "Nombre";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 246);
            Controls.Add(lblNombreProd);
            Controls.Add(btnRegresar);
            Controls.Add(labelExistenciasProd);
            Controls.Add(labelPrecioProd);
            Controls.Add(labelDescripcionProd);
            Controls.Add(pictureBoxImagenProd);
            Margin = new Padding(2);
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
    }
}