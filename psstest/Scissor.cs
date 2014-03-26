using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Scissor : Hand
    {
        /// <summary>
        /// return the id of scissor (2)
        /// </summary>
        /// <returns>int containing 2</returns>
        public override int getID()
        {
            return 2;
        }

        /// <summary>
        /// returns the name of scissor
        /// </summary>
        /// <returns>returns "Scissor"</returns>
        public override String getName()
        {
            return "Scissor";
        }
    }
}
