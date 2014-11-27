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
using MySql.Data.Types;

namespace WFA_Cabane
{
    public partial class Form_AjoutContact : Form
    {
        public Form_AjoutContact()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            ConnexionDB DB = new ConnexionDB();

            string requete = "INSERT INTO `personnes`(`Nom`, `Prenom`, `Adresse`, `NoMobile`, `Email`, `SiteWeb`) VALUES ([test],[wd],[wqd],[341],[adw],[qqdwawd])";
        }
    }
}
