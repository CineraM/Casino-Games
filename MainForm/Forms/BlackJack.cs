using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// good seeds, 12 for ace
// seed 83, 683
// seed 21: black jack first round
namespace MainForm.Forms
{ // will probably need to encapsulate all these variables in a class for the last project
    public partial class BlackJack : Form
    {                                        // match results (win - lose - tie)
        private int[] match_results = new int[] {0, 0, 0};
        private bool shuffle_flag = true;    // Shuffle animation trigger
        private int global_delay = 2000;     // animation delay (how long will the animation run for), use 2000 ideally
        private aShoe cards = new aShoe(1);  // aShoe object, initialized to have 1 deck

        // Keeps track of the player and dealer cards, reseted every round
        private List<string> player_cards = new List<string>(); 
        private List<string> dealer_cards = new List<string>();

        private int default_seed = 999;
        private int deafault_deck_size = 1;

        private int player_score = 0;       // player/dealer score, reseted each round
        private int dealer_score = 0;

        // animation variable
        private int player_x = 192;         // location of where the first player card will be dealt
        private int player_y = 263;

        private int dealer_x = 192;         // location of where the first dealer card will be dealt
        private int dealer_y = 32;

        private int target_x = 0;
        private int target_y = 0;

        private bool bet_bool = false;
        private int soft_17 = 18;
        private int reset_Ace_value = 0;

        // bootleg destructor stuff
        List<PictureBox> remove = new List<PictureBox>();

        /// <summary>
        /// Constructor with extra arguments to open a new form
        /// This constructor pre initializes the seed, the num of decks and soft 17
        /// It also disables the controls to set them until you click reset
        /// </summary>
        public BlackJack(int new_seed, int num_of_decks, int new_soft_17) // constructor for the num of decks
        {
            InitializeComponent();
            display_deck_size();
            default_image();
            display_seed();
            default_button();
            deafault_deck_size = num_of_decks + 1;
            default_seed = new_seed;
            comboBox_decksize.SelectedIndex = num_of_decks; // Default num of decks = 1
            comboBox_soft17.SelectedIndex = new_soft_17;

            cards.set_seed(new_seed);
            textBox_seed.Text = "";
            display_seed();

            comboBox_decksize.SelectedIndex = num_of_decks;
            comboBox_decksize.Enabled = false;
            button_change_seed.Enabled = false;
            textBox_seed.Enabled = false;


            if (new_soft_17 == 0)
                soft_17 = 18;
            else if (new_soft_17  == 1)
                soft_17 = 17;

            comboBox_soft17.SelectedIndex = new_soft_17;
            comboBox_soft17.Enabled = false;
            
            cards = new aShoe(num_of_decks + 1); // create the new set of cards with the new seed
            label_dcards_num.Text = "of Cards: " + cards.ret_deck_size().ToString();

            button_start_game.Select();
            this.CenterToScreen();              // Open the form to the center of the screen
        }

        /// <summary>
        /// Form constructor, initializses all the default component through the default functions
        /// </summary>
        public BlackJack()
        {
            InitializeComponent();
            display_deck_size();
            comboBox_decksize.SelectedIndex = 0; // Default num of decks = 1
            comboBox_soft17.SelectedIndex = 0;
            default_image();
            display_seed();
            default_button();
            this.CenterToScreen();              // Open the form to the center of the screen
        }
        
        /// <summary>
        /// Loads a theme, literally just changes the color of the buttons and labels
        /// </summary>
        private void load_theme()
        {   // For each loop to change the colors of both labels and pictureboxes
            foreach (Control btns in this.Controls.OfType<Button>())
            {
                Button btn = (Button)btns;
                btn.BackColor = ThemeColor.primary_color;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = ThemeColor.secondary_color;
            }

            foreach (Control lbl in this.Controls.OfType<Label>())
                lbl.ForeColor = ThemeColor.secondary_color;
        }

        /// <summary>
        /// Initialize the aShoe object  to the default seed, also load up the theme
        /// </summary>
        private void BlackJack_Load(object sender, EventArgs e) { 
            load_theme();
            cards.set_seed(default_seed);        // initialize the the shuffled deck to a seed with 999
            cards = new aShoe(deafault_deck_size);
            display_deck_size();
        } // cool theme B)

