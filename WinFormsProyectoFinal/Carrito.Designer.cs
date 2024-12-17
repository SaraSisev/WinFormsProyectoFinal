namespace WinFormsProyectoFinal
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            pictureBox1 = new PictureBox();
            lblProducto = new Label();
            btnEliminar = new Button();
            btnComprar = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox2 = new PictureBox();
            lblNombre = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblFecha = new Label();
            lblSubtot = new Label();
            lblIva = new Label();
            lblTot = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // lblProducto
            // 
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblProducto.Location = new Point(6, 19);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(172, 68);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Seleccione un producto para mostrar los detalles";
            lblProducto.TextAlign = ContentAlignment.TopCenter;
            lblProducto.Click += lblProducto_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 204, 205);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.Maroon;
            btnEliminar.Location = new Point(59, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(221, 234, 238);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = Color.FromArgb(23, 41, 46);
            btnComprar.Location = new Point(521, 362);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(75, 42);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += Imprimir;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(684, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(35, 35, 35);
            lblNombre.Location = new Point(254, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(351, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblFecha
            // 
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(35, 35, 35);
            lblFecha.Location = new Point(674, 11);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(130, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopRight;
            lblFecha.Click += lblFecha_Click;
            // 
            // lblSubtot
            // 
            lblSubtot.AutoSize = true;
            lblSubtot.BackColor = Color.Transparent;
            lblSubtot.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtot.Location = new Point(429, 337);
            lblSubtot.Name = "lblSubtot";
            lblSubtot.Size = new Size(22, 15);
            lblSubtot.TabIndex = 8;
            lblSubtot.Text = "$ 0";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.BackColor = Color.Transparent;
            lblIva.Font = new Font("Nirmala UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIva.Location = new Point(429, 363);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(22, 15);
            lblIva.TabIndex = 9;
            lblIva.Text = "$ 0";
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.BackColor = Color.Transparent;
            lblTot.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTot.Location = new Point(429, 389);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(24, 15);
            lblTot.TabIndex = 10;
            lblTot.Text = "$ 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(360, 335);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(322, 362);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 12;
            label5.Text = "Impuestos (6%)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(372, 389);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 13;
            label6.Text = "TOTAL";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblProducto);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(545, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 135);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(239, 231, 229);
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(98, 107);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.No;
            listView1.Size = new Size(410, 209);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 429);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTot);
            Controls.Add(lblIva);
            Controls.Add(lblSubtot);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox2);
            Controls.Add(btnComprar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito";
            Load += Carrito_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblProducto;
        private Button btnEliminar;
        private Button btnComprar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox2;
        private Label lblNombre;
        private System.Windows.Forms.Timer timer1;
        private Label lblFecha;
        private Label lblSubtot;
        private Label lblIva;
        private Label lblTot;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label1;
        private ListView listView1;
    }
}