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
    public partial class Form_ListeContacts : Form
    {
        public Form_ListeContacts()
        {
            InitializeComponent();
        }

        // Initialise la connexion.
        ConnexionDB DB;

        private void Form_ListeContacts_Load(object sender, EventArgs e)
        {
            LstBx_ListeContact.Items.Clear();
            try
            {
                DB = new ConnexionDB();

                // Execute la requête.
                MySqlDataReader Reader = DB.ExecuteSelectQuery("select idPersonne, Nom from personnes");
                while (Reader.Read())
                {
                    Contact contact = new Contact();
                    contact.IdPersonne = Convert.ToInt32(Reader["idPersonne"].ToString());
                    contact.Nom = Reader["Nom"].ToString();
                    
                   LstBx_ListeContact.Items.Add(contact);
                   LstBx_ListeContact.DisplayMember = "Nom";
                   LstBx_ListeContact.ValueMember = "IdPersonne";
                }
                Reader.Close();
            }
            catch
            {  // Message d'information.
                MessageBox.Show("connexion à la base de données impossible");
            }
        }

        // Permet la recherche d'une cabane.
        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            // Test si l'edit est vide.
            if (TxtBx_Recherche.Text == "")
            {
                Form_ListeContacts_Load(sender, e);
            }
            else
            {
                LstBx_ListeContact.Items.Clear();
                string recherche = TxtBx_Recherche.Text; // Récupère la valeur recherchée.
                string requete = "select idPersonne, Prenom , Nom from personnes where Nom REGEXP @Nom"; // Initialise la requete
                MySqlParameter[] parametres = new MySqlParameter[1]; // Cré une variable pour des paramètres
                parametres[0] = new MySqlParameter("@Nom", MySqlDbType.VarChar, 50); // Ajoute un paramètre à la variable
                parametres[0].Value = recherche; // Initialise le paramètre
                try
                {  // Recupère les valeurs selon la requête.
                    MySqlDataReader Reader = DB.ExecuteSelectQuery(requete, parametres);
                    
                    if (Reader.FieldCount >= 0)
                    {
                        while (Reader.Read())
                        {
                            Contact contact = new Contact();
                            contact.IdPersonne = Convert.ToInt32(Reader["idPersonne"].ToString());
                            contact.Nom = Reader["Nom"].ToString();
                            LstBx_ListeContact.Items.Add(contact);
                        }
                    }
                    else
                    {   // Message d'information.
                        LstBx_ListeContact.Items.Add("il n'existe pas de résultats pour la recherche \"" + recherche + "\"");
                    }
                    Reader.Close();
                }
                catch
                {   // Message d'information.
                    LstBx_ListeContact.Items.Add("recherche impossible");
                }
            }
        }
        
        // Execute la requête à chaque modification du contenu de l'edit.
        private void TxtBx_Recherche_TextChanged(object sender, EventArgs e)
        {
            Btn_Recherche_Click(sender, e);
        }

        // Affiche le menu principal.
        private void Form_ListeContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
