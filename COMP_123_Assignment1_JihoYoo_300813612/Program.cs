/*
 *  Author's name:Jiho Yoo
 *  Date : 1/30/2015
 *  Program description : COMP-123 062
 *  Revision History : Date         Description
 *                    1/28/2015     set a at public void fight()
 *                    1/29/2015     tried to use int hitAttempt = rnd.Next(1, 11) at private bool hitAttempt(Random rnd)
 *                    1/29/2015     make more efficient show at public void show()
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment1_JihoYoo_300813612
{
    class Program
    {
        static void Main(string[] args)
        {
            // To set Hero name -----------------------------------------------------
            Hero jiho = new Hero("Jiho");
            jiho.show();

            //ConsoleKey ------------------------------------------------------------
            string consoleKey = "";
            consoleKey = checkKey(consoleKey);


            //Keep looping until q is entered ---------------------------------------
            while (consoleKey != "q")
            {
                switch (consoleKey)
                {
                    case "q":
                        break;
                    case "r":
                        jiho.fight();
                        consoleKey = "";
                        break;
                    default:
                        consoleKey = checkKey(consoleKey);
                        break;

                }

            }
        }
        //Method checks key entered in order to perform task
        private static string checkKey(string consoleKey)
        {
            Console.WriteLine("Press q to exit or r to roll");
            consoleKey = Console.ReadLine();
            return consoleKey;
        }

    }
}

