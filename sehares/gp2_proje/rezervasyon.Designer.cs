namespace gp2_proje
{
    partial class rezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyon));
            rezerv = new DataGridView();
            exit = new Button();
            back2 = new Button();
            rezervasyon_ekle = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)rezerv).BeginInit();
            SuspendLayout();
            // 
            // rezerv
            // 
            rezerv.AllowUserToAddRows = false;
            rezerv.AllowUserToDeleteRows = false;
            rezerv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rezerv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezerv.Location = new Point(91, 73);
            rezerv.MultiSelect = false;
            rezerv.Name = "rezerv";
            rezerv.ReadOnly = true;
            rezerv.RowTemplate.Height = 25;
            rezerv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezerv.Size = new Size(748, 357);
            rezerv.TabIndex = 85;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exit.ForeColor = SystemColors.ControlText;
            exit.ImeMode = ImeMode.NoControl;
            exit.Location = new Point(897, 13);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.TabIndex = 84;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // back2
            // 
            back2.BackColor = Color.White;
            back2.Cursor = Cursors.Hand;
            back2.FlatAppearance.BorderSize = 3;
            back2.FlatStyle = FlatStyle.Flat;
            back2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back2.ForeColor = Color.Black;
            back2.ImeMode = ImeMode.NoControl;
            back2.Location = new Point(12, 570);
            back2.Name = "back2";
            back2.Size = new Size(33, 32);
            back2.TabIndex = 83;
            back2.Text = "<-";
            back2.UseVisualStyleBackColor = false;
            back2.Click += back2_Click;
            // 
            // rezervasyon_ekle
            // 
            rezervasyon_ekle.BackColor = Color.FromArgb(171, 206, 207);
            rezervasyon_ekle.Cursor = Cursors.Hand;
            rezervasyon_ekle.FlatAppearance.BorderSize = 3;
            rezervasyon_ekle.FlatStyle = FlatStyle.Flat;
            rezervasyon_ekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rezervasyon_ekle.ForeColor = Color.FromArgb(30, 32, 34);
            rezervasyon_ekle.ImeMode = ImeMode.NoControl;
            rezervasyon_ekle.Location = new Point(91, 436);
            rezervasyon_ekle.Name = "rezervasyon_ekle";
            rezervasyon_ekle.Size = new Size(748, 102);
            rezervasyon_ekle.TabIndex = 82;
            rezervasyon_ekle.Text = "REZERVASYON EKLE-DÜZENLE-KALDIR";
            rezervasyon_ekle.UseVisualStyleBackColor = false;
            rezervasyon_ekle.Click += rezervasyon_ekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 32, 34);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(255, 10);
            label1.Name = "label1";
            label1.Size = new Size(429, 60);
            label1.TabIndex = 81;
            label1.Text = "REZERVASYON LİSTESİ";
            // 
            // rezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(928, 613);
            Controls.Add(rezerv);
            Controls.Add(exit);
            Controls.Add(back2);
            Controls.Add(rezervasyon_ekle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rezervasyon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rezervasyon";
            Load += rezervasyon_Load;
            ((System.ComponentModel.ISupportInitialize)rezerv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView rezerv;
        private Button exit;
        private Button back2;
        private Button rezervasyon_ekle;
        private Label label1;
    }
}