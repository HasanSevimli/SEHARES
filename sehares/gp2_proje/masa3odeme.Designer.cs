namespace gp2_proje
{
    partial class masa3odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masa3odeme));
            masaodeme = new DataGridView();
            odemetur = new ComboBox();
            exit = new Button();
            back = new Button();
            ode = new Button();
            odemeturu = new Label();
            masatoplam = new DataGridView();
            toplam = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)masaodeme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masatoplam).BeginInit();
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
            label1.TabIndex = 80;
            label1.Text = "ÖDEME";
            // 
            // masaodeme
            // 
            masaodeme.AllowUserToAddRows = false;
            masaodeme.AllowUserToDeleteRows = false;
            masaodeme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masaodeme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masaodeme.Location = new Point(77, 124);
            masaodeme.Name = "masaodeme";
            masaodeme.ReadOnly = true;
            masaodeme.RowTemplate.Height = 25;
            masaodeme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masaodeme.Size = new Size(388, 259);
            masaodeme.TabIndex = 72;
            // 
            // odemetur
            // 
            odemetur.DropDownStyle = ComboBoxStyle.DropDownList;
            odemetur.FormattingEnabled = true;
            odemetur.Items.AddRange(new object[] { "kart", "nakit" });
            odemetur.Location = new Point(162, 403);
            odemetur.Name = "odemetur";
            odemetur.Size = new Size(109, 23);
            odemetur.TabIndex = 73;
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
            exit.TabIndex = 74;
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
            back.Location = new Point(12, 502);
            back.Name = "back";
            back.Size = new Size(33, 32);
            back.TabIndex = 75;
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
            ode.Location = new Point(289, 389);
            ode.Name = "ode";
            ode.Size = new Size(176, 50);
            ode.TabIndex = 76;
            ode.Text = "ÖDE";
            ode.UseVisualStyleBackColor = false;
            ode.Click += ode_Click;
            // 
            // odemeturu
            // 
            odemeturu.AutoSize = true;
            odemeturu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            odemeturu.Location = new Point(77, 406);
            odemeturu.Name = "odemeturu";
            odemeturu.Size = new Size(79, 15);
            odemeturu.TabIndex = 77;
            odemeturu.Text = "Ödeme Türü:";
            // 
            // masatoplam
            // 
            masatoplam.AllowUserToAddRows = false;
            masatoplam.AllowUserToDeleteRows = false;
            masatoplam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            masatoplam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masatoplam.Location = new Point(162, 69);
            masatoplam.Name = "masatoplam";
            masatoplam.ReadOnly = true;
            masatoplam.RowTemplate.Height = 25;
            masatoplam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masatoplam.Size = new Size(303, 49);
            masatoplam.TabIndex = 78;
            // 
            // toplam
            // 
            toplam.AutoSize = true;
            toplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toplam.Location = new Point(78, 83);
            toplam.Name = "toplam";
            toplam.Size = new Size(78, 21);
            toplam.TabIndex = 79;
            toplam.Text = "TOPLAM:";
            // 
            // masa3odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(531, 545);
            Controls.Add(label1);
            Controls.Add(toplam);
            Controls.Add(masatoplam);
            Controls.Add(odemeturu);
            Controls.Add(ode);
            Controls.Add(back);
            Controls.Add(exit);
            Controls.Add(odemetur);
            Controls.Add(masaodeme);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "masa3odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "masa3odeme";
            Load += masa3odeme_Load;
            ((System.ComponentModel.ISupportInitialize)masaodeme).EndInit();
            ((System.ComponentModel.ISupportInitialize)masatoplam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView masaodeme;
        private ComboBox odemetur;
        private Button exit;
        private Button back;
        private Button ode;
        private Label odemeturu;
        private DataGridView masatoplam;
        private Label toplam;
    }
}