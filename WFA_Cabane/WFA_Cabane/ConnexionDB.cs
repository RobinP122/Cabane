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
        static MySqlConnection CnxDB = null;


        private MySqlConnection connexion()
        {
            if (CnxDB == null)
            {
                try
                {
                    CnxDB = new MySqlConnection("Database=cabanes;server=127.0.0.1;User Id=root;pwd=");
                    CnxDB.Open();
                }
                catch
                {
                    CnxDB = null;
                }

                return CnxDB;
            }
            else
            {
                return CnxDB;
            }
        }
        public MySqlDataReader ExecuteSelectQuery(string requete, MySqlParameter[] parametres = null)
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
            MySqlDataReader Reader = commande.ExecuteReader();
            return Reader;
        }
    }
}
