namespace gp2_proje
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            cikis = new Button();
            ciro_giris = new Button();
            personel = new Button();
            admin_cikis = new Button();
            menu_duzenle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikis.Location = new Point(896, 12);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 0;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // ciro_giris
            // 
            ciro_giris.BackColor = Color.FromArgb(224, 224, 224);
            ciro_giris.FlatAppearance.BorderSize = 2;
            ciro_giris.FlatStyle = FlatStyle.Flat;
            ciro_giris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ciro_giris.Location = new Point(204, 195);
            ciro_giris.Name = "ciro_giris";
            ciro_giris.Size = new Size(522, 123);
            ciro_giris.TabIndex = 2;
            ciro_giris.Text = "CİRO";
            ciro_giris.UseVisualStyleBackColor = false;
            ciro_giris.Click += ciro_giris_Click;
            // 
            // personel
            // 
            personel.BackColor = Color.FromArgb(224, 224, 224);
            personel.FlatAppearance.BorderSize = 2;
            personel.FlatStyle = FlatStyle.Flat;
            personel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            personel.Location = new Point(204, 324);
            personel.Name = "personel";
            personel.Size = new Size(170, 170);
            personel.TabIndex = 3;
            personel.Text = "PERSONEL";
            personel.UseVisualStyleBackColor = false;
            personel.Click += personel_Click;
            // 
            // admin_cikis
            // 
            admin_cikis.BackColor = Color.Red;
            admin_cikis.FlatAppearance.BorderSize = 2;
            admin_cikis.FlatStyle = FlatStyle.Flat;
            admin_cikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            admin_cikis.Location = new Point(556, 324);
            admin_cikis.Name = "admin_cikis";
            admin_cikis.Size = new Size(170, 170);
            admin_cikis.TabIndex = 4;
            admin_cikis.Text = "CIKIŞ";
            admin_cikis.UseVisualStyleBackColor = false;
            admin_cikis.Click += admin_cikis_Click;
            // 
            // menu_duzenle
            // 
            menu_duzenle.BackColor = Color.FromArgb(224, 224, 224);
            menu_duzenle.FlatAppearance.BorderSize = 2;
            menu_duzenle.FlatStyle = FlatStyle.Flat;
            menu_duzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menu_duzenle.Location = new Point(380, 324);
            menu_duzenle.Name = "menu_duzenle";
            menu_duzenle.Size = new Size(170, 170);
            menu_duzenle.TabIndex = 5;
            menu_duzenle.Text = "MENU";
            menu_duzenle.UseVisualStyleBackColor = false;
            menu_duzenle.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 12);
            label1.Name = "label1";
            label1.Size = new Size(333, 60);
            label1.TabIndex = 7;
            label1.Text = "SeHaRes ADMİN";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(928, 613);
            Controls.Add(label1);
            Controls.Add(menu_duzenle);
            Controls.Add(admin_cikis);
            Controls.Add(personel);
            Controls.Add(ciro_giris);
            Controls.Add(cikis);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminanasayfa";
            Load += admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikis;
        private Button ciro_giris;
        private Button personel;
        private Button admin_cikis;
        private Button menu_duzenle;
        private Label label1;
    }
}