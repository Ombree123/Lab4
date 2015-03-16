using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Pomme
    {
        private sbyte variete;
        private string dateCueillette;
        private sbyte murete;
        private bool contientUnVer;

        public void pomme(sbyte variete, string dateCueillette, bool contientUnVer, sbyte murete)
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

            this.contientUnVer = contientUnVer;

            if (murete >= 0 && murete <= 100)
            {
                this.murete = murete;
            }
            else
                do
                {
                    Console.WriteLine("ERREUR mureté invalide, veuillez la réentrer");
                    verification = sbyte.TryParse(Console.ReadLine(), out murete);

                    if ((murete < 0 || murete < 100) && verification)
                        verification = false;
                } while (!verification);
        }

        public void pomme(Pomme pomme)
        {
            variete = pomme.variete;
            dateCueillette = pomme.dateCueillette;
            murete = pomme.murete;
            contientUnVer = pomme.contientUnVer;
        }

        public void pomme()
        {

        }

        public void unVerSiInfiltre()
        {
            contientUnVer = true;
        }

        public string reactionAEtreMangee()
        {
            if (contientUnVer)
                return ("Vous allez être malade si vous manger ce fruit");
            else
                return ("");
        }

        public string afficherDescription()
        {
            return ("La pomme est de la veriété numéro " + variete + ", sa date de cueillette est " + dateCueillette + " sa mureté est de " + murete + "% et il est "+contientUnVer+"qu'elle contient un ver. "+reactionAEtreMangee());
        }
    }
}
