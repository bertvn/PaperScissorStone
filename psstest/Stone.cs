using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Stone : Hand
    {
        /// <summary>
        /// return the id of stone (3)
        /// </summary>
        /// <returns>int containing 3</returns>
        public override int getID()
        {
            return 3;
        }

        /// <summary>
        /// returns the name of stone
        /// </summary>
        /// <returns>returns "Stone"</returns>
        public override String getName()
        {
            return "Stone";
        }
    }
}
