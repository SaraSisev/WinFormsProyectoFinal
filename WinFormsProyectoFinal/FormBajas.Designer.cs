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
            buttonLogoutB = new Button();
            textBoxBaID = new TextBox();
            labelBajasID = new Label();
            buttonBuscar = new Button();
            buttonEliminar = new Button();
            labelIDBus = new Label();
            labelPrecioBus = new Label();
            labelExiBus = new Label();
            labelImaBus = new Label();
            labelDesBus = new Label();
            SuspendLayout();
            // 
            // buttonLogoutB
            // 
            buttonLogoutB.Location = new Point(676, 404);
            buttonLogoutB.Name = "buttonLogoutB";
            buttonLogoutB.Size = new Size(112, 34);
            buttonLogoutB.TabIndex = 0;
            buttonLogoutB.Text = "LogOut";
            buttonLogoutB.UseVisualStyleBackColor = true;
            buttonLogoutB.Click += buttonLogoutB_Click;
            // 
            // textBoxBaID
            // 
            textBoxBaID.Location = new Point(72, 79);
            textBoxBaID.Name = "textBoxBaID";
            textBoxBaID.PlaceholderText = "ID";
            textBoxBaID.Size = new Size(150, 31);
            textBoxBaID.TabIndex = 1;
            // 
            // labelBajasID
            // 
            labelBajasID.AutoSize = true;
            labelBajasID.Location = new Point(83, 36);
            labelBajasID.Name = "labelBajasID";
            labelBajasID.Size = new Size(300, 25);
            labelBajasID.TabIndex = 2;
            labelBajasID.Text = "Ingrese el ID del producto a eliminar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(72, 153);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(112, 34);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(324, 385);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelIDBus
            // 
            labelIDBus.AutoSize = true;
            labelIDBus.Location = new Point(324, 85);
            labelIDBus.Name = "labelIDBus";
            labelIDBus.Size = new Size(0, 25);
            labelIDBus.TabIndex = 5;
            // 
            // labelPrecioBus
            // 
            labelPrecioBus.AutoSize = true;
            labelPrecioBus.Location = new Point(324, 268);
            labelPrecioBus.Name = "labelPrecioBus";
            labelPrecioBus.Size = new Size(59, 25);
            labelPrecioBus.TabIndex = 6;
            labelPrecioBus.Text = "label1";
            labelPrecioBus.Click += labelPrecioBus_Click;
            // 
            // labelExiBus
            // 
            labelExiBus.AutoSize = true;
            labelExiBus.Location = new Point(324, 320);
            labelExiBus.Name = "labelExiBus";
            labelExiBus.Size = new Size(59, 25);
            labelExiBus.TabIndex = 7;
            labelExiBus.Text = "label1";
            labelExiBus.Click += labelExiBus_Click;
            // 
            // labelImaBus
            // 
            labelImaBus.AutoSize = true;
            labelImaBus.Location = new Point(324, 131);
            labelImaBus.Name = "labelImaBus";
            labelImaBus.Size = new Size(59, 25);
            labelImaBus.TabIndex = 8;
            labelImaBus.Text = "label1";
            // 
            // labelDesBus
            // 
            labelDesBus.AutoSize = true;
            labelDesBus.Location = new Point(324, 212);
            labelDesBus.Name = "labelDesBus";
            labelDesBus.Size = new Size(59, 25);
            labelDesBus.TabIndex = 9;
            labelDesBus.Text = "label1";
            // 
            // FormBajas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDesBus);
            Controls.Add(labelImaBus);
            Controls.Add(labelExiBus);
            Controls.Add(labelPrecioBus);
            Controls.Add(labelIDBus);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonBuscar);
            Controls.Add(labelBajasID);
            Controls.Add(textBoxBaID);
            Controls.Add(buttonLogoutB);
            Name = "FormBajas";
            Text = "FormBajas";
            Load += FormBajas_Load;
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
        private Label labelImaBus;
        private Label labelDesBus;
    }
}