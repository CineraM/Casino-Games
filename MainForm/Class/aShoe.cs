using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MainForm
{
    public partial class aShoe : aRandomVariable, IDrawCard
    {
        int n_decks = 1;
        // initialize aDeaDeckOfCards object and a temporary card
        aDeckOfCards cards = new aDeckOfCards();
        aCard card_insert;

        /// <summary>
        /// First create a deck based on the number the user provided
        /// then push the cards randomly into a stack (shuffle)
        /// </summary>
        /// <param name="num_of_decks">Self descriptive</param>
        public aShoe(int num_of_decks)
        {
            initialize_deck(num_of_decks);
            shuffle_deck();
        }

        /// <summary>
        /// push cards into the aDeckOfCards deck 
        /// </summary>
        /// <param name="num_of_decks"></param>
        private void initialize_deck(int num_of_decks) {
            n_decks = num_of_decks;
            cards.clear_deck();     // the default contructor had some dummy values, clear them before inserting
            for (int j = 0; j < num_of_decks; j++) {
                for (int i = 0; i < 13; i++)
                {
                    card_insert = new aCard((i + 1), "Clubs", "C" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// clubs (♣)

                    card_insert = new aCard((i + 1), "Diamonds", "D" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// diamonds (♦),

                    card_insert = new aCard((i + 1), "Hearts", "H" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// hearts (♥)

                    card_insert = new aCard((i + 1), "Spades", "S" + (1 + i).ToString());
                    cards.add_card_deck(card_insert); // spades  (♠)
                }
            }
        }

        public void re_shuffle() {
            cards.clear_deck();     // the default contructor had some dummy values, clear them before inserting
            for (int j = 0; j < n_decks; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    card_insert = new aCard((i + 1), "Clubs", "C" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// clubs (♣)

                    card_insert = new aCard((i + 1), "Diamonds", "D" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// diamonds (♦),

                    card_insert = new aCard((i + 1), "Hearts", "H" + (1 + i).ToString());
                    cards.add_card_deck(card_insert);// hearts (♥)

                    card_insert = new aCard((i + 1), "Spades", "S" + (1 + i).ToString());
                    cards.add_card_deck(card_insert); // spades  (♠)
                }
            }

            cards.clear_deck_shuffled();
            while (cards.return_deck_size() > 0)
            {
                int index = gen.Next(cards.return_deck().Count); // deck size
                aCard random_card = cards.return_deck()[index];
                cards.add_card_shuffled(random_card);
                cards.remove_card(index);
            }
        }

        /// <summary>
        /// Add cards into the aDeckOfCards stack randomly
        /// Whenever a card is added to the stack, this card is also removed in the deck
        /// </summary>
        private void shuffle_deck() {
            cards.clear_deck_shuffled();

            while (cards.return_deck_size() > 0)
            { 
                int index = gen.Next(cards.return_deck().Count); // deck size
                aCard random_card = cards.return_deck()[index];
                cards.add_card_shuffled(random_card);
                cards.remove_card(index);
            }
        }

        /// <summary>
        /// Draw just pops out of the random stack of cards.
        /// </summary>
        public aCard draw()
        {
            aCard hit = cards.pop_deck_shuffled();
            return hit;
        }

        /// <summary>
        /// Returns the number of cards in the shuffled deck
        /// </summary>
        public int ret_deck_size() { return cards.return_deck_shuffled_size(); }

    }
}
