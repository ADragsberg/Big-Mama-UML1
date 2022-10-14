using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ordre
    {
        private Pizza _pizza;
        private Kunde _kunde;

        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }

        public Pizza Pizza
        {
            get { return _pizza; }
        }
    }
}
