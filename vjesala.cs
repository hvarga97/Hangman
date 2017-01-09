using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analiza06_zad2
{
    class vjesala
    {
        private string myrijec;
        public vjesala(string rijec)
        {
            myrijec = rijec;
        }
        public override string ToString()
        {
            return myrijec;
        }
    }
}
