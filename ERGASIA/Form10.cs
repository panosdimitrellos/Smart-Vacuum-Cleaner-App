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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button1.Text = "Πληρωμή " + Form9.SetValueForMoney + " €";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Σπύρος Παπαγιαννόπουλος")
            {
                panelBrwmikos.Visible = true;
            }
            else
            {
                msg m = new msg();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
        }

        private void button183_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelForm10.Visible = true;
            HP.ShowDialog();
        }
    }
}
