using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace dnd_project.Core.BusinessModels.Dice
{
    class DiceRoller
    {
        #region Class Variables
        private StringBuilder fullRollOutput;
        #endregion

        #region Constructors
        public DiceRoller()
        {
            fullRollOutput = new StringBuilder();
        }
        #endregion

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
            fullRollOutput.Clear();
            Die die = new Die(sizeOfDie);
            int[] attributeScores = new int[numOfAttr];
            int[] dieScores = new int[numOfAttempts];
            int aggregate = 0;

            fullRollOutput.Append(string.Format("Rolling for {0} attributes:\n", numOfAttr));
            for (int i = 0; i < numOfAttr; i++)
            {
                fullRollOutput.Append(string.Format("Attribute {0}: ", i + 1));

                for (int j = 0; j < numOfAttempts; j++)
                {
                    dieScores[j] = die.Roll();
                }

                Array.Sort(dieScores);
                Array.Reverse(dieScores);
                foreach(int score in dieScores)
                {
                    fullRollOutput.Append(string.Format("{0} ", score));
                }
                aggregate = 0;

                for (int k = 0; k < numOfSuccesses; k++)
                {
                    aggregate += dieScores[k];
                }
                attributeScores[i] = aggregate;

                fullRollOutput.Append(string.Format(" = {0}\n", aggregate));
            }
            Array.Sort(attributeScores);

            fullRollOutput.Append("Final attribure scores: ");
            foreach(int score in attributeScores)
            {
                fullRollOutput.Append(string.Format("{0} ", score));
            }

            return attributeScores;
        }

        /// <summary>
        /// Simulates rolling dice in an #d# + # format (ex. 1d6+2)
        /// </summary>
        /// <param name="numberOfDie">The numer of die to be rolled</param>
        /// <param name="dieSides">The number of sides </param>
        /// <param name="modifier">The modifier to be added at the end of rolling</param>
        /// <returns>The value of the dice rolls plus any optional modifiers</returns>
        public int Roll(int numberOfDie, int dieSides, int modifier = 0)
        {
            fullRollOutput.Clear();
            fullRollOutput.Append(string.Format("Rolling {0}d{1}+({2}):\n", numberOfDie, dieSides, modifier));
            int rollValue = 0;
            Die die = new Die(dieSides);

            for (int i = 0; i < numberOfDie; i++)
            {
                int thisRoll = die.Roll();
                rollValue += thisRoll;
                fullRollOutput.Append(string.Format("Roll {0}: {1}\n", i + 1, thisRoll));
            }

            fullRollOutput.Append(string.Format("Subtotal: {0}\n", rollValue));
            rollValue += modifier;
            fullRollOutput.Append(string.Format("Total Roll: {0}", rollValue));

            return rollValue;
        }

        /// <summary>
        /// A method to roll using string input in the xdy +/- z... format
        /// </summary>
        /// <param name="rollString">A stringg containining the number of die, the side count of the die, and modifiers. ex. "1d6+2"</param>
        /// <returns>The value of the roll</returns>
        public int RollString(string rollString)
        {
            string roll = Regex.Replace(rollString, @"\s+", "");
            Queue<string> rollParams = new Queue<string>(Regex.Split(roll, @"\d+"));
            Queue<string> rollValues = new Queue<string>(Regex.Split(roll, @"\D+"));
            Console.WriteLine();
            int numberOfDie = int.Parse(rollValues.Dequeue());
            int sizeOfDie = int.Parse(rollValues.Dequeue());
            int modifierTotal = 0;

            // Removes the added '' and 'd' character from the start of the queue
            rollParams.Dequeue();
            rollParams.Dequeue();
            
            // The last element in the queue is '' so it isn't needed
            while (rollParams.Count != 1)
            {
                string currentParam = rollParams.Dequeue();
                modifierTotal += currentParam == "+" ? int.Parse(rollValues.Dequeue()) : -int.Parse(rollValues.Dequeue());
            }

            return Roll(numberOfDie, sizeOfDie, modifierTotal);

        }
        /// <summary>
        /// Returns a string of the hitory of every step of the most recent roll
        /// </summary>
        /// <returns>a string of the history of the roll</returns>
        public string GetFullRollDetails()
        {
            return fullRollOutput.ToString();
        }
        #endregion
    }
}
