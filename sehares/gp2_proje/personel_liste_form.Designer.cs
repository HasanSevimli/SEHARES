namespace gp2_proje
{
    partial class personel_liste_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_liste_form));
            button17 = new Button();
            label1 = new Label();
            personel_ekle = new Button();
            back3 = new Button();
            personel_ana_liste = new DataGridView();
            eski_personel_gor = new Button();
            personel_gor = new Button();
            kaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)personel_ana_liste).BeginInit();
            SuspendLayout();
            // 
            // button17
            // 
            button17.BackColor = Color.Red;
            button17.Cursor = Cursors.Hand;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ImeMode = ImeMode.NoControl;
            button17.Location = new Point(768, 12);
            button17.Name = "button17";
            button17.Size = new Size(20, 20);
            button17.TabIndex = 25;
            button17.Text = "X";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 32, 34);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(315, 12);
            label1.Name = "label1";
            label1.Size = new Size(202, 34);
            label1.TabIndex = 52;
            label1.Text = "PERSONEL LİSTESİ";
            // 
            // personel_ekle
            // 
            personel_ekle.BackColor = Color.Turquoise;
            personel_ekle.Cursor = Cursors.Hand;
            personel_ekle.FlatAppearance.BorderSize = 3;
            personel_ekle.FlatStyle = FlatStyle.Flat;
            personel_ekle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            personel_ekle.ForeColor = Color.FromArgb(30, 32, 34);
            personel_ekle.ImeMode = ImeMode.NoControl;
            personel_ekle.Location = new Point(138, 407);
            personel_ekle.Name = "personel_ekle";
            personel_ekle.Size = new Size(201, 45);
            personel_ekle.TabIndex = 53;
            personel_ekle.Text = "PERSONEL BİLGİ İŞLEMLERİ";
            personel_ekle.UseVisualStyleBackColor = false;
            personel_ekle.Click += button20_Click;
            // 
            // back3
            // 
            back3.BackColor = Color.FromArgb(171, 206, 207);
            back3.Cursor = Cursors.Hand;
            back3.FlatAppearance.BorderSize = 3;
            back3.FlatStyle = FlatStyle.Flat;
            back3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back3.ForeColor = Color.Black;
            back3.ImeMode = ImeMode.NoControl;
            back3.Location = new Point(12, 467);
            back3.Name = "back3";
            back3.Size = new Size(33, 32);
            back3.TabIndex = 56;
            back3.Text = "<-";
            back3.UseVisualStyleBackColor = false;
            back3.Click += back3_Click;
            // 
            // personel_ana_liste
            // 
            personel_ana_liste.AllowUserToAddRows = false;
            personel_ana_liste.AllowUserToDeleteRows = false;
            personel_ana_liste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personel_ana_liste.Location = new Point(138, 59);
            personel_ana_liste.Name = "personel_ana_liste";
            personel_ana_liste.ReadOnly = true;
            personel_ana_liste.RowTemplate.Height = 25;
            personel_ana_liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personel_ana_liste.Size = new Size(552, 342);
            personel_ana_liste.TabIndex = 57;
            personel_ana_liste.CellContentClick += personel_ana_liste_CellContentClick;
            personel_ana_liste.CellEnter += dataGridView1_CellEnter;
            // 
            // eski_personel_gor
            // 
            eski_personel_gor.BackColor = Color.Turquoise;
            eski_personel_gor.Cursor = Cursors.Hand;
            eski_personel_gor.FlatAppearance.BorderSize = 3;
            eski_personel_gor.FlatStyle = FlatStyle.Flat;
            eski_personel_gor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            eski_personel_gor.ForeColor = Color.FromArgb(30, 32, 34);
            eski_personel_gor.ImeMode = ImeMode.NoControl;
            eski_personel_gor.Location = new Point(469, 407);
            eski_personel_gor.Name = "eski_personel_gor";
            eski_personel_gor.Size = new Size(136, 45);
            eski_personel_gor.TabIndex = 58;
            eski_personel_gor.Text = "ESKİ PERSONELLERİ GÖRÜNTÜLE";
            eski_personel_gor.UseVisualStyleBackColor = false;
            eski_personel_gor.Click += eski_personel_gor_Click;
            // 
            // personel_gor
            // 
            personel_gor.BackColor = Color.Turquoise;
            personel_gor.Cursor = Cursors.Hand;
            personel_gor.FlatAppearance.BorderSize = 3;
            personel_gor.FlatStyle = FlatStyle.Flat;
            personel_gor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            personel_gor.ForeColor = Color.FromArgb(30, 32, 34);
            personel_gor.ImeMode = ImeMode.NoControl;
            personel_gor.Location = new Point(345, 407);
            personel_gor.Name = "personel_gor";
            personel_gor.Size = new Size(118, 45);
            personel_gor.TabIndex = 59;
            personel_gor.Text = "PERSONELLERİ GÖRÜNTÜLE";
            personel_gor.UseVisualStyleBackColor = false;
            personel_gor.Click += personel_gor_Click;
            // 
            // kaydet
            // 
            kaydet.BackColor = Color.Green;
            kaydet.Cursor = Cursors.Hand;
            kaydet.FlatStyle = FlatStyle.Flat;
            kaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kaydet.ForeColor = Color.White;
            kaydet.ImeMode = ImeMode.NoControl;
            kaydet.Location = new Point(611, 407);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(79, 45);
            kaydet.TabIndex = 60;
            kaydet.Text = "KAYDET";
            kaydet.UseVisualStyleBackColor = false;
            kaydet.Click += kaydet_Click;
            // 
            // personel_liste_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(800, 511);
            Controls.Add(kaydet);
            Controls.Add(personel_gor);
            Controls.Add(eski_personel_gor);
            Controls.Add(personel_ana_liste);
            Controls.Add(back3);
            Controls.Add(personel_ekle);
            Controls.Add(label1);
            Controls.Add(button17);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "personel_liste_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += personel_liste_form_Load;
            ((System.ComponentModel.ISupportInitialize)personel_ana_liste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button17;
        private Label label1;
        private Button personel_ekle;
        private Button back3;
        private DataGridView personel_ana_liste;
        private Button eski_personel_gor;
        private Button personel_gor;
        private Button kaydet;
    }
}