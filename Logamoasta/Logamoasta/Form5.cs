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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        #region Variables
        public string Connectionstring;
        LogamoastaEntities entity = new LogamoastaEntities();
        #endregion

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            entity.Database.Connection.ConnectionString = Connectionstring;
        }
    }
}
