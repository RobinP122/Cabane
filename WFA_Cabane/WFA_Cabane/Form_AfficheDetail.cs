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
    public partial class Form_AfficheDetail : Form
    {
        public Form_AfficheDetail()
        {
            InitializeComponent();
        }

        private void Form_AfficheDetail_Load(object sender, EventArgs e)
        {
            ConnexionDB DB = new ConnexionDB();

            //Nom
            string requete = "SELECT Nom, Altitude, Douche, NbLits, GPS, Tarif, Commentaire FROM cabanes WHERE @idCabane;";
            MySqlParameter[] parametres = new MySqlParameter[1];
            parametres[0] = new MySqlParameter("@idCabane", MySqlDbType.Int32, 2);
            parametres[0].Value = 1;
            try
            {
                MySqlDataReader reader = DB.ExecuteSelectQuery(requete, parametres);
                reader.Read();
                Lbl_Nom.Text = reader["Nom"].ToString();
                Lbl_Altitude.Text = reader["Altitude"].ToString();
                if (reader["Douche"] == 1)
                {
                    Lbl_Douche.Text = "Oui";
                }
                else
                {
                    Lbl_Douche.Text = "Non";
                }
                
                Lbl_NbLits.Text = reader["NbLits"].ToString();
                Lbl_GPS.Text = reader["GPS"].ToString();
                Lbl_Tarif.Text = reader["Tarif"].ToString();
                Edt_Commentaires.Text = reader["Commentaire"].ToString();
                reader.Close();
            }
            catch(Exception x)
            {
                Lbl_Nom.Text = "Erreur / "+ x.Message;
            }
        }
    }
}
