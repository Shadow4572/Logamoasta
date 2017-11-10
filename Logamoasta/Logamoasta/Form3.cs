using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Logamoasta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
        }

        private void rbtn_neuerartikel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_neuerartikel.Checked)
            {
                txt_bezeichnung.Visible = true;
                txt_ekpreis.Visible = true;
                txt_vkpreis.Visible = true;
                num_anzahl.Visible = true;
                cmb_artikelnr.Visible = false;
                cmb_bezeichnung.Visible = false;
                cmb_ekpreis.Visible = false;
                cmb_vkpreis.Visible = false;
                lbl_artikelnr.Visible = false;
            }
            else if (rbtn_aktualisieren.Checked)
            {
                txt_bezeichnung.Visible = false;
                txt_ekpreis.Visible = false;
                txt_vkpreis.Visible = false;
                num_anzahl.Visible = true;
                cmb_artikelnr.Visible = true;
                cmb_bezeichnung.Visible = true;
                cmb_ekpreis.Visible = true;
                cmb_vkpreis.Visible = true;
                lbl_artikelnr.Visible = true;
            }
        }

        private void rbtn_aktualisieren_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_neuerartikel.Checked)
            {
                txt_bezeichnung.Visible = true;
                txt_ekpreis.Visible = true;
                txt_vkpreis.Visible = true;
                num_anzahl.Visible = true;
                cmb_artikelnr.Visible = false;
                cmb_bezeichnung.Visible = false;
                cmb_ekpreis.Visible = false;
                cmb_vkpreis.Visible = false;
                lbl_artikelnr.Visible = false;
            }
            else if (rbtn_aktualisieren.Checked)
            {
                txt_bezeichnung.Visible = false;
                txt_ekpreis.Visible = false;
                txt_vkpreis.Visible = false;
                num_anzahl.Visible = true;
                cmb_artikelnr.Visible = true;
                cmb_bezeichnung.Visible = true;
                cmb_ekpreis.Visible = true;
                cmb_vkpreis.Visible = true;
                lbl_artikelnr.Visible = true;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lst_lagerbestand.Items.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Lagerbestand", Form1.con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                lst_lagerbestand.Items.Add("ArtikelNr\tBezeichnung\tEinkaufspreis\tVerkaufspreis\tAnzahl");
                while (reader.Read())
                {
                    lst_lagerbestand.Items.Add(reader.GetValue(0).ToString() + "\t" + reader.GetValue(1).ToString() + "\t\t" + reader.GetValue(2).ToString() + "\t\t" + reader.GetValue(3).ToString() + "\t\t" + reader.GetValue(4).ToString());
                }
            }
            reader.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (rbtn_neuerartikel.Checked)
            {
                if (txt_bezeichnung.Text.Trim() == "" || txt_ekpreis.Text.Trim() == "" || txt_vkpreis.Text.Trim() == "" || num_anzahl.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Passt nid");
                }
                else
                {
                    if (txt_ekpreis.Text.Contains(",") || txt_vkpreis.Text.Contains(","))
                    {
                        MessageBox.Show("Passt nid weil ,");
                    }
                    else
                    {
                        MessageBox.Show("Passt");
                    }
                }
            }
        }
    }
}
