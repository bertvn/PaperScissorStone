using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psstest
{
    class View
    {
        public Controller control;

        public View(Controller ctrl)
        {
            control = ctrl;
            displayOptions();
            String number = System.Console.ReadLine();
            Int32 num = Convert.ToInt32(number);
            int result = control.play(num);
            printResult(result);
        }

        public void displayOptions()
        {

            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("---------Options--------");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("- 1.Paper              -");
            System.Console.WriteLine("- 2.Scissor            -");
            System.Console.WriteLine("- 3.Stone              -");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Enter the number of the option you want ");
        }

        public void printResult(int i)
        {
            switch (i)
            {
                case 0:
                    System.Console.WriteLine("draw");
                    break;
                case 1:
                    System.Console.WriteLine("win");
                    break;
                case 2:
                    System.Console.WriteLine("lose");
                    break;
            }
        }

    }
}
