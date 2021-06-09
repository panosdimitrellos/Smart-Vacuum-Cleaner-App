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
    public partial class Skoupa : Form
    {
        public Skoupa()
        {
            InitializeComponent();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {

            if (startButton.ForeColor == Color.DimGray && programButton.ForeColor == Color.DimGray)
            {
                startButton.ForeColor = Color.White;
                programButton.ForeColor = Color.White;
                labelON.Visible = true;

                label3.Visible = true;
                label4.Visible = true;
                bluedot.Visible = true;

            }
            else
            {
                startButton.ForeColor = Color.DimGray;
                programButton.ForeColor = Color.DimGray;

                programPanel.Visible = false;
                startPanel.Visible = false;
                cleanedPanel.Visible = false;
                ChargingPanel.Visible = false;

                labelON.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                bluedot.Visible = false;
                labelCleaning.Visible = false;
                labelCleaned.Visible = false;

            }

        }

        private void programButton_Click(object sender, EventArgs e)
        {
            if (programButton.ForeColor == Color.White)
            {
                programPanel.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaErgazomenou FE = new FormaErgazomenou();
            this.Hide();
            FE.ShowDialog();
            this.Close();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            panelError.Visible = false;
        }

        string time1 = "13:45";
        string time2 = "18:00";
        string time3 = "22:10";
        string time4 = "24:10";

        private void Skoupa_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(time1);
            comboBox1.Items.Add(time2);
            comboBox1.Items.Add(time3);
            comboBox1.Items.Add(time4);
        }

        int x = 0;
        private void buttonOK_Click(object sender, EventArgs e)
        {
            x = 1;
            panelSuccess.Visible = true;
            labelProgrammed.Visible = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                panelError.Visible = true;
            }
            else
            {
                labelProgrammed.Visible = false;
                labelCleaning.Visible = true;

                programPanel.Visible = false;
                if (y == 0)
                {
                    startPanel.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
        }
        
        int y = 0;
        int duration=10;
        public static int buttery = 100;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            labelTime.Text = "00:0" + duration.ToString();

            buttery-=10;
            labelButtery.Text = buttery.ToString() + "%";
            labelButtery2.Text = buttery.ToString() + "%";

            if (duration ==0)
            {
                timer1.Stop();
                y = 1;
                finishedPanel.Visible = true;
                labelCleaning.Visible = false;
                labelCleaned.Visible = true;
            }

            if(buttery == 0)
            {
                labelButtery2.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            cleanedPanel.Visible = true;
        }

        public static int flag = 0;
        private void chargeButton_Click(object sender, EventArgs e)
        {
            flag = 1;
            ChargingPanel.Visible = true;
            cleanedPanel.Visible = false;

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = progressBar1.Minimum;

            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            buttery+=10;
            labelButtery2.Text = buttery.ToString() + "%";
            labelButtery2.ForeColor = Color.Lime;

            labelCleaned.Text = "Charging";
            labelCleaned.ForeColor = Color.Lime;
            progressBar1.Increment(10);

            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                label24.Visible = false;
                label25.Visible = true;
                label26.Visible = true;
                SmilePictureBox.Visible = true;
                labelCleaned.Text = "Charged";
                labelCleaned.ForeColor = Color.MediumSpringGreen;
                labelButtery2.ForeColor = Color.Blue;
            }        
        }

        private void OKbutton4_Click(object sender, EventArgs e)
        {
            labelCleaned.Visible = false;
            labelON.Visible = true;
            ChargingPanel.Visible = false;
            enterPanel.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            HelpErgazomenou HP = new HelpErgazomenou();
            HP.panelSkoupa.Visible = true;
            HP.ShowDialog();
        }
    }
}
