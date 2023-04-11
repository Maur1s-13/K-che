using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kueche
{
    public class Gericht 
    {

        private string _name = string.Empty;

        protected List<Zutat> list;

        public string Getname()
        {
            return _name;
        }

        public void Setname (string name)
        {
                _name = name;
        }

        public void AddZutat (Zutat zutat)
        {

        }

    }


}
