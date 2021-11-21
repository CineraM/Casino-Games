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
    public partial class AceInput : Form
    {
        private static string ace_str = "11";

        /// <summary>
        /// allows to pass input to another form
        /// </summary>
        public string ace_ret
        {
            get { return ace_str; }
        }

        /// <summary>
        /// Load the theme for all desired controls in the form
        /// </summary>
        private void load_theme()
        {   // For each loop to change the colors of both labels and pictureboxes
            pictureBox_up.BackColor = ThemeColor.secondary_color;
            pictureBox_down.BackColor = ThemeColor.secondary_color;
            pictureBox_left.BackColor = ThemeColor.secondary_color;
            pictureBox_right.BackColor = ThemeColor.secondary_color;

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
        /// The constructor is passed the player cards and both the planer/dealer score
        /// Basicaly a copy of the player board is displayed 
        /// </summary>
        public AceInput(string card, List<string> player_cards, int player_score, int dealer_score)
        {
            InitializeComponent();
            string face = "";

            char eval_face = card[0];
            if (eval_face == 'H')
                face = "♥";
            else if (eval_face == 'D')
                face = "♦";
            else if (eval_face == 'C')
                face = "♣";
            else if (eval_face == 'S')
                face = "♠";

            

            pictureBox_ace.Image = (Image)Properties.Resources.ResourceManager.GetObject(card);
            pictureBox_ace.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_player_board.Image  = Properties.Resources.table_texture;
            pictureBox_player_board.SizeMode = PictureBoxSizeMode.StretchImage;

            label_ace.Text = "Set Ace of " + face;
            label_without.Text = "Without Ace of " + face;
            label_playerscore.Text = "Player Score: " + (player_score - 1).ToString();
            label_dealerscore.Text = "Dealer Score: " + dealer_score.ToString();


            load_player_cards(player_cards);
            comboBox_ace.SelectedIndex = 1;

            load_theme();
            this.CenterToScreen();

            button_ace.Select();
        }

        /// <summary>
        /// Function that creates picture boxes to display the player's cards
        /// </summary>
        public void load_player_cards(List<string> cards) 
        {
            int player_x = 75;

            foreach (string card in cards)
            {
                PictureBox player_card = new PictureBox();
                player_card.Size = new System.Drawing.Size(50, 71);
                player_card.Location = new Point(player_x, 80);
                player_card.Image = (Image)Properties.Resources.ResourceManager.GetObject(card);
                player_card.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(player_card);                     // Add picture box to controls
                player_x += 60;
            }
            pictureBox_player_board.SendToBack();
        }

        /// <summary>
        /// Only this form will be available until the player enters the value for ace
        /// </summary>
        private void button_ace_Click(object sender, EventArgs e){ this.DialogResult = DialogResult.OK;}

        /// <summary>
        /// Sets the ace value to whatever theuser selected
        /// </summary>
        private void comboBox_ace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ace_str = comboBox_ace.GetItemText(comboBox_ace.SelectedItem);
        }
    }
}
