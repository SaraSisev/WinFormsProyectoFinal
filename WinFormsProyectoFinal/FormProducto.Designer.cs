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
            pictureBoxImagenProd = new PictureBox();
            labelDescripcionProd = new Label();
            labelPrecioProd = new Label();
            labelExistenciasProd = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagenProd
            // 
            pictureBoxImagenProd.Location = new Point(72, 96);
            pictureBoxImagenProd.Name = "pictureBoxImagenProd";
            pictureBoxImagenProd.Size = new Size(186, 135);
            pictureBoxImagenProd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenProd.TabIndex = 0;
            pictureBoxImagenProd.TabStop = false;
            // 
            // labelDescripcionProd
            // 
            labelDescripcionProd.AutoSize = true;
            labelDescripcionProd.Location = new Point(72, 255);
            labelDescripcionProd.Name = "labelDescripcionProd";
            labelDescripcionProd.Size = new Size(59, 25);
            labelDescripcionProd.TabIndex = 1;
            labelDescripcionProd.Text = "label1";
            // 
            // labelPrecioProd
            // 
            labelPrecioProd.AutoSize = true;
            labelPrecioProd.Location = new Point(72, 301);
            labelPrecioProd.Name = "labelPrecioProd";
            labelPrecioProd.Size = new Size(59, 25);
            labelPrecioProd.TabIndex = 2;
            labelPrecioProd.Text = "label2";
            // 
            // labelExistenciasProd
            // 
            labelExistenciasProd.AutoSize = true;
            labelExistenciasProd.Location = new Point(72, 344);
            labelExistenciasProd.Name = "labelExistenciasProd";
            labelExistenciasProd.Size = new Size(59, 25);
            labelExistenciasProd.TabIndex = 3;
            labelExistenciasProd.Text = "label3";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelExistenciasProd);
            Controls.Add(labelPrecioProd);
            Controls.Add(labelDescripcionProd);
            Controls.Add(pictureBoxImagenProd);
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImagenProd;
        private Label labelDescripcionProd;
        private Label labelPrecioProd;
        private Label labelExistenciasProd;
    }
}