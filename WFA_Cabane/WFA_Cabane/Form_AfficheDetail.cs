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

        private Int32 idCabane;

        public Int32 IdCabane
        {
            get { return idCabane; }
            set { idCabane = value; }
        }

        private void Form_AfficheDetail_Load(object sender, EventArgs e)
        {
            ConnexionDB DB = new ConnexionDB();

            //Nom
            string requete = "SELECT Nom, Altitude, Douche, NbLits, GPS, Tarif, Commentaire FROM cabanes WHERE idCabane = @idCabane;";
            MySqlParameter[] parametres = new MySqlParameter[1];
            parametres[0] = new MySqlParameter("@idCabane", MySqlDbType.Int32, 2);
            parametres[0].Value = idCabane;
            try
            {
                MySqlDataReader reader = DB.ExecuteSelectQuery(requete, parametres);
                reader.Read();
                Lbl_Nom.Text = reader["Nom"].ToString();
                Lbl_Altitude.Text = reader["Altitude"].ToString();                
                if (reader["Douche"].ToString() == "True")
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
            catch (Exception x)
            {
                Lbl_Nom.Text = "Erreur / " + x.Message;
            }
        }

        private void Form_AfficheDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            Form_EditerCabane EditerCabane = new Form_EditerCabane();
            EditerCabane.IdCabane = idCabane;
            EditerCabane.Show(this);
            this.Hide();
        }

        private void Form_AfficheDetail_VisibleChanged(object sender, EventArgs e)
        {
            this.Form_AfficheDetail_Load(this, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
