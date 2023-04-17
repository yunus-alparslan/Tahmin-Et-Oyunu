using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        int random = 0, tahminim = 0,hak=5,puan=0;


        void sayim()
        {
            Random sayim = new Random();
            random = sayim.Next(1, 10);

            label2.Text = random.ToString();


        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            sayim();

            tahminim = Convert.ToInt16(textBox1.Text);

            label3.Text = tahminim.ToString();

            if (tahminim == random)
            {
                hak += 3;
                MessageBox.Show("Doğru Tahmin","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Visible = true;
                puan++;
                label6.Text = puan.ToString();
            }
            else if (tahminim != random)
            {
                label2.Visible = false;
                hak--;
                label7.Text = hak.ToString();
              //  MessageBox.Show("Bilemediniz", "Bilgi", MessageBoxButtons.OK);

            }

            if (hak == 0)
            {
                hak+=5;
                
                textBox1.Text = "";
                MessageBox.Show("Yenildiniz Tekrar Tahmin Ediniz ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

         //  else
          //  {

            //   MessageBox.Show("Bilemediniz","Bilgi",MessageBoxButtons.OK);
            //  }


        }
    }
}
