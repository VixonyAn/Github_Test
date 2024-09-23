using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Test
{
    internal class soldier
    {
        #region instance fields

        private string _name;
        private int _age;
        private int _hp;

        #endregion

        #region Properties

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public int HP { get { return _hp; } }

        #endregion

    }
}
