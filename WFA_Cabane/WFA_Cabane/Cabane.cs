using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Cabane
{
    public class Cabane
    {
        private int _idCabane;

        public int IdCabane
        {
            get { return _idCabane; }
            set { _idCabane = value; }
        }

        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        private int _Altitude;

        public int Altitude
        {
            get { return _Altitude; }
            set { _Altitude = value; }
        }
        private bool _Douche;

        public bool Douche
        {
            get { return _Douche; }
            set { _Douche = value; }
        }
        private int _NbLits;

        public int NbLits
        {
            get { return _NbLits; }
            set { _NbLits = value; }
        }
        private decimal _Tarif;

        public decimal Tarif
        {
            get { return _Tarif; }
            set { _Tarif = value; }
        }
        private string _Commentaire;

        public string Commentaire
        {
            get { return _Commentaire; }
            set { _Commentaire = value; }
        }

        private string _GPS;

        public string GPS
        {
            get { return _GPS; }
            set { _GPS = value; }
        }
    }
}
