using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo_Affaires
{
    public class Cargo
    {
        private string _nom;
        private int _capacite;
        private List<Baril> _barils;
        public string Nom { get { return _nom; } set { _nom = value; } }
        public int Capacite { get { return _capacite; } set { _capacite = value; } }
        public List<Baril> Barils { get { return _barils; } set { _barils = value; } }

        public Cargo(string nom, int capacite)
        {
            _nom = nom;
            _capacite = capacite;
            _barils = new List<Baril>();
        }
        public void ajouter(Baril baril)
        {
            // completer le dernier baril compatible
            // s'il reste toujours une qte dans le baril recu, 
            // ajouter un nouveau baril avec ce contenu, vider le baril recu
        }
        public int calculerNbUnites(string nomProduit)
        {
            return 0;
        }
        public bool estPlein() { return false; }
        public int denombrerBarils() { return 0; }
    }
}
