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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        public string Connectionstring;
        LogamoastaEntities entity = new LogamoastaEntities();

        private void btn_abmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lagerbestand_Click(object sender, EventArgs e)
        {
            Form_Lagerbestand f_bestand = new Form_Lagerbestand();
            f_bestand.Connectionstring = entity.Database.Connection.ConnectionString;
            Hide();
            f_bestand.ShowDialog();
            Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            if(Form_Login.group.Equals("Moasta"))
            {
                btn_mitarbeiter.Visible = true;
            }
            else
            {
                btn_mitarbeiter.Visible = false;
            }

            entity.Database.Connection.ConnectionString = Connectionstring;
        }

        private void btn_mitarbeiter_Click(object sender, EventArgs e)
        {
            Form_Mitarbeiter f_ma = new Form_Mitarbeiter();
            f_ma.Connectionstring = entity.Database.Connection.ConnectionString;
            Hide();
            f_ma.ShowDialog();
            Show();
        }

        private void btn_lagerverlauf_Click(object sender, EventArgs e)
        {
            Form_Lagerverlauf f_verlauf = new Form_Lagerverlauf();
            f_verlauf.Connectionstring = entity.Database.Connection.ConnectionString;
            Hide();
            f_verlauf.ShowDialog();
            Show();
        }
    }
}
