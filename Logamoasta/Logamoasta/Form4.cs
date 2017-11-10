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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void rbtn_maanlegen_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_gruppe.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
                cmb_gruppe.Visible = false;
                lbl_bid.Visible = false;
            }

            if(rbtn_mabearbeiten.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_maloeschen.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                cmb_gruppe.Visible = false;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_gruppe.Visible = false;
                lbl_passwort.Visible = false;
            }

            if(rbtn_masuchen.Checked)
            {
                cmb_bid.Visible = true;
                cmb_benutzername.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_mabearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_gruppe.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
                cmb_gruppe.Visible = false;
                lbl_bid.Visible = false;
            }

            if (rbtn_mabearbeiten.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_maloeschen.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                cmb_gruppe.Visible = false;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_gruppe.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_masuchen.Checked)
            {
                cmb_bid.Visible = true;
                cmb_benutzername.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_maloeschen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_gruppe.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
                cmb_gruppe.Visible = false;
                lbl_bid.Visible = false;
            }

            if (rbtn_mabearbeiten.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_maloeschen.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                cmb_gruppe.Visible = false;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_gruppe.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_masuchen.Checked)
            {
                cmb_bid.Visible = true;
                cmb_benutzername.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_masuchen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_gruppe.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
                cmb_gruppe.Visible = false;
                lbl_bid.Visible = false;
            }

            if (rbtn_mabearbeiten.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_maloeschen.Checked)
            {
                cmb_benutzername.Visible = true;
                cmb_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_bid.Visible = true;
                cmb_gruppe.Visible = false;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_gruppe.Visible = false;
                lbl_passwort.Visible = false;
            }

            if (rbtn_masuchen.Checked)
            {
                cmb_bid.Visible = true;
                cmb_benutzername.Visible = true;
                cmb_gruppe.Visible = true;
                lbl_bid.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                txt_benutzername.Visible = false;
                txt_gruppe.Visible = false;
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
        }
    }
}
