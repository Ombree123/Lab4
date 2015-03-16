using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Fraise
    {
        private sbyte variete;
        private string dateCueillette;
        private sbyte murete;
        private bool possedeSaFeuille;

        public void fraise(sbyte variete, string dateCueillette, bool possedeSaFeuille)
        {
            bool verification = true;

            if (variete == 1 || variete == 2 || variete == 3)
                this.variete = variete;
            else
            {
                verification = false;
                do
                {
                    Console.WriteLine("ERREUR dans la variete, 1 2 ou 3, veuillez la réentrer");
                    if (variete == 1 || variete == 2 || variete == 3)
                        verification = true;
                } while (!verification);
            }

            this.dateCueillette = dateCueillette;

            this.possedeSaFeuille = possedeSaFeuille;
        }

        public void fraise(Fraise fraise)
        {
            variete = fraise.variete;
            dateCueillette = fraise.dateCueillette;
            murete = fraise.murete;
            possedeSaFeuille = fraise.possedeSaFeuille;
        }

        public void fraise()
        {

        }

        public void arracherFeuille()
        {
            possedeSaFeuille = false;
        }

        public void setMurete(sbyte nouvelleMurete)
        {
            bool verification = false;

            if (nouvelleMurete >= 0 && nouvelleMurete <= 100)
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
                while (!verification); 
        }

        public string afficherDescription()
        {
            return ("La fraise est de la veriété numéro " + variete + ", sa date de cueillette est " + dateCueillette + " sa mureté est de " + murete + "% et il est " + possedeSaFeuille + "qu'elle possede sa feuille");
        }
    }
}
