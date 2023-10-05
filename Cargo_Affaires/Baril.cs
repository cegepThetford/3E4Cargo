using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo_Affaires
{
    public class Baril
    {
        private int _quantite;
        private string _nomProduit;
        public const int CAPACITE = 50;
        public int Quantite { get { return _quantite; } set { _quantite = value; } }
        public string NomProduit { get { return _nomProduit; } set { _nomProduit = value; } }

        public Baril(int qte, string nomProduit)
        {
            _quantite = qte;
            _nomProduit = nomProduit;
        }
        public bool estPlein() { return false; }
        public bool estVide() { return false; }
        public bool estCompatible(Baril autreBaril) { return false; }
        public void transvider(Baril autreBaril)
        {
        }
        public void soustraire(int qte)
        {
        }
    }
}
