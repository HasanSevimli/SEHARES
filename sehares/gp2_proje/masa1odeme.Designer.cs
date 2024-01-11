namespace gp2_proje
{
    partial class masa1odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa1odeme));
            odemetur = new ComboBox();
            masaodeme1 = new DataGridView();
            exit = new Button();
            back = new Button();
            ode = new Button();
            odemeturu = new Label();
            masa1toplam = new DataGridView();
            toplam = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)masaodeme1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masa1toplam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 32, 34);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 34);
            label1.TabIndex = 62;
            label1.Text = "ÖDEME";
            label1.Click += label1_Click;
            // 
            // odemetur
            // 
            odemetur.DropDownStyle = ComboBoxStyle.DropDownList;
            odemetur.FormattingEnabled = true;
            odemetur.Items.AddRange(new object[] { "kart", "nakit" });
            odemetur.Location = new Point(162, 402);
            odemetur.Name = "odemetur";
            odemetur.Size = new Size(109, 23);
            odemetur.TabIndex = 2;
            // 
            // masaodeme1
            // 
            masaodeme1.AllowUserToAddRows = false;
            masaodeme1.AllowUserToDeleteRows = false;
            masaodeme1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masaodeme1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masaodeme1.Location = new Point(77, 123);
            masaodeme1.Name = "masaodeme1";
            masaodeme1.ReadOnly = true;
            masaodeme1.RowTemplate.Height = 25;
            masaodeme1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masaodeme1.Size = new Size(388, 259);
            masaodeme1.TabIndex = 0;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exit.ImeMode = ImeMode.NoControl;
            exit.Location = new Point(498, 12);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // back
            // 
            back.BackColor = Color.White;
            back.Cursor = Cursors.Hand;
            back.FlatAppearance.BorderSize = 3;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.Black;
            back.ImeMode = ImeMode.NoControl;
            back.Location = new Point(12, 501);
            back.Name = "back";
            back.Size = new Size(33, 32);
            back.TabIndex = 25;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // ode
            // 
            ode.BackColor = Color.FromArgb(224, 224, 224);
            ode.FlatAppearance.BorderSize = 3;
            ode.FlatStyle = FlatStyle.Flat;
            ode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ode.Location = new Point(289, 388);
            ode.Name = "ode";
            ode.Size = new Size(176, 50);
            ode.TabIndex = 26;
            ode.Text = "ÖDE";
            ode.UseVisualStyleBackColor = false;
            ode.Click += ode_Click;
            // 
            // odemeturu
            // 
            odemeturu.AutoSize = true;
            odemeturu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            odemeturu.Location = new Point(77, 405);
            odemeturu.Name = "odemeturu";
            odemeturu.Size = new Size(79, 15);
            odemeturu.TabIndex = 27;
            odemeturu.Text = "Ödeme Türü:";
            // 
            // masa1toplam
            // 
            masa1toplam.AllowUserToAddRows = false;
            masa1toplam.AllowUserToDeleteRows = false;
            masa1toplam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masa1toplam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masa1toplam.Location = new Point(162, 68);
            masa1toplam.Name = "masa1toplam";
            masa1toplam.ReadOnly = true;
            masa1toplam.RowTemplate.Height = 25;
            masa1toplam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masa1toplam.Size = new Size(303, 49);
            masa1toplam.TabIndex = 28;
            // 
            // toplam
            // 
            toplam.AutoSize = true;
            toplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toplam.Location = new Point(78, 82);
            toplam.Name = "toplam";
            toplam.Size = new Size(78, 21);
            toplam.TabIndex = 29;
            toplam.Text = "TOPLAM:";
            // 
            // masa1odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(531, 545);
            Controls.Add(label1);
            Controls.Add(toplam);
            Controls.Add(masa1toplam);
            Controls.Add(odemeturu);
            Controls.Add(ode);
            Controls.Add(back);
            Controls.Add(exit);
            Controls.Add(odemetur);
            Controls.Add(masaodeme1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa1odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "masa1odeme";
            Load += masa1odeme_Load;
            ((System.ComponentModel.ISupportInitialize)masaodeme1).EndInit();
            ((System.ComponentModel.ISupportInitialize)masa1toplam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView masaodeme1;
        private ComboBox odemetur;
        private Button exit;
        private Button back;
        private Button ode;
        private Label odemeturu;
        private DataGridView masa1toplam;
        private Label toplam;
    }
}