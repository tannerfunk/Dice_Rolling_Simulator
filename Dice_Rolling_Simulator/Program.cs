using System;

namespace Dice_Rolling_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numRolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            numRolls = Int32.Parse(Console.ReadLine());

            Random r = new Random();
            int[] numberThrown = new int[11];

            //declaration and instantiation
            GetStars gs = new GetStars(); 
            

            // rolling the dice! and recording what gets rolled!
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = r.Next(7);
                int roll2 = r.Next(7);

                if (roll1 + roll2 ==  2)
                {
                    numberThrown[0]++;
                }
                else if (roll1 + roll2 == 3)
                {
                    numberThrown[1]++;
                }
                else if (roll1 + roll2 == 4)
                {
                    numberThrown[2]++;
                }
                else if (roll1 + roll2 == 5)
                {
                    numberThrown[3]++;
                }
                else if (roll1 + roll2 == 6)
                {
                    numberThrown[4]++;
                }
                else if (roll1 + roll2 == 7)
                {
                    numberThrown[5]++;
                }
                else if (roll1 + roll2 == 8)
                {
                    numberThrown[6]++;
                }
                else if (roll1 + roll2 == 9)
                {
                    numberThrown[7]++;
                }
                else if (roll1 + roll2 == 10)
                {
                    numberThrown[8]++;
                }
                else if (roll1 + roll2 == 11)
                {
                    numberThrown[9]++;
                }
                else if (roll1 + roll2 == 12)
                {
                    numberThrown[10]++;
                }
                
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls.ToString() + ".\n");

            // this is a loop that gets the stars for each total that was rolled, the function prints it out.
            {
                for (int i = 0; i < 11; i++)
                {
                    gs.PrintStars(numRolls, numberThrown[i], i+2);
                }
            }
            Console.Write("\n");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
