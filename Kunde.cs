using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kunde
    {


        #region Instance field
        private string _firstname;
        private string _lastname;

        #endregion

        #region Constructor
        public Kunde(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        #endregion
        #region Properties
        public string FirstName
        {
            get { return _firstname ; }
        }
        public string LastName
        {
            get { return _lastname ; }
        }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        #endregion
        #region Method
        public override string ToString()
        {
            return $"Kunde: {FullName}";
        }

        #endregion
    }
}
