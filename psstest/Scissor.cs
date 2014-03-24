using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    class Scissor : Hand
    {
        public override int getID()
        {
            return 2;
        }

        public override String getName()
        {
            return "Scissor";
        }
    }
}
