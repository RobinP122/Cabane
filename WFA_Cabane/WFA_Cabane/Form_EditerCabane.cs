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
    public partial class Form_EditerCabane : Form
    {
        public Form_EditerCabane()
        {
            InitializeComponent();
        }

        private Cabane EditedCabane;

        private Int32 idCabane;

        public Int32 IdCabane
        {
            get { return idCabane; }
            set { idCabane = value; }
        }

        

        private void Form_EditerCabane_Load(object sender, EventArgs e)
        {
            ConnexionDB DB = new ConnexionDB();
            string requete = "SELECT Nom, Altitude, Douche, NbLits, GPS, Tarif, Commentaire FROM cabanes WHERE @idCabane;";
            MySqlParameter[] parametres = new MySqlParameter[1];
            parametres[0] = new MySqlParameter("@idCabane", MySqlDbType.Int32, 2);
            parametres[0].Value = idCabane;
            try
            {
                MySqlDataReader reader = DB.ExecuteSelectQuery(requete, parametres);
                reader.Read();
                EditedCabane = new Cabane();
                EditedCabane.IdCabane = idCabane;
                EditedCabane.Nom = reader["Nom"].ToString();
                EditedCabane.Altitude = Convert.ToInt32(reader["Altitude"].ToString());
                if (reader["Douche"].ToString() == "1")
                {
                    EditedCabane.Douche = true;
                }
                else
                {
                    EditedCabane.Douche = false;
                }

                EditedCabane.NbLits = Convert.ToInt32(reader["NbLits"].ToString());
                EditedCabane.Tarif = Convert.ToDecimal(reader["Tarif"].ToString());
                EditedCabane.Commentaire = reader["Commentaire"].ToString();
                reader.Close();

                TxtBxNom.Text = EditedCabane.Nom;
                NumAltitude.Value = EditedCabane.Altitude;
                NumNbLits.Value = EditedCabane.NbLits;
                if (EditedCabane.Douche)
                {
                    RdBtnNon.Checked = false;
                    RdBtnOui.Checked = true;
                }else
                {
                    RdBtnNon.Checked = true;
                    RdBtnOui.Checked = false;
                }
                TxtBxTarif.Text = Convert.ToString(EditedCabane.Tarif);
                TxtBxCommentaires.Text = EditedCabane.Commentaire;
            }
            catch (Exception x)
            {
                
            }
        }

        private void Form_EditerCabane_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (EditedCabane.Nom != TxtBxNom.Text)
            {
                EditedCabane.Nom = TxtBxNom.Text;
            }
            if (EditedCabane.Altitude != NumAltitude.Value)
            {
                EditedCabane.Altitude = Convert.ToInt32(NumAltitude.Value);
            }
            if (EditedCabane.Commentaire != TxtBxCommentaires.Text)
            {
                EditedCabane.Commentaire = TxtBxCommentaires.Text;
            }
            if (EditedCabane.NbLits != NumNbLits.Value)
            {
                EditedCabane.NbLits = Convert.ToInt32(NumNbLits.Value);
            }
            if (EditedCabane.Tarif != Convert.ToDecimal(TxtBxTarif.Text))
            {
                EditedCabane.Tarif = Convert.ToDecimal(TxtBxTarif.Text);
            }
            if (RdBtnNon.Checked)
            {
                EditedCabane.Douche = false;
            }
            else
            {
                EditedCabane.Douche = true;
            }

        }
    }
}
