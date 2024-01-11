namespace gp2_proje
{
    partial class menu_ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_ekran));
            cikis = new Button();
            geri = new Button();
            menu_label = new Label();
            menu = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            SuspendLayout();
            // 
            // cikis
            // 
            cikis.BackColor = Color.Red;
            cikis.FlatAppearance.BorderSize = 0;
            cikis.FlatStyle = FlatStyle.Flat;
            cikis.Location = new Point(768, 12);
            cikis.Name = "cikis";
            cikis.Size = new Size(20, 20);
            cikis.TabIndex = 0;
            cikis.Text = "X";
            cikis.UseVisualStyleBackColor = false;
            cikis.Click += cikis_Click;
            // 
            // geri
            // 
            geri.BackColor = Color.Turquoise;
            geri.FlatAppearance.BorderSize = 3;
            geri.FlatStyle = FlatStyle.Flat;
            geri.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            geri.Location = new Point(12, 467);
            geri.Name = "geri";
            geri.Size = new Size(33, 32);
            geri.TabIndex = 1;
            geri.Text = "<-";
            geri.UseVisualStyleBackColor = false;
            geri.Click += geri_Click;
            // 
            // menu_label
            // 
            menu_label.AutoSize = true;
            menu_label.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            menu_label.Location = new Point(368, 12);
            menu_label.Name = "menu_label";
            menu_label.Size = new Size(75, 34);
            menu_label.TabIndex = 2;
            menu_label.Text = "MENU";
            // 
            // menu
            // 
            menu.AllowUserToAddRows = false;
            menu.AllowUserToDeleteRows = false;
            menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu.Location = new Point(138, 59);
            menu.Name = "menu";
            menu.ReadOnly = true;
            menu.RowTemplate.Height = 25;
            menu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menu.Size = new Size(552, 342);
            menu.TabIndex = 3;
            menu.CellContentClick += menu_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(138, 407);
            button1.Name = "button1";
            button1.Size = new Size(552, 56);
            button1.TabIndex = 4;
            button1.Text = "MENU DÜZENLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menu_ekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(800, 511);
            Controls.Add(button1);
            Controls.Add(menu);
            Controls.Add(menu_label);
            Controls.Add(geri);
            Controls.Add(cikis);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menu_ekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikis;
        private Button geri;
        private Label menu_label;
        private DataGridView menu;
        private Button button1;
    }
}