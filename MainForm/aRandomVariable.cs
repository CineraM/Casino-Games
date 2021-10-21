using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class aRandomVariable : Random
    {
        private static Random gen = new Random(999);    // Default Value
        private static int seed = 999;                  // Keep track of the seed separately

        /// <summary>
        /// Set new seed for the random number gen, and the seed variable
        /// </summary>
        /// <param name="new_seed"> self-descriptive </param>
        public void set_seed(int new_seed)
        {
            gen = new Random(new_seed);
            seed = new_seed;
        }

        /// <summary> Returns a random number between 1 and 6 </summary>
        /// <returns> self-descriptive </returns>
        public int roll() { return gen.Next(1, 7); }

        /// <summary> Seed value getter </summary>
        /// <returns> self-descriptive </returns>
        public int ret_seed() { return seed; }
    }
}
