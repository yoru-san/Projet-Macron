using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    class Program
    {
        public static List<Page> pages;

        static void Main(string[] args)
        {
            Page maPage = new ProjetMacron.Page("test");
            //pages.Add(maPage);
            maPage._texte = "Ceci est un essai de page";
            maPage._Choix.Add(new Choix(1, "1er choix"));
            maPage._Choix.Add(new Choix(2, "2e choix"));
            maPage._Choix.Add(new Choix(3, "3e choix"));

            maPage.AfficherPage();
            string pause = Console.ReadLine();
        }
    }
}
