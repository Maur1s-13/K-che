using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kueche
{
    public class Zutat
    {
        private int _menge = 0;

        private string _name = string.Empty;
        public int Getmenge()
        {
            return _menge;
        }

        public void Setmenge (int menge)
        {
            _menge = menge; 
        }


        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
