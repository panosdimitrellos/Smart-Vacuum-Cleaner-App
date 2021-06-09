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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void παίζονταιΤώραToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void προσεχωςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void αίθουσα1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.αίθουσα1ToolStripMenuItem_Click(sender, e);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void αΙΘΟΥΣΑ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.αΙΘΟΥΣΑ2ToolStripMenuItem_Click(sender, e);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void gOLDCLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.gOLDCLASSToolStripMenuItem_Click(sender, e);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void gOLDCLASSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.gOLDCLASSToolStripMenuItem1_Click(sender, e);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search_key = textBox1.Text;

            List<string> tainies = new List<string>
            {
                "1917",
                "Κάποτε στο ... Χόλιγουντ",
                "Bad Boys For Life ",
                "Ευτυχία",
                "Ντουλιτλ",
                "Η Γκουβερνάντα",
                "Η Κατάρα",
                "Ενωμένες Πατούσες",
                "Χαβάη 5-0",
                "CATS",
                "ΤΖΟΤΖΟ",
                "The Gentlemen",
                "Αγώνας για δικαιοσύνη",
                "Sonic η ταινία ",
                "Ένα Ήσυχο Μέρος 2",
                "Μουλάν"
            };

            Form5 f5 = new Form5();
            Form6 f6 = new Form6();

            if (tainies[0].Contains(search_key))
            {
                f5.panel1.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[1].Contains(search_key))
            {
                f5.panel2.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[2].Contains(search_key))
            {
                f5.panel3.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[3].Contains(search_key))
            {
                f5.panel4.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[4].Contains(search_key))
            {
                f5.panel5.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[5].Contains(search_key))
            {
                f5.panel6.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[6].Contains(search_key))
            {
                f5.panel7.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[7].Contains(search_key))
            {
                f5.panel8.Visible = true;
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            else if (tainies[8].Contains(search_key))
            {
                f6.panel1.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[9].Contains(search_key))
            {
                f6.panel2.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[10].Contains(search_key))
            {
                f6.panel3.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[11].Contains(search_key))
            {
                f6.panel4.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[12].Contains(search_key))
            {
                f6.panel5.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[13].Contains(search_key))
            {
                f6.panel6.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[14].Contains(search_key))
            {
                f6.panel7.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (tainies[15].Contains(search_key))
            {
                f6.panel8.Visible = true;
                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpPelath HP = new HelpPelath();
            HP.panelForm6.Visible = true;
            HP.ShowDialog();
        }
    }
}
