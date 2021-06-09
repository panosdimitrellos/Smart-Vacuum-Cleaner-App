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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public static string SetValueForMoney = "";

        double dtimh_1 = 4.5;
        double dtimh_2 = 3.5;
        double dtimh_3 = 3.0;
        double dtimh_4 = 3.0;
        double dtimh_5 = 3.0;
        double dtimh_6 = 4.0;
        double dtimh_7 = 0.5;
        private void Form9_Load(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            label_tickets.Text = Form8.SetValueForText1 + " Εισιτήρια";
            label_tickets_money.Text = Form8.SetValueForText2;
            total_label.Text = Form8.moneyX.ToString() + " €";
            label_tainias.Text = Form8.SetValueForMovieName2;


            timh_1.Text = dtimh_1.ToString() + " €";
            timh_2.Text = dtimh_2.ToString() + " €";
            timh_3.Text = dtimh_3.ToString() + " €";
            timh_4.Text = dtimh_4.ToString() + " €";
            timh_5.Text = dtimh_5.ToString() + " €";
            timh_6.Text = dtimh_6.ToString() + " €";
            timh_7.Text = dtimh_7.ToString() + " €";

        }

        


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();
        }


        public void SumOfProionta()
        {
            
        }

        public void SumOfTickets()
        {
            decimal total_proionta = numericUpDown1.Value + numericUpDown2.Value +
                numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value +
                numericUpDown6.Value + numericUpDown7.Value;
            label_proionta.Text = total_proionta.ToString() + " Προϊόντα";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            SumOfTickets();
            SumOfProducts();

        }

        public void SumOfProducts()
        {

            decimal t1 = (decimal)dtimh_1;
            decimal total_proion_1 = numericUpDown1.Value * t1;
            synolo_1.Text = total_proion_1.ToString() + " €";

            decimal t2 = (decimal)dtimh_2;
            decimal total_proion_2 = numericUpDown2.Value * t2;
            synolo_2.Text = total_proion_2.ToString() + " €";

            decimal t3 = (decimal)dtimh_3;
            decimal total_proion_3 = numericUpDown3.Value * t3;
            synolo_3.Text = total_proion_3.ToString() + " €";

            decimal t4 = (decimal)dtimh_4;
            decimal total_proion_4 = numericUpDown4.Value * t4;
            synolo_4.Text = total_proion_4.ToString() + " €";

            decimal t5 = (decimal)dtimh_5;
            decimal total_proion_5 = numericUpDown5.Value * t5;
            synolo_5.Text = total_proion_5.ToString() + " €";

            decimal t6 = (decimal)dtimh_6;
            decimal total_proion_6 = numericUpDown6.Value * t6;
            synolo_6.Text = total_proion_6.ToString() + " €";

            decimal t7 = (decimal)dtimh_7;
            decimal total_proion_7 = numericUpDown7.Value * t7;
            synolo_7.Text = total_proion_7.ToString() + " €";

            decimal total_proionta_money = total_proion_1 + total_proion_2 + total_proion_3 + total_proion_4 + total_proion_5
                + total_proion_6 + total_proion_7;
            label_proionta_money.Text = total_proionta_money.ToString() + " €";
            

            
            decimal ticket_money = (decimal)Form8.moneyX;
            decimal total = total_proionta_money + ticket_money;
            SetValueForMoney = total.ToString();
            total_label.Text = total.ToString()+ " €";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.ShowDialog();
            this.Close();

        }

        private void button183_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelForm9.Visible = true;
            HP.ShowDialog();
        }
    }

}
