namespace gp2_proje
{
    partial class ciro
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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciro));
            button17 = new Button();
            back1 = new Button();
            genelciro = new DataGridView();
            dateTimePicker = new DateTimePicker();
            tumu = new Button();
            kayit = new Button();
            kart = new Button();
            nakit = new Button();
            genel = new Button();
            kartgenel = new Button();
            nakitgenel = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)genelciro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 32, 34);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 34);
            label1.TabIndex = 63;
            label1.Text = "CİRO EKRANI";
            // 
            // button17
            // 
            button17.BackColor = Color.Red;
            button17.Cursor = Cursors.Hand;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ImeMode = ImeMode.NoControl;
            button17.Location = new Point(799, 12);
            button17.Name = "button17";
            button17.Size = new Size(20, 20);
            button17.TabIndex = 21;
            button17.Text = "X";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // back1
            // 
            back1.BackColor = Color.FromArgb(255, 128, 0);
            back1.Cursor = Cursors.Hand;
            back1.FlatAppearance.BorderSize = 3;
            back1.FlatStyle = FlatStyle.Flat;
            back1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back1.ForeColor = Color.Black;
            back1.ImeMode = ImeMode.NoControl;
            back1.Location = new Point(12, 503);
            back1.Name = "back1";
            back1.Size = new Size(33, 32);
            back1.TabIndex = 25;
            back1.Text = "<-";
            back1.UseVisualStyleBackColor = false;
            back1.Click += back1_Click;
            // 
            // genelciro
            // 
            genelciro.AllowUserToAddRows = false;
            genelciro.AllowUserToDeleteRows = false;
            genelciro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            genelciro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            genelciro.Location = new Point(111, 71);
            genelciro.Name = "genelciro";
            genelciro.ReadOnly = true;
            genelciro.RowTemplate.Height = 25;
            genelciro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            genelciro.Size = new Size(607, 323);
            genelciro.TabIndex = 26;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(111, 458);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(195, 23);
            dateTimePicker.TabIndex = 27;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // tumu
            // 
            tumu.BackColor = Color.Turquoise;
            tumu.FlatStyle = FlatStyle.Flat;
            tumu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tumu.Location = new Point(312, 458);
            tumu.Name = "tumu";
            tumu.Size = new Size(200, 23);
            tumu.TabIndex = 28;
            tumu.Text = "TÜMÜNÜ GETİR";
            tumu.UseVisualStyleBackColor = false;
            tumu.Click += tumu_Click;
            // 
            // kayit
            // 
            kayit.BackColor = Color.Green;
            kayit.FlatStyle = FlatStyle.Flat;
            kayit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kayit.ForeColor = Color.White;
            kayit.Location = new Point(518, 460);
            kayit.Name = "kayit";
            kayit.Size = new Size(200, 23);
            kayit.TabIndex = 64;
            kayit.Text = "KAYDET";
            kayit.UseVisualStyleBackColor = false;
            kayit.Click += kayit_Click;
            // 
            // kart
            // 
            kart.BackColor = Color.Turquoise;
            kart.FlatStyle = FlatStyle.Flat;
            kart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kart.Location = new Point(312, 400);
            kart.Name = "kart";
            kart.Size = new Size(200, 23);
            kart.TabIndex = 85;
            kart.Text = "KART TOPLAM";
            kart.UseVisualStyleBackColor = false;
            kart.Click += kart_Click;
            // 
            // nakit
            // 
            nakit.BackColor = Color.Turquoise;
            nakit.FlatStyle = FlatStyle.Flat;
            nakit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nakit.Location = new Point(518, 400);
            nakit.Name = "nakit";
            nakit.Size = new Size(200, 23);
            nakit.TabIndex = 86;
            nakit.Text = "NAKİT TOPLAM";
            nakit.UseVisualStyleBackColor = false;
            nakit.Click += nakit_Click;
            // 
            // genel
            // 
            genel.BackColor = Color.Turquoise;
            genel.FlatStyle = FlatStyle.Flat;
            genel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            genel.Location = new Point(111, 400);
            genel.Name = "genel";
            genel.Size = new Size(195, 23);
            genel.TabIndex = 87;
            genel.Text = "GENEL TOPLAM";
            genel.UseVisualStyleBackColor = false;
            genel.Click += genel_Click;
            // 
            // kartgenel
            // 
            kartgenel.BackColor = Color.Turquoise;
            kartgenel.FlatStyle = FlatStyle.Flat;
            kartgenel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kartgenel.Location = new Point(111, 429);
            kartgenel.Name = "kartgenel";
            kartgenel.Size = new Size(299, 23);
            kartgenel.TabIndex = 88;
            kartgenel.Text = "KART";
            kartgenel.UseVisualStyleBackColor = false;
            kartgenel.Click += kartgenel_Click;
            // 
            // nakitgenel
            // 
            nakitgenel.BackColor = Color.Turquoise;
            nakitgenel.FlatStyle = FlatStyle.Flat;
            nakitgenel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nakitgenel.Location = new Point(419, 429);
            nakitgenel.Name = "nakitgenel";
            nakitgenel.Size = new Size(299, 23);
            nakitgenel.TabIndex = 89;
            nakitgenel.Text = "NAKİT";
            nakitgenel.UseVisualStyleBackColor = false;
            nakitgenel.Click += nakitgenel_Click;
            // 
            // ciro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(831, 547);
            Controls.Add(nakitgenel);
            Controls.Add(kartgenel);
            Controls.Add(genel);
            Controls.Add(nakit);
            Controls.Add(kart);
            Controls.Add(kayit);
            Controls.Add(label1);
            Controls.Add(tumu);
            Controls.Add(dateTimePicker);
            Controls.Add(genelciro);
            Controls.Add(back1);
            Controls.Add(button17);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ciro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ciro";
            Load += ciro_Load;
            ((System.ComponentModel.ISupportInitialize)genelciro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button17;
        private Button back1;
        private DataGridView genelciro;
        private DateTimePicker dateTimePicker;
        private Button tumu;
        private Button kayit;
        private Button kart;
        private Button nakit;
        private Button genel;
        private Button kartgenel;
        private Button nakitgenel;
    }
}