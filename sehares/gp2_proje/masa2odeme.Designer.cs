namespace gp2_proje
{
    partial class masa2odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa2odeme));
            toplam = new Label();
            masa2toplam = new DataGridView();
            odemeturu = new Label();
            ode = new Button();
            back = new Button();
            exit = new Button();
            odemetur = new ComboBox();
            masaodeme2 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)masa2toplam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masaodeme2).BeginInit();
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
            label1.TabIndex = 71;
            label1.Text = "ÖDEME";
            // 
            // toplam
            // 
            toplam.AutoSize = true;
            toplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toplam.Location = new Point(78, 83);
            toplam.Name = "toplam";
            toplam.Size = new Size(78, 21);
            toplam.TabIndex = 70;
            toplam.Text = "TOPLAM:";
            // 
            // masa2toplam
            // 
            masa2toplam.AllowUserToAddRows = false;
            masa2toplam.AllowUserToDeleteRows = false;
            masa2toplam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masa2toplam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masa2toplam.Location = new Point(162, 69);
            masa2toplam.Name = "masa2toplam";
            masa2toplam.ReadOnly = true;
            masa2toplam.RowTemplate.Height = 25;
            masa2toplam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masa2toplam.Size = new Size(303, 49);
            masa2toplam.TabIndex = 69;
            // 
            // odemeturu
            // 
            odemeturu.AutoSize = true;
            odemeturu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            odemeturu.Location = new Point(77, 406);
            odemeturu.Name = "odemeturu";
            odemeturu.Size = new Size(79, 15);
            odemeturu.TabIndex = 68;
            odemeturu.Text = "Ödeme Türü:";
            // 
            // ode
            // 
            ode.BackColor = Color.FromArgb(224, 224, 224);
            ode.FlatAppearance.BorderSize = 3;
            ode.FlatStyle = FlatStyle.Flat;
            ode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ode.Location = new Point(289, 389);
            ode.Name = "ode";
            ode.Size = new Size(176, 50);
            ode.TabIndex = 67;
            ode.Text = "ÖDE";
            ode.UseVisualStyleBackColor = false;
            ode.Click += ode_Click;
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
            back.Location = new Point(12, 502);
            back.Name = "back";
            back.Size = new Size(33, 32);
            back.TabIndex = 66;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exit.ImeMode = ImeMode.NoControl;
            exit.Location = new Point(498, 13);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.TabIndex = 65;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // odemetur
            // 
            odemetur.DropDownStyle = ComboBoxStyle.DropDownList;
            odemetur.FormattingEnabled = true;
            odemetur.Items.AddRange(new object[] { "kart", "nakit" });
            odemetur.Location = new Point(162, 403);
            odemetur.Name = "odemetur";
            odemetur.Size = new Size(109, 23);
            odemetur.TabIndex = 64;
            // 
            // masaodeme2
            // 
            masaodeme2.AllowUserToAddRows = false;
            masaodeme2.AllowUserToDeleteRows = false;
            masaodeme2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masaodeme2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masaodeme2.Location = new Point(77, 124);
            masaodeme2.Name = "masaodeme2";
            masaodeme2.ReadOnly = true;
            masaodeme2.RowTemplate.Height = 25;
            masaodeme2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masaodeme2.Size = new Size(388, 259);
            masaodeme2.TabIndex = 63;
            // 
            // masa2odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(531, 545);
            Controls.Add(label1);
            Controls.Add(toplam);
            Controls.Add(masa2toplam);
            Controls.Add(odemeturu);
            Controls.Add(ode);
            Controls.Add(back);
            Controls.Add(exit);
            Controls.Add(odemetur);
            Controls.Add(masaodeme2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa2odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)masa2toplam).EndInit();
            ((System.ComponentModel.ISupportInitialize)masaodeme2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label toplam;
        private DataGridView masa2toplam;
        private Label odemeturu;
        private Button ode;
        private Button back;
        private Button exit;
        private ComboBox odemetur;
        private DataGridView masaodeme2;
    }
}