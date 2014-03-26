using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public abstract class Hand
    {
        /// <summary>
        /// returns ID that represents the choice
        /// </summary>
        /// <returns>int choice id</returns>
        public abstract int getID();

        /// <summary>
        /// returns string that represents the choice
        /// </summary>
        /// <returns>string containing the choice</returns>
        public abstract String getName();
    }
}
