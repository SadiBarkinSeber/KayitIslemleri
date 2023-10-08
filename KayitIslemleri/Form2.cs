using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitIslemleri
{
    public partial class Form2 : Form
    {
        Kisi kisi1 = new Kisi();
        List<Kisi> kisiler = new List<Kisi>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kisi1 = new Kisi();
            kisi1.AdSoyad = txtAdSoyad.Text;
            kisi1.Telefon = txtTelefon.Text;
            kisi1.Yas = (byte)NudYas.Value;
            kisi1.Adres = txtAdres.Text;

            kisiler.Add(kisi1);
            MessageBox.Show("Kaydetme Başarılı!");

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            NudYas.Value = 0;
        }

        private void btnListeyeDön_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(kisiler);
            form1.Form1Guncelle();
            form1.Show();
            this.Hide();
        }
    }
}
