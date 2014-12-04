using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace WFA_Cabane
{
    class ConnexionDB
    {
        // Initialise la variable.
        static MySqlConnection CnxDB = null;

        // Procédure de connexion à la base.
        private MySqlConnection connexion()
        {
            if (CnxDB == null)
            {
                try // Essaie de se connecter à la base.

                {   // Données de connexion.
                    CnxDB = new MySqlConnection("Database=cabanes;server=127.0.0.1;User Id=root;pwd=");
                    CnxDB.Open(); // Ouverture de la connexion.
                }
                catch
                {
                    CnxDB = null; // Si erreur de connexion à la base informe utilisateur.
                }

                return CnxDB;
            }
            else
            {
                return CnxDB;
            }
        }
        // Procédure qui execute les requêtes de type "SELECT".
        public MySqlDataReader ExecuteSelectQuery(string requete, MySqlParameter[] parametres = null)
        {
            this.connexion();
            // Prépare la requête.
            MySqlCommand commande = new MySqlCommand(requete, CnxDB);
            int compteur;
            if (parametres != null)
            {   // Ajoute les paramètres présent dans le tableau à la requête.
                for (compteur = 0; compteur <= parametres.Count() - 1; compteur++)
                {
                    commande.Parameters.Add(parametres[compteur]);
                }
            }       
            // Execute la requête.
            MySqlDataReader Reader = commande.ExecuteReader();
            return Reader;
        }
        public MySqlCommand ExecuteQuery(string requete, MySqlParameter[] parametres = null)
        {
            this.connexion();
            MySqlCommand commande = new MySqlCommand(requete, CnxDB);
            int compteur;
            if (parametres != null)
            {
                for (compteur = 0; compteur <= parametres.Count() - 1; compteur++)
                {
                    commande.Parameters.Add(parametres[compteur]);
                }
            }
            commande.ExecuteNonQuery();
            return commande;
        }
    }
}
