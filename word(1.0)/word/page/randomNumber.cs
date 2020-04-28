using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word.page
{
    public partial class randomNumber : Form
    {
        

        public randomNumber()
        {
            InitializeComponent();
        }
        Random sayiuret = new Random();
        int hedefsayi;

        List<int> sayilar1 = new List<int>();
        List<int> sayilar2 = new List<int>();
        private void randomNumber_Load(object sender, EventArgs e)
        {

           
            hedefsayi = sayiuret.Next(100, 1000);

            lblMySelfResult.Text = hedefsayi.ToString();

            SayiDoldur(sayilar1, sayilar2);



            Yazdir(sayilar1);

        }
     

        private void btnRandomStart_Click(object sender, EventArgs e)
        {
            int denemesayac = 0;

            denemesayac = islemYap(sayilar1, sayilar2, hedefsayi);
            while (denemesayac == 5)
            {

                YeniSayilar(sayilar1, sayilar2);

                denemesayac = islemYap(sayilar1, sayilar2, hedefsayi);
            }
            islem1.Visible = true;
            islem2.Visible = true;
            islem3.Visible = true;
            islem4.Visible = true;
            islem5.Visible = true;


        }
        public void YeniSayilar(List<int> sayilar1, List<int> sayilar2)
        {
            sayilar1.Clear();
            sayilar2.Clear();
            int sayi = 0;
            for (int i = 0; i < 5; i++)
            {
                sayi = sayiuret.Next(9) + 1;
                sayilar1.Add(sayi);
                sayilar2.Add(sayi);
            }
            while (true)
            {
                sayi = sayiuret.Next(9, 99);
                if (sayi % 10 == 0)
                {
                    sayilar1.Add(sayi);
                    sayilar2.Add(sayi);
                    break;
                }
            }

        }
        public void SayiDoldur(List<int> sayilar1, List<int> sayilar2)
        {
            int sayi = 0;
            for (int i = 0; i < 5; i++)
            {
                sayi = sayiuret.Next(9) + 1;
                sayilar1.Add(sayi);
                sayilar2.Add(sayi);
            }
            while (true)
            {
                sayi = sayiuret.Next(9, 99);
                if (sayi % 10 == 0)
                {
                    sayilar1.Add(sayi);
                    sayilar2.Add(sayi);
                    break;
                }
            }

        }

        public int islemYap(List<int> sayilar1, List<int> sayilar2, int hedef)
        {
            int sonuc = 0;
            int temple = 0;
            int sayi1 = 0;
            int sayi2 = 0;
            int islemsayac = 1;
            int denemesayisi = 0;
            while (true)
            {

                temple = sayiuret.Next(sayilar2.Count);
                sayi1 = sayilar2[temple];
                sayilar2.RemoveAt(temple);

                temple = sayiuret.Next(sayilar2.Count);
                sayi2 = sayilar2[temple];
                sayilar2.RemoveAt(temple);

                sonuc = DortIslem(sayi1, sayi2, islemsayac);


                if (sonuc == hedef && hedef - sonuc < 9 && hedef - sonuc > -9)
                {

                    break;
                }
                sayilar2.Add(sonuc);
                islemsayac++;
                if (sayilar2.Count == 1)
                {
                    TekrarDene(sayilar1, sayilar2);
                    islemsayac = 0;
                }
                if (denemesayisi == 5)
                {
                    break;
                }
                denemesayisi++;

            }
            return denemesayisi;
        }
        public void TekrarDene(List<int> sayilar1, List<int> sayilar2)
        {
          
            sayilar2.Clear();

            sayilar2.Add(sayilar1[0]);
            sayilar2.Add(sayilar1[1]);
            sayilar2.Add(sayilar1[2]);
            sayilar2.Add(sayilar1[3]);
            sayilar2.Add(sayilar1[4]);
            sayilar2.Add(sayilar1[5]);


        }
        public int DortIslem(int sayi1, int sayi2, int islemsayac)
        {

            int sonuc = 0;
            int islem = 0;
            float dsonuc = 0;
            if (sayi1 != 0 && sayi2 != 0)
                islem = sayiuret.Next(4) + 1;
            else
                islem = sayiuret.Next(3) + 1;

            switch (islem)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    if (islemsayac == 1)
                        islem1.Text = "1. İşlem: "+ sayi1.ToString() + "+" + sayi2.ToString();
                    if (islemsayac == 2)
                        islem2.Text = "2. İşlem: " + sayi1.ToString() + "+" + sayi2.ToString();
                    if (islemsayac == 3)
                        islem3.Text = "3. İşlem: " + sayi1.ToString() + "+" + sayi2.ToString();
                    if (islemsayac == 4)
                        islem4.Text = "4. İşlem: " + sayi1.ToString() + "+" + sayi2.ToString();
                    if (islemsayac == 5)
                        islem5.Text = "5. İşlem: " + sayi1.ToString() + "+" + sayi2.ToString();
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    if (islemsayac == 1)
                        islem1.Text = "1. İşlem: " + sayi1.ToString() + "-" + sayi2.ToString();
                    if (islemsayac == 2)
                        islem2.Text = "2. İşlem: " + sayi1.ToString() + "-" + sayi2.ToString();
                    if (islemsayac == 3)
                        islem3.Text = "3. İşlem: " + sayi1.ToString() + "-" + sayi2.ToString();
                    if (islemsayac == 4)
                        islem4.Text = "4. İşlem: " + sayi1.ToString() + "-" + sayi2.ToString();
                    if (islemsayac == 5)
                        islem5.Text = "5. İşlem: " + sayi1.ToString() + "-" + sayi2.ToString();
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    if (islemsayac == 1)
                        islem1.Text = "1. İşlem: " + sayi1.ToString() + "*" + sayi2.ToString();
                    if (islemsayac == 2)
                        islem2.Text = "2. İşlem: " + sayi1.ToString() + "*" + sayi2.ToString();
                    if (islemsayac == 3)
                        islem3.Text = "3. İşlem: " + sayi1.ToString() + "*" + sayi2.ToString();
                    if (islemsayac == 4)
                        islem4.Text = "4. İşlem: " + sayi1.ToString() + "*" + sayi2.ToString();
                    if (islemsayac == 5)
                        islem5.Text = "5. İşlem: " + sayi1.ToString() + "*" + sayi2.ToString();
                    break;
                case 4:
                    dsonuc = sayi1 / sayi2;
                    sonuc = Convert.ToInt32(Math.Ceiling(dsonuc));
                    if (islemsayac == 1)
                        islem1.Text = "1. İşlem: " + sayi1.ToString() + "/" + sayi2.ToString();
                    if (islemsayac == 2)
                        islem2.Text = "2. İşlem: " + sayi1.ToString() + "/" + sayi2.ToString();
                    if (islemsayac == 3)
                        islem3.Text = "3. İşlem: " + sayi1.ToString() + "/" + sayi2.ToString();
                    if (islemsayac == 4)
                        islem4.Text = "4. İşlem: " + sayi1.ToString() + "/" + sayi2.ToString();
                    if (islemsayac == 5)
                        islem5.Text = "5. İşlem: " + sayi1.ToString() + "/" + sayi2.ToString();
                    break;
            }


            return sonuc;
        }
        public void Yazdir(List<int> sayilar1)
        {
            for (int i = 0; i < 6; i++)
            {
                lwNumberList.Items.Add(sayilar1[i].ToString());
            }
         
        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
