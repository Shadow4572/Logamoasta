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
    public partial class Form_Lagerverlauf : Form
    {
        public Form_Lagerverlauf()
        {
            InitializeComponent();
        }

        #region Variables
        public string Connectionstring;
        LogamoastaEntities entity = new LogamoastaEntities();
        #endregion

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Lagerverlauf_Load(object sender, EventArgs e)
        {
            entity.Database.Connection.ConnectionString = Connectionstring;
        }
    }
}
