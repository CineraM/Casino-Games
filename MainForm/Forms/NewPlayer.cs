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
    public partial class Form_new_player : Form
    {
        // Random variable to generate a random theme
        private Random random = new Random();
        private int temp_index;
        public Form_new_player()
        {
            InitializeComponent();
            pictureBox_anim.Image = Properties.Resources.black_jack;
            pictureBox_anim.SizeMode = PictureBoxSizeMode.StretchImage;

            comboBox_decks.SelectedIndex = 0;       // Initializing both indexes the default
            comboBox_s17.SelectedIndex = 0;         

        }
        /// <summary>
        /// Load the theme for all desired controls in the form
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
        /// Function copied from ThemeColor class, make it work for a new form
        /// </summary>
        /// <returns>Returns a color</returns>
        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);


            while (temp_index == index)                     // if collor is the same, select another color!
                index = random.Next(ThemeColor.ColorList.Count);

            temp_index = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        /// <summary>
        /// Forms launches a new form with the specified deck, seed and soft 17
        /// </summary>
        private void button_launch_game_Click(object sender, EventArgs e)
        {
            try
            {   // input validation for the seed
                int new_seed = Int32.Parse(textBox_seed.Text);
                int new_deck_size = comboBox_decks.SelectedIndex;
                Console.WriteLine(comboBox_decks.SelectedIndex);
                // if the input is valid select a random theme color
                Color color = SelectThemeColor();
                ThemeColor.primary_color = color;
                ThemeColor.secondary_color = ThemeColor.ChangeColorBrightness(color, -0.3);

                Form multiple_form = new Forms.BlackJack(new_seed, new_deck_size, comboBox_s17.SelectedIndex);
                multiple_form.Size = new Size(900, 630);
                multiple_form.Show();

            }
            catch (Exception)
            {   // if invalid input reset the textbox
                MessageBox.Show("Invalid Input");
                textBox_seed.Text = "999";
            }

        }
        /// <summary>
        /// Loads the theme to the form
        /// </summary>
        private void Form_new_player_Load(object sender, EventArgs e)
        {
            load_theme();
        }
    }
}
