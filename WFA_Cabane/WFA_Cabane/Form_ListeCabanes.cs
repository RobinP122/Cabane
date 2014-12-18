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

                MySqlDataReader Reader = DB.ExecuteSelectQuery("select idCabane,Nom from cabanes");
                while (Reader.Read())
                {
                    Cabane cabane = new Cabane();
                    cabane.IdCabane = Convert.ToInt32(Reader["idCabane"].ToString());
                    cabane.Nom = Reader["Nom"].ToString();
                    LstBx_ListeCabane.Items.Add(cabane);
                    LstBx_ListeCabane.DisplayMember = "Nom";
                    LstBx_ListeCabane.ValueMember = "IdCabane";
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
                string recherche = TxtBx_Recherche.Text; // Récupère la valeur recherchée.
                string requete = "select idCabane, Nom from cabanes where Nom REGEXP @Nom"; // Initialise la requete
                MySqlParameter[] parametres = new MySqlParameter[1]; // Cré une variable pour des paramètres
                parametres[0] = new MySqlParameter("@Nom", MySqlDbType.VarChar, 50); // Ajoute un paramètre à la variable
                parametres[0].Value = recherche; // Initialise le paramètre
                try
                {
                    MySqlDataReader Reader = DB.ExecuteSelectQuery(requete, parametres);
                    
                    if (Reader.FieldCount >= 0)
                    {
                        while (Reader.Read())
                        {
                            Cabane cabane = new Cabane();
                            cabane.IdCabane = Convert.ToInt32(Reader["idCabane"].ToString());
                            cabane.Nom = Reader["Nom"].ToString();
                            LstBx_ListeCabane.Items.Add(cabane);

                            //LstBx_ListeCabane.
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

        private void LstBx_ListeCabane_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            Form_AfficheDetail AfficheDetail = new Form_AfficheDetail();
            Cabane selectedCabane = (Cabane)LstBx_ListeCabane.SelectedItem;
            AfficheDetail.IdCabane = selectedCabane.IdCabane;
            AfficheDetail.Show(this);
            this.Hide();

        }
    }
}
