using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word.page
{
    public partial class wordRandom : Form
    {
        string[] rndChar = new string[7];
        private static List<string> arr = new List<string>();
        ArrayList randomList = new ArrayList();
        ArrayList dataList = new ArrayList();
        bool Verification = false;
        OleDbConnection con;
        DialogResult result1;
        public wordRandom()
        {
            InitializeComponent();
        }

        private void btnRandomStart_Click(object sender, EventArgs e)
        {
            DataVerification();

            if (result1 == DialogResult.OK)
            {
                randomNumber randomNumber = new randomNumber();
                randomNumber.Show();
                this.Hide();
            }
        }

        //Random 8 Harf Üretme 
        private string[] randomChar()
        {
            Random rnd = new Random();
            string[] word = new string[8];
            char charWord;
            // 8 tane random sayı üretiyoruz
            for (int i = 0; i <= 7; i++)
            {
                int asci = rnd.Next(65, 90);
                //sayılar X-Q-W olamaz
                if (asci == 81 || asci == 87 || asci == 88)
                {
                    asci = rnd.Next(65, 90);
                }
                //sayıları harfe dönüştürüyoruz
                charWord = Convert.ToChar(asci);
                word[i] = charWord.ToString();
            }

            return word;

        }

        private void wordRandom_Load(object sender, EventArgs e)
        {
            rndChar = randomChar();
            for (int r = 0; r <= 7; r++)
            {
                lwWordList.Items.Add(rndChar[r].ToString());
            }
        }

        void DataVerification()
        {
            // dizideki veriler birleştirilip string oluşturuldu
            string result = ConvertStringArrayToStringJoin(rndChar);
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Emre\\source\\repos\\word\\tdk.mdb");

            foreach (var sayi in GetPermutationsOfString(result))
            {
                randomList.Add(sayi);

            }
            randomList.Add(txtJokerWord.Text);
            // veritabanındaki veriler diziye çekildi
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SElECT * from word ", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataList.Add(dr["wordName"]);
            }
            con.Close();


            // Veritabanındaki veriler ile Üretilen verileri kıyaslama
            for (int i = 0; i < randomList.Count; i++)
            {
                for (int k = 0; k < dataList.Count; k++)
                {

                    if (randomList[i].ToString() == dataList[k].ToString())
                    {
                        lblMySelfResult.Text = "Eşleşen Kelime: " + dataList[k].ToString();
                        textBox1.Text = dataList[k].ToString();
                         if (textBox1.TextLength == 9)
                        {
                            lblMySelfPoint.Text = "Puan: 15";
                        }
                        else if(textBox1.TextLength == 8)
                        {
                            lblMySelfPoint.Text = "Puan: 11";
                        }
                        else if (textBox1.TextLength == 7)
                        {
                            lblMySelfPoint.Text = "Puan: 9";
                        }
                        else if (textBox1.TextLength == 6)
                        {
                            lblMySelfPoint.Text = "Puan: 7";
                        }
                        else if (textBox1.TextLength == 5)
                        {
                            lblMySelfPoint.Text = "Puan: 5";
                        }
                        else if (textBox1.TextLength == 4)
                        {
                            lblMySelfPoint.Text = "Puan: 4";
                        }
                        else if (textBox1.TextLength == 3)
                        {
                            lblMySelfPoint.Text = "Puan: 3";
                        }
                        MessageBox.Show(dataList[k].ToString(), "Eşleşen Kelime");
                        Verification = true;
                    }
                }
            }

            if (Verification == false)
            {
                result1= MessageBox.Show("Eşlenen Kelime Bulunamadı", "Eşleşen Kelime");
            }

        }



        // Dizideki Değerleri Metine Çeevirme
        static string ConvertStringArrayToStringJoin(string[] array)
        {
            string result = string.Join("", array);
            return result;
        }

        public List<string> GetPermutationsOfString(string value)
        {
            var resultList = new List<string>();

            for (var i = 3; i <= value.Length; i++)
            {
                var permutations = GetPermutations(Enumerable.Range(0, value.Length), i);

                resultList.AddRange(
                    permutations
                        .Select(v => new string(v.Select(z => value[z]).ToArray()))
                        .Distinct()
                    );
            }

            return resultList;
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
