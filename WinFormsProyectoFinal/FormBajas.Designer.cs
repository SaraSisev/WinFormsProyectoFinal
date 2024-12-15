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
            buttonBuscar = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // buttonLogoutB
            // 
            buttonLogoutB.Location = new Point(608, 11);
            buttonLogoutB.Margin = new Padding(2);
            buttonLogoutB.Name = "buttonLogoutB";
            buttonLogoutB.Size = new Size(78, 20);
            buttonLogoutB.TabIndex = 0;
            buttonLogoutB.Text = "LogOut";
            buttonLogoutB.UseVisualStyleBackColor = true;
            buttonLogoutB.Click += buttonLogoutB_Click;
            // 
            // labelBajasID
            // 
            labelBajasID.AutoSize = true;
            labelBajasID.Location = new Point(58, 22);
            labelBajasID.Margin = new Padding(2, 0, 2, 0);
            labelBajasID.Name = "labelBajasID";
            labelBajasID.Size = new Size(197, 15);
            labelBajasID.TabIndex = 2;
            labelBajasID.Text = "Ingrese el ID del producto a eliminar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(50, 92);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(78, 20);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(25, 294);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(78, 20);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelIDBus
            // 
            labelIDBus.AutoSize = true;
            labelIDBus.Location = new Point(308, 22);
            labelIDBus.Margin = new Padding(2, 0, 2, 0);
            labelIDBus.Name = "labelIDBus";
            labelIDBus.Size = new Size(32, 15);
            labelIDBus.TabIndex = 5;
            labelIDBus.Text = "label";
            // 
            // labelPrecioBus
            // 
            labelPrecioBus.AutoSize = true;
            labelPrecioBus.Location = new Point(304, 94);
            labelPrecioBus.Margin = new Padding(2, 0, 2, 0);
            labelPrecioBus.Name = "labelPrecioBus";
            labelPrecioBus.Size = new Size(38, 15);
            labelPrecioBus.TabIndex = 6;
            labelPrecioBus.Text = "label1";
            labelPrecioBus.Click += labelPrecioBus_Click;
            // 
            // labelExiBus
            // 
            labelExiBus.AutoSize = true;
            labelExiBus.Location = new Point(304, 125);
            labelExiBus.Margin = new Padding(2, 0, 2, 0);
            labelExiBus.Name = "labelExiBus";
            labelExiBus.Size = new Size(38, 15);
            labelExiBus.TabIndex = 7;
            labelExiBus.Text = "label1";
            labelExiBus.Click += labelExiBus_Click;
            // 
            // labelDesBus
            // 
            labelDesBus.Location = new Point(294, 196);
            labelDesBus.Margin = new Padding(2, 0, 2, 0);
            labelDesBus.Name = "labelDesBus";
            labelDesBus.Size = new Size(192, 102);
            labelDesBus.TabIndex = 9;
            labelDesBus.Text = "label1";
            labelDesBus.Click += labelDesBus_Click;
            // 
            // boxId
            // 
            boxId.DropDownStyle = ComboBoxStyle.DropDownList;
            boxId.FormattingEnabled = true;
            boxId.Location = new Point(50, 48);
            boxId.Name = "boxId";
            boxId.Size = new Size(121, 23);
            boxId.TabIndex = 10;
            boxId.SelectedIndexChanged += boxId_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(423, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelVenBus
            // 
            labelVenBus.AutoSize = true;
            labelVenBus.Location = new Point(302, 152);
            labelVenBus.Name = "labelVenBus";
            labelVenBus.Size = new Size(38, 15);
            labelVenBus.TabIndex = 12;
            labelVenBus.Text = "label1";
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(640, 285);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 40);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 13;
            btnRegresar.TabStop = false;
            btnRegresar.Click += pictureBox2_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(305, 54);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(38, 15);
            labelNombre.TabIndex = 14;
            labelNombre.Text = "label1";
            // 
            // FormBajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 337);
            Controls.Add(labelNombre);
            Controls.Add(btnRegresar);
            Controls.Add(labelVenBus);
            Controls.Add(pictureBox1);
            Controls.Add(boxId);
            Controls.Add(labelDesBus);
            Controls.Add(labelExiBus);
            Controls.Add(labelPrecioBus);
            Controls.Add(labelIDBus);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonBuscar);
            Controls.Add(labelBajasID);
            Controls.Add(buttonLogoutB);
            Margin = new Padding(2);
            Name = "FormBajas";
            Text = "FormBajas";
            Load += FormBajas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogoutB;
        private TextBox textBoxBaID;
        private Label labelBajasID;
        private Button buttonBuscar;
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
    }
}