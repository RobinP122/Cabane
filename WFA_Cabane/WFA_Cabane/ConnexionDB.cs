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
        public MySqlDataReader ExecuteSelectQuery(string requete)
        {
            this.connexion();
            MySqlCommand commande = new MySqlCommand(requete, CnxDB);
            MySqlDataReader Reader = commande.ExecuteReader();
            return Reader;
        }
    }
}
