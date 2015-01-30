using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment1_JihoYoo_300813612
{
    class Hero
    {

        //Private properties -------------------------------------------------------
        private int strength = 0;
        private int speed = 0;
        private int health = 0;

        //Public properties --------------------------------------------------------
        public string name;

        //Using random number ------------------------------------------------------
        Random rnd = new Random();

        //CONSTRUCTOR Method -------------------------------------------------------
        public Hero(string name)
        {
            this.name = name;
            generateAbilities(rnd);

        }

        //randomly generates the ability numbers for the strength, speed and health. -----
        private void generateAbilities(Random rnd)
        {
            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);

        }

        //
        public void fight()
        {
            bool a; // hitAttempt is changed to a ---------------------------------------
            a = hitAttempt(rnd);

            // Checking hit or not ------------------------------------------------------
            if (a == true)
            {
                Console.WriteLine(" Hit!! ");
                hitDamage(rnd);

            }
            else
                Console.WriteLine(" Again Attack!! ");


        }

        //randomly determine if the Hero hits that should  be 20% of the time otherwise false.-----

        private bool hitAttempt(Random rnd)
        {
            int hitAttempt = rnd.Next(1, 11); //10% to 100%

            if (hitAttempt == 1)  // 1 = 10%
            {
                return true;
            }
            else if (hitAttempt == 2) // 2 = 20%
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        //This method calculates the Hero hit damage to the target---------------------
        private int hitDamage(Random rnd)
        {

            int hitHit = rnd.Next(1, 7); // to multiplying by Hero's strength and the number between 1 and 6.
            int result = this.strength * hitHit;  // result = multiplying value
            Console.WriteLine("{0} was hit!!!!!", result); // to show hit damage

            return result;
        }


        //Show the Hero's ability scores
        public void show()
        {
            Console.WriteLine("Name : {0} ", this.name);
            Console.WriteLine("Strengh : {0}, Speed : {1}, Health : {2}", this.strength, this.speed, this.health);
            Console.WriteLine();

        }

    }
}
