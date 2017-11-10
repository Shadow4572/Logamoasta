using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logamoasta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_abmelden_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
        }

        private void btn_lagerbestand_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form1.group.Equals("Moasta"))
            {
                btn_mitarbeiter.Visible = true;
            }
            else
            {
                btn_mitarbeiter.Visible = false;
            }
        }

        private void btn_mitarbeiter_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Hide();
            f4.ShowDialog();
        }

        private void btn_lagerverlauf_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Hide();
            f5.ShowDialog();
        }
    }
}
