﻿using System;
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
        private int _leveringsGebyr = 40;
        private double _moms = 1.25;

        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }

        public double CalculateTotalPrice()
        {
            return (_pizza.Price + _leveringsGebyr) * _moms;
        }
        
        public override string ToString()
        {
            return $"{_kunde} har bestilt: {_pizza}. \nTotalpris for ordren er: {CalculateTotalPrice()}";
        }
    }
}
