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
    public partial class Dice : Form
    {
        private aDie die_obj_1 = new aDie(0, 999);                  // Declaring Die objects, d1 and d2
        private aDie die_obj_2 = new aDie(0, 999);                  // First value initializes the results array
        private int[] temp_results = new int[7];                    // Temp results are used to plot the histogram
        private int[] temp_results_d2 = new int[7];                 // Temp results for d2
        private int[] temp_results2 = new int[13];
        private int histo_die_rolls;                                // # of rolls, used in Statistics and Sum of 2 Dice

        public Dice()
        {
            InitializeComponent();
            default_image();
            listBox_Stats.SelectedIndex = 0;                        // Select the first option of the 
            this.chart_histogram.Titles.Add(" ");                    // Insert an emtpy title so default_chart() can modify it
            chart_histogram.ChartAreas[0].AxisX.Title = "Die Sides"; // Adding default axis titles for the Chart 
            chart_histogram.ChartAreas[0].AxisY.Title = "Frecuency of Sides";
            default_chart();                                        // Call default_chart()    
        }
        private void DieForm_Load(object sender, EventArgs e)
        {
            load_theme();
        }

        private void load_theme() 
        {
            foreach (Control btns in this.Controls.OfType<Button>())
            {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primary_color;    
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondary_color;
            }

            foreach (Control lbl in this.Controls.OfType<Label>()) 
                lbl.ForeColor = ThemeColor.secondary_color;

            load_chart_theme();
        }

        private void load_chart_theme()
        {
            try
            {
                chart_histogram.Series["Die 1 Rolls"].Color = ThemeColor.primary_color;
                chart_histogram.Series["Die 2 Rolls"].Color = ThemeColor.secondary_color;
            }
            catch (Exception) {
                chart_histogram.Series["2 Dice Sum"].Color = ThemeColor.primary_color;
            }
        }

        private void default_chart()
        {
            chart_histogram.Series.Clear();                          // Clear the Series to redraw the Chart
            chart_histogram.Titles[0].Text = "Theoretical 6 Rolls";  // Add the default title
            chart_histogram.Series.Add("Die 1 Rolls");               // Add the 2 default series
            chart_histogram.Series.Add("Die 2 Rolls");

            for (int i = 1; i < 7; i++)
            {                            // Add 6 XY points, all with 0 as their value
                this.chart_histogram.Series["Die 1 Rolls"].Points.AddXY(i.ToString(), 1);
                this.chart_histogram.Series["Die 2 Rolls"].Points.AddXY(i.ToString(), 1);
            }
            chart_histogram.ChartAreas[0].RecalculateAxesScale();    // Rescale the axes
            load_chart_theme();
        }

        public void default_image()
        {
            foreach (var picture_box in this.Controls.OfType<PictureBox>()) {
                picture_box.Image = Properties.Resources.dice0;
                picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void default_label_box()
        {
            label_die1_max.Text = "f = 0";
            label_die2_max.Text = "f = 0";
            label_die1_min.Text = "f = 0";
            label_die2_min.Text = "f = 0";
            label_mean_d1.Text = "Die 1 Mean: 0";
            label_mean_d2.Text = "Die 2 Mean: 0";
            label_die_sum_max.Text = "f = 0";
            label_die_sum_min.Text = "f = 0";
            label_die_sum_mean.Text = "Mean: 0";
        }

        void calculate_stats_roll()
        {
            int sum_d1 = 0;                     // declaring the initial values
            int sum_d2 = 0;
            int rolls_d1 = 0;
            int rolls_d2 = 0;
            int[] fixed_arr_d1 = new int[6];    // The fixed arrays are used to calculate the mean 
            int[] fixed_arr_d2 = new int[6];

            for (int i = 1; i < 7; i++)         // Copying the values from the object
                fixed_arr_d1[i - 1] = die_obj_1.ret_results()[i];

            for (int j = 1; j < 7; j++)
            {       // calculating #of rolls and sum
                rolls_d1 += fixed_arr_d1[j - 1];
                sum_d1 += fixed_arr_d1[j - 1] * j;
            }

            for (int i = 1; i < 7; i++)         // Copying the values from the object
                fixed_arr_d2[i - 1] = die_obj_2.ret_results()[i];

            for (int j = 1; j < 7; j++)
            {       // calculating #of rolls and sum
                rolls_d2 += fixed_arr_d2[j - 1];
                sum_d2 += fixed_arr_d2[j - 1] * j;
            }

            // avg = mean, Limited to 2 decimal points
            double avgd1 = Math.Round(Convert.ToDouble(sum_d1) / rolls_d1, 2);
            double avgd2 = Math.Round(Convert.ToDouble(sum_d2) / rolls_d2, 2);

            // Finding theMax frecuency and index for both dice
            int max_d1 = fixed_arr_d1.Max();
            int max_index_d1 = fixed_arr_d1.ToList().IndexOf(max_d1) + 1;
            int min_d1 = fixed_arr_d1.Min();
            int min_index_d1 = fixed_arr_d1.ToList().IndexOf(min_d1) + 1;

            int max_d2 = fixed_arr_d2.Max();
            int max_index_d2 = fixed_arr_d2.ToList().IndexOf(max_d2) + 1;
            int min_d2 = fixed_arr_d2.Min();
            int min_index_d2 = fixed_arr_d2.ToList().IndexOf(min_d2) + 1;

            // Inserting the values into their respective picture boxes and labels.
            label_mean_d1.Text = "Die 1 Mean: " + avgd1.ToString();
            label_mean_d2.Text = "Die 2 Mean: " + avgd2.ToString();

            pictureBox_die_1_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + max_index_d1.ToString());
            pictureBox_die_1_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_max.Text = "f = " + max_d1.ToString();

            pictureBox_die_1_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + min_index_d1.ToString());
            pictureBox_die_1_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_min.Text = "f = " + min_d1.ToString();


            pictureBox_die_2_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + max_index_d2.ToString());
            pictureBox_die_2_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_max.Text = "f = " + max_d2.ToString();

            pictureBox_die_2_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + min_index_d2.ToString());
            pictureBox_die_2_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_min.Text = "f = " + min_d2.ToString();
        }

        private void button_roll_Click(object sender, EventArgs e)
        {
            try
            {   // try and cath block for input validation
                // if the seed is not a number it will clear the textbox and ignore the input
                if (textSeedInput_d1.Text == "")
                {
                }
                else
                {
                    int new_seed = Int32.Parse(textSeedInput_d1.Text);
                    change_seed(new_seed);
                    textSeedInput_d1.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                textSeedInput_d1.Text = "";
            }
            // Set the Title 
            chart_histogram.Titles[0].Text = "ROLL! Die Histogram";
            int d1_roll = die_obj_1.roll();
            int d2_roll = die_obj_2.roll();

            // loads the new image for both dice picture boxes
            pictureBox_die1.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + d1_roll.ToString());
            pictureBox_die1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die2.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + d2_roll.ToString());
            pictureBox_die2.SizeMode = PictureBoxSizeMode.StretchImage;

            update_histogram(d1_roll, d2_roll); // update the rollsed die face
            calculate_stats_roll();             // updates the stats, mean, max, min
        }

        public void change_seed(int new_seed)
        {
            // Calls set seed, pass the new seed and updates the Label for the GUI
            die_obj_1.set_seed(new_seed);
            labelSeed_d1.Text = ("Current Seed: " + die_obj_1.ret_seed().ToString());
        }

        private void update_histogram(int die_index_d1, int die_index_d2)
        {

            die_obj_1.increment_results(die_index_d1);      // Call the increment_results for both dice
            die_obj_2.increment_results(die_index_d2);

            chart_histogram.Series.Clear();                  // Clear the series 

            chart_histogram.Series.Add("Die 1 Rolls");       // Add the 2 Dice series
            chart_histogram.Series.Add("Die 2 Rolls");

            for (int i = 1; i < 7; i++)                     // Add the series values from object results
                this.chart_histogram.Series["Die 1 Rolls"].Points.AddXY(i.ToString(), die_obj_1.ret_results_index(i));

            for (int i = 1; i < 7; i++)
                this.chart_histogram.Series["Die 2 Rolls"].Points.AddXY(i.ToString(), die_obj_2.ret_results_index(i));

            chart_histogram.ChartAreas[0].RecalculateAxesScale();
            load_chart_theme();
        }



        private void button_stats_Click(object sender, EventArgs e)
        {
            // Re-draw the graph with the appropiate axis titles and series
            chart_histogram.Titles[0].Text = "Die Histogram of " + histo_die_rolls.ToString() + " Rolls";
            chart_histogram.Series.Clear();
            chart_histogram.Series.Add("Die 1 Rolls");
            chart_histogram.Series.Add("Die 2 Rolls");
            // 0 values for all the series
            for (int j = 1; j < 7; j++)
            {
                this.chart_histogram.Series["Die 1 Rolls"].Points.AddXY(j.ToString(), 0);
                this.chart_histogram.Series["Die 2 Rolls"].Points.AddXY(j.ToString(), 0);
            }
            // Recalculate axis scale and update
            chart_histogram.ChartAreas[0].RecalculateAxesScale();
            load_chart_theme();
            chart_histogram.Update();
            // Declaring all the variables
            histo_die_rolls = Int32.Parse(listBox_Stats.GetItemText(listBox_Stats.SelectedItem));
            double new_limit = histo_die_rolls * 0.1;
            int count = 0;
            int limit = 6;
            int sum_d1 = 0;
            int sum_d2 = 0;
            int[] fixed_arr_d1 = new int[6];
            int[] fixed_arr_d2 = new int[6];
            // storing the new limit
            limit = Convert.ToInt32(new_limit);
            // Reseting the temp arrays
            for (int i = 1; i < 7; i++)
            {
                temp_results[i] = 0;
                temp_results_d2[i] = 0;
            }

            // This loop updates the graph in real-time
            for (int i = 0; i < histo_die_rolls; i++)
            {
                int rolld1 = die_obj_1.roll();
                int rolld2 = die_obj_2.roll();
                // Increasing the results
                temp_results[rolld1]++;
                temp_results_d2[rolld2]++;
                // count keeps track of when to update the graph
                if (count == limit || i == (histo_die_rolls - 1))
                {   // this section updates the graph in realtime by redrawing the graph each (#rolls * 0.1) times
                    chart_histogram.Titles[0].Text = "Die Histogram of " + histo_die_rolls.ToString() + " Rolls";
                    chart_histogram.Series.Clear();
                    chart_histogram.Series.Add("Die 1 Rolls");
                    chart_histogram.Series.Add("Die 2 Rolls");

                    for (int j = 1; j < 7; j++)
                        this.chart_histogram.Series["Die 1 Rolls"].Points.AddXY(j.ToString(), temp_results[j]);

                    for (int j = 1; j < 7; j++)
                        this.chart_histogram.Series["Die 2 Rolls"].Points.AddXY(j.ToString(), temp_results_d2[j]);
                    // Finally add a 0.1 second delay when updating the graph
                    chart_histogram.ChartAreas[0].RecalculateAxesScale();
                    load_chart_theme();
                    chart_histogram.Update();
                    System.Threading.Thread.Sleep(100);
                    count = 0;
                }
                else
                    count++;    // if count = limit, dont update the chart and increment count
            }

            for (int j = 1; j < 7; j++)         // copping results
                fixed_arr_d1[j - 1] = temp_results[j];

            for (int j = 1; j < 7; j++)         // calculating sum for d1 
                sum_d1 += fixed_arr_d1[j - 1] * j;

            for (int j = 1; j < 7; j++)         // copping results
                fixed_arr_d2[j - 1] = temp_results_d2[j];

            for (int j = 1; j < 7; j++)         // calculating sum for d2 
                sum_d2 += fixed_arr_d2[j - 1] * j;

            // Calculate the mean for the 2 dice
            double avgd1 = Math.Round(Convert.ToDouble(sum_d1) / histo_die_rolls, 4);
            double avgd2 = Math.Round(Convert.ToDouble(sum_d2) / histo_die_rolls, 4);
            // Calculate Max/min dice face & frecuency of Die 1
            int max_d1 = fixed_arr_d1.Max();
            int max_index_d1 = fixed_arr_d1.ToList().IndexOf(max_d1) + 1;
            int min_d1 = fixed_arr_d1.Min();
            int min_index_d1 = fixed_arr_d1.ToList().IndexOf(min_d1) + 1;
            // Calculate Max/min dice face & frecuency of Die 2
            int max_d2 = fixed_arr_d2.Max();
            int max_index_d2 = fixed_arr_d2.ToList().IndexOf(max_d2) + 1;
            int min_d2 = fixed_arr_d2.Min();
            int min_index_d2 = fixed_arr_d2.ToList().IndexOf(min_d2) + 1;

            // Update the labes and picture boxes for the mean, max and min of the 2 dice
            label_mean_d1.Text = "Die 1 Mean: " + avgd1.ToString();
            label_mean_d2.Text = "Die 2 Mean: " + avgd2.ToString();

            pictureBox_die_1_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + max_index_d1.ToString());
            pictureBox_die_1_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_max.Text = "f = " + max_d1.ToString();

            pictureBox_die_1_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + min_index_d1.ToString());
            pictureBox_die_1_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_min.Text = "f = " + min_d1.ToString();

            pictureBox_die_2_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + max_index_d2.ToString());
            pictureBox_die_2_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_max.Text = "f = " + max_d2.ToString();

            pictureBox_die_2_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + min_index_d2.ToString());
            pictureBox_die_2_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_min.Text = "f = " + min_d2.ToString();
        }

        private void button_sum_of_2_dice_Click(object sender, EventArgs e)
        {
            // Re-draw the graph with the appropiate axis titles and series
            chart_histogram.Titles[0].Text = "Sum of 2 Dice Histogram of " + histo_die_rolls.ToString() + " Rolls";
            chart_histogram.Series.Clear();
            chart_histogram.Series.Add("2 Dice Sum");
            for (int j = 1; j < 13; j++)
                this.chart_histogram.Series["2 Dice Sum"].Points.AddXY(j.ToString(), 0);
            // Recalculate axis scale and update
            chart_histogram.ChartAreas[0].RecalculateAxesScale();
            load_chart_theme();
            chart_histogram.Update();
            // Declaring all the variables
            histo_die_rolls = Int32.Parse(listBox_Stats.GetItemText(listBox_Stats.SelectedItem));
            double new_limit = histo_die_rolls * 0.1;
            int count = 0;
            int limit = 6;
            int sum = 0;
            int[] fixed_arr = new int[11];
            // storing the new limit
            limit = Convert.ToInt32(new_limit);
            // Reseting the temp array
            for (int i = 0; i < 13; i++)
                temp_results2[i] = 0;

            // This loop updates the graph in real-time
            for (int i = 0; i < histo_die_rolls; i++)
            {
                // Increasing the results
                int roll_d1 = die_obj_1.roll();
                int roll_d2 = die_obj_2.roll();
                temp_results2[roll_d1 + roll_d2]++;
                // count keeps track of when to update the graph
                if (count == limit || i == (histo_die_rolls - 1))
                {
                    // this section updates the graph in realtime by redrawing the graph each (#rolls * 0.1) times
                    chart_histogram.Titles[0].Text = "Sum of 2 Dice Histogram of " + histo_die_rolls.ToString() + " Rolls";
                    chart_histogram.Series.Clear();
                    chart_histogram.Series.Add("2 Dice Sum");

                    for (int j = 1; j < 13; j++)
                        this.chart_histogram.Series["2 Dice Sum"].Points.AddXY(j.ToString(), temp_results2[j]);

                    // Finally add a 0.1 second delay when updating the graph
                    chart_histogram.ChartAreas[0].RecalculateAxesScale();
                    load_chart_theme();
                    chart_histogram.Update();
                    System.Threading.Thread.Sleep(100);
                    count = 0;
                }
                else
                    count++;    // if count = limit, dont update the chart and increment count
            }

            for (int j = 2; j < 13; j++)     // copping results
                fixed_arr[j - 2] = temp_results2[j];

            for (int j = 2; j < 13; j++)     // calculating sum for d2 
                sum += fixed_arr[j - 2] * j;

            // Calculating the mean 
            double avg = Math.Round(Convert.ToDouble(sum) / histo_die_rolls, 4);
            // Calculate Max/min dice face & frecuency
            int max = fixed_arr.Max();
            int max_index = fixed_arr.ToList().IndexOf(max) + 2;
            int min = fixed_arr.Min();
            int min_index = fixed_arr.ToList().IndexOf(min) + 2;

            // Update the labes and picture boxes for the mean, max and min
            label_die_sum_mean.Text = "Mean: " + avg.ToString();

            pictureBox_die_sum_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + max_index.ToString());
            pictureBox_die_sum_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die_sum_max.Text = "f = " + max.ToString();

            pictureBox_die_sum_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + min_index.ToString());
            pictureBox_die_sum_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die_sum_min.Text = "f = " + min.ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            listBox_Stats.SelectedIndex = 0;    // Select the first index of the listbox aka '60'
            default_image();                    // Call all the default functions
            default_chart();                    // image, chart, and labelbox
            default_label_box();
            die_obj_1 = new aDie(0);            // Resets the results from die, sets the seed to the default seed --> (999)
            die_obj_2 = new aDie(0);
            change_seed(999);                 // changes the sed for both dice  
        }

        private void button_set_seed_Click(object sender, EventArgs e)
        {
            try
            {   // try and cath block for input validation
                // if the seed is not a number it will clear the textbox and ignore the input
                int new_seed = Int32.Parse(textSeedInput_d1.Text);
                change_seed(new_seed);
                textSeedInput_d1.Text = "";
                die_obj_1.reset_results();      // reset results since the seed was changed
                die_obj_2.reset_results();      // ^
                default_chart();                // Also Reset the chart
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                textSeedInput_d1.Text = "";
            }
        }
    }
}
