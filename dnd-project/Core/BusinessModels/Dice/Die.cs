using System;

namespace dnd_project.Core.BusinessModels.Dice
{
    class Die
    {
        private int Sides { get; set; }
        private static Random r = new Random();

        public Die(int sides)
        {
            Sides = sides;
        }

        public int Roll()
        {
            return r.Next(1, Sides);
        }
    }
}
