using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pizza
    {
        #region Instance fields
        private string _Name;
        private double _Price;

        #endregion
        #region Constructor
        public Pizza(string name, double price)
        {
            _Name = name;
            _Price = price;
        }
        #endregion

        #region Properties
         public string Name
        {
            get { return _Name; }
        }
        public double Price
        {
            get { return _Price; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// returnerer pizzaobjekt ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Pizzanavn: {Name}, Pizzapris: {Price}";
        }
        #endregion
    }
}
