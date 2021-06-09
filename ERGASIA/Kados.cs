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
    public partial class Kados : Form
    {
        public Kados()
        {
            InitializeComponent();
        }

        public static string antikeimeno1 = "";
        public static string antikeimeno2 = "";
        public static string markakin = "";
        public static string xrwmakin = "";
        public static string thesikin1 = "";
        public static string thesikin2 = "";
        public static string markaport = "";
        public static string xrwmaport = "";
        public static string thesiport1 = "";
        public static string thesiport2 = "";

        private void Kados_Load(object sender, EventArgs e)
        {
            if(Skoupa.flag == 0)
            {
                panelAdeios.Visible = true;
                panelGematos.Visible = false;
                panelXwris.Visible = true;
                panelMe.Visible = false;
            }
            else
            {
                panelGematos.Visible = true;
                panelAdeios.Visible = false;

                progressBar1.Maximum = 10;
                progressBar1.Minimum = 0;
                progressBar1.Value = progressBar1.Maximum;

                panelXwris.Visible = false;
                panelMe.Visible = true;

                labelMarkaKin.Text = "SAMSUNG";
                markakin = labelMarkaKin.Text;

                labelXrwmaKin.Text = "Μαύρο";
                xrwmakin = labelXrwmaKin.Text;

                labelThesiKin1.Text = "P1";
                thesikin1 = labelThesiKin1.Text;

                labelThesiKin2.Text = "P2";
                thesikin2 = labelThesiKin2.Text;

                labelMarkaPort.Text = "Armani";
                markaport = labelMarkaPort.Text;

                labelXrwmaPort.Text = "Πράσινο";
                xrwmaport = labelXrwmaPort.Text;

                labelThesiPort1.Text = "S3";
                thesiport1 = labelThesiPort1.Text;

                labelThesiPort2.Text = "S4";
                thesiport2 = labelThesiPort2.Text;

                labelKinhtoThl.Text = "Κινητό Τηλέφωνο";
                antikeimeno1 = labelKinhtoThl.Text;

                labelPortofoli.Text = "Πορτοφόλι";
                antikeimeno2 = labelPortofoli.Text;
            }
        }

        private void buttonAdeiasma_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaErgazomenou fe = new FormaErgazomenou();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 2;

            if (progressBar1.Value == 0)
            {
                panelAdeios.Visible = true;
                panelGematos.Visible = false;
                timer1.Stop();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            HelpErgazomenou HP = new HelpErgazomenou();
            HP.panelKados.Visible = true;
            HP.ShowDialog();
        }
    }
}
