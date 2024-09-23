using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Test
{
    internal class Apple
    {
        #region Instance Fields
        private string _variety;
        private int _amount;
        #endregion

        #region Properties
        public string Variety
        {
            get { return _variety; }
            set { _variety = value; }
        }
        public int Amount
        { 
            get { return _amount; }
            set { _amount = value; }
        }
        #endregion

        #region Constructors
        public Apple(string variety, int amount)
        {
            _variety = variety;
            _amount = amount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Apple Variety: {_variety}\nAmount: {_amount}";
        }
        #endregion
    }
}
