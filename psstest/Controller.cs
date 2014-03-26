using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    public class Controller
    {
        //factory handles the creation of hand objects
        public Factory ify;

        /// <summary>
        /// constructor for controller class
        /// </summary>
        public Controller()
        {
            ify = new Factory();
        }

        /// <summary>
        /// generates the hand that has id i
        /// </summary>
        /// <param name="i">hand of choice</param>
        /// <returns>instance of hand</returns>
        public Hand getPlayerHand(int i){
            return ify.createHand(i);
        }

        /// <summary>
        /// generates a random hand
        /// </summary>
        /// <returns>instance of hand</returns>
        public Hand getCpuHand()
        {
            Random rng = new Random();
            int num = rng.Next(1,4);
            return ify.createHand(num);
        }

        /// <summary>
        /// checks who won the game
        /// </summary>
        /// <param name="p">id of the player hand</param>
        /// <param name="c">id of the computer hand</param>
        /// <returns>int containing the outcome. 1 - player wins, 2 - computer wins, 0 - draw</returns>
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
