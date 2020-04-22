using System;
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
        int[] rndInt = new int[5];
        public randomNumber()
        {
            InitializeComponent();
        }

        private void randomNumber_Load(object sender, EventArgs e)
        {
            rndInt = rndNumber();
            for (int r = 0; r <= 5; r++)
            {
                lwNumberList.Items.Add(rndInt[r].ToString());
            }
            Random rnd = new Random();
            lblMySelfResult.Text = rnd.Next(100, 999).ToString();

        }
        private int[] rndNumber()
        {
            Random rnd = new Random();
            int[] number = new int[7];
            
            // 5 tane random sayı üretiyoruz
            for (int i = 0; i <= 4; i++)
            {

                number[i] = rnd.Next(1, 10);
             
            }
            number[5] = 20;
            return number;

        }

    }
}
