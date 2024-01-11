namespace gp2_proje
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            cikis = new Button();
            siparis_duzenle = new Button();
            rezervasyon_duzenle = new Button();
            button4 = new Button();
            restoflex = new Label();
            SuspendLayout();
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 2;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cikis.Location = new Point(545, 325);
            cikis.Name = "cikis";
            cikis.Size = new Size(173, 163);
            cikis.TabIndex = 0;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // siparis_duzenle
            // 
            siparis_duzenle.BackColor = Color.FromArgb(224, 224, 224);
            siparis_duzenle.FlatAppearance.BorderSize = 2;
            siparis_duzenle.FlatStyle = FlatStyle.Flat;
            siparis_duzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            siparis_duzenle.Location = new Point(231, 180);
            siparis_duzenle.Name = "siparis_duzenle";
            siparis_duzenle.Size = new Size(487, 139);
            siparis_duzenle.TabIndex = 1;
            siparis_duzenle.Text = "SİPARİŞ";
            siparis_duzenle.UseVisualStyleBackColor = false;
            siparis_duzenle.Click += siparis_duzenle_Click;
            // 
            // rezervasyon_duzenle
            // 
            rezervasyon_duzenle.BackColor = Color.FromArgb(224, 224, 224);
            rezervasyon_duzenle.FlatAppearance.BorderSize = 2;
            rezervasyon_duzenle.FlatStyle = FlatStyle.Flat;
            rezervasyon_duzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rezervasyon_duzenle.Location = new Point(231, 325);
            rezervasyon_duzenle.Name = "rezervasyon_duzenle";
            rezervasyon_duzenle.Size = new Size(308, 163);
            rezervasyon_duzenle.TabIndex = 2;
            rezervasyon_duzenle.Text = "REZERVASYON";
            rezervasyon_duzenle.UseVisualStyleBackColor = false;
            rezervasyon_duzenle.Click += rezervasyon_duzenle_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(896, 12);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 3;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // restoflex
            // 
            restoflex.AutoSize = true;
            restoflex.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            restoflex.Location = new Point(367, 12);
            restoflex.Name = "restoflex";
            restoflex.Size = new Size(200, 60);
            restoflex.TabIndex = 4;
            restoflex.Text = "SeHaRes";
            restoflex.Click += label1_Click;
            // 
            // personel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(928, 613);
            Controls.Add(restoflex);
            Controls.Add(button4);
            Controls.Add(rezervasyon_duzenle);
            Controls.Add(siparis_duzenle);
            Controls.Add(cikis);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "personel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form11";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikis;
        private Button siparis_duzenle;
        private Button rezervasyon_duzenle;
        private Button button4;
        private Label restoflex;
    }
}