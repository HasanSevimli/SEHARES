namespace gp2_proje
{
    partial class personel_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_giris));
            back6 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            person_button = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // back6
            // 
            back6.BackColor = Color.FromArgb(224, 224, 224);
            back6.Cursor = Cursors.Hand;
            back6.FlatAppearance.BorderSize = 0;
            back6.FlatStyle = FlatStyle.Flat;
            back6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back6.ForeColor = Color.Black;
            back6.ImeMode = ImeMode.NoControl;
            back6.Location = new Point(12, 611);
            back6.Name = "back6";
            back6.Size = new Size(33, 32);
            back6.TabIndex = 27;
            back6.Text = "<-";
            back6.UseVisualStyleBackColor = false;
            back6.Click += back6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(240, 245, 249);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(87, 273);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 26;
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
            textBox2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(240, 245, 249);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 24;
            label2.Text = "E-Posta:";
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
            textBox1.TabIndex = 23;
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
            button1.TabIndex = 19;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // person_button
            // 
            person_button.BackColor = Color.FromArgb(171, 206, 207);
            person_button.BackgroundImageLayout = ImageLayout.None;
            person_button.Cursor = Cursors.Hand;
            person_button.FlatAppearance.BorderSize = 0;
            person_button.FlatStyle = FlatStyle.Flat;
            person_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            person_button.ForeColor = Color.White;
            person_button.Location = new Point(90, 357);
            person_button.Name = "person_button";
            person_button.Size = new Size(259, 63);
            person_button.TabIndex = 28;
            person_button.Text = "PERSONEL";
            person_button.UseVisualStyleBackColor = false;
            person_button.Click += person_button_Click;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(8, 21);
            logo.Name = "logo";
            logo.Size = new Size(423, 554);
            logo.TabIndex = 29;
            logo.TabStop = false;
            // 
            // personel_giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(443, 655);
            Controls.Add(person_button);
            Controls.Add(back6);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "personel_giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back6;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button person_button;
        private PictureBox logo;
    }
}