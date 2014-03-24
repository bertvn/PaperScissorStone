using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    class Paper : Hand
    {
        public override int getID()
        {
            return 1;
        }
        public override String getName()
        {
            return "Paper";
        }
    }
}
