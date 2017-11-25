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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region Variables
        //public int index;
        public string Connectionstring;
        LogamoastaEntities entity = new LogamoastaEntities();
        #endregion

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

        //MySqlCommand cmd = new MySqlCommand("SELECT * FROM Lagerbestand", Form1.con);

        private void Form3_Load(object sender, EventArgs e)
        {
            /*lst_lagerbestand.Items.Clear();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                lst_lagerbestand.Items.Add("ArtikelNr\tBezeichnung\tEinkaufspreis\tVerkaufspreis\tAnzahl");
                while (reader.Read())
                {
                    lst_lagerbestand.Items.Add(reader.GetValue(0).ToString() + "\t" + reader.GetValue(1).ToString() + "\t\t" + reader.GetValue(2).ToString() + "\t\t" + reader.GetValue(3).ToString() + "\t\t" + reader.GetValue(4).ToString());
                }
            }
            reader.Close();*/

            entity.Database.Connection.ConnectionString = Connectionstring;

            LoadData();
        }

        private void LoadData()
        {
            var lagerbestandQuery = from Lagerbestand in entity.Lagerbestand select Lagerbestand;

            List<Lagerbestand> lagerbestandList = lagerbestandQuery.ToList();

            dat_lagerbestand.DataSource = lagerbestandList;
        }

        private int CheckID()
        {
            for (int i = 1; true; i++)
            {
                //goes on until it finds a ID which has not been used
                if (entity.Lagerbestand.Where(x => x.ArtikelNr == i).FirstOrDefault() == null)
                {
                    return i;
                }
            }
        }

        private bool CheckBezeichnung()
        {
            foreach (Lagerbestand lb in entity.Lagerbestand)
            {
                if (lb.Bezeichnung == txt_bezeichnung.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Lagerbestand bestand = new Lagerbestand();

            if (rbtn_neuerartikel.Checked)
            {
                if (txt_bezeichnung.Text.Trim() == "" || txt_ekpreis.Text.Trim() == "" || txt_vkpreis.Text.Trim() == "" || num_anzahl.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Passt nid weil laar");
                }
                else
                {
                    try
                    {
                        Convert.ToDecimal(txt_ekpreis.Text);
                        Convert.ToDecimal(txt_vkpreis.Text);

                        /*MySqlCommand cmd2 = new MySqlCommand("INSERT INTO Lagerbestand (Bezeichnung, Einkaufspreis, Verkaufspreis, Anzahl) VALUES ('" + txt_bezeichnung.Text + "', '" + txt_ekpreis.Text + "', '" + txt_vkpreis.Text + "', '" + num_anzahl.Value.ToString() + "')", Form1.con);

                        MySqlDataReader reader2 = cmd.ExecuteReader();
                        List<string> Bezeichnungen = new List<string>();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                Bezeichnungen.Add(reader2.GetValue(1).ToString());
                            }
                        }
                        reader2.Close();*/

                        if (CheckBezeichnung()) //Bezeichnungen.Contains(txt_bezeichnung.Text)
                        {
                            MessageBox.Show("Passt nid, weil scho vorhondn");
                        }
                        else
                        {
                            try
                            {
                                //cmd2.ExecuteNonQuery();

                                bestand.ArtikelNr = CheckID();
                                bestand.Bezeichnung = txt_bezeichnung.Text;
                                bestand.Einkaufspreis = Convert.ToDecimal(txt_ekpreis.Text);
                                bestand.Verkaufspreis = Convert.ToDecimal(txt_vkpreis.Text);
                                bestand.Anzahl = Convert.ToInt32(num_anzahl.Value);

                                entity.Lagerbestand.Add(bestand);

                                try
                                {
                                    entity.SaveChanges();
                                }
                                catch (Exception)
                                {

                                    throw;
                                }

                                LoadData();

                                /*MySqlDataReader reader3 = cmd.ExecuteReader();
                                if (reader3.HasRows)
                                {
                                    while (reader3.Read())
                                    {
                                        index = Convert.ToInt32(reader3.GetValue(0));
                                        
                                    }
                                    lst_lagerbestand.Items.Add(index.ToString() + "\t" + txt_bezeichnung.Text + "\t\t" + txt_ekpreis.Text + "\t\t" + txt_vkpreis.Text + "\t\t" + num_anzahl.Value.ToString());
                                }
                                reader3.Close();*/                                

                                MessageBox.Show("Passt");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Passt nid weil nid numeric. Schau weng an .");
                        //MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
