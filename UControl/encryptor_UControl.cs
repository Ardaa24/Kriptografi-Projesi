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
    public partial class encryptor_UControl: UserControl
    {
        public encryptor_UControl()
        {
            InitializeComponent();
        }

        //Encryptor UControl
        string normalYazi;
        string sifreliYazi;
        private void normal_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifrele_button_Click(object sender, EventArgs e)
        {

            normalYazi = normal_textbox.Text;


            byte[] bytes = ASCIIEncoding.UTF8.GetBytes(normalYazi);

            sifreliYazi = Convert.ToBase64String(bytes);
            sifre_textbox.Text = sifreliYazi;

            //Eğer şifreli metin boşsa hata mesajı göster.
            if (string.IsNullOrEmpty(sifreliYazi))
            {
                MessageBox.Show("Lütfen normal metni giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
