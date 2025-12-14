namespace KriptografiProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.encryptor_UControl3 = new KriptografiProjesi.UControl.encryptor_UControl();
            this.encryptor_UControl2 = new KriptografiProjesi.UControl.encryptor_UControl();
            this.encryptor_UControl1 = new KriptografiProjesi.UControl.encryptor_UControl();
            this.decryptor_ucontrol1 = new KriptografiProjesi.UControl.decryptor_ucontrol();
            this.dev_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.dev_button);
            this.panel1.Controls.Add(this.about_button);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.nav_panel);
            this.panel1.Controls.Add(this.decrypt_button);
            this.panel1.Controls.Add(this.encrypt_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 686);
            this.panel1.TabIndex = 0;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.DimGray;
            this.nav_panel.Location = new System.Drawing.Point(1, 164);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(5, 56);
            this.nav_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Void24";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.encryptor_UControl3);
            this.panel2.Controls.Add(this.encryptor_UControl2);
            this.panel2.Controls.Add(this.encryptor_UControl1);
            this.panel2.Controls.Add(this.decryptor_ucontrol1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 686);
            this.panel2.TabIndex = 2;
            // 
            // encryptor_UControl3
            // 
            this.encryptor_UControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encryptor_UControl3.Location = new System.Drawing.Point(0, 0);
            this.encryptor_UControl3.Name = "encryptor_UControl3";
            this.encryptor_UControl3.Size = new System.Drawing.Size(883, 683);
            this.encryptor_UControl3.TabIndex = 3;
            // 
            // encryptor_UControl2
            // 
            this.encryptor_UControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encryptor_UControl2.Location = new System.Drawing.Point(0, 0);
            this.encryptor_UControl2.Name = "encryptor_UControl2";
            this.encryptor_UControl2.Size = new System.Drawing.Size(883, 686);
            this.encryptor_UControl2.TabIndex = 2;
            // 
            // encryptor_UControl1
            // 
            this.encryptor_UControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encryptor_UControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptor_UControl1.Location = new System.Drawing.Point(0, 0);
            this.encryptor_UControl1.Name = "encryptor_UControl1";
            this.encryptor_UControl1.Size = new System.Drawing.Size(883, 686);
            this.encryptor_UControl1.TabIndex = 1;
            // 
            // decryptor_ucontrol1
            // 
            this.decryptor_ucontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.decryptor_ucontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptor_ucontrol1.Location = new System.Drawing.Point(0, 0);
            this.decryptor_ucontrol1.Name = "decryptor_ucontrol1";
            this.decryptor_ucontrol1.Size = new System.Drawing.Size(883, 686);
            this.decryptor_ucontrol1.TabIndex = 0;
            // 
            // dev_button
            // 
            this.dev_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dev_button.FlatAppearance.BorderSize = 0;
            this.dev_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dev_button.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dev_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
//            this.dev_button.Image = global::KriptografiProjesi.Resource1.dev1;
            this.dev_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dev_button.Location = new System.Drawing.Point(0, 518);
            this.dev_button.Name = "dev_button";
            this.dev_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dev_button.Size = new System.Drawing.Size(200, 56);
            this.dev_button.TabIndex = 7;
            this.dev_button.Text = "Geliştirici";
            this.dev_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dev_button.UseVisualStyleBackColor = true;
            this.dev_button.Click += new System.EventHandler(this.dev_button_Click);
            // 
            // about_button
            // 
            this.about_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.about_button.FlatAppearance.BorderSize = 0;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.about_button.Image = global::KriptografiProjesi.Resource1.Voidcrypt_StatisticsIcon;
            this.about_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.about_button.Location = new System.Drawing.Point(0, 574);
            this.about_button.Name = "about_button";
            this.about_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.about_button.Size = new System.Drawing.Size(200, 56);
            this.about_button.TabIndex = 6;
            this.about_button.Text = "Program";
            this.about_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.close_button.Image = global::KriptografiProjesi.Resource1.Voidcrypt_Close1;
            this.close_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_button.Location = new System.Drawing.Point(0, 630);
            this.close_button.Name = "close_button";
            this.close_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.close_button.Size = new System.Drawing.Size(200, 56);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Kapat";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.FlatAppearance.BorderSize = 0;
            this.decrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt_button.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decrypt_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.decrypt_button.Image = global::KriptografiProjesi.Resource1.Voidcrypt_KeyIcon;
            this.decrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decrypt_button.Location = new System.Drawing.Point(3, 226);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.decrypt_button.Size = new System.Drawing.Size(197, 56);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Tanımlayıcı";
            this.decrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encrypt_button.FlatAppearance.BorderSize = 0;
            this.encrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt_button.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encrypt_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.encrypt_button.Image = global::KriptografiProjesi.Resource1.Voidcrypt_LockIcon;
            this.encrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encrypt_button.Location = new System.Drawing.Point(4, 164);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.encrypt_button.Size = new System.Drawing.Size(196, 56);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "Şifreleyici";
            this.encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KriptografiProjesi.Resource1.Voidcrypt_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1083, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kriptogra";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Panel panel2;
        private UControl.encryptor_UControl encryptor_UControl1;
        private UControl.decryptor_ucontrol decryptor_ucontrol1;
        private UControl.encryptor_UControl encryptor_UControl3;
        private UControl.encryptor_UControl encryptor_UControl2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button dev_button;
    }
}

