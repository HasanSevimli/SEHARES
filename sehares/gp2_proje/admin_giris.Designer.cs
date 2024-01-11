namespace gp2_proje
{
    partial class admin_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_giris));
            admin_buton = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            back5 = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // admin_buton
            // 
            admin_buton.BackColor = Color.FromArgb(171, 206, 207);
            admin_buton.Cursor = Cursors.Hand;
            admin_buton.FlatAppearance.BorderSize = 0;
            admin_buton.FlatStyle = FlatStyle.Flat;
            admin_buton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            admin_buton.ForeColor = Color.White;
            admin_buton.ImeMode = ImeMode.NoControl;
            admin_buton.Location = new Point(90, 357);
            admin_buton.Name = "admin_buton";
            admin_buton.Size = new Size(259, 63);
            admin_buton.TabIndex = 11;
            admin_buton.Text = "ADMİN";
            admin_buton.UseVisualStyleBackColor = false;
            admin_buton.Click += admin_buton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(411, 12);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(90, 227);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 30);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 14;
            label2.Text = "E-Posta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(87, 273);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 16;
            label3.Text = "Şifre:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(90, 299);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(259, 30);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // back5
            // 
            back5.BackColor = Color.FromArgb(224, 224, 224);
            back5.Cursor = Cursors.Hand;
            back5.FlatAppearance.BorderSize = 0;
            back5.FlatStyle = FlatStyle.Flat;
            back5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back5.ForeColor = Color.Black;
            back5.ImeMode = ImeMode.NoControl;
            back5.Location = new Point(12, 611);
            back5.Name = "back5";
            back5.Size = new Size(33, 32);
            back5.TabIndex = 17;
            back5.Text = "<-";
            back5.UseVisualStyleBackColor = false;
            back5.Click += back5_Click;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(8, 21);
            logo.Name = "logo";
            logo.Size = new Size(423, 554);
            logo.TabIndex = 18;
            logo.TabStop = false;
            // 
            // admin_giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(443, 655);
            ControlBox = false;
            Controls.Add(back5);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(admin_buton);
            Controls.Add(button1);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin_giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += admin_giris_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button admin_buton;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button back5;
        private PictureBox logo;
    }
}