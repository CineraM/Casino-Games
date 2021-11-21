using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class aDie : aRandomVariable
    {
        private int[] results = new int[7];     // Private member to hold results. Results are used to plot the histogram

        /// <summary> Initial;izses results and chages the seed </summary>
        /// <param name="a"> a is the value all elements in results will be replaced with</param>
        /// <param name="new_seed"> self-descriptive </param>
        public aDie(int a, int new_seed)
        {
            for (int i = 0; i < 7; i++)
                results[i] = a;
            this.set_seed(new_seed);
        }
        /// <summary> This constructor initializes results, Does not change the seed </summary>
        /// <param name="a"> a is the reset value </param>
        public aDie(int a)
        {
            for (int i = 0; i < 7; i++)
                results[i] = a;
        }
        /// <summary> Resets results </summary>
        public void reset_results()
        {
            for (int i = 0; i < 7; i++)
                results[i] = 0;
        }
        /// <summary>result getter</summary>
        /// <returns>returns results, arr of 6 numbers(all die faces frecuencies) </returns>
        public int[] ret_results() { return results; }
        public void increment_results(int index)
        {
            results[index]++;
        }
        /// <summary> Getter for value of results[index] </summary>
        /// <param name="index"> self-descriptive </param>
        /// <returns> self-descriptive </returns>
        public int ret_results_index(int index)
        {
            return results[index];
        }
    }
}
