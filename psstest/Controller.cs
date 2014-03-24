using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Controller
    {
        public Factory ify;

        public Controller()
        {
            ify = new Factory();
        }

        public Hand getPlayerHand(int i){
            return ify.createHand(i);
        }

        public Hand getCpuHand()
        {
            Random rng = new Random();
            int num = rng.Next(1,4);
            return ify.createHand(num);
        }

        public int match(int p, int c)
        {
            if (p == c)
            {
                return 0;
            }
            if (p != 1 && p == c + 1)
            {
                return 1;
            }
            if (p == 1 && c == 3)
            {
                return 1;
            }
            return 2;
        }

    }
}
