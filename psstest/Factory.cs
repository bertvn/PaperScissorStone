using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Factory
    {

        /// <summary>
        /// creates an instant of a child class of hand
        /// child is decided by number
        /// 1 paper
        /// 2 scissor
        /// 3 stone
        /// </summary>
        /// <param name="number">number indicating the choice of hand</param>
        /// <returns>instance of hand</returns>
        public Hand createHand(Int32 number)
        {
            Hand hd = null;
            switch (number)
            {
                case 1:
                    hd = new Paper();
                    break;
                case 2:
                    hd = new Scissor();
                    break;
                case 3:
                    hd = new Stone();
                    break;
            }
            return hd;
        }
    }
}
