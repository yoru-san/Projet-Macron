using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    class Program
    {
        

        

        static void Main(string[] args)
        {
            Jeu jeu = new Jeu();
            jeu.GenererPagesRandom();
            jeu.Jouer(Page.pageList[0]);
        }
    }
}
