namespace gp2_proje
{
    partial class masa6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa6));
            iptal = new Button();
            odeme = new Button();
            odeme_kapat = new Button();
            button1 = new Button();
            anayemek = new Button();
            icecek = new Button();
            arasicak = new Button();
            baslangic = new Button();
            menu_masa6 = new DataGridView();
            masa6siparis = new DataGridView();
            cikis = new Button();
            masa6label = new Label();
            ((System.ComponentModel.ISupportInitialize)menu_masa6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masa6siparis).BeginInit();
            SuspendLayout();
            // 
            // iptal
            // 
            iptal.BackColor = Color.FromArgb(224, 224, 224);
            iptal.FlatAppearance.BorderSize = 3;
            iptal.FlatStyle = FlatStyle.Flat;
            iptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iptal.Location = new Point(13, 89);
            iptal.Name = "iptal";
            iptal.Size = new Size(66, 66);
            iptal.TabIndex = 64;
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
            odeme.Location = new Point(85, 369);
            odeme.Name = "odeme";
            odeme.Size = new Size(190, 64);
            odeme.TabIndex = 62;
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
            odeme_kapat.Location = new Point(283, 369);
            odeme_kapat.Name = "odeme_kapat";
            odeme_kapat.Size = new Size(190, 64);
            odeme_kapat.TabIndex = 61;
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
            button1.Location = new Point(638, 369);
            button1.Name = "button1";
            button1.Size = new Size(388, 64);
            button1.TabIndex = 60;
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
            anayemek.Location = new Point(479, 229);
            anayemek.Name = "anayemek";
            anayemek.Size = new Size(153, 64);
            anayemek.TabIndex = 59;
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
            icecek.Location = new Point(479, 299);
            icecek.Name = "icecek";
            icecek.Size = new Size(153, 64);
            icecek.TabIndex = 58;
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
            arasicak.Location = new Point(479, 159);
            arasicak.Name = "arasicak";
            arasicak.Size = new Size(153, 64);
            arasicak.TabIndex = 57;
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
            baslangic.Location = new Point(479, 89);
            baslangic.Name = "baslangic";
            baslangic.Size = new Size(153, 64);
            baslangic.TabIndex = 56;
            baslangic.Text = "BAŞLANGIÇ";
            baslangic.UseVisualStyleBackColor = false;
            baslangic.Click += baslangic_Click;
            // 
            // menu_masa6
            // 
            menu_masa6.AllowUserToAddRows = false;
            menu_masa6.AllowUserToDeleteRows = false;
            menu_masa6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menu_masa6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu_masa6.Location = new Point(638, 89);
            menu_masa6.Name = "menu_masa6";
            menu_masa6.ReadOnly = true;
            menu_masa6.RowTemplate.Height = 25;
            menu_masa6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menu_masa6.Size = new Size(388, 274);
            menu_masa6.TabIndex = 55;
            // 
            // masa6siparis
            // 
            masa6siparis.AllowUserToAddRows = false;
            masa6siparis.AllowUserToDeleteRows = false;
            masa6siparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masa6siparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masa6siparis.Location = new Point(85, 89);
            masa6siparis.Name = "masa6siparis";
            masa6siparis.ReadOnly = true;
            masa6siparis.RowTemplate.Height = 25;
            masa6siparis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masa6siparis.Size = new Size(388, 274);
            masa6siparis.TabIndex = 54;
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikis.Location = new Point(1034, 12);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 53;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // masa6label
            // 
            masa6label.AutoSize = true;
            masa6label.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            masa6label.Location = new Point(494, 9);
            masa6label.Name = "masa6label";
            masa6label.Size = new Size(96, 34);
            masa6label.TabIndex = 52;
            masa6label.Text = "MASA 6";
            // 
            // masa6
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
            Controls.Add(menu_masa6);
            Controls.Add(masa6siparis);
            Controls.Add(cikis);
            Controls.Add(masa6label);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "masa6";
            Load += masa6_Load;
            ((System.ComponentModel.ISupportInitialize)menu_masa6).EndInit();
            ((System.ComponentModel.ISupportInitialize)masa6siparis).EndInit();
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
        private DataGridView menu_masa6;
        private DataGridView masa6siparis;
        private Button cikis;
        private Label masa6label;
    }
}