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
    public partial class Form_ListeCabanes : Form
    {
        public Form_ListeCabanes()
        {
            InitializeComponent();
        }

        ConnexionDB DB;

        private void Form_ListeCabanes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Form_ListeCabanes_Load(object sender, EventArgs e)
        {
            LstBx_ListeCabane.Items.Clear();
            try
            {
                DB = new ConnexionDB();

                MySqlDataReader Reader = DB.ExecuteSelectQuery("select Nom from Cabanes");
                while (Reader.Read())
                {
                    LstBx_ListeCabane.Items.Add(Reader["Nom"].ToString());
                }
                Reader.Close();
            }
            catch
            {
                MessageBox.Show("connexion à la base de données impossible");
            }
        }

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            if (TxtBx_Recherche.Text == "")
            {
                Form_ListeCabanes_Load(sender, e);
            }
            else
            {
                LstBx_ListeCabane.Items.Clear();
                string recherche = TxtBx_Recherche.Text;
                string requete = "select Nom from cabanes where Nom REGEXP @Nom";
                MySqlParameter[] parametres = new MySqlParameter[1];
                parametres[0] = new MySqlParameter("@Nom", MySqlDbType.VarChar, 50);
                parametres[0].Value = recherche;
                try
                {
                    MySqlDataReader Reader = DB.ExecuteSelectQuery(requete, parametres);
                    if (Reader.FieldCount >= 0)
                    {
                        while (Reader.Read())
                        {
                            LstBx_ListeCabane.Items.Add(Reader["Nom"].ToString());
                        }
                    }
                    else
                    {
                        LstBx_ListeCabane.Items.Add("il n'existe pas de résultats pour la recherche \"" + recherche + "\"");
                    }
                    Reader.Close();
                }
                catch
                {
                    LstBx_ListeCabane.Items.Add("recherche impossible");
                }
            }
        }

        private void TxtBx_Recherche_TextChanged(object sender, EventArgs e)
        {
            Btn_Recherche_Click(sender, e);
        }
    }
}
