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
    public partial class FormaErgazomenou : Form
    {
        public FormaErgazomenou()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fwtismos fwt = new Fwtismos();
            this.Hide();
            fwt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterForm ef = new EnterForm();
            this.Hide();
            ef.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Skoupa sk = new Skoupa();
            this.Hide();
            sk.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kados kados = new Kados();
            this.Hide();
            kados.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpErgazomenou HP = new HelpErgazomenou();
            HP.panelFormaErgazomenou.Visible = true;
            HP.ShowDialog();
        }
    }
}
