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

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            Form_ListeCabanes ListeCabane = new Form_ListeCabanes();
            ListeCabane.Show(this);
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_AfficheDetail AfficheDetail = new Form_AfficheDetail();
            AfficheDetail.Show(this);
            this.Hide();
        }
    }
}
