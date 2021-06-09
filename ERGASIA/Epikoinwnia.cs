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
    public partial class Epikoinwnia : Form
    {
        public Epikoinwnia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonEpikoinwnia_Click(object sender, EventArgs e)
        {
            string antikeimeno = textBoxAntikeimeno.Text;
            string marka = textBoxMarka.Text;
            string xrwma = textBoxXrwma.Text;
            string thesi = textBoxThesi.Text;

            if(antikeimeno == Kados.antikeimeno1 && marka == Kados.markakin && xrwma == Kados.xrwmakin && (thesi == Kados.thesikin1| thesi == Kados.thesikin2))
            {
                VerifiedPanel.Visible = true;
                labelVerifiedAntikeimeno.Text = "Κινητό Τηλέφωνο";
            }
            else if (antikeimeno == Kados.antikeimeno2 && marka == Kados.markaport && xrwma == Kados.xrwmaport && (thesi == Kados.thesiport1 | thesi == Kados.thesiport2))
            {
                VerifiedPanel.Visible = true;
                labelVerifiedAntikeimeno.Text = "Πορτοφόλι";
            }
            else
            {
                DeclinedPanel.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelEpikoinwnia.Visible = true;
            HP.ShowDialog();
        }
    }
}
