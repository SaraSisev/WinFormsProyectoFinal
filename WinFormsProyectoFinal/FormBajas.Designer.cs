namespace WinFormsProyectoFinal
{
    partial class FormBajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajas));
            buttonLogoutB = new Button();
            labelBajasID = new Label();
            buttonEliminar = new Button();
            labelIDBus = new Label();
            labelPrecioBus = new Label();
            labelExiBus = new Label();
            labelDesBus = new Label();
            boxId = new ComboBox();
            pictureBox1 = new PictureBox();
            labelVenBus = new Label();
            btnRegresar = new PictureBox();
            labelNombre = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            labelNomSistema = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutB
            // 
            buttonLogoutB.BackColor = Color.Transparent;
            buttonLogoutB.FlatAppearance.BorderSize = 0;
            buttonLogoutB.FlatStyle = FlatStyle.Flat;
            buttonLogoutB.Image = (Image)resources.GetObject("buttonLogoutB.Image");
            buttonLogoutB.Location = new Point(650, 11);
            buttonLogoutB.Margin = new Padding(2);
            buttonLogoutB.Name = "buttonLogoutB";
            buttonLogoutB.Size = new Size(36, 44);
            buttonLogoutB.TabIndex = 0;
            buttonLogoutB.UseVisualStyleBackColor = false;
            buttonLogoutB.Click += buttonLogoutB_Click;
            // 
            // labelBajasID
            // 
            labelBajasID.AutoSize = true;
            labelBajasID.BackColor = Color.Transparent;
            labelBajasID.Location = new Point(26, 113);
            labelBajasID.Margin = new Padding(2, 0, 2, 0);
            labelBajasID.Name = "labelBajasID";
            labelBajasID.Size = new Size(197, 15);
            labelBajasID.TabIndex = 2;
            labelBajasID.Text = "Ingrese el ID del producto a eliminar";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(255, 230, 208);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = Color.FromArgb(64, 0, 0);
            buttonEliminar.Location = new Point(488, 281);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(118, 67);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelIDBus
            // 
            labelIDBus.BackColor = Color.Transparent;
            labelIDBus.Location = new Point(300, 113);
            labelIDBus.Margin = new Padding(2, 0, 2, 0);
            labelIDBus.Name = "labelIDBus";
            labelIDBus.Size = new Size(32, 15);
            labelIDBus.TabIndex = 5;
            labelIDBus.Text = "ID";
            labelIDBus.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPrecioBus
            // 
            labelPrecioBus.BackColor = Color.Transparent;
            labelPrecioBus.Location = new Point(233, 167);
            labelPrecioBus.Margin = new Padding(2, 0, 2, 0);
            labelPrecioBus.Name = "labelPrecioBus";
            labelPrecioBus.Size = new Size(172, 16);
            labelPrecioBus.TabIndex = 6;
            labelPrecioBus.Text = "Precio";
            labelPrecioBus.TextAlign = ContentAlignment.TopCenter;
            labelPrecioBus.Click += labelPrecioBus_Click;
            // 
            // labelExiBus
            // 
            labelExiBus.BackColor = Color.Transparent;
            labelExiBus.Location = new Point(250, 196);
            labelExiBus.Margin = new Padding(2, 0, 2, 0);
            labelExiBus.Name = "labelExiBus";
            labelExiBus.Size = new Size(143, 17);
            labelExiBus.TabIndex = 7;
            labelExiBus.Text = "Existencias";
            labelExiBus.TextAlign = ContentAlignment.TopCenter;
            labelExiBus.Click += labelExiBus_Click;
            // 
            // labelDesBus
            // 
            labelDesBus.BackColor = Color.Transparent;
            labelDesBus.Location = new Point(179, 254);
            labelDesBus.Margin = new Padding(2, 0, 2, 0);
            labelDesBus.Name = "labelDesBus";
            labelDesBus.Size = new Size(278, 124);
            labelDesBus.TabIndex = 9;
            labelDesBus.Text = "Descripción del producto";
            labelDesBus.TextAlign = ContentAlignment.TopCenter;
            labelDesBus.Click += labelDesBus_Click;
            // 
            // boxId
            // 
            boxId.BackColor = Color.Gainsboro;
            boxId.DropDownStyle = ComboBoxStyle.DropDownList;
            boxId.FlatStyle = FlatStyle.System;
            boxId.FormattingEnabled = true;
            boxId.Location = new Point(64, 131);
            boxId.Name = "boxId";
            boxId.Size = new Size(121, 23);
            boxId.TabIndex = 10;
            boxId.SelectedIndexChanged += boxId_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelVenBus
            // 
            labelVenBus.BackColor = Color.Transparent;
            labelVenBus.Location = new Point(256, 223);
            labelVenBus.Name = "labelVenBus";
            labelVenBus.Size = new Size(133, 19);
            labelVenBus.TabIndex = 12;
            labelVenBus.Text = "Ventas";
            labelVenBus.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(36, 36);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 13;
            btnRegresar.TabStop = false;
            btnRegresar.Click += pictureBox2_Click;
            // 
            // labelNombre
            // 
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Location = new Point(231, 137);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(176, 17);
            labelNombre.TabIndex = 14;
            labelNombre.Text = "Nombre";
            labelNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(312, 40);
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
            pictureBox2.Location = new Point(236, -4);
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
            labelNomSistema.Location = new Point(312, 15);
            labelNomSistema.Name = "labelNomSistema";
            labelNomSistema.Size = new Size(183, 25);
            labelNomSistema.TabIndex = 23;
            labelNomSistema.Text = "Tricotera Shop";
            // 
            // FormBajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(715, 391);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(labelNomSistema);
            Controls.Add(labelNombre);
            Controls.Add(btnRegresar);
            Controls.Add(labelVenBus);
            Controls.Add(boxId);
            Controls.Add(labelDesBus);
            Controls.Add(labelExiBus);
            Controls.Add(labelPrecioBus);
            Controls.Add(labelIDBus);
            Controls.Add(buttonEliminar);
            Controls.Add(labelBajasID);
            Controls.Add(buttonLogoutB);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormBajas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBajas";
            Load += FormBajas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutB;
        private TextBox textBoxBaID;
        private Label labelBajasID;
        private Button buttonEliminar;
        private Label labelIDBus;
        private Label labelPrecioBus;
        private Label labelExiBus;
        private Label labelDesBus;
        private ComboBox boxId;
        private PictureBox pictureBox1;
        private Label labelVenBus;
        private PictureBox btnRegresar;
        private Label labelNombre;
        private Label label7;
        private PictureBox pictureBox2;
        private Label labelNomSistema;
    }
}