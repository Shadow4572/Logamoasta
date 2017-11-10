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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables Alex smells
        public static MySqlConnection con = new MySqlConnection("server=eduweb.kb.local;uid=team13;password=T3amO13;database=team13;allowuservariables=True;persistsecurityinfo=True;port=3306;");
        public static string group;
        #endregion

        private void btn_anmelden_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM Mitarbeiter", con);
            string usernamelog = txt_benutzername.Text;
            string passwordlog = txt_passwort.Text;

            MySqlDataReader reader = cmd4.ExecuteReader();
            List<string> Usernames = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usernames.Add(reader.GetValue(1).ToString());
                }
            }
            reader.Close();

            MySqlDataReader reader2 = cmd4.ExecuteReader();
            List<string> Passwords = new List<string>();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    Passwords.Add(reader2.GetValue(2).ToString());
                }
            }
            reader2.Close();

            MySqlDataReader reader3 = cmd4.ExecuteReader();
            List<string> Groups = new List<string>();
            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    Groups.Add(reader3.GetValue(3).ToString());
                }
            }
            reader3.Close();

            int index = Usernames.IndexOf(usernamelog);
            string[] passwordarray = Passwords.ToArray();
            string[] grouparray = Groups.ToArray();

            if (Usernames.Contains(usernamelog) && passwordarray[index].Equals(passwordlog))
            {
                group = grouparray[index].ToString();
                //MessageBox.Show(group);
                Form2 f2 = new Form2();
                Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Keine Anmeldung möglich! Falschen Benutzernamen oder falsches Passwort eingegeben.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("CREATE DATABASE IF NOT EXISTS team13", con);
            MySqlCommand cmd2 = new MySqlCommand("USE team13", con);
            MySqlCommand cmd3 = new MySqlCommand("CREATE TABLE IF NOT EXISTS Mitarbeiter(BID INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL, Benutzername VARCHAR(20), Passwort VARCHAR(20), Gruppe VARCHAR(20))", con);
            MySqlCommand cmd4 = new MySqlCommand("CREATE TABLE IF NOT EXISTS Lagerbestand(ArtikelNr INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL, Bezeichnung VARCHAR(20), Einkaufspreis DECIMAL(10,2), Verkaufspreis DECIMAL(10,2), Anzahl INTEGER)", con);
            MySqlCommand cmd5 = new MySqlCommand("CREATE TABLE IF NOT EXISTS Lagerverlauf(ArtikelNr INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL, Bezeichnung VARCHAR(20), Einkaufspreis DECIMAL(10,2), Verkaufspreis DECIMAL(10,2), Anzahl INTEGER, Benutzer VARCHAR(20))", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                    cmd1.ExecuteNonQuery(); 
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }

            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }

            try
            {
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.ToString());
            }

            try
            {
                cmd4.ExecuteNonQuery();
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.ToString());
            }

            try
            {
                cmd5.ExecuteNonQuery();
            }
            catch (Exception ex5)
            {
                MessageBox.Show(ex5.ToString());
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
