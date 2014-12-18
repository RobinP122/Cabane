using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Cabane
{
    public class Contact
    {
        private int _idPersonne;
        public int IdPersonne
        {
            get { return _idPersonne; }
            set { _idPersonne = value; }
        }

        private string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private string _Prenom;
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        private string _Adresse;
        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }

        private string _Telephone;
        public string Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        private string _Mail;
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private string _SiteWeb;
        public string SiteWeb
        {
            get { return _SiteWeb; }
            set { _SiteWeb = value; }
        }
    }
}
