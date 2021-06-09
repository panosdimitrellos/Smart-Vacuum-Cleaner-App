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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public static string SetValueForMovieName1 = "";

        private void panel3_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel3.BackColor = Color.LightYellow;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel7.BackColor = Color.LightYellow;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel8.BackColor = Color.LightYellow;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel4.BackColor = Color.LightYellow;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel5.BackColor = Color.LightYellow;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel11.BackColor = Color.LightYellow;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel21.BackColor = Color.LightYellow;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel17.BackColor = Color.LightYellow;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel13.BackColor = Color.LightYellow;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel12.BackColor = Color.LightYellow;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel6.BackColor = Color.LightYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            //f8.label_tainias.Text = label_tainias.Text;
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label_tainias.Text = Form5.SetValueForMovieName;
            SetValueForMovieName1 = label_tainias.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelForm7.Visible = true;
            HP.ShowDialog();
        }
    }
}
