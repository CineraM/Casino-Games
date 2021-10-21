
namespace MainForm.Forms
{
    partial class Dice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice));
            this.chart_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_roll = new System.Windows.Forms.Button();
            this.button_sum_of_2_dice = new System.Windows.Forms.Button();
            this.button_stats = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.listBox_Stats = new System.Windows.Forms.ListBox();
            this.pictureBox_die2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_die1 = new System.Windows.Forms.PictureBox();
            this.button_set_seed = new System.Windows.Forms.Button();
            this.labelSeed_d1 = new System.Windows.Forms.Label();
            this.textSeedInput_d1 = new System.Windows.Forms.TextBox();
            this.label_InputSeed_d1 = new System.Windows.Forms.Label();
            this.pictureBox_die_1_max = new System.Windows.Forms.PictureBox();
            this.label_die_1_title = new System.Windows.Forms.Label();
            this.label_die_2_title = new System.Windows.Forms.Label();
            this.label_mean_d1 = new System.Windows.Forms.Label();
            this.label_mean_d2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_die_1_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_2_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_2_max = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_sum_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_sum_max = new System.Windows.Forms.PictureBox();
            this.label_die1_max = new System.Windows.Forms.Label();
            this.label_die1_min = new System.Windows.Forms.Label();
            this.label_die2_max = new System.Windows.Forms.Label();
            this.label_die2_min = new System.Windows.Forms.Label();
            this.label_die_sum_max = new System.Windows.Forms.Label();
            this.label_die_sum_min = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_die_sum_mean = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_max)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_histogram
            // 
            this.chart_histogram.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart_histogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_histogram.Legends.Add(legend1);
            this.chart_histogram.Location = new System.Drawing.Point(429, 314);
            this.chart_histogram.Name = "chart_histogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_histogram.Series.Add(series1);
            this.chart_histogram.Size = new System.Drawing.Size(510, 249);
            this.chart_histogram.TabIndex = 0;
            this.chart_histogram.Text = "chart1";
            // 
            // button_roll
            // 
            this.button_roll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_roll.Location = new System.Drawing.Point(23, 258);
            this.button_roll.Name = "button_roll";
            this.button_roll.Size = new System.Drawing.Size(240, 67);
            this.button_roll.TabIndex = 1;
            this.button_roll.Text = "ROLL!";
            this.button_roll.UseVisualStyleBackColor = true;
            this.button_roll.Click += new System.EventHandler(this.button_roll_Click);
            // 
            // button_sum_of_2_dice
            // 
            this.button_sum_of_2_dice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sum_of_2_dice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sum_of_2_dice.Location = new System.Drawing.Point(23, 417);
            this.button_sum_of_2_dice.Name = "button_sum_of_2_dice";
            this.button_sum_of_2_dice.Size = new System.Drawing.Size(240, 67);
            this.button_sum_of_2_dice.TabIndex = 3;
            this.button_sum_of_2_dice.Text = "SUM OF 2 DICE";
            this.button_sum_of_2_dice.UseVisualStyleBackColor = true;
            this.button_sum_of_2_dice.Click += new System.EventHandler(this.button_sum_of_2_dice_Click);
            // 
            // button_stats
            // 
            this.button_stats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stats.Location = new System.Drawing.Point(23, 339);
            this.button_stats.Name = "button_stats";
            this.button_stats.Size = new System.Drawing.Size(240, 67);
            this.button_stats.TabIndex = 4;
            this.button_stats.Text = "STATISTICS!";
            this.button_stats.UseVisualStyleBackColor = true;
            this.button_stats.Click += new System.EventHandler(this.button_stats_Click);
            // 
            // button_reset
            // 
            this.button_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Location = new System.Drawing.Point(23, 496);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(380, 67);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // listBox_Stats
            // 
            this.listBox_Stats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_Stats.FormattingEnabled = true;
            this.listBox_Stats.ItemHeight = 16;
            this.listBox_Stats.Items.AddRange(new object[] {
            "60",
            "600",
            "6000",
            "60000"});
            this.listBox_Stats.Location = new System.Drawing.Point(278, 256);
            this.listBox_Stats.Name = "listBox_Stats";
            this.listBox_Stats.Size = new System.Drawing.Size(125, 228);
            this.listBox_Stats.TabIndex = 6;
            // 
            // pictureBox_die2
            // 
            this.pictureBox_die2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die2.Image")));
            this.pictureBox_die2.InitialImage = null;
            this.pictureBox_die2.Location = new System.Drawing.Point(275, 25);
            this.pictureBox_die2.Name = "pictureBox_die2";
            this.pictureBox_die2.Size = new System.Drawing.Size(239, 211);
            this.pictureBox_die2.TabIndex = 2;
            this.pictureBox_die2.TabStop = false;
            // 
            // pictureBox_die1
            // 
            this.pictureBox_die1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die1.Image")));
            this.pictureBox_die1.InitialImage = null;
            this.pictureBox_die1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox_die1.Name = "pictureBox_die1";
            this.pictureBox_die1.Size = new System.Drawing.Size(239, 211);
            this.pictureBox_die1.TabIndex = 1;
            this.pictureBox_die1.TabStop = false;
            // 
            // button_set_seed
            // 
            this.button_set_seed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_set_seed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_set_seed.Location = new System.Drawing.Point(696, -8);
            this.button_set_seed.Name = "button_set_seed";
            this.button_set_seed.Size = new System.Drawing.Size(100, 30);
            this.button_set_seed.TabIndex = 9;
            this.button_set_seed.Text = "Set Seed";
            this.button_set_seed.UseVisualStyleBackColor = true;
            this.button_set_seed.Click += new System.EventHandler(this.button_set_seed_Click);
            // 
            // labelSeed_d1
            // 
            this.labelSeed_d1.AutoSize = true;
            this.labelSeed_d1.Location = new System.Drawing.Point(814, 22);
            this.labelSeed_d1.Name = "labelSeed_d1";
            this.labelSeed_d1.Size = new System.Drawing.Size(124, 17);
            this.labelSeed_d1.TabIndex = 10;
            this.labelSeed_d1.Text = "Current Seed: 999";
            // 
            // textSeedInput_d1
            // 
            this.textSeedInput_d1.Location = new System.Drawing.Point(587, 20);
            this.textSeedInput_d1.Name = "textSeedInput_d1";
            this.textSeedInput_d1.Size = new System.Drawing.Size(100, 22);
            this.textSeedInput_d1.TabIndex = 11;
            this.textSeedInput_d1.Text = "999";
            // 
            // label_InputSeed_d1
            // 
            this.label_InputSeed_d1.AutoSize = true;
            this.label_InputSeed_d1.Location = new System.Drawing.Point(538, 22);
            this.label_InputSeed_d1.Name = "label_InputSeed_d1";
            this.label_InputSeed_d1.Size = new System.Drawing.Size(45, 17);
            this.label_InputSeed_d1.TabIndex = 12;
            this.label_InputSeed_d1.Text = "Seed:";
            // 
            // pictureBox_die_1_max
            // 
            this.pictureBox_die_1_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_1_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_1_max.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_1_max.Image")));
            this.pictureBox_die_1_max.InitialImage = null;
            this.pictureBox_die_1_max.Location = new System.Drawing.Point(530, 81);
            this.pictureBox_die_1_max.Name = "pictureBox_die_1_max";
            this.pictureBox_die_1_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_1_max.TabIndex = 13;
            this.pictureBox_die_1_max.TabStop = false;
            // 
            // label_die_1_title
            // 
            this.label_die_1_title.AutoSize = true;
            this.label_die_1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_die_1_title.Location = new System.Drawing.Point(91, 12);
            this.label_die_1_title.Name = "label_die_1_title";
            this.label_die_1_title.Size = new System.Drawing.Size(86, 32);
            this.label_die_1_title.TabIndex = 14;
            this.label_die_1_title.Text = "Die 1";
            // 
            // label_die_2_title
            // 
            this.label_die_2_title.AutoSize = true;
            this.label_die_2_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_die_2_title.Location = new System.Drawing.Point(353, 12);
            this.label_die_2_title.Name = "label_die_2_title";
            this.label_die_2_title.Size = new System.Drawing.Size(86, 32);
            this.label_die_2_title.TabIndex = 15;
            this.label_die_2_title.Text = "Die 2";
            // 
            // label_mean_d1
            // 
            this.label_mean_d1.AutoSize = true;
            this.label_mean_d1.Location = new System.Drawing.Point(580, 54);
            this.label_mean_d1.Name = "label_mean_d1";
            this.label_mean_d1.Size = new System.Drawing.Size(96, 17);
            this.label_mean_d1.TabIndex = 16;
            this.label_mean_d1.Text = "Die 1 Mean: 0";
            // 
            // label_mean_d2
            // 
            this.label_mean_d2.AutoSize = true;
            this.label_mean_d2.Location = new System.Drawing.Point(782, 54);
            this.label_mean_d2.Name = "label_mean_d2";
            this.label_mean_d2.Size = new System.Drawing.Size(96, 17);
            this.label_mean_d2.TabIndex = 17;
            this.label_mean_d2.Text = "Die 2 Mean: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Die 1 MAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Die 1 MIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Die 2 MAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Die 2 MIN";
            // 
            // pictureBox_die_1_min
            // 
            this.pictureBox_die_1_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_1_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_1_min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_1_min.Image")));
            this.pictureBox_die_1_min.InitialImage = null;
            this.pictureBox_die_1_min.Location = new System.Drawing.Point(621, 81);
            this.pictureBox_die_1_min.Name = "pictureBox_die_1_min";
            this.pictureBox_die_1_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_1_min.TabIndex = 22;
            this.pictureBox_die_1_min.TabStop = false;
            // 
            // pictureBox_die_2_min
            // 
            this.pictureBox_die_2_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_2_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_2_min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_2_min.Image")));
            this.pictureBox_die_2_min.InitialImage = null;
            this.pictureBox_die_2_min.Location = new System.Drawing.Point(823, 80);
            this.pictureBox_die_2_min.Name = "pictureBox_die_2_min";
            this.pictureBox_die_2_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_2_min.TabIndex = 23;
            this.pictureBox_die_2_min.TabStop = false;
            // 
            // pictureBox_die_2_max
            // 
            this.pictureBox_die_2_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_2_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_2_max.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_2_max.Image")));
            this.pictureBox_die_2_max.InitialImage = null;
            this.pictureBox_die_2_max.Location = new System.Drawing.Point(732, 80);
            this.pictureBox_die_2_max.Name = "pictureBox_die_2_max";
            this.pictureBox_die_2_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_2_max.TabIndex = 24;
            this.pictureBox_die_2_max.TabStop = false;
            // 
            // pictureBox_die_sum_min
            // 
            this.pictureBox_die_sum_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_sum_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_sum_min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_sum_min.Image")));
            this.pictureBox_die_sum_min.InitialImage = null;
            this.pictureBox_die_sum_min.Location = new System.Drawing.Point(720, 204);
            this.pictureBox_die_sum_min.Name = "pictureBox_die_sum_min";
            this.pictureBox_die_sum_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_sum_min.TabIndex = 25;
            this.pictureBox_die_sum_min.TabStop = false;
            // 
            // pictureBox_die_sum_max
            // 
            this.pictureBox_die_sum_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_die_sum_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_sum_max.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_die_sum_max.Image")));
            this.pictureBox_die_sum_max.InitialImage = null;
            this.pictureBox_die_sum_max.Location = new System.Drawing.Point(531, 204);
            this.pictureBox_die_sum_max.Name = "pictureBox_die_sum_max";
            this.pictureBox_die_sum_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_sum_max.TabIndex = 26;
            this.pictureBox_die_sum_max.TabStop = false;
            // 
            // label_die1_max
            // 
            this.label_die1_max.AutoSize = true;
            this.label_die1_max.Location = new System.Drawing.Point(537, 189);
            this.label_die1_max.Name = "label_die1_max";
            this.label_die1_max.Size = new System.Drawing.Size(36, 17);
            this.label_die1_max.TabIndex = 27;
            this.label_die1_max.Text = "f = 0";
            // 
            // label_die1_min
            // 
            this.label_die1_min.AutoSize = true;
            this.label_die1_min.Location = new System.Drawing.Point(628, 189);
            this.label_die1_min.Name = "label_die1_min";
            this.label_die1_min.Size = new System.Drawing.Size(36, 17);
            this.label_die1_min.TabIndex = 28;
            this.label_die1_min.Text = "f = 0";
            // 
            // label_die2_max
            // 
            this.label_die2_max.AutoSize = true;
            this.label_die2_max.Location = new System.Drawing.Point(739, 189);
            this.label_die2_max.Name = "label_die2_max";
            this.label_die2_max.Size = new System.Drawing.Size(36, 17);
            this.label_die2_max.TabIndex = 29;
            this.label_die2_max.Text = "f = 0";
            // 
            // label_die2_min
            // 
            this.label_die2_min.AutoSize = true;
            this.label_die2_min.Location = new System.Drawing.Point(830, 189);
            this.label_die2_min.Name = "label_die2_min";
            this.label_die2_min.Size = new System.Drawing.Size(36, 17);
            this.label_die2_min.TabIndex = 30;
            this.label_die2_min.Text = "f = 0";
            // 
            // label_die_sum_max
            // 
            this.label_die_sum_max.AutoSize = true;
            this.label_die_sum_max.Location = new System.Drawing.Point(526, 310);
            this.label_die_sum_max.Name = "label_die_sum_max";
            this.label_die_sum_max.Size = new System.Drawing.Size(36, 17);
            this.label_die_sum_max.TabIndex = 31;
            this.label_die_sum_max.Text = "f = 0";
            // 
            // label_die_sum_min
            // 
            this.label_die_sum_min.AutoSize = true;
            this.label_die_sum_min.Location = new System.Drawing.Point(715, 310);
            this.label_die_sum_min.Name = "label_die_sum_min";
            this.label_die_sum_min.Size = new System.Drawing.Size(36, 17);
            this.label_die_sum_min.TabIndex = 32;
            this.label_die_sum_min.Text = "f = 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sum of 2 Dice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Sum of 2 Dice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Sum of 2 Dice";
            // 
            // label_die_sum_mean
            // 
            this.label_die_sum_mean.AutoSize = true;
            this.label_die_sum_mean.Location = new System.Drawing.Point(827, 280);
            this.label_die_sum_mean.Name = "label_die_sum_mean";
            this.label_die_sum_mean.Size = new System.Drawing.Size(59, 17);
            this.label_die_sum_mean.TabIndex = 38;
            this.label_die_sum_mean.Text = "Mean: 0";
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 579);
            this.Controls.Add(this.label_die_sum_mean);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_die_sum_min);
            this.Controls.Add(this.label_die_sum_max);
            this.Controls.Add(this.label_die2_min);
            this.Controls.Add(this.label_die2_max);
            this.Controls.Add(this.label_die1_min);
            this.Controls.Add(this.label_die1_max);
            this.Controls.Add(this.pictureBox_die_sum_max);
            this.Controls.Add(this.pictureBox_die_sum_min);
            this.Controls.Add(this.pictureBox_die_2_max);
            this.Controls.Add(this.pictureBox_die_2_min);
            this.Controls.Add(this.pictureBox_die_1_min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_mean_d2);
            this.Controls.Add(this.label_mean_d1);
            this.Controls.Add(this.label_die_2_title);
            this.Controls.Add(this.label_die_1_title);
            this.Controls.Add(this.pictureBox_die_1_max);
            this.Controls.Add(this.label_InputSeed_d1);
            this.Controls.Add(this.textSeedInput_d1);
            this.Controls.Add(this.labelSeed_d1);
            this.Controls.Add(this.button_set_seed);
            this.Controls.Add(this.listBox_Stats);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_stats);
            this.Controls.Add(this.button_sum_of_2_dice);
            this.Controls.Add(this.button_roll);
            this.Controls.Add(this.pictureBox_die2);
            this.Controls.Add(this.pictureBox_die1);
            this.Controls.Add(this.chart_histogram);
            this.Name = "Dice";
            this.Text = "Dice";
            this.Load += new System.EventHandler(this.DieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_histogram;
        private System.Windows.Forms.PictureBox pictureBox_die1;
        private System.Windows.Forms.PictureBox pictureBox_die2;
        private System.Windows.Forms.Button button_roll;
        private System.Windows.Forms.Button button_sum_of_2_dice;
        private System.Windows.Forms.Button button_stats;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox listBox_Stats;
        private System.Windows.Forms.Button button_set_seed;
        private System.Windows.Forms.Label labelSeed_d1;
        private System.Windows.Forms.TextBox textSeedInput_d1;
        private System.Windows.Forms.Label label_InputSeed_d1;
        private System.Windows.Forms.PictureBox pictureBox_die_1_max;
        private System.Windows.Forms.Label label_die_1_title;
        private System.Windows.Forms.Label label_die_2_title;
        private System.Windows.Forms.Label label_mean_d1;
        private System.Windows.Forms.Label label_mean_d2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_die_1_min;
        private System.Windows.Forms.PictureBox pictureBox_die_2_min;
        private System.Windows.Forms.PictureBox pictureBox_die_2_max;
        private System.Windows.Forms.PictureBox pictureBox_die_sum_min;
        private System.Windows.Forms.PictureBox pictureBox_die_sum_max;
        private System.Windows.Forms.Label label_die1_max;
        private System.Windows.Forms.Label label_die1_min;
        private System.Windows.Forms.Label label_die2_max;
        private System.Windows.Forms.Label label_die2_min;
        private System.Windows.Forms.Label label_die_sum_max;
        private System.Windows.Forms.Label label_die_sum_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_die_sum_mean;
    }
}