using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERGASIA
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static double moneyX= 0;
        public static string SetValueForMovieName2 = "";

        public int x = 0;
        public void button153_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Snow)
            {
                btn.BackColor = Color.Green;
                x++;
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Snow;
                x--;
            }

            label_seats.Text = x.ToString();
            SetValueForText1 = label_seats.Text;
            double money = (x * 7.5);
            moneyX = money;
            label_money.Text = money.ToString()+ " €";
            SetValueForText2 = label_money.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.ShowDialog();
            this.Close();
        }

        private void button183_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label_tainias.Text = Form7.SetValueForMovieName1;
            SetValueForMovieName2 = label_tainias.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelForm8.Visible = true;
            HP.ShowDialog();
        }
    }
}
