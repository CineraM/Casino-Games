using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{

    public partial class PlayingCards : aRandomVariable
    {
        //List<int> deck = new List<int>();
        // check if bust
        public Dictionary<string, int> deck = new Dictionary<string, int>();
        private double bet;
        private int cpu_total = 0;
        private int player_total = 0;

        public PlayingCards(int num_of_decks)
        {
            initialize_deck(num_of_decks);
        }

        private void initialize_deck(int num_of_decks) {
            for (int i = 0; i<13; i++) {
                deck.Add("C" + (1+ i ).ToString(), num_of_decks); // clubs (♣)
                deck.Add("D" + (1 + i).ToString(), num_of_decks); // diamonds (♦),
                deck.Add("H" + (1 + i).ToString(), num_of_decks); // hearts (♥)
                deck.Add("S" + (1 + i).ToString(), num_of_decks); // spades  (♠)
            }

            

            // Clubs, Diamonds, hearts spades


        }
    }



}
