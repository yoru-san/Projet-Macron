using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMacron
{
    class Choix
    {
        public int _numero { get; set; }
        public string _texte { get; set; }
        public int _consq { get; set; }

        public Choix(int num, string text)
        {
            _numero = num;
            _texte = text;
        }
        
    }
}
