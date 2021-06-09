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
    public partial class Fwtismos : Form
    {
        public Fwtismos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaErgazomenou FE = new FormaErgazomenou();
            this.Hide();
            FE.ShowDialog();
            this.Close();
        }

        private void aithousa3pic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aithousa1ON.Visible = true;
            aithousa1OFF.Visible = false;

            button1.BackColor = Color.Green;
            button2.BackColor = Color.LightCoral;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aithousa1ON.Visible = false;
            aithousa1OFF.Visible = true;

            button2.BackColor = Color.Red;
            button1.BackColor = Color.DarkSeaGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aithousa2ON.Visible = true;
            aithousa2OFF.Visible = false;

            button4.BackColor = Color.Green;
            button5.BackColor = Color.LightCoral;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aithousa2ON.Visible = false;
            aithousa2OFF.Visible = true;

            button5.BackColor = Color.Red;
            button4.BackColor = Color.DarkSeaGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aithousa3ON.Visible = true;
            aithousa3OFF.Visible = false;

            button6.BackColor = Color.Green;
            button7.BackColor = Color.LightCoral;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            aithousa3ON.Visible = false;
            aithousa3OFF.Visible = true;

            button7.BackColor = Color.Red;
            button6.BackColor = Color.DarkSeaGreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GoldClassON.Visible = true;
            GoldClassOFF.Visible = false;

            button8.BackColor = Color.Green;
            button9.BackColor = Color.LightCoral;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GoldClassOFF.Visible = true;
            GoldClassON.Visible = false;

            button9.BackColor = Color.Red;
            button8.BackColor = Color.DarkSeaGreen;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            diadromos1ON.Visible = true;
            diadromos1OFF.Visible = false;

            button10.BackColor = Color.Green;
            button11.BackColor = Color.LightCoral;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            diadromos1ON.Visible = false;
            diadromos1OFF.Visible = true;

            button11.BackColor = Color.Red;
            button10.BackColor = Color.DarkSeaGreen;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            diadromos2ON.Visible = true;
            diadromos2OFF.Visible = false;

            button12.BackColor = Color.Green;
            button13.BackColor = Color.LightCoral;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            diadromos2ON.Visible = false;
            diadromos2OFF.Visible = true;

            button13.BackColor = Color.Red;
            button12.BackColor = Color.DarkSeaGreen;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;

            button18.BackColor = Color.Red;
            button17.BackColor = Color.DarkSeaGreen;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;

            button17.BackColor = Color.Green;
            button18.BackColor = Color.LightCoral;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel6.Visible = false;

            button15.BackColor = Color.Green;
            button16.BackColor = Color.LightCoral;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;

            button16.BackColor = Color.Red;
            button15.BackColor = Color.DarkSeaGreen;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel8.Visible = false;

            button19.BackColor = Color.Green;
            button20.BackColor = Color.LightCoral;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;

            button20.BackColor = Color.Red;
            button19.BackColor = Color.DarkSeaGreen;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            HelpErgazomenou HP = new HelpErgazomenou();
            HP.panelFwtismos.Visible = true;
            HP.ShowDialog();
        }
    }
}
