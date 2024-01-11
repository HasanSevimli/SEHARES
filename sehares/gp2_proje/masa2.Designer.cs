namespace gp2_proje
{
    partial class masa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa2));
            masa2label = new Label();
            cikis = new Button();
            masa2siparis = new DataGridView();
            menu_masa2 = new DataGridView();
            baslangic = new Button();
            arasicak = new Button();
            icecek = new Button();
            anayemek = new Button();
            button1 = new Button();
            odeme_kapat = new Button();
            odeme = new Button();
            iptal = new Button();
            ((System.ComponentModel.ISupportInitialize)masa2siparis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_masa2).BeginInit();
            SuspendLayout();
            // 
            // masa2label
            // 
            masa2label.AutoSize = true;
            masa2label.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            masa2label.Location = new Point(489, 9);
            masa2label.Name = "masa2label";
            masa2label.Size = new Size(95, 34);
            masa2label.TabIndex = 0;
            masa2label.Text = "MASA 2";
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
            cikis.TabIndex = 1;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // masa2siparis
            // 
            masa2siparis.AllowUserToAddRows = false;
            masa2siparis.AllowUserToDeleteRows = false;
            masa2siparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masa2siparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masa2siparis.Location = new Point(84, 87);
            masa2siparis.Name = "masa2siparis";
            masa2siparis.ReadOnly = true;
            masa2siparis.RowTemplate.Height = 25;
            masa2siparis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masa2siparis.Size = new Size(388, 274);
            masa2siparis.TabIndex = 2;
            // 
            // menu_masa2
            // 
            menu_masa2.AllowUserToAddRows = false;
            menu_masa2.AllowUserToDeleteRows = false;
            menu_masa2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menu_masa2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu_masa2.Location = new Point(637, 87);
            menu_masa2.Name = "menu_masa2";
            menu_masa2.ReadOnly = true;
            menu_masa2.RowTemplate.Height = 25;
            menu_masa2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menu_masa2.Size = new Size(388, 274);
            menu_masa2.TabIndex = 3;
            // 
            // baslangic
            // 
            baslangic.BackColor = Color.Turquoise;
            baslangic.FlatAppearance.BorderSize = 3;
            baslangic.FlatStyle = FlatStyle.Flat;
            baslangic.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            baslangic.Location = new Point(478, 87);
            baslangic.Name = "baslangic";
            baslangic.Size = new Size(153, 64);
            baslangic.TabIndex = 4;
            baslangic.Text = "BAŞLANGIÇ";
            baslangic.UseVisualStyleBackColor = false;
            baslangic.Click += baslangic_Click;
            // 
            // arasicak
            // 
            arasicak.BackColor = Color.Turquoise;
            arasicak.FlatAppearance.BorderSize = 3;
            arasicak.FlatStyle = FlatStyle.Flat;
            arasicak.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            arasicak.Location = new Point(478, 157);
            arasicak.Name = "arasicak";
            arasicak.Size = new Size(153, 64);
            arasicak.TabIndex = 5;
            arasicak.Text = "ARA SICAK";
            arasicak.UseVisualStyleBackColor = false;
            arasicak.Click += arasicak_Click;
            // 
            // icecek
            // 
            icecek.BackColor = Color.Turquoise;
            icecek.FlatAppearance.BorderSize = 3;
            icecek.FlatStyle = FlatStyle.Flat;
            icecek.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            icecek.Location = new Point(478, 297);
            icecek.Name = "icecek";
            icecek.Size = new Size(153, 64);
            icecek.TabIndex = 6;
            icecek.Text = "İÇECEKLER";
            icecek.UseVisualStyleBackColor = false;
            icecek.Click += icecek_Click;
            // 
            // anayemek
            // 
            anayemek.BackColor = Color.Turquoise;
            anayemek.FlatAppearance.BorderSize = 3;
            anayemek.FlatStyle = FlatStyle.Flat;
            anayemek.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            anayemek.Location = new Point(478, 227);
            anayemek.Name = "anayemek";
            anayemek.Size = new Size(153, 64);
            anayemek.TabIndex = 7;
            anayemek.Text = "ANA YEMEK";
            anayemek.UseVisualStyleBackColor = false;
            anayemek.Click += anayemek_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(637, 367);
            button1.Name = "button1";
            button1.Size = new Size(388, 64);
            button1.TabIndex = 8;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // odeme_kapat
            // 
            odeme_kapat.BackColor = Color.Red;
            odeme_kapat.FlatAppearance.BorderSize = 3;
            odeme_kapat.FlatStyle = FlatStyle.Flat;
            odeme_kapat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            odeme_kapat.Location = new Point(282, 367);
            odeme_kapat.Name = "odeme_kapat";
            odeme_kapat.Size = new Size(190, 64);
            odeme_kapat.TabIndex = 9;
            odeme_kapat.Text = "KAPAT";
            odeme_kapat.UseVisualStyleBackColor = false;
            odeme_kapat.Click += odeme_kapat_Click;
            // 
            // odeme
            // 
            odeme.BackColor = Color.FromArgb(224, 224, 224);
            odeme.FlatAppearance.BorderSize = 3;
            odeme.FlatStyle = FlatStyle.Flat;
            odeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            odeme.Location = new Point(84, 367);
            odeme.Name = "odeme";
            odeme.Size = new Size(190, 64);
            odeme.TabIndex = 10;
            odeme.Text = "ÖDEME";
            odeme.UseVisualStyleBackColor = false;
            odeme.Click += odeme_Click;
            // 
            // iptal
            // 
            iptal.BackColor = Color.FromArgb(224, 224, 224);
            iptal.FlatAppearance.BorderSize = 3;
            iptal.FlatStyle = FlatStyle.Flat;
            iptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iptal.Location = new Point(12, 87);
            iptal.Name = "iptal";
            iptal.Size = new Size(66, 66);
            iptal.TabIndex = 12;
            iptal.Text = "İPTAL";
            iptal.UseVisualStyleBackColor = false;
            iptal.Click += iptal_Click;
            // 
            // masa2
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
            Controls.Add(menu_masa2);
            Controls.Add(masa2siparis);
            Controls.Add(cikis);
            Controls.Add(masa2label);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)masa2siparis).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_masa2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label masa2label;
        private Button cikis;
        private DataGridView masa2siparis;
        private DataGridView menu_masa2;
        private Button baslangic;
        private Button arasicak;
        private Button icecek;
        private Button anayemek;
        private Button button1;
        private Button odeme_kapat;
        private Button odeme;
        private Button iptal;
    }
}