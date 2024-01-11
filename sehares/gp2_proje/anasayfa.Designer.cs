namespace gp2_proje
{
    partial class anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            button1 = new Button();
            personel_buton = new Button();
            admin_buton = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // personel_buton
            // 
            resources.ApplyResources(personel_buton, "personel_buton");
            personel_buton.BackColor = Color.FromArgb(224, 224, 224);
            personel_buton.Cursor = Cursors.Hand;
            personel_buton.FlatAppearance.BorderSize = 3;
            personel_buton.ForeColor = Color.FromArgb(30, 32, 34);
            personel_buton.Name = "personel_buton";
            personel_buton.UseVisualStyleBackColor = false;
            personel_buton.Click += personel_buton_Click;
            // 
            // admin_buton
            // 
            resources.ApplyResources(admin_buton, "admin_buton");
            admin_buton.BackColor = Color.FromArgb(224, 224, 224);
            admin_buton.Cursor = Cursors.Hand;
            admin_buton.FlatAppearance.BorderSize = 3;
            admin_buton.ForeColor = Color.FromArgb(30, 32, 34);
            admin_buton.Name = "admin_buton";
            admin_buton.UseVisualStyleBackColor = false;
            admin_buton.Click += admin_buton_Click;
            // 
            // logo
            // 
            resources.ApplyResources(logo, "logo");
            logo.Name = "logo";
            logo.TabStop = false;
            // 
            // anasayfa
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ControlBox = false;
            Controls.Add(admin_buton);
            Controls.Add(personel_buton);
            Controls.Add(button1);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "anasayfa";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button personel_buton;
        private Button admin_buton;
        private PictureBox logo;
    }
}