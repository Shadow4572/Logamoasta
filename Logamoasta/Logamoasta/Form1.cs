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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables Alex smells
        LogamoastaEntities entity = new LogamoastaEntities();
        public static string group;
        #endregion

        private void btn_anmelden_Click(object sender, EventArgs e)
        {

            CheckUser();

            if(CheckUser())
            {
                Form2 f2 = new Form2();
                f2.Connectionstring = entity.Database.Connection.ConnectionString;
                Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Keine Anmeldung möglich! Falschen Benutzernamen oder falsches Passwort eingegeben.", "Fehler beim Anmelden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUser()
        {
            foreach (Mitarbeiter ma in entity.Mitarbeiter)
            {
                if (ma.Benutzername == txt_benutzername.Text && PasswordHash.Verify(txt_passwort.Text, ma.Passwort))
                {
                    group = ma.Gruppe;
                    return true;
                }
            }
            return false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Checks if connection to the DB is possible
            IDbConnection con = new LogamoastaEntities().Database.Connection;
            try
            {
                con.Open();
                //Split the connectionstring, so only the web location of the db will be shown "Verbunden zu eduweb.kb.local" for example
                string[] connectionsite = con.ConnectionString.Split('=', ';');
                lbl_connection.Text = "Verbunden zu '" + connectionsite[1] + "'.";
            }
            catch
            {
                lbl_connection.Text = "Verbindung zur Datenbank nicht möglich!";
                btn_anmelden.Enabled = false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            if (lbl_connection.Text == "Verbindung zur Datenbank nicht möglich!")
            {
                LogamoastaEntities hakkitzcon = new LogamoastaEntities();
                //replace the connection with web.hak-kitz.at
                hakkitzcon.Database.Connection.ConnectionString = hakkitzcon.Database.Connection.ConnectionString.Replace("eduweb.kb.local", "web.hak-kitz.at");

                IDbConnection con2 = hakkitzcon.Database.Connection;
                try
                {
                    con2.Open();
                    //Split the connectionstring, so only the web location of the db will be shown "Verbunden zu eduweb.kb.local" for example
                    string[] connectionsite = con2.ConnectionString.Split('=', ';');
                    lbl_connection.Text = "Verbunden zu '" + connectionsite[1] + "'.";
                    entity.Database.Connection.ConnectionString = hakkitzcon.Database.Connection.ConnectionString;
                    btn_anmelden.Enabled = true;
                }
                catch
                {
                    lbl_connection.Text = "Verbindung zur Datenbank nicht möglich!";
                    btn_anmelden.Enabled = false;
                }
                finally
                {
                    if (con2.State == ConnectionState.Open)
                    {
                        con2.Close();
                    }
                }
            }
        }

        private void txt_benutzername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_anmelden.PerformClick();
            }
        }

        private void txt_passwort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_anmelden.PerformClick();
            }
        }
    }
}