        /// <summary>
        /// Will change label of the seed to the seed stored in aShoe
        /// </summary>
        private void display_seed() { label_seed.Text = "Current Seed: " + cards.ret_seed().ToString();}
        /// <summary>
        /// Return the number of cards on the shuffling machine (aDeckOfCards object)
        /// </summary>
        private void display_deck_size() { label_dcards_num.Text = "of Cards: " + cards.ret_deck_size().ToString();}

        /// <summary>
        /// Loads up all the default images into the form
        /// </summary>
        private void default_image() {
            pictureBox_player_table.Image = Properties.Resources.table_texture;
            pictureBox_player_table.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_dealer_table.Image = Properties.Resources.table_texture;
            pictureBox_dealer_table.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_back_deck.Image = Properties.Resources.back_deck;
            pictureBox_back_deck.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_card_display.Image = Properties.Resources.joker_red;
            pictureBox_card_display.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_back.Image = Properties.Resources.back; // for animation 
            pictureBox_back.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_back.SendToBack();

            pictureBox_shuffle.Image = Properties.Resources.shuffling2; // shuffling animation
            pictureBox_shuffle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_shuffle.Hide();
        }

        /// <summary>
        /// Load the default buttons, only set seed and start game should be enabled
        /// </summary>
        private void default_button() {
            button_hit.Enabled = false;
            button_reset.Enabled = false;
            button_stand.Enabled = false;
            button_start_game.Enabled = true;
            button_start_game.Enabled = true;
            button_start_game.BringToFront();
            button_continue_playing.Hide();
        }
        /// <summary>
        /// This functions decides which player wins the match based on the current score of both players.
        /// It will update the score of the player who won, Enable the button "Continue Playing' to start another match
        /// It will reshuffle the deck if the size i6 less than 18
        /// </summary>
        private void evaluate_game_state() { 
            button_hit.Enabled = false;             // disable hit and stand to avoid bugs
            button_stand.Enabled = false;

            if (cards.ret_deck_size() < 18)         // 18 for 2 players, This will not reset the seed
            {                                       // However, it will not return the same sequence of cards (shuffle sequence is differenet)
                cards.re_shuffle();
                display_deck_size();
                shuffle_flag = true;                // shuffle flag is used to trigger the shuffle animation
            }
            double bet = Convert.ToDouble(textBox_bet.Text);
            double win = bet;                       // retrieve the bet from the textbox and convert it to int


            // Game rules
            if (player_score > dealer_score && player_score <= 21 && dealer_score <= 21)
            {
                MessageBox.Show("You Win!");        // Update total based on the result
                match_results[0]++;                 // + win * 1.5 when player wins, - win if lose, do nothing if tie
                textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) + (win * 1.5)), 2).ToString();
                label_win.Text = match_results[0].ToString();
            }
            else if (dealer_score > player_score && player_score <= 21 && dealer_score <= 21)
            {
                MessageBox.Show("You Lose :(");
                match_results[1]++;
                textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) - bet), 2).ToString();
                label_lose.Text = match_results[1].ToString();
            }
            else if (dealer_score == player_score)
            {
                if (player_score == 21) // 21 many cases
                {
                    if (player_cards.Count == 2 && dealer_cards.Count == 2)
                    {
                        MessageBox.Show("Tie");
                        match_results[2]++;
                        label_tie.Text = match_results[2].ToString();
                    }
                    else if (player_cards.Count == 2 && dealer_cards.Count > 2)
                    {
                        MessageBox.Show("You Win!");        // Update total based on the result
                        match_results[0]++;                 // + win * 1.5 when player wins, - win if lose, do nothing if tie
                        textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) + (win * 1.5)), 2).ToString();
                        label_win.Text = match_results[0].ToString();
                    }
                    else if (player_cards.Count > 2 && dealer_cards.Count == 2)
                    {
                        MessageBox.Show("You Lose :(");
                        match_results[1]++;
                        textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) - bet), 2).ToString();
                        label_lose.Text = match_results[1].ToString();
                    }
                    else if (player_cards.Count > 2 && dealer_cards.Count > 2)
                    {
                        MessageBox.Show("Tie");
                        match_results[2]++;
                        label_tie.Text = match_results[2].ToString();
                    }
                }
                else {
                    MessageBox.Show("Tie");
                    match_results[2]++;
                    label_tie.Text = match_results[2].ToString();
                }

            }
            else if (dealer_score > 21 && player_score > 21)
            {
                MessageBox.Show("Tie");
                match_results[2]++;
                label_tie.Text = match_results[2].ToString();
            } else if (dealer_score <= 21 && player_score >21) 
            {
                MessageBox.Show("BUST: You Lose :(");
                match_results[1]++;
                textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) - bet), 2).ToString();
                label_lose.Text = match_results[1].ToString();
            } else if (player_score <= 21 && dealer_score > 21) 
            {
                MessageBox.Show("You Win!");
                match_results[0]++;
                textBox_total.Text = Math.Round((Convert.ToDouble(textBox_total.Text) + (win * 1.5)), 2).ToString();
                label_win.Text = match_results[0].ToString();
            }

            // Show and enable the continue_playing button
            button_continue_playing.Show();
            button_continue_playing.BringToFront();
            button_continue_playing.Enabled = true;
            button_continue_playing.Select();
            // Enable the bet input

            textBox_bet.Enabled = true;
            button_stand.Enabled = false;

            if (player_score == 21 && player_cards.Count == 2) // work around, if you get a black jack on the first round it brakes the logic
                bet_bool = true;
            // Check if the bet is less than the total, is so reset the game (player has negative or 0 $)

            double total = Math.Round(Convert.ToDouble(textBox_total.Text), 2);
            if (total <= 0)
            {
                MessageBox.Show("Insuficcient funds to play: " + total.ToString() + '\n' + "Resseting game...");
                button_reset.PerformClick();           // Activate Reset Button
            }
        }

        /// <summary>
        /// Button to start another game with a new bet and the updated total from the previous game
        /// </summary>
        private void button_continue_playing_Click(object sender, EventArgs e)
        {
            try
            {                       // if the user enters a valid bet flag = true, thus enabling the program to continue
                double bet_int = Convert.ToDouble(textBox_bet.Text);
                if (bet_int > Convert.ToDouble(textBox_total.Text))
                {
                    MessageBox.Show("Invalid Bet: bet larger than Total($)");
                }
                else 
                    textBox_bet.Text = bet_int.ToString();   
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input: Please enter an integer");
            }

            button_continue_playing.Enabled = false;
            // This whole if statement for input validation may be completely useless, proably remove later
            button_start_game.Enabled = true;
            button_start_game.PerformClick();
        }

        /// <summary>
        /// Calls delay animation, where all the logic is in
        /// </summary>
        private void button_start_game_Click(object sender, EventArgs e)
        {
            reset_board();
            bool flag = false;      // variable used for bet input validation
            try
            {                       // if the user enters a valid bet flag = true, thus enabling the program to continue
                double bet_int = Convert.ToDouble(textBox_bet.Text);
                if (bet_int > Convert.ToDouble(textBox_total.Text))
                {
                    MessageBox.Show("Invalid Bet: bet larger than Total($)");
                }
                else
                {
                    textBox_bet.Text = bet_int.ToString();
                    flag = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input: Please enter an integer\n" +
                    "for the Total or Bet");

            }

            if (flag) {
                button_start_game.Enabled = false;
                label_total.Text = "Available($)";
                int delay = 0;
                if (shuffle_flag)
                {         // will only shuffle the cards at the start of the game
                    delay = global_delay;   // or whenever the cards left are > 18
                    shuffle_cards();
                }
                shuffle_flag = false;

                delayed_animation(delay, sender, e);
            }
        }

        /// <summary>
        /// Deal a card to the player, one to the dealer, then one to the player again
        /// Some buttons are disbaled to avoid bugs
        /// </summary>
        /// <param name="delay">Delay value</param>
        /// <param name="sender" && param name="e">Used to activate button</param>
        private async Task delayed_animation(int delay, object sender, EventArgs e)
        {
            await Task.Delay(delay);
            // will need to create a extra function when having multiple players
            this.button_hit_Click(sender, e);               // click hit

            string hit_dealer = cards.draw().ret_picture();
            dealer_cards.Add(hit_dealer);                   // deal a card to the player logic
            deal_cards_dealer();
            calculate_score_dealer();
            display_deck_size();

            this.button_hit_Click(sender, e);               // click hit

            button_change_seed.Enabled = false;             // deactivate seed
            textBox_seed.Enabled = false;

            button_start_game.Enabled = false;
            comboBox_decksize.Enabled = false;
            comboBox_soft17.Enabled = false;

            textBox_total.Enabled = false;
            if (bet_bool)
                textBox_bet.Enabled = true;
            else
                textBox_bet.Enabled = false;
            bet_bool = false;
        }

        /// <summary>
        /// asynchronour function that will stop the program
        /// doesnt freeze the program, the following lines of code to execute for a period of time
        /// </summary>
        /// <param name="delay">Delay time in ms</param>
        /// <returns> Returns a system dealy</returns>
        private async Task delayed_shuffle(int delay) 
        {
            await Task.Delay(delay);
            pictureBox_shuffle.Hide();
        }
        /// <summary>
        /// Doesnt actually shuffles the cards, just shows an animation whenever a new aShoe method is created
        /// just enables a gif of shuffling cards for a period of time
        /// </summary>
        private void shuffle_cards()
        {
            pictureBox_shuffle.Show();
            delayed_shuffle(global_delay);      // ignore the warning it works!
        }

        /// <summary>
        /// Resets the board, deletes all the player and dealer cards
        /// Delete the picture boxes, and the elements in the list of both players
        /// Reset the score, and reset the initial card coordinate of both players
        /// </summary>
        private void reset_board() {
            player_score = 0;
            dealer_score = 0;
            reset_Ace_value = 0;
            label_playertotal.Text = "Player Total: " + player_score.ToString();
            label_dealertotal.Text = "Dealer Total: " + dealer_score.ToString();

            player_cards.Clear();
            dealer_cards.Clear();

            player_x = 192; // reseting the position where the cards will be inserted
            player_y = 263;
            dealer_x = 192;
            dealer_y = 32;
            
            foreach (var picture_box in this.Controls.OfType<PictureBox>()) 
            {
                if (picture_box.ClientSize == new System.Drawing.Size(65, 85))
                    remove.Add(picture_box);    // Add references of the picture boxes to remove
            }

            foreach (var x in remove)
                this.Controls.Remove(x);        // delete all the picture boxes of remove from the form
                                                // ~ All the cards dealt last turn
            remove.Clear();

        }

        /// <summary>
        /// Deal cards will trigger pop a card from the shuffled deck
        /// Add it to the player card list, create a picture box, call the card animation
        /// and place it into the player's mat. Then increment x axis for the next player card
        /// </summary>
        private void deal_cards_player()
        {
            card_animation(true);                               // true for player
            string item = player_cards[player_cards.Count-1];
            PictureBox player_card = new PictureBox();
            player_card.Size = new System.Drawing.Size(65, 85);
            player_card.Location = new Point(player_x, player_y);
            player_card.Image = (Image)Properties.Resources.ResourceManager.GetObject(item);
            player_card.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(player_card);                     // Add picture box to controls
            player_x += 75;
            pictureBox_player_table.SendToBack();               // sned the tatble picture box to back so the card is visible
        }

        /// <summary>
        /// Deal cards will trigger pop a card from the shuffled deck
        /// Add it to the dealer card list, create a picture box, call the card animation
        /// and place it into the player's mat. Then increment x axis for the next player card
        /// </summary>
        private void deal_cards_dealer() 
        {
            card_animation(false);                              // false for dealer
            string item = dealer_cards[dealer_cards.Count - 1];
            PictureBox dealer_card = new PictureBox();
            dealer_card.Size = new System.Drawing.Size(65, 85);
            dealer_card.Location = new Point(dealer_x, dealer_y);
            dealer_card.Image = (Image)Properties.Resources.ResourceManager.GetObject(item);
            dealer_card.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(dealer_card);
            dealer_x += 75;
            pictureBox_dealer_table.SendToBack();
        }

        /// <summary>
        /// Calculates player score. If the score goes over 21, call evaluate_game_state()
        /// If the player was dealt an ACE, let him choose the value
        /// </summary>
        private void calculate_score_player() {

            int length = player_cards.Count;

            string str = player_cards[length-1].Substring(1);
            string str2 = player_cards[length - 1].Substring(1);

            int card_value = Int32.Parse(str);
            int card_value2 = Int32.Parse(str2);

            if (card_value >= 10)       // make card value 10 if J, Q, or K was Dealt
                card_value = 10;
            player_score += card_value;

            if (card_value == 1)        // Player chooses the value of Ace
            {
                button_hit.Enabled = false;
                button_stand.Enabled = false;
                string card_str = player_cards[player_cards.Count - 1];

                
                bool flag = true;
                while (flag) {
                    try
                    {
                        int ace_value = 11;     // open the AceInput form
                        using (AceInput form = new AceInput(card_str, player_cards, player_score, dealer_score))
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                ace_value = Int32.Parse(form.ace_ret);
                            }
                        }
                        if (ace_value == 1 || ace_value == 11)
                        {
                            if (ace_value == 11)
                                player_score += 10;
                            flag = false;
                        }
                    }
                    catch (Exception) { // the except should never happen, just leave it here just in case
                        MessageBox.Show("Invalid Input: Enter 1 or 11");
                    }
                }
            }

            if (player_score > 21)
            {
                int compare_score = 0;
                for (int j = 0; j < player_cards.Count; j++) // hard code a temporary score, making all ace = 1
                    compare_score += Int32.Parse(player_cards[j].Substring(1));

                // if the player score is > than the temporary score, the player set the value of an ace to 11
                if (compare_score < player_score) 
                {
                    for (int i = reset_Ace_value; i < player_cards.Count; i++)
                    { // reseting the value of ace if the bet goes over 21, ace autimatically sets to 1
                        try
                        {
                            if (Int32.Parse(player_cards[i].Substring(1)) == 1)
                            {
                                player_score -= 10;
                                reset_Ace_value = i + 1;
                                break;
                            }
                        }
                        catch {
                            throw;
                        }  
                            
                    }
                }

                if (player_score > 21)
                {
                    label_playertotal.Text = "Player Total: " + "Bust :(";
                    button_stand.Enabled = false;
                    evaluate_game_state();
                }
                else {
                    label_playertotal.Text = "Player Total: " + player_score.ToString();
                    button_hit.Enabled = true;
                    button_stand.Enabled = true;
                }

            } else if (player_score == 21) {
                label_playertotal.Text = "Player Total: " + player_score.ToString();
                button_stand.Enabled = true;
                button_stand.PerformClick();
            }
            else {
                label_playertotal.Text = "Player Total: " + player_score.ToString();
                button_hit.Enabled = true;
                button_stand.Enabled = true;
            }
                
            
        }

        /// <summary>
        /// Calculates dealer score. Not as involved as calculate player score
        /// </summary>
        private void calculate_score_dealer() {
            int length = dealer_cards.Count;

            string str = dealer_cards[length - 1].Substring(1);
            int card_value = Int32.Parse(str);
            if (card_value >= 10)
                card_value = 10;

            if (card_value == 1) // deal aces as 11, instructions said so!
                card_value = 11;

            dealer_score += card_value;
            if(dealer_score > 21)
                label_dealertotal.Text = "Dealer Total: " + "Bust :(";
            else
                label_dealertotal.Text = "Dealer Total: " + dealer_score.ToString();

        }

        /// <summary>
        /// Moves the location of the "back-card" to the new location of the dealt card
        /// Then hides the picture, and resets its location
        /// </summary>
        /// <param name="p_d">p_d --> plaer or dealer</param>
        private void card_animation(bool p_d) { // true for player - false for dealer
            pictureBox_back.Visible = true;
            pictureBox_back.BringToFront();
            if (p_d)
            {
                target_x = player_x;
                target_y = player_y;
            }
            else {
                target_x = dealer_x;
                target_y = dealer_y;
            }
            
            
            int x = pictureBox_back.Location.X;
            int y = pictureBox_back.Location.Y;

            bool flag = true;
            int limit = 50; // rate to update
            int count = 0;

            while (flag) {
                count++;
                if (x != target_x) {
                    if (x > target_x)
                        x--;
                    if (x < target_x)
                        x++;
                }

                if (y != target_y) {
                    if (y > target_y)
                        y--;
                    if (y < target_y)
                        y++;
                }
                if (limit == count) {
                    pictureBox_back.Location = new Point(x, y);
                    pictureBox_back.Update();
                    System.Threading.Thread.Sleep(4);
                    count = 0;
                }


                if (x == target_x & y == target_y) {
                    pictureBox_back.Location = new Point(x, y);
                    pictureBox_back.BringToFront();
                    pictureBox_back.Update();
                    flag = false;
                }
                    
            }
            
            pictureBox_back.Visible = false;
            pictureBox_back.SendToBack();
            pictureBox_back.Location = new Point(431, 272);
            
        }

        /// <summary>
        /// Button to change the aShoe seed, some basic input validation
        /// </summary>
        private void button_change_seed_Click(object sender, EventArgs e)
        {
            try
            {   
                int new_seed = Int32.Parse(textBox_seed.Text);
                cards.set_seed(new_seed);
                textBox_seed.Text = "";
                cards = new aShoe(comboBox_decksize.SelectedIndex);
                display_seed();

                cards = new aShoe(comboBox_decksize.SelectedIndex + 1); // create the new set of cards with the new seed
                display_deck_size();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                textBox_seed.Text = "";
            }
        }

        /// <summary>
        /// Overrides the aShoe obejct. Creates a aShoe object with a new number of decks
        /// </summary>
        private void comboBox_decksize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cards = new aShoe(comboBox_decksize.SelectedIndex + 1);
            display_deck_size();
        }



        /// <summary>
        /// Let the player ask for cards if the player_score < 22
        /// </summary>
        private void button_hit_Click(object sender, EventArgs e)
        {
            button_hit.Enabled = true;
            button_reset.Enabled = true;
            button_stand.Enabled = true;
            button_hit.Select();                                // focuses again on the button
            if (player_score <= 21)
            {
                string hit_player = cards.draw().ret_picture(); // pop a card from the deck
                pictureBox_card_display.Image = (Image)Properties.Resources.ResourceManager.GetObject(hit_player);
                pictureBox_card_display.SizeMode = PictureBoxSizeMode.StretchImage;
                player_cards.Add(hit_player);                   // add the card to the player cards
                deal_cards_player();
                calculate_score_player();
            }

            display_deck_size();
        }

        /// <summary>
        /// Stand will deal cards to the dealer until its score is 17 or more
        /// Will also call evaluate game state() after cards are dealt
        /// </summary>
        private void button_stand_Click(object sender, EventArgs e)
        {
            button_hit.Enabled = false;

            bool flag = true;
            while (flag) {
                if (dealer_score < soft_17)
                {
                    string hit_dealer = cards.draw().ret_picture();
                    dealer_cards.Add(hit_dealer);
                    deal_cards_dealer();
                    calculate_score_dealer();
                    display_deck_size();
                }
                else
                {
                    flag = false;
                    evaluate_game_state();
                }
            }
        }

        /// <summary>
        /// Will reset the Score, player cards, set the bets and total to the default
        /// Reset the cards to whatever index was selected and create a new aShoe object based on that 
        /// Enable and disable the desired buttons
        /// </summary>
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset_board();
            default_button();
            default_image();
            label_total.Text = "Total($)";
            button_change_seed.Enabled = true;
            textBox_seed.Enabled = true;
            shuffle_flag = true;
            match_results = new int[] { 0, 0, 0 };

            textBox_total.Text = 100.ToString();
            textBox_bet.Text = 10.ToString();
            
            // probably not need this anymore
            //cards.set_seed(default_seed);   // sets default seed
            //cards = new aShoe(comboBox_decksize.SelectedIndex + 1);
            cards.re_shuffle();
            display_deck_size();
            display_seed();

            // enable back stuf
            comboBox_decksize.Enabled = true;
            textBox_total.Enabled = true;
            textBox_bet.Enabled = true;

            comboBox_soft17.Enabled = true;
            comboBox_soft17.SelectedIndex = 0;
            soft_17 = 18;

            label_win.Text = "0";
            label_lose.Text = "0";
            label_tie.Text = "0";
            button_start_game.Select();
        }

        /// <summary>
        /// Decide if soft 17
        /// </summary>
        private void comboBox_soft17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_soft17.SelectedIndex == 0) 
                soft_17 = 18;
             else if (comboBox_soft17.SelectedIndex == 1) 
                soft_17 = 17;
        }
    }
}
