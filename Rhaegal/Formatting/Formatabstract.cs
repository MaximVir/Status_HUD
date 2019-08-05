using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhaegal.Formatting
{
    abstract class Formatabstract
    {
        public abstract string printFormatted(string top, string bottom);
        public abstract string Format(string top, string bottom);
    }
}
