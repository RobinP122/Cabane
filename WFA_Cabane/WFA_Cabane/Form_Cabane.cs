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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Cabane_Load(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection("Database=kyjk_cabaneGroupeC;server=kyjk.myd.infomaniak.com;User Id=kyjk_adminC;pwd=cabane14c");
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
    }
}
