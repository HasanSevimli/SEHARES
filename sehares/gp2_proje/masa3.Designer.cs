namespace gp2_proje
{
    partial class masa3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa3));
            iptal = new Button();
            odeme = new Button();
            odeme_kapat = new Button();
            button1 = new Button();
            anayemek = new Button();
            icecek = new Button();
            arasicak = new Button();
            baslangic = new Button();
            menu_masa3 = new DataGridView();
            masa3siparis = new DataGridView();
            cikis = new Button();
            masa3label = new Label();
            ((System.ComponentModel.ISupportInitialize)menu_masa3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masa3siparis).BeginInit();
            SuspendLayout();
            // 
            // iptal
            // 
            iptal.BackColor = Color.FromArgb(224, 224, 224);
            iptal.FlatAppearance.BorderSize = 3;
            iptal.FlatStyle = FlatStyle.Flat;
            iptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iptal.Location = new Point(12, 88);
            iptal.Name = "iptal";
            iptal.Size = new Size(66, 66);
            iptal.TabIndex = 25;
            iptal.Text = "İPTAL";
            iptal.UseVisualStyleBackColor = false;
            iptal.Click += iptal_Click;
            // 
            // odeme
            // 
            odeme.BackColor = Color.FromArgb(224, 224, 224);
            odeme.FlatAppearance.BorderSize = 3;
            odeme.FlatStyle = FlatStyle.Flat;
            odeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            odeme.Location = new Point(84, 368);
            odeme.Name = "odeme";
            odeme.Size = new Size(190, 64);
            odeme.TabIndex = 23;
            odeme.Text = "ÖDEME";
            odeme.UseVisualStyleBackColor = false;
            odeme.Click += odeme_Click;
            // 
            // odeme_kapat
            // 
            odeme_kapat.BackColor = Color.Red;
            odeme_kapat.FlatAppearance.BorderSize = 3;
            odeme_kapat.FlatStyle = FlatStyle.Flat;
            odeme_kapat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            odeme_kapat.Location = new Point(282, 368);
            odeme_kapat.Name = "odeme_kapat";
            odeme_kapat.Size = new Size(190, 64);
            odeme_kapat.TabIndex = 22;
            odeme_kapat.Text = "KAPAT";
            odeme_kapat.UseVisualStyleBackColor = false;
            odeme_kapat.Click += odeme_kapat_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(637, 368);
            button1.Name = "button1";
            button1.Size = new Size(388, 64);
            button1.TabIndex = 21;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // anayemek
            // 
            anayemek.BackColor = Color.Turquoise;
            anayemek.FlatAppearance.BorderSize = 3;
            anayemek.FlatStyle = FlatStyle.Flat;
            anayemek.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            anayemek.Location = new Point(478, 228);
            anayemek.Name = "anayemek";
            anayemek.Size = new Size(153, 64);
            anayemek.TabIndex = 20;
            anayemek.Text = "ANA YEMEK";
            anayemek.UseVisualStyleBackColor = false;
            anayemek.Click += anayemek_Click;
            // 
            // icecek
            // 
            icecek.BackColor = Color.Turquoise;
            icecek.FlatAppearance.BorderSize = 3;
            icecek.FlatStyle = FlatStyle.Flat;
            icecek.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            icecek.Location = new Point(478, 298);
            icecek.Name = "icecek";
            icecek.Size = new Size(153, 64);
            icecek.TabIndex = 19;
            icecek.Text = "İÇECEKLER";
            icecek.UseVisualStyleBackColor = false;
            icecek.Click += icecek_Click;
            // 
            // arasicak
            // 
            arasicak.BackColor = Color.Turquoise;
            arasicak.FlatAppearance.BorderSize = 3;
            arasicak.FlatStyle = FlatStyle.Flat;
            arasicak.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            arasicak.Location = new Point(478, 158);
            arasicak.Name = "arasicak";
            arasicak.Size = new Size(153, 64);
            arasicak.TabIndex = 18;
            arasicak.Text = "ARA SICAK";
            arasicak.UseVisualStyleBackColor = false;
            arasicak.Click += arasicak_Click;
            // 
            // baslangic
            // 
            baslangic.BackColor = Color.Turquoise;
            baslangic.FlatAppearance.BorderSize = 3;
            baslangic.FlatStyle = FlatStyle.Flat;
            baslangic.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            baslangic.Location = new Point(478, 88);
            baslangic.Name = "baslangic";
            baslangic.Size = new Size(153, 64);
            baslangic.TabIndex = 17;
            baslangic.Text = "BAŞLANGIÇ";
            baslangic.UseVisualStyleBackColor = false;
            baslangic.Click += baslangic_Click;
            // 
            // menu_masa3
            // 
            menu_masa3.AllowUserToAddRows = false;
            menu_masa3.AllowUserToDeleteRows = false;
            menu_masa3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menu_masa3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu_masa3.Location = new Point(637, 88);
            menu_masa3.Name = "menu_masa3";
            menu_masa3.ReadOnly = true;
            menu_masa3.RowTemplate.Height = 25;
            menu_masa3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menu_masa3.Size = new Size(388, 274);
            menu_masa3.TabIndex = 16;
            menu_masa3.CellContentClick += menu_masa3_CellContentClick;
            // 
            // masa3siparis
            // 
            masa3siparis.AllowUserToAddRows = false;
            masa3siparis.AllowUserToDeleteRows = false;
            masa3siparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masa3siparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masa3siparis.Location = new Point(84, 88);
            masa3siparis.Name = "masa3siparis";
            masa3siparis.ReadOnly = true;
            masa3siparis.RowTemplate.Height = 25;
            masa3siparis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masa3siparis.Size = new Size(388, 274);
            masa3siparis.TabIndex = 15;
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikis.Location = new Point(1034, 9);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 14;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // masa3label
            // 
            masa3label.AutoSize = true;
            masa3label.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            masa3label.Location = new Point(489, 9);
            masa3label.Name = "masa3label";
            masa3label.Size = new Size(95, 34);
            masa3label.TabIndex = 13;
            masa3label.Text = "MASA 3";
            // 
            // masa3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(1066, 473);
            Controls.Add(iptal);
            Controls.Add(odeme);
            Controls.Add(odeme_kapat);
            Controls.Add(button1);
            Controls.Add(anayemek);
            Controls.Add(icecek);
            Controls.Add(arasicak);
            Controls.Add(baslangic);
            Controls.Add(menu_masa3);
            Controls.Add(masa3siparis);
            Controls.Add(cikis);
            Controls.Add(masa3label);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "masa3";
            Load += masa3_Load;
            ((System.ComponentModel.ISupportInitialize)menu_masa3).EndInit();
            ((System.ComponentModel.ISupportInitialize)masa3siparis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iptal;
        private Button odeme;
        private Button odeme_kapat;
        private Button button1;
        private Button anayemek;
        private Button icecek;
        private Button arasicak;
        private Button baslangic;
        private DataGridView menu_masa3;
        private DataGridView masa3siparis;
        private Button cikis;
        private Label masa3label;
    }
}