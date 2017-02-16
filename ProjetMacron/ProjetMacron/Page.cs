using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    
    class Page
    {
        private static List<Page> _pageList = new List<Page>();
        public static List<Page> pageList
        {
            get { return _pageList; }
        }

        public string _titre { get; set; }
        
        public int _numero { get; set; }

        public string _texte { get; set; }

        public List<Choix> _Choix { get; set; }

        public Page(string titre)
        {
            _titre = "\t" + titre;
            _Choix = new List<Choix>();
            pageList.Add(this);
        }
        public void addChoix(Choix choix)
        {
            _Choix.Add(choix);
        }



        public void AfficherPage()
        {
            Console.Clear();
            Console.WriteLine(_titre+"\n");
            Console.WriteLine(_texte+"\n");
            AfficherChoix();


        }

        void AfficherChoix()
        {
            //Console.WriteLine(_Choix.Count());
            string choix = "";

            foreach (Choix ch in _Choix)
            {
                choix += (ch._numero + ". " + ch._texte + "\t");
            }
            Console.WriteLine(choix);
        }

        public Page choisirChoix()
        {
            bool choixok = false;
            short choix = 0;

            while (!choixok)
            {
                if (!short.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("Choix incorrect: entrez un chiffre");
                    AfficherChoix();
                }
                else if(choix > _Choix.Count || choix <= 0)
                {
                    Console.WriteLine("Choix incorrect: entrez un choix entre 1 et "+_Choix.Count);
                    AfficherChoix();

                }
                else
                {
                    choixok = true;
                }
            }
            int index = _Choix[choix-1].selectChoix();
            return pageList[index];
        }
    }
}
