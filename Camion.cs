using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Camion
    {
        private double tailleCoffre=10000, tailleContenuActuel=10000;  //Je me suis tromper j'ai fait place libre mais je devrais arriver au même résultat
        private CaisseBananes[] contenuBananes;
        private CaissePommes[] contenuPommes;
        private CasseauFraises[] contenuFraises;

        public void charger(CaisseBananes caisse)
        {
            if ((tailleContenuActuel - caisse.getTaille()) >= 0)
            {
                contenuBananes[contenuBananes.Count()] = caisse;
                tailleContenuActuel = tailleContenuActuel - caisse.getTaille();
            }
            else
                Console.WriteLine("ERREUR : Surcharge");
            
        }

        public void charger(CaisseBananes[] caisses)
        {
            double tailleCharge=0;

            for (int i = 0; i < caisses.Count(); i++)
            {
                tailleCharge = tailleCharge + caisses[i].getTaille();
            }

            if ((tailleContenuActuel - tailleCharge) >= 0)
                contenuBananes = caisses;
            else
                Console.WriteLine("Erreur, surcharge");
        }

        public void charger(CaissePommes caisse)
        {
            if ((tailleContenuActuel - caisse.getTaille()) >= 0)
            {
                contenuPommes[contenuPommes.Count()] = caisse;
                tailleContenuActuel = tailleContenuActuel - caisse.getTaille();
            }
            else
                Console.WriteLine("ERREUR : Surcharge");
        }

        public void charger(CaissePommes[] caisses)
        {
            double tailleCharge = 0;

            for (int i = 0; i < caisses.Count(); i++)
            {
                tailleCharge = tailleCharge + caisses[i].getTaille();
            }

            if ((tailleContenuActuel - tailleCharge) >= 0)
                contenuPommes = caisses;
            else
                Console.WriteLine("Erreur, surcharge");
        }

        public void charger(CasseauFraises casseau)
        {
            if ((tailleContenuActuel - casseau.getTaille()) >= 0)
            {
                contenuFraises[contenuFraises.Count()] = casseau;
                tailleContenuActuel = tailleContenuActuel - casseau.getTaille();
            }
            else
                Console.WriteLine("ERREUR : Surcharge");
        }

        public void charger(CasseauFraises[] casseaux)
        {
            double tailleCharge = 0;

            for (int i = 0; i < casseaux.Count(); i++)
            {
                tailleCharge = tailleCharge + casseaux[i].getTaille();
            }

            if ((tailleContenuActuel - tailleCharge) >= 0)
                contenuFraises = casseaux;
            else
                Console.WriteLine("Erreur, surcharge");
        }

        public void dechargerPommes()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuPommes.Count(); i++)
            {
                tailleCharge = tailleCharge + contenuPommes[i].getTaille();
            }

            tailleContenuActuel = tailleContenuActuel + tailleCharge;

            contenuPommes = null;

        }

        public void dechargerBananes()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuBananes.Count(); i++)
            {
                tailleCharge = tailleCharge + contenuBananes[i].getTaille();
            }

            tailleContenuActuel = tailleContenuActuel + tailleCharge;

            contenuBananes = null;
        }

        public void dechargerFraises()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuFraises.Count(); i++)
            {
                tailleCharge = tailleCharge + contenuFraises[i].getTaille();
            }

            tailleContenuActuel = tailleContenuActuel + tailleCharge;

            contenuFraises = null;
        }

        public string afficherDescription()
        {
            return ("Le camion a une taille de "+tailleCoffre+" et "+tailleContenuActuel+"d'espace libre.");
        }
    }
}
