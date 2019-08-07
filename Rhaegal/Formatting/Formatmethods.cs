using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhaegal.Formatting
{
    class Formatmethods : Formatabstract
    {
        public override string printFormatted(string top, string bottom)
        {
            string result = Format(top, bottom);
            return result;
        }

        public override string Format(string top, string bottom)
        {
            return string.Format("{0,-10}\t {1,33}", top, bottom);
        }
    }
}
