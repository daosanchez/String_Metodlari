using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_ornekleri_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj =lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            string mesaj = $"Toplam {lblMesaj.Text.Length} Krakter Vardır. ";

            MessageBox.Show(mesaj);
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"Merhaba Dünya, Ben {txtMesaj.Text}";

        }

        private void btnBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "Merhaba Dünya";
            string mesaj2 = "Ben Ravza";

            // string yeniMesaj = mesaj1 + mesaj2;

            string yeniMesaj = String.Concat(mesaj1, mesaj2);

            lblMesaj.Text = yeniMesaj;


        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            //5. sıradak, harfi getir 

            string mesaj = lblMesaj.Text;

            //mesaj[4] char türündedir.

            MessageBox.Show( $"6. Sıradaki Harf :{ mesaj[5]}" );
        }

        private void btnKacis1_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba Dünya \"Ravza\". \rNasılsın?";
            lblMesaj.Text = mesaj;

            // \ r , n , t
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "Ravza";
            string isim2 = "Ravza";
            string isim3 = "Halley";

            bool durum1 =isim1.Equals(isim2);
            bool durum2 =isim1 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"Durum1 :{durum1}  --> Durum2 :{durum2} \rdurum3 :{durum3}  --> Durum4 :{durum4}";
            MessageBox.Show(mesaj);
        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 200;

            string mesaj = $"{a} * {b} = {c}";
            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = "Ravza";
            string isim2 = "Hilal";
            string isim3 = "Nursevim";
            string isim4 = "Yezda";

            int sonuc = String.Compare(isim1, isim2);
            MessageBox.Show($" Sonuc :{sonuc}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4); //başlangıç adet

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);

            

        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);

            MessageBox.Show($"{txtMesaj.Text} ...... {durum}");
        }

 
        private void btnReplace_Click_1(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("Ravza", txtMesaj.Text);
            lblMesaj.Text = mesaj;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            lbMetin.DataSource = lblMesaj.Text.Split(' ').ToList();
        }
    }
}
