namespace gp2_proje
{
    partial class menu_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_duzenle));
            cikis = new Button();
            back = new Button();
            urunID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            urun_id_giris = new TextBox();
            urun_adi_giris = new TextBox();
            urun_fiyat_giris = new TextBox();
            menu_duzenleme_baslik = new Label();
            menu_data = new DataGridView();
            menu_ekle = new Button();
            menu_guncelle = new Button();
            menu_kaldır = new Button();
            urun_tipi_giris = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)menu_data).BeginInit();
            SuspendLayout();
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Location = new Point(768, 12);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 0;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // back
            // 
            back.BackColor = Color.Turquoise;
            back.FlatAppearance.BorderSize = 3;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(12, 467);
            back.Name = "back";
            back.Size = new Size(33, 32);
            back.TabIndex = 1;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // urunID
            // 
            urunID.AutoSize = true;
            urunID.Location = new Point(297, 80);
            urunID.Name = "urunID";
            urunID.Size = new Size(23, 15);
            urunID.TabIndex = 2;
            urunID.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Urun Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 80);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Urun Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 108);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Urun Tipi:";
            // 
            // urun_id_giris
            // 
            urun_id_giris.Enabled = false;
            urun_id_giris.Location = new Point(326, 77);
            urun_id_giris.Name = "urun_id_giris";
            urun_id_giris.Size = new Size(53, 23);
            urun_id_giris.TabIndex = 6;
            // 
            // urun_adi_giris
            // 
            urun_adi_giris.Location = new Point(222, 106);
            urun_adi_giris.Name = "urun_adi_giris";
            urun_adi_giris.Size = new Size(157, 23);
            urun_adi_giris.TabIndex = 7;
            // 
            // urun_fiyat_giris
            // 
            urun_fiyat_giris.Location = new Point(475, 77);
            urun_fiyat_giris.Name = "urun_fiyat_giris";
            urun_fiyat_giris.Size = new Size(142, 23);
            urun_fiyat_giris.TabIndex = 8;
            // 
            // menu_duzenleme_baslik
            // 
            menu_duzenleme_baslik.AutoSize = true;
            menu_duzenleme_baslik.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            menu_duzenleme_baslik.Location = new Point(259, 12);
            menu_duzenleme_baslik.Name = "menu_duzenleme_baslik";
            menu_duzenleme_baslik.Size = new Size(298, 34);
            menu_duzenleme_baslik.TabIndex = 10;
            menu_duzenleme_baslik.Text = "MENU DUZENLEME İŞLMLERİ";
            // 
            // menu_data
            // 
            menu_data.AllowUserToAddRows = false;
            menu_data.AllowUserToDeleteRows = false;
            menu_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menu_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu_data.Location = new Point(157, 135);
            menu_data.Name = "menu_data";
            menu_data.ReadOnly = true;
            menu_data.RowTemplate.Height = 25;
            menu_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menu_data.Size = new Size(460, 272);
            menu_data.TabIndex = 11;
            menu_data.CellContentClick += menu_data_CellContentClick;
            menu_data.CellEnter += menu_data_CellEnter;
            // 
            // menu_ekle
            // 
            menu_ekle.BackColor = Color.Turquoise;
            menu_ekle.FlatAppearance.BorderSize = 2;
            menu_ekle.FlatStyle = FlatStyle.Flat;
            menu_ekle.Location = new Point(326, 413);
            menu_ekle.Name = "menu_ekle";
            menu_ekle.Size = new Size(93, 46);
            menu_ekle.TabIndex = 12;
            menu_ekle.Text = "EKLE";
            menu_ekle.UseVisualStyleBackColor = false;
            menu_ekle.Click += menu_ekle_Click;
            // 
            // menu_guncelle
            // 
            menu_guncelle.BackColor = Color.Turquoise;
            menu_guncelle.FlatAppearance.BorderSize = 2;
            menu_guncelle.FlatStyle = FlatStyle.Flat;
            menu_guncelle.Location = new Point(425, 413);
            menu_guncelle.Name = "menu_guncelle";
            menu_guncelle.Size = new Size(93, 46);
            menu_guncelle.TabIndex = 13;
            menu_guncelle.Text = "GÜNCELLE";
            menu_guncelle.UseVisualStyleBackColor = false;
            menu_guncelle.Click += menu_guncelle_Click;
            // 
            // menu_kaldır
            // 
            menu_kaldır.BackColor = Color.Red;
            menu_kaldır.FlatAppearance.BorderSize = 2;
            menu_kaldır.FlatStyle = FlatStyle.Flat;
            menu_kaldır.Location = new Point(524, 413);
            menu_kaldır.Name = "menu_kaldır";
            menu_kaldır.Size = new Size(93, 46);
            menu_kaldır.TabIndex = 14;
            menu_kaldır.Text = "KALDIR";
            menu_kaldır.UseVisualStyleBackColor = false;
            menu_kaldır.Click += menu_kaldır_Click;
            // 
            // urun_tipi_giris
            // 
            urun_tipi_giris.FormattingEnabled = true;
            urun_tipi_giris.Items.AddRange(new object[] { "İçecek", "Başlangıç", "Ara Sıcak", "Ana Yemek" });
            urun_tipi_giris.Location = new Point(475, 105);
            urun_tipi_giris.Name = "urun_tipi_giris";
            urun_tipi_giris.Size = new Size(142, 23);
            urun_tipi_giris.TabIndex = 15;
            // 
            // menu_duzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(800, 511);
            Controls.Add(urun_tipi_giris);
            Controls.Add(menu_kaldır);
            Controls.Add(menu_guncelle);
            Controls.Add(menu_ekle);
            Controls.Add(menu_data);
            Controls.Add(menu_duzenleme_baslik);
            Controls.Add(urun_fiyat_giris);
            Controls.Add(urun_adi_giris);
            Controls.Add(urun_id_giris);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(urunID);
            Controls.Add(back);
            Controls.Add(cikis);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menu_duzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form13";
            Load += menu_duzenle_Load;
            ((System.ComponentModel.ISupportInitialize)menu_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikis;
        private Button back;
        private Label urunID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox urun_id_giris;
        private TextBox urun_adi_giris;
        private TextBox urun_fiyat_giris;
        private Label menu_duzenleme_baslik;
        private DataGridView menu_data;
        private Button menu_ekle;
        private Button menu_guncelle;
        private Button menu_kaldır;
        private ComboBox urun_tipi_giris;
    }
}