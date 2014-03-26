using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Paper : Hand
    {
        /// <summary>
        /// returns the id of paper (1)
        /// </summary>
        /// <returns>int containing 1</returns>
        public override int getID()
        {
            return 1;
        }
        /// <summary>
        /// returns the name of paper
        /// </summary>
        /// <returns>returns "Paper"</returns>
        public override String getName()
        {
            return "Paper";
        }
    }
}
