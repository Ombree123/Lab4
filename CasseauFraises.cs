using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CasseauFraises
    {
        private Fraise[] lesFraises = new Fraise[100];
        private string dateEmpaquetage;
        private int taille=100;
        private int espaceInterieur = 100;

        public void ajouterFraise(Fraise fraise)
        {
            if (espaceInterieur-- >= 0)
            {
                espaceInterieur--;
                lesFraises[lesFraises.Count()] = fraise;
            }
            else
                Console.WriteLine("ERREUR : surcharge");
        }

        public void ajouterFraise(Fraise[] fraise)
        {
            if (espaceInterieur >= fraise.Count())
            {
                Fraise[] lesFraisesTemp = new Fraise[lesFraises.Length + fraise.Length];
                Array.Copy(lesFraises, lesFraisesTemp, 0);
                Array.Copy(fraise, 0, lesFraisesTemp, lesFraises.Length, fraise.Length);

                lesFraises = lesFraisesTemp;

                espaceInterieur = espaceInterieur - fraise.Count();
            }
            else
                Console.WriteLine("ERREUR : Surcharge");

            
        }

        public void casseauFraises()
        {

        }

        public void casseauFraises (int taille)
        {
            bool verification = false;

            if (taille <= 100 && taille > 0)
            {
                this.taille = taille;
            }
            else
                do
                {
                    Console.WriteLine("ERREUR taille invalide, veuillez la réentrer");
                    verification = int.TryParse(Console.ReadLine(), out taille);
                    if (taille <= 0 && taille > 100 && verification)
                        verification = false;
                }
                while (!verification);

            Array.Resize(ref lesFraises, taille);
        }

        public void casseauFraises(Fraise[] fraise, int taille)
        {
            bool verification = false;

            if (taille <= 100 && taille > 0)
            {
                this.taille = taille;
            }
            else
                do
                {
                    Console.WriteLine("ERREUR taille invalide, veuillez la réentrer");
                    verification = int.TryParse(Console.ReadLine(), out taille);
                    if (taille <= 0 && taille > 100 && verification)
                        verification = false;
                }
                while (!verification);

            if (taille >= fraise.Count())
                lesFraises = fraise;
            else
                Console.WriteLine("ERREUR : Surcharge");
        }

        public void casseauFraises(CasseauFraises casseauFraises)
        {
            dateEmpaquetage = casseauFraises.dateEmpaquetage;
            taille = casseauFraises.taille;
            espaceInterieur = casseauFraises.espaceInterieur;
            lesFraises = casseauFraises.lesFraises;
        }

        public void viderDeSesFraises()
        {
            lesFraises = new Fraise[taille];
            espaceInterieur = taille;
        }

        public double getTaille()
        {
            return(taille);
        }

        public string afficherDescription()
        {
            espaceInterieur = taille - lesFraises.Count();
            return ("La date d'empaquetage est le " + dateEmpaquetage + " il y a de la place total pour " + taille + " Fraises et son espace interieur est de " + espaceInterieur + " bananes");
        }
    }
}
