using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIEFLIAGE
{
    internal class Etudiant
    {
        public Etudiant()
        {
        }

        public int Id {  get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int IdClasse { get; set; }
        public  Classe classe { get; set; }
        


    }

    internal class ViewEtudiant
    {
        

        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Libelle { get; set; }
        



    }
}
