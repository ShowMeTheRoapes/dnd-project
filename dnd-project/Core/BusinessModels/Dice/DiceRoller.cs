using System;
using System.Text.RegularExpressions;

namespace dnd_project.Core.BusinessModels.Dice
{
    class DiceRoller
    {
        #region Class Methods
        /// <summary>
        /// Rolls values for random attributes for a character
        /// </summary>
        /// <param name="numOfAttr">The number of attributes that are being rolled for</param>
        /// <param name="sizeOfDie">The number of sides the die/dice will have. </param>
        /// <param name="numOfAttempts">The number of dice thown per roll</param>
        /// <param name="numOfSuccesses">The number of dice counted per throw</param>
        /// <returns>int[] The values to be assigned to the attributes.</returns>
        public int[] RollAttributes(int numOfAttr, int sizeOfDie, int numOfAttempts, int numOfSuccesses)
        {
            Die die = new Die(sizeOfDie);
            int[] attributeScores = new int[numOfAttr];
            int[] dieScores = new int[numOfAttempts];
            int aggregate = 0;

            for (int i = 0; i < numOfAttr; i++)
            {
                for (int j = 0; j < numOfAttempts; j++)
                {
                    dieScores[j] = die.Roll();
                }

                Array.Sort(dieScores);
                Array.Reverse(dieScores);
                aggregate = 0;

                for (int k = 0; k < numOfSuccesses; k++)
                {
                    aggregate += dieScores[k];
                }
                attributeScores[i] = aggregate;
            }
            Array.Sort(attributeScores);

            return attributeScores;
        }

        /// <summary>
        /// Simulates rolling dice in an #d# + # format (ex. 1d6+2)
        /// </summary>
        /// <param name="numberOfDie">The numer of die to be rolled</param>
        /// <param name="dieSides">The number of sides </param>
        /// <param name="modifiers">The modifier to be added at the end of rolling</param>
        /// <returns>The value of the dice rolls plus any optional modifiers</returns>
        public int Roll(int numberOfDie, int dieSides, int modifiers = 0)
        {
            int rollValue = 0;
            Die die = new Die(dieSides);

            for (int i = 0; i < numberOfDie; i++)
            {
                rollValue += die.Roll();
            }

            return rollValue + modifiers;
        }

        /// <summary>
        /// Simulates rolling dice in an #d# + # format (ex. 1d6+2) with a string input
        /// </summary>
        /// <param name="rollString">A string containing the number of die, the side count of the die, and modifiers. ex. "1d6+2"</param>
        /// <returns>The value of the dice rolls plus any optional modifiers</returns>
        public int Roll(string rollString)
        {
            int rollValue = 0;
            string roll = Regex.Replace(rollString, @"\s+", "");
            string[] rollParams = Regex.Split(roll, @"\D+");

            Die die = new Die(int.Parse(rollParams[1]));

            for (int i = 0; i < int.Parse(rollParams[0]); i++)
            {
                rollValue += die.Roll();
            }

            if (rollString.Contains("-"))
            {
                return rollValue -= int.Parse(rollParams[2]);
            }
            else if (rollString.Contains("+"))
            {
                return rollValue += int.Parse(rollParams[2]);
            }
            else
            {
                return rollValue;
            }
            
        }
        #endregion
    }
}
