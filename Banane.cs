using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Banane
    {
        private sbyte variete;              //variete 1-2-3
        private string dateCueillette;
        private sbyte murete;
        private string couleur;

        public bool banane(sbyte variete, string dateCueillette)
        {
            bool verification=true;

            if(variete == 1 || variete==2 || variete==3)
            this.variete = variete;
            else
            { 
                verification = false;
                do
                {    
                Console.WriteLine("ERREUR dans la variete, 1 2 ou 3, veuillez la réentrer");
                if (variete == 1 || variete == 2 || variete == 3)
                    verification = true;
                }while(!verification);
          }

            this.dateCueillette = dateCueillette;

            return (verification);
        }

        public void banane(Banane banane)
        {
            variete = banane.variete;
            dateCueillette = banane.dateCueillette;
            murete = banane.murete;
            couleur = banane.couleur;
        }

        public void banane()
        {
            return;
        }

        public string afficherDescription()
        {
            return ("La banane est de la veriété numéro " + variete + ", sa date de cueillette est " + dateCueillette + " sa mureté est de " + murete + "% et sa couleur est " + couleur);
        }

        public void murir(sbyte nouvelleMurete)
        {
            bool verification = false;
            if (nouvelleMurete>=0 && nouvelleMurete <= 100)
            {
                murete = nouvelleMurete;
            }
            else
                do
                {
                Console.WriteLine("ERREUR mureté invalide, veuillez la réentrer");
                verification = sbyte.TryParse(Console.ReadLine(), out nouvelleMurete);
                if (nouvelleMurete < 0 || nouvelleMurete > 100 && verification)
                    verification = false;
                }
                while(!verification);          
        }

        private void mettreAJourCouleur()
        {
            if (murete >= 50)
                couleur = "jaune";
            else
                couleur = "vert";
        }
    }
}
