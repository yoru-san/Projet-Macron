using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{

    class Jeu
    {
        public static Random rand = new Random();

        bool end = false;

        public void Jouer(Page currentPage)
        {
            while (!end)
            {
                currentPage.AfficherPage();
                currentPage = currentPage.choisirChoix();
            }
        }

        public void GenererPagesRandom()
        {
            int index = -1;
            for (int i = 0; i < 10; i++)
            {
                Page.pageList[i]=(new ProjetMacron.Page("Page " + (i + 1).ToString()));
                Page.pageList[i]._texte = "Ceci est un essai de page\nJe suis une page, mon but va être d'afficher des choses pour raconter l'histoire\n\nPour changer de page, il va falloir choisir un choix en bas de la page, ils seront affichés comme ceci :\n";
                index = rand.Next(3, 6);
                for (int j = 0; j < index; j++)
                {
                    Page.pageList[i].addChoix(new Choix(j+1, "Choix " + (j+1).ToString()));
                    Page.pageList[i]._Choix[j]._consq = rand.Next(10);
                    //Console.WriteLine("Choix "+(j+1).ToString());
                }

            }
        }
    }
}
