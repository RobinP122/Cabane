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

            string requete = "INSERT INTO personnes(Nom, Prenom, Adresse, NoMobile, Email, SiteWeb) VALUES (@Nom,@Prenom,@Adresse,@NoMobile,@Email,@SiteWeb)";
            MySqlParameter[] parametres = new MySqlParameter[6];
            parametres[0] = new MySqlParameter("@Nom", MySqlDbType.String, 50);
            parametres[0].Value = edt_nom.Text;

            parametres[1] = new MySqlParameter("@Prenom", MySqlDbType.String, 50);
            parametres[1].Value = edt_prenom.Text;

            parametres[2] = new MySqlParameter("@Adresse", MySqlDbType.String, 50);
            parametres[2].Value = edt_adresse.Text;

            parametres[3] = new MySqlParameter("@NoMobile", MySqlDbType.String, 50);
            parametres[3].Value = edt_mobile.Text;

            parametres[4] = new MySqlParameter("@Email", MySqlDbType.String, 50);
            parametres[4].Value = edt_email.Text;

            parametres[5] = new MySqlParameter("@SiteWeb", MySqlDbType.String, 50);
            parametres[5].Value = edt_web.Text;

            MySqlDataReader reader = DB.ExecuteSelectQuery(requete,parametres);
            reader.Read();
        }
    }
}
