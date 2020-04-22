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
    public partial class wordMySelf : Form
    {
     
        private static List<string> arr = new List<string>();
        ArrayList randomList = new ArrayList();
        ArrayList dataList = new ArrayList();
        bool Verification = false;
        OleDbConnection con;
        string[] rndChar = new string[9];
        DialogResult result1;
        public wordMySelf()
        {
            InitializeComponent();
        }

        private void btnSelfStart_Click(object sender, EventArgs e)
        {
            rndChar[0] = txtCharacter1.Text;
            rndChar[1] = txtCharacter2.Text;
            rndChar[2] = txtCharacter3.Text;
            rndChar[3] = txtCharacter4.Text;
            rndChar[4] = txtCharacter5.Text;
            rndChar[5] = txtCharacter6.Text;
            rndChar[6] = txtCharacter7.Text;
            rndChar[7] = txtCharacter8.Text;
            rndChar[8] = txtCharacter9.Text;


            DataVerification();
            if (result1 == DialogResult.OK)
            {
                randomNumber randomMySelf = new randomNumber();
                randomMySelf.Show();
                this.Hide();
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
                       else if (textBox1.TextLength==8)
                        {
                            lblMySelfPoint.Text = "Puan: 11";
                        }
                        else if(textBox1.TextLength == 7)
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
                            lblMySelfPoint.Text = " Puan:4";
                        }
                        else if (textBox1.TextLength == 3)
                        {
                            lblMySelfPoint.Text = "Puan: 3";
                        }
                        listBox1.Items.Add(dataList[k].ToString());
                        result1 = MessageBox.Show(dataList[k].ToString(), "Eşleşen Kelime");
                        Verification = true;
                    }
                }
            }

            if (Verification == false)
            {
                MessageBox.Show("Eşlenen Kelime Bulunamadı", "Eşleşen Kelime");
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
