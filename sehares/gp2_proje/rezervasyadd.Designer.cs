namespace gp2_proje
{
    partial class rezervasyadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyadd));
            button1 = new Button();
            ad = new TextBox();
            soyad = new TextBox();
            telefon = new TextBox();
            adi = new Label();
            tel = new Label();
            soyadi = new Label();
            rezervasyonlabel = new Label();
            masano = new ComboBox();
            label1 = new Label();
            rezervasyon_liste = new DataGridView();
            back2 = new Button();
            cikis = new Button();
            saat = new DateTimePicker();
            label2 = new Label();
            kaldir = new Button();
            guncelle = new Button();
            tarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)rezervasyon_liste).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(73, 245);
            button1.Name = "button1";
            button1.Size = new Size(79, 50);
            button1.TabIndex = 0;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ad
            // 
            ad.Location = new Point(180, 70);
            ad.Name = "ad";
            ad.Size = new Size(145, 23);
            ad.TabIndex = 1;
            // 
            // soyad
            // 
            soyad.Location = new Point(180, 99);
            soyad.Name = "soyad";
            soyad.Size = new Size(145, 23);
            soyad.TabIndex = 2;
            // 
            // telefon
            // 
            telefon.Location = new Point(180, 128);
            telefon.Name = "telefon";
            telefon.Size = new Size(145, 23);
            telefon.TabIndex = 3;
            // 
            // adi
            // 
            adi.AutoSize = true;
            adi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adi.Location = new Point(146, 73);
            adi.Name = "adi";
            adi.Size = new Size(28, 15);
            adi.TabIndex = 72;
            adi.Text = "Adı:";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tel.Location = new Point(122, 131);
            tel.Name = "tel";
            tel.Size = new Size(52, 15);
            tel.TabIndex = 74;
            tel.Text = "Telefon:";
            // 
            // soyadi
            // 
            soyadi.AutoSize = true;
            soyadi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            soyadi.Location = new Point(128, 102);
            soyadi.Name = "soyadi";
            soyadi.Size = new Size(46, 15);
            soyadi.TabIndex = 75;
            soyadi.Text = "Soyadı:";
            // 
            // rezervasyonlabel
            // 
            rezervasyonlabel.AutoSize = true;
            rezervasyonlabel.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rezervasyonlabel.Location = new Point(306, 9);
            rezervasyonlabel.Name = "rezervasyonlabel";
            rezervasyonlabel.Size = new Size(256, 34);
            rezervasyonlabel.TabIndex = 76;
            rezervasyonlabel.Text = "REZERVASYON DÜZENLE";
            // 
            // masano
            // 
            masano.DropDownStyle = ComboBoxStyle.DropDownList;
            masano.FormattingEnabled = true;
            masano.Items.AddRange(new object[] { "M1", "M2", "M3", "M4", "M5", "M6" });
            masano.Location = new Point(180, 156);
            masano.Name = "masano";
            masano.Size = new Size(145, 23);
            masano.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 159);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 78;
            label1.Text = "Masa Numarası:";
            // 
            // rezervasyon_liste
            // 
            rezervasyon_liste.AllowUserToAddRows = false;
            rezervasyon_liste.AllowUserToDeleteRows = false;
            rezervasyon_liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rezervasyon_liste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervasyon_liste.Location = new Point(331, 70);
            rezervasyon_liste.Name = "rezervasyon_liste";
            rezervasyon_liste.ReadOnly = true;
            rezervasyon_liste.RowTemplate.Height = 25;
            rezervasyon_liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezervasyon_liste.Size = new Size(476, 225);
            rezervasyon_liste.TabIndex = 79;
            rezervasyon_liste.CellEnter += rezervasyon_liste_CellEnter;
            // 
            // back2
            // 
            back2.BackColor = Color.White;
            back2.Cursor = Cursors.Hand;
            back2.FlatAppearance.BorderSize = 3;
            back2.FlatStyle = FlatStyle.Flat;
            back2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back2.ForeColor = Color.Black;
            back2.ImeMode = ImeMode.NoControl;
            back2.Location = new Point(12, 316);
            back2.Name = "back2";
            back2.Size = new Size(33, 32);
            back2.TabIndex = 80;
            back2.Text = "<-";
            back2.UseVisualStyleBackColor = false;
            back2.Click += back2_Click;
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikis.Location = new Point(802, 12);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 81;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // saat
            // 
            saat.Format = DateTimePickerFormat.Time;
            saat.Location = new Point(180, 216);
            saat.Name = "saat";
            saat.ShowUpDown = true;
            saat.Size = new Size(145, 23);
            saat.TabIndex = 82;
            saat.Value = new DateTime(2023, 12, 26, 19, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 205);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 83;
            label2.Text = "saat ve tarih:";
            // 
            // kaldir
            // 
            kaldir.BackColor = Color.Red;
            kaldir.FlatStyle = FlatStyle.Flat;
            kaldir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kaldir.Location = new Point(246, 245);
            kaldir.Name = "kaldir";
            kaldir.Size = new Size(79, 50);
            kaldir.TabIndex = 84;
            kaldir.Text = "KALDIR";
            kaldir.UseVisualStyleBackColor = false;
            kaldir.Click += kaldir_Click;
            // 
            // guncelle
            // 
            guncelle.BackColor = Color.Turquoise;
            guncelle.FlatStyle = FlatStyle.Flat;
            guncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guncelle.Location = new Point(158, 245);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(82, 50);
            guncelle.TabIndex = 85;
            guncelle.Text = "GÜNCELLE";
            guncelle.UseVisualStyleBackColor = false;
            guncelle.Click += guncelle_Click;
            // 
            // tarih
            // 
            tarih.Location = new Point(180, 187);
            tarih.Name = "tarih";
            tarih.Size = new Size(145, 23);
            tarih.TabIndex = 86;
            // 
            // rezervasyadd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(834, 360);
            Controls.Add(tarih);
            Controls.Add(guncelle);
            Controls.Add(kaldir);
            Controls.Add(label2);
            Controls.Add(saat);
            Controls.Add(cikis);
            Controls.Add(back2);
            Controls.Add(rezervasyon_liste);
            Controls.Add(label1);
            Controls.Add(masano);
            Controls.Add(rezervasyonlabel);
            Controls.Add(soyadi);
            Controls.Add(tel);
            Controls.Add(adi);
            Controls.Add(telefon);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rezervasyadd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rezervasyadd";
            Load += rezervasyadd_Load;
            ((System.ComponentModel.ISupportInitialize)rezervasyon_liste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ad;
        private TextBox soyad;
        private TextBox telefon;
        private Label adi;
        private Label tel;
        private Label soyadi;
        private Label rezervasyonlabel;
        private ComboBox masano;
        private Label label1;
        private DataGridView rezervasyon_liste;
        private Button back2;
        private Button cikis;
        private DateTimePicker saat;
        private Label label2;
        private Button kaldir;
        private Button guncelle;
        private DateTimePicker tarih;
    }
}