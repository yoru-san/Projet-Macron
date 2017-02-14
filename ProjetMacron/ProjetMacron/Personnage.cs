using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    class Personnage
    {
        protected string _nom;
        protected int _vie;
        protected int _popularite;



        public Personnage()
        {
            _nom = "Manu";
            _vie = 100;
            _popularite = 10;
        }

        public Personnage(string nom)
        {
            _nom = nom;
            _vie = 100;
            _popularite = 10;
        }

        public Personnage(string nom, int vie, int pop)
        {
            _nom = nom;
            _vie = vie;
            _popularite = pop;
        }
    }
}
