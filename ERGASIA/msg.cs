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
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelmsg.Visible = true;
            HP.ShowDialog();
        }
    }
}
