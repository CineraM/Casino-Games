using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class aDeckOfCards : aRandomVariable
    {
        List<aCard> deck = new List<aCard>();
        Stack<aCard> deck_shuffled = new Stack<aCard>();

        /// <summary>
        /// object constructor the list and stack with dummy values
        /// values will be overwritten with the methods in the aShoe class
        /// </summary>
        public aDeckOfCards() { // dummy values, not really needed
            aCard card_insert = new aCard(1 , "Clubs", "C" + 1);
            deck.Add(card_insert);
            deck_shuffled.Push(card_insert);
        }
        /*
         * The following functions are pretty slef-explanatory
         * Most of them are just getters and setters
         */
        public void add_card_deck(aCard new_card) { deck.Add(new_card);}
        public void clear_deck() { deck.Clear(); }
        public int return_deck_size() { return deck.Count; }
        public List<aCard> return_deck() { return deck; }
        public void remove_card(int index) { deck.RemoveAt(index); }
        public void add_card_shuffled(aCard new_card) { deck_shuffled.Push(new_card); }
        public void clear_deck_shuffled() { deck_shuffled.Clear(); }
        public aCard pop_deck_shuffled() { return deck_shuffled.Pop(); }
        public int return_deck_shuffled_size() { return deck_shuffled.Count; }
    }
}
