using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Logamoasta
{
    public partial class Form_Mitarbeiter : Form
    {
        public Form_Mitarbeiter()
        {
            InitializeComponent();
        }

        #region Variables
        public string Connectionstring;
        LogamoastaEntities entity = new LogamoastaEntities();
        #endregion

        private void rbtn_maanlegen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_gruppe.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
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
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_mabearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_gruppe.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
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
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_maloeschen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_gruppe.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
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
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void rbtn_masuchen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                txt_benutzername.Visible = true;
                txt_passwort.Visible = true;
                lbl_benutzername.Visible = true;
                lbl_gruppe.Visible = true;
                lbl_passwort.Visible = true;
                cmb_gruppe.Visible = true;
                cmb_benutzername.Visible = false;
                cmb_bid.Visible = false;
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
                txt_passwort.Visible = false;
                lbl_passwort.Visible = false;
            }
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            var mitarbeiterQuery = from Mitarbeiter in entity.Mitarbeiter select Mitarbeiter;

            List<Mitarbeiter> mitarbeiterList = mitarbeiterQuery.ToList();

            dat_mitarbeiter.DataSource = mitarbeiterList;
        }

        private int CheckID()
        {
            for (int i = 1; true; i++)
            {
                //goes on until it finds a ID which has not been used
                if (entity.Mitarbeiter.Where(x => x.BID == i).FirstOrDefault() == null)
                {
                    return i;
                }
            }
        }

        private bool CheckBenutzer()
        {
            foreach (Mitarbeiter ma in entity.Mitarbeiter)
            {
                if (ma.Benutzername == txt_benutzername.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void Form_Mitarbeiter_Load(object sender, EventArgs e)
        {
            /*mitarbeiter_lst.Items.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Mitarbeiter", Form1.con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                mitarbeiter_lst.Items.Add("BID\tBenutzername\tGruppe");
                while (reader.Read())
                {
                    mitarbeiter_lst.Items.Add(reader.GetValue(0).ToString() + "\t" + reader.GetValue(1).ToString() + "\t" + reader.GetValue(3).ToString());
                }
            }
            reader.Close();*/

            entity.Database.Connection.ConnectionString = Connectionstring;

            LoadData();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (rbtn_maanlegen.Checked)
            {
                if (txt_benutzername.Text.Trim() == "" || txt_passwort.Text.Trim() == "" || cmb_gruppe.Text.Trim() == "")
                {
                    MessageBox.Show("Passt nid");
                }
                else
                {
                    /*MySqlCommand cmd2 = new MySqlCommand("INSERT INTO Mitarbeiter (Benutzername, Gruppe, Passwort) VALUES ('" + txt_benutzername.Text + "', '" + cmb_gruppe.Text + "', '" + txt_passwort.Text + "')", Form1.con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    List<string> Bezeichnungen = new List<string>();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            Bezeichnungen.Add(reader2.GetValue(1).ToString());
                        }
                    }
                    reader2.Close();
                    if (Bezeichnungen.Contains(txt_benutzername.Text))
                    {
                        MessageBox.Show("Passt nid, weil scho vorhondn");
                    }
                    else
                    {
                        MessageBox.Show("Passt");
                        cmd2.ExecuteNonQuery();
                    }*/

                    if (CheckBenutzer())
                    {
                        MessageBox.Show("Passt nid, weil scho vorhondn");
                    }
                    else
                    {
                        try
                        {
                            Mitarbeiter ma = new Mitarbeiter();

                            ma.BID = CheckID();
                            ma.Benutzername = txt_benutzername.Text;
                            ma.Passwort = PasswordHash.Hash(txt_passwort.Text);
                            ma.Gruppe = cmb_gruppe.Text;

                            entity.Mitarbeiter.Add(ma);

                            entity.SaveChanges();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}

