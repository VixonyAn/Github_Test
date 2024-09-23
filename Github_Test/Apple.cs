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
        private int _dmgValue;
        private int _totalDmgValue;
        private int _hpValue;
        private int _totalHpValue;
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
        public int DmgValue { get; set; }
        public int TotalDmgValue
        {
            get { return _totalDmgValue; }
            set { _totalDmgValue = value; }
        }
        public int HpValue { get; set; }
        public int TotalHpValue
        {
            get { return _totalHpValue; }
            set { _totalHpValue = value; }
        }
        #endregion

        #region Constructors
        public Apple(string variety, int amount)
        {
            _variety = variety;
            _amount = amount;
            _dmgValue = 2;
            _hpValue = 5;
        }
        #endregion

        #region Methods
        public void TotalDamageValue()
        {
            _totalDmgValue = _dmgValue * _amount;
        }
        public void TotalHealingValue()
        {
            _totalHpValue = _hpValue * _amount;
        }
        public override string ToString()
        {
            TotalDamageValue(); TotalHealingValue();
            return $"Apple Variety: {_variety}\nAmount: {_amount}\n\n" +
                   $"Damage Value per Apple: {_dmgValue}\nTotal Possible Damage {_totalDmgValue}\n\n" +
                   $"Healing Value per Apple: {_hpValue}\nTotal Healing Value {_totalHpValue}";
        }
        #endregion
    }
}
