namespace ConsoleApp1
{
    public class Ordre
    {
        #region Fields
        private Pizza _pizza;
        private Kunde _kunde;
        private const int _leveringsGebyr = 40;
        private const double _moms = 1.25;
        #endregion

        
        #region Constructor
        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Returnerer totalprisen for en ordre som en double
        /// </summary>
        public double CalculateTotalPrice()
        {
            return (_pizza.Price + _leveringsGebyr) * _moms; // Vi antager at levering er valgt til hver gang.
        }

        public override string ToString()
        {
            return $"{_kunde} har bestilt: {_pizza}. \nMed levering er totalpris for ordren: {CalculateTotalPrice()} kr. inkl. moms";
        } 
        #endregion
    }
}
