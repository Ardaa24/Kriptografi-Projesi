using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace KriptografiProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            encryptor_UControl1.BringToFront();

            nav_panel.Top = encrypt_button.Top;

            encrypt_button.BackColor = Color.FromArgb(45, 45, 48);
            decrypt_button.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            decryptor_ucontrol1.BringToFront();

            nav_panel.Top = decrypt_button.Top;

            decrypt_button.BackColor = Color.FromArgb(45, 45, 48);
            encrypt_button.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama, metin şifreleme ve şifre çözme işlemleri için belirli programları referans  alınarak, \n açık kod şeklinde geliştirilmiştir.\n\n" +
                           "Geliştirici: ARDA24\n" +
                           "Program,  genel anlamda metinlerinizi güvenli bir şekilde şifrelemenize ve çözmenize yardımcı olur.",
                           "Hakkında",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dev_button_Click(object sender, EventArgs e)
        {
          

            //Alternatif
            
            //DialogResult result = MessageBox.Show("Hangi bağlantıya gitmek istersiniz?", "Bağlantı Seç", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    // GitHub'a yönlendir
            //    Process.Start(new ProcessStartInfo
            //    {
            //        FileName = "https://github.com/Ardaa24",
            //        UseShellExecute = true
            //    });
            //}
            //else if (result == DialogResult.No)
            //{
            //    // Instagram'a yönlendir
            //    Process.Start(new ProcessStartInfo
            //    {
            //        FileName = "https://www.instagram.com/_arda24/",
            //        UseShellExecute = true
            //    });



            
            Form popupForm = new Form();
            popupForm.Text = "Geliştirici Bağlantıları";
            popupForm.Size = new Size(300, 150);
            popupForm.StartPosition = FormStartPosition.CenterParent;
            popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            popupForm.MaximizeBox = false;
            popupForm.MinimizeBox = false;

            // GitHub butonu
            Button githubButton = new Button();
            githubButton.Text = "GitHub";
            githubButton.Size = new Size(100, 40);
            githubButton.Location = new Point(40, 40);
            githubButton.Click += (s, args) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/Ardaa24",
                    UseShellExecute = true
                });
                popupForm.Close();
            };

            // Instagram butonu
            Button instagramButton = new Button();
            instagramButton.Text = "Instagram";
            instagramButton.Size = new Size(100, 40);
            instagramButton.Location = new Point(150, 40);
            instagramButton.Click += (s, args) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/_arda24/",
                    UseShellExecute = true
                });
                popupForm.Close();
            };

            //Forma ekle
            popupForm.Controls.Add(githubButton);
            popupForm.Controls.Add(instagramButton);

            // Formu göster
            popupForm.ShowDialog();
        }
    }
}

