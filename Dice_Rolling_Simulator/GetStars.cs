using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Rolling_Simulator
{
    class GetStars
    {

        // this takes in the totalRolls for the percentage, starCount for the printing of "*"'s, and the rollResult (whether it's 2,3,4, etc)
        public void PrintStars(int totalRolls, int starCount, int rollResult)
        {

            string stars = "";
            // I had to use some doubles in order to get the right rounding going on
            // otherwise it always rounded down which skewed the results.
            double percent = (0.01 * totalRolls);
            double starCountDub;
            starCountDub = starCount / percent;
            starCount = Convert.ToInt32(starCountDub);

            //this loops however many times the roll resulted in the current number (2-12)
            for (int i = 0; i < starCount; i++)
            {
                stars = stars + "*";
            }

            Console.WriteLine(rollResult + ": " + stars);
        }
    }
}
