using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    class Page
    {
        public string _titre { get; set; }
        public int _numero { get; set; }
        public string _texte { get; set; }
        public List<Choix> _Choix { get; set; }

        public void AfficherPage()
        {
            Console.WriteLine(_titre+"\n");
            Console.WriteLine(_texte+"\n");
            
            foreach (Choix ch in _Choix){
                Console.WriteLine(ch._numero+". "+ch._texte);
            }


        }
        public Page(string titre)
        {
            _titre = titre;
            //Program.pages.Add(this);
        }
    }
}
