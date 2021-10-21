using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class BlackJack : Form
    {

        PlayingCards cards = new PlayingCards(1);
        Random random = new Random();
        List<string> player_cards = new List<string>();
        public BlackJack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;

            while (flag) {
                int index = random.Next(cards.deck.Count);
                string key = cards.deck.Keys.ElementAt(index);
            
                int check = cards.deck[key];
                if (check > 0) {
                        cards.deck[key] = cards.deck[key]--;
                        player_cards.Add(key);
                        label1.Text = key;
                        flag = false;
                    }
               }
        }

        private void button_hit_Click(object sender, EventArgs e)
        {
            string pout = "";

            foreach (string str in player_cards) 
                pout += str + " ";

            label2.Text = pout;

        }
    }
}
