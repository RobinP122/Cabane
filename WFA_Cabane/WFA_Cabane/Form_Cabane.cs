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
    public partial class Form_Cabane : Form
    {
        public Form_Cabane()
        {
            InitializeComponent();
        }

           

        private void Form_Cabane_Load(object sender, EventArgs e)
        {



            MySqlConnection Conn = new MySqlConnection("Database=cabanes;server=127.0.0.1;User Id=root;pwd=");
            string requete = "SELECT Nom FROM cabanes WHERE idCabane = 1";

            try
            {
                MySqlCommand req = new MySqlCommand(requete, Conn);
                Conn.Open();
                MySqlDataReader Requete = req.ExecuteReader();
                Requete.Read();
                Lbl_Titre.Text = Requete.GetValue(0).ToString();

                Conn.Close();
            }
            catch
            {
               Lbl_Titre.Text = "Erreur";
            }
        }

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            Form_ListeCabanes ListeCabane = new Form_ListeCabanes();
            ListeCabane.Show(this);
            this.Hide();
        }
    }
}
