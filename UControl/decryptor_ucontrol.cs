using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptografiProjesi.UControl
{
    public partial class decryptor_ucontrol : UserControl
    {
        public decryptor_ucontrol()
        {
            InitializeComponent();
        }

        //Decryptor UControl
        string normalYazi;
        string sifreliYazi;

        private void coz_button_Click(object sender, EventArgs e)
        {
            sifreliYazi = sifre_textbox.Text;
            byte[] bytes = Convert.FromBase64String(sifreliYazi);
            normalYazi = Encoding.UTF8.GetString(bytes);
            normal_textbox.Text = normalYazi;


            //Eğer normal metin boşsa hata mesajı göster.
            if (string.IsNullOrEmpty(normalYazi))
            {
                MessageBox.Show("Lütfen şifreli metni giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Şifre çözme işlemi başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
            }
        }
    }
