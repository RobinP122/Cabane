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

        public MySqlConnection connexion()
        {
            if (CnxDB == null){
                CnxDB = new MySqlConnection("Database=cabanes;server=127.0.0.1;User Id=root;pwd=");             
                CnxDB.Open();
                return CnxDB;
            }else{
                return CnxDB;
            }
        }
        public MySqlDataReader ExecuteReadQuery(string requete, MySqlConnection conn)
        {
            MySqlCommand commande = new MySqlCommand(requete, conn);
            MySqlDataReader Reader = commande.ExecuteReader();
            return Reader;
        }
    }
}
