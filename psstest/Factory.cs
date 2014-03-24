using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Factory
    {


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
