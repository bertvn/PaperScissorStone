using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    class Stone : Hand
    {
        public override int getID()
        {
            return 3;
        }

        public override String getName()
        {
            return "Stone";
        }
    }
}
