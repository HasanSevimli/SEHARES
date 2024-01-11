namespace gp2_proje
{
    partial class personel_ekle_form
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
            Button personelekle;
            Label label1;
            Button guncelle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_ekle_form));
            back4 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            personel_liste = new DataGridView();
            personel_kaldir = new Button();
            tc = new TextBox();
            txtid = new TextBox();
            ad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            datetime = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            pass = new TextBox();
            label7 = new Label();
            email = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cinsiyet = new ComboBox();
            tel = new TextBox();
            label11 = new Label();
            id = new Label();
            soy = new TextBox();
            vardiyabas = new DateTimePicker();
            vardiyabit = new DateTimePicker();
            personelekle = new Button();
            label1 = new Label();
            guncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)personel_liste).BeginInit();
            SuspendLayout();
            // 
            // personelekle
            // 
            personelekle.BackColor = Color.FromArgb(171, 206, 207);
            personelekle.Cursor = Cursors.Hand;
            personelekle.FlatAppearance.BorderSize = 2;
            personelekle.FlatStyle = FlatStyle.Flat;
            personelekle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            personelekle.ForeColor = Color.FromArgb(30, 32, 34);
            personelekle.ImeMode = ImeMode.NoControl;
            personelekle.Location = new Point(353, 418);
            personelekle.Name = "personelekle";
            personelekle.Size = new Size(120, 63);
            personelekle.TabIndex = 62;
            personelekle.Text = "EKLE";
            personelekle.UseVisualStyleBackColor = false;
            personelekle.Click += personelekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 32, 34);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(276, 12);
            label1.Name = "label1";
            label1.Size = new Size(292, 34);
            label1.TabIndex = 61;
            label1.Text = "PERSONEL BİLGİ İŞLEMLERİ";
            // 
            // guncelle
            // 
            guncelle.BackColor = Color.FromArgb(171, 206, 207);
            guncelle.Cursor = Cursors.Hand;
            guncelle.FlatAppearance.BorderSize = 2;
            guncelle.FlatStyle = FlatStyle.Flat;
            guncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guncelle.ForeColor = Color.FromArgb(30, 32, 34);
            guncelle.ImeMode = ImeMode.NoControl;
            guncelle.Location = new Point(479, 418);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(120, 63);
            guncelle.TabIndex = 74;
            guncelle.Text = "GÜNCELLE";
            guncelle.UseVisualStyleBackColor = false;
            guncelle.Click += guncelle_Click;
            // 
            // back4
            // 
            back4.BackColor = Color.FromArgb(171, 206, 207);
            back4.Cursor = Cursors.Hand;
            back4.FlatAppearance.BorderSize = 2;
            back4.FlatStyle = FlatStyle.Flat;
            back4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back4.ForeColor = Color.Black;
            back4.ImeMode = ImeMode.NoControl;
            back4.Location = new Point(12, 467);
            back4.Name = "back4";
            back4.Size = new Size(33, 32);
            back4.TabIndex = 65;
            back4.Text = "<-";
            back4.UseVisualStyleBackColor = false;
            back4.Click += back4_Click;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderSize = 0;
            button15.ImeMode = ImeMode.NoControl;
            button15.Location = new Point(716, 12);
            button15.Name = "button15";
            button15.Size = new Size(20, 20);
            button15.TabIndex = 59;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderSize = 0;
            button16.ImeMode = ImeMode.NoControl;
            button16.Location = new Point(742, 12);
            button16.Name = "button16";
            button16.Size = new Size(20, 20);
            button16.TabIndex = 58;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Cursor = Cursors.Hand;
            button17.FlatAppearance.BorderSize = 0;
            button17.ImeMode = ImeMode.NoControl;
            button17.Location = new Point(768, 12);
            button17.Name = "button17";
            button17.Size = new Size(20, 20);
            button17.TabIndex = 57;
            button17.Text = "X";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // personel_liste
            // 
            personel_liste.AllowUserToAddRows = false;
            personel_liste.AllowUserToDeleteRows = false;
            personel_liste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personel_liste.Location = new Point(70, 215);
            personel_liste.Name = "personel_liste";
            personel_liste.ReadOnly = true;
            personel_liste.RowTemplate.Height = 25;
            personel_liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personel_liste.Size = new Size(655, 197);
            personel_liste.TabIndex = 72;
            personel_liste.CellContentClick += dataGridView1_CellContentClick;
            personel_liste.CellEnter += personel_liste_CellEnter;
            // 
            // personel_kaldir
            // 
            personel_kaldir.BackColor = Color.Red;
            personel_kaldir.FlatAppearance.BorderSize = 2;
            personel_kaldir.FlatStyle = FlatStyle.Flat;
            personel_kaldir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            personel_kaldir.Location = new Point(605, 418);
            personel_kaldir.Name = "personel_kaldir";
            personel_kaldir.Size = new Size(120, 63);
            personel_kaldir.TabIndex = 73;
            personel_kaldir.Text = "KALDIR";
            personel_kaldir.UseVisualStyleBackColor = false;
            personel_kaldir.Click += personel_kaldir_Click;
            // 
            // tc
            // 
            tc.Location = new Point(169, 120);
            tc.Name = "tc";
            tc.Size = new Size(199, 23);
            tc.TabIndex = 68;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(314, 62);
            txtid.Name = "txtid";
            txtid.Size = new Size(54, 23);
            txtid.TabIndex = 67;
            // 
            // ad
            // 
            ad.Location = new Point(169, 62);
            ad.Name = "ad";
            ad.Size = new Size(107, 23);
            ad.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(135, 65);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 71;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(117, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 72;
            label3.Text = "Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 123);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 73;
            label4.Text = "TC Kimlik No:";
            // 
            // datetime
            // 
            datetime.Location = new Point(169, 149);
            datetime.Name = "datetime";
            datetime.Size = new Size(199, 23);
            datetime.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(79, 152);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 75;
            label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(417, 152);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 77;
            label6.Text = "vardiya başlangıç:";
            // 
            // pass
            // 
            pass.Location = new Point(169, 178);
            pass.Name = "pass";
            pass.Size = new Size(199, 23);
            pass.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(126, 181);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 79;
            label7.Text = "Şifre:";
            // 
            // email
            // 
            email.Location = new Point(526, 120);
            email.Name = "email";
            email.Size = new Size(199, 23);
            email.TabIndex = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(471, 123);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 81;
            label8.Text = "E Posta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(467, 65);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 82;
            label9.Text = "Cinsiyet:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(444, 181);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 86;
            label10.Text = "vardiya bitiş:";
            // 
            // cinsiyet
            // 
            cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cinsiyet.FormattingEnabled = true;
            cinsiyet.Items.AddRange(new object[] { "erkek", "kadın" });
            cinsiyet.Location = new Point(526, 62);
            cinsiyet.Name = "cinsiyet";
            cinsiyet.Size = new Size(199, 23);
            cinsiyet.TabIndex = 72;
            // 
            // tel
            // 
            tel.Location = new Point(526, 91);
            tel.Name = "tel";
            tel.Size = new Size(199, 23);
            tel.TabIndex = 87;
            tel.TextChanged += tel_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(469, 94);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 88;
            label11.Text = "telefon:";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            id.Location = new Point(285, 65);
            id.Name = "id";
            id.Size = new Size(23, 15);
            id.TabIndex = 89;
            id.Text = "ID:";
            // 
            // soy
            // 
            soy.Location = new Point(169, 91);
            soy.Name = "soy";
            soy.Size = new Size(199, 23);
            soy.TabIndex = 90;
            // 
            // vardiyabas
            // 
            vardiyabas.Format = DateTimePickerFormat.Time;
            vardiyabas.Location = new Point(526, 149);
            vardiyabas.Name = "vardiyabas";
            vardiyabas.ShowUpDown = true;
            vardiyabas.Size = new Size(199, 23);
            vardiyabas.TabIndex = 91;
            // 
            // vardiyabit
            // 
            vardiyabit.Format = DateTimePickerFormat.Time;
            vardiyabit.Location = new Point(526, 178);
            vardiyabit.Name = "vardiyabit";
            vardiyabit.ShowUpDown = true;
            vardiyabit.Size = new Size(199, 23);
            vardiyabit.TabIndex = 92;
            // 
            // personel_ekle_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(800, 511);
            Controls.Add(vardiyabit);
            Controls.Add(vardiyabas);
            Controls.Add(soy);
            Controls.Add(guncelle);
            Controls.Add(id);
            Controls.Add(personel_kaldir);
            Controls.Add(label11);
            Controls.Add(personel_liste);
            Controls.Add(tel);
            Controls.Add(cinsiyet);
            Controls.Add(back4);
            Controls.Add(label10);
            Controls.Add(personelekle);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(button15);
            Controls.Add(label8);
            Controls.Add(button16);
            Controls.Add(email);
            Controls.Add(button17);
            Controls.Add(label7);
            Controls.Add(pass);
            Controls.Add(tc);
            Controls.Add(label6);
            Controls.Add(txtid);
            Controls.Add(ad);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(datetime);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "personel_ekle_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += personel_ekle_form_Load;
            ((System.ComponentModel.ISupportInitialize)personel_liste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back4;

        private Button button15;
        private Button button16;
        private Button button17;
        private DataGridView personel_liste;
        private Button personel_kaldir;
        private TextBox tc;
        private TextBox txtid;
        private TextBox ad;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker datetime;
        private Label label5;
        private Label label6;
        private TextBox pass;
        private Label label7;
        private TextBox email;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cinsiyet;
        private TextBox tel;
        private Label label11;
        private Label id;
        private TextBox soy;
        private DateTimePicker vardiyabas;
        private DateTimePicker vardiyabit;
    }
}