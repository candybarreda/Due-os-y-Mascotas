namespace trabajo_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            g_3_button_regsitrar_1 = new Button();
            g_3_listview = new ListView();
            Dueño = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            g_3_telefono = new TextBox();
            g_3_Direccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            g_3_nombreD = new TextBox();
            groupBox2 = new GroupBox();
            g_3_button_registrar_2 = new Button();
            g_3_listview_2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            g_3_direc = new ColumnHeader();
            g_3_telf = new ColumnHeader();
            g_3_dueño = new ComboBox();
            g_3_raza_mascota = new TextBox();
            g_3_edad_mascota = new TextBox();
            g_3_nom_mascota = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            g_3_button_buscar = new Button();
            g_3_Buscar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(g_3_button_regsitrar_1);
            groupBox1.Controls.Add(g_3_listview);
            groupBox1.Controls.Add(g_3_telefono);
            groupBox1.Controls.Add(g_3_Direccion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(g_3_nombreD);
            groupBox1.Location = new Point(24, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(975, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro del Dueño";
            // 
            // g_3_button_regsitrar_1
            // 
            g_3_button_regsitrar_1.Location = new Point(187, 180);
            g_3_button_regsitrar_1.Name = "g_3_button_regsitrar_1";
            g_3_button_regsitrar_1.Size = new Size(94, 29);
            g_3_button_regsitrar_1.TabIndex = 7;
            g_3_button_regsitrar_1.Text = "Registrar ";
            g_3_button_regsitrar_1.UseVisualStyleBackColor = true;
            g_3_button_regsitrar_1.Click += g_3_button_regsitrar_1_Click;
            // 
            // g_3_listview
            // 
            g_3_listview.Columns.AddRange(new ColumnHeader[] { Dueño, columnHeader2, columnHeader3 });
            g_3_listview.Location = new Point(359, 33);
            g_3_listview.Name = "g_3_listview";
            g_3_listview.Size = new Size(593, 194);
            g_3_listview.TabIndex = 6;
            g_3_listview.UseCompatibleStateImageBehavior = false;
            g_3_listview.View = View.Details;
            // 
            // Dueño
            // 
            Dueño.Text = "Nombre del Dueño";
            Dueño.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Direccion";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Telefono";
            columnHeader3.Width = 150;
            // 
            // g_3_telefono
            // 
            g_3_telefono.Location = new Point(173, 132);
            g_3_telefono.Name = "g_3_telefono";
            g_3_telefono.Size = new Size(125, 27);
            g_3_telefono.TabIndex = 5;
            // 
            // g_3_Direccion
            // 
            g_3_Direccion.Location = new Point(173, 82);
            g_3_Direccion.Name = "g_3_Direccion";
            g_3_Direccion.Size = new Size(125, 27);
            g_3_Direccion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefono :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Direccion :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Dueño :\r\n\r\n";
            // 
            // g_3_nombreD
            // 
            g_3_nombreD.Location = new Point(173, 33);
            g_3_nombreD.Name = "g_3_nombreD";
            g_3_nombreD.Size = new Size(125, 27);
            g_3_nombreD.TabIndex = 0;
            g_3_nombreD.TextChanged += g_3_nombreD_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(g_3_button_registrar_2);
            groupBox2.Controls.Add(g_3_listview_2);
            groupBox2.Controls.Add(g_3_dueño);
            groupBox2.Controls.Add(g_3_raza_mascota);
            groupBox2.Controls.Add(g_3_edad_mascota);
            groupBox2.Controls.Add(g_3_nom_mascota);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(24, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(975, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de la Mascota";
            // 
            // g_3_button_registrar_2
            // 
            g_3_button_registrar_2.Location = new Point(187, 220);
            g_3_button_registrar_2.Name = "g_3_button_registrar_2";
            g_3_button_registrar_2.Size = new Size(94, 29);
            g_3_button_registrar_2.TabIndex = 8;
            g_3_button_registrar_2.Text = "Registrar";
            g_3_button_registrar_2.UseVisualStyleBackColor = true;
            g_3_button_registrar_2.Click += g_3_button_registrar_2_Click;
            // 
            // g_3_listview_2
            // 
            g_3_listview_2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader5, columnHeader6, g_3_direc, g_3_telf });
            g_3_listview_2.Location = new Point(343, 26);
            g_3_listview_2.Name = "g_3_listview_2";
            g_3_listview_2.Size = new Size(609, 201);
            g_3_listview_2.TabIndex = 10;
            g_3_listview_2.UseCompatibleStateImageBehavior = false;
            g_3_listview_2.View = View.Details;
            g_3_listview_2.SelectedIndexChanged += g_3_listview_2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mascota";
            columnHeader1.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Edad de la Mascota";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Raza de la Mascota";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Dueño";
            columnHeader6.Width = 100;
            // 
            // g_3_direc
            // 
            g_3_direc.Text = "Direccion";
            g_3_direc.Width = 100;
            // 
            // g_3_telf
            // 
            g_3_telf.Text = "Telefono";
            g_3_telf.Width = 100;
            // 
            // g_3_dueño
            // 
            g_3_dueño.FormattingEnabled = true;
            g_3_dueño.Location = new Point(189, 172);
            g_3_dueño.Name = "g_3_dueño";
            g_3_dueño.Size = new Size(135, 28);
            g_3_dueño.TabIndex = 9;
            g_3_dueño.Text = "buscar";
            g_3_dueño.SelectedIndexChanged += g_3_dueño_SelectedIndexChanged;
            // 
            // g_3_raza_mascota
            // 
            g_3_raza_mascota.Location = new Point(189, 125);
            g_3_raza_mascota.Name = "g_3_raza_mascota";
            g_3_raza_mascota.Size = new Size(135, 27);
            g_3_raza_mascota.TabIndex = 8;
            // 
            // g_3_edad_mascota
            // 
            g_3_edad_mascota.Location = new Point(189, 79);
            g_3_edad_mascota.Name = "g_3_edad_mascota";
            g_3_edad_mascota.Size = new Size(135, 27);
            g_3_edad_mascota.TabIndex = 7;
            // 
            // g_3_nom_mascota
            // 
            g_3_nom_mascota.Location = new Point(189, 40);
            g_3_nom_mascota.Name = "g_3_nom_mascota";
            g_3_nom_mascota.Size = new Size(135, 27);
            g_3_nom_mascota.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 172);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 5;
            label7.Text = "Dueño :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 128);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 4;
            label6.Text = "Raza de la Mascota :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 82);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 3;
            label5.Text = "Edad de la Mascota :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 40);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre de la Mascota :";
            // 
            // g_3_button_buscar
            // 
            g_3_button_buscar.Location = new Point(383, 275);
            g_3_button_buscar.Name = "g_3_button_buscar";
            g_3_button_buscar.Size = new Size(94, 29);
            g_3_button_buscar.TabIndex = 9;
            g_3_button_buscar.Text = "Buscar";
            g_3_button_buscar.UseVisualStyleBackColor = true;
            g_3_button_buscar.Click += g_3_button_buscar_Click;
            // 
            // g_3_Buscar
            // 
            g_3_Buscar.Location = new Point(81, 275);
            g_3_Buscar.Name = "g_3_Buscar";
            g_3_Buscar.Size = new Size(241, 27);
            g_3_Buscar.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 612);
            Controls.Add(g_3_Buscar);
            Controls.Add(g_3_button_buscar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox g_3_telefono;
        private TextBox g_3_Direccion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox g_3_nombreD;
        private GroupBox groupBox2;
        private ComboBox g_3_dueño;
        private TextBox g_3_raza_mascota;
        private TextBox g_3_edad_mascota;
        private TextBox g_3_nom_mascota;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button g_3_button_regsitrar_1;
        private ListView g_3_listview;
        private Button g_3_button_registrar_2;
        private ListView g_3_listview_2;
        private Button g_3_button_buscar;
        private TextBox g_3_Buscar;
        private ColumnHeader Dueño;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader g_3_direc;
        private ColumnHeader g_3_telf;
    }
}