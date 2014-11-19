﻿using System;
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
            try
            {
                DB = new ConnexionDB();

                MySqlDataReader Reader = DB.ExecuteSelectQuery("select Nom from Cabanes");
                while (Reader.Read())
                {
                    LstBx_ListeCabane.Items.Add(Reader["Nom"].ToString());                        
                }
                
            }
            catch
            {
                MessageBox.Show("connexion à la base de données impossible");                
            }
        }
    }
}
