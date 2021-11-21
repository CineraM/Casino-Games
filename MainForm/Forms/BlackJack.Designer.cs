
namespace MainForm.Forms
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.button_hit = new System.Windows.Forms.Button();
            this.label_playertotal = new System.Windows.Forms.Label();
            this.button_stand = new System.Windows.Forms.Button();
            this.label_dealertotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_change_seed = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.label_seed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_dcards_num = new System.Windows.Forms.Label();
            this.comboBox_decksize = new System.Windows.Forms.ComboBox();
            this.textBox_bet = new System.Windows.Forms.TextBox();
            this.label_bet = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label_tie = new System.Windows.Forms.Label();
            this.label_lose = new System.Windows.Forms.Label();
            this.label_win = new System.Windows.Forms.Label();
            this.label_wlt = new System.Windows.Forms.Label();
            this.button_start_game = new System.Windows.Forms.Button();
            this.label_ace = new System.Windows.Forms.Label();
            this.button_continue_playing = new System.Windows.Forms.Button();
            this.comboBox_soft17 = new System.Windows.Forms.ComboBox();
            this.label_soft17 = new System.Windows.Forms.Label();
            this.pictureBox_card_display = new System.Windows.Forms.PictureBox();
            this.pictureBox_shuffle = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_back_deck = new System.Windows.Forms.PictureBox();
            this.pictureBox_dealer_table = new System.Windows.Forms.PictureBox();
            this.pictureBox_player_table = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back_deck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dealer_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button_hit
            // 
            this.button_hit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hit.Location = new System.Drawing.Point(349, 626);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(261, 84);
            this.button_hit.TabIndex = 2;
            this.button_hit.Text = "HIT";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.button_hit_Click);
            // 
            // label_playertotal
            // 
            this.label_playertotal.AutoSize = true;
            this.label_playertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playertotal.Location = new System.Drawing.Point(232, 227);
            this.label_playertotal.Name = "label_playertotal";
            this.label_playertotal.Size = new System.Drawing.Size(182, 29);
            this.label_playertotal.TabIndex = 6;
            this.label_playertotal.Text = "Player Total: 0";
            // 
            // button_stand
            // 
            this.button_stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stand.Location = new System.Drawing.Point(672, 626);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(261, 84);
            this.button_stand.TabIndex = 7;
            this.button_stand.Text = "STAND";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Click += new System.EventHandler(this.button_stand_Click);
            // 
            // label_dealertotal
            // 
            this.label_dealertotal.AutoSize = true;
            this.label_dealertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dealertotal.Location = new System.Drawing.Point(232, 194);
            this.label_dealertotal.Name = "label_dealertotal";
            this.label_dealertotal.Size = new System.Drawing.Size(186, 29);
            this.label_dealertotal.TabIndex = 8;
            this.label_dealertotal.Text = "Dealer Total: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dealer Cards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Player Cards";
            // 
            // button_change_seed
            // 
            this.button_change_seed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_seed.Location = new System.Drawing.Point(131, 510);
            this.button_change_seed.Name = "button_change_seed";
            this.button_change_seed.Size = new System.Drawing.Size(178, 40);
            this.button_change_seed.TabIndex = 14;
            this.button_change_seed.Text = "Change Seed";
            this.button_change_seed.UseVisualStyleBackColor = true;
            this.button_change_seed.Click += new System.EventHandler(this.button_change_seed_Click);
            // 
            // button_reset
            // 
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(12, 23);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(202, 86);
            this.button_reset.TabIndex = 15;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_seed
            // 
            this.textBox_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_seed.Location = new System.Drawing.Point(315, 515);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(105, 30);
            this.textBox_seed.TabIndex = 16;
            // 
            // label_seed
            // 
            this.label_seed.AutoSize = true;
            this.label_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seed.Location = new System.Drawing.Point(131, 563);
            this.label_seed.Name = "label_seed";
            this.label_seed.Size = new System.Drawing.Size(196, 29);
            this.label_seed.TabIndex = 17;
            this.label_seed.Text = "Current Seed: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Remaining Number ";
            // 
            // label_dcards_num
            // 
            this.label_dcards_num.AutoSize = true;
            this.label_dcards_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dcards_num.Location = new System.Drawing.Point(608, 535);
            this.label_dcards_num.Name = "label_dcards_num";
            this.label_dcards_num.Size = new System.Drawing.Size(139, 29);
            this.label_dcards_num.TabIndex = 21;
            this.label_dcards_num.Text = "of Cards: 0";
            // 
            // comboBox_decksize
            // 
            this.comboBox_decksize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_decksize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_decksize.FormattingEnabled = true;
            this.comboBox_decksize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_decksize.Location = new System.Drawing.Point(497, 512);
            this.comboBox_decksize.Name = "comboBox_decksize";
            this.comboBox_decksize.Size = new System.Drawing.Size(106, 37);
            this.comboBox_decksize.TabIndex = 22;
            this.comboBox_decksize.SelectedIndexChanged += new System.EventHandler(this.comboBox_decksize_SelectedIndexChanged);
            // 
            // textBox_bet
            // 
            this.textBox_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bet.Location = new System.Drawing.Point(52, 309);
            this.textBox_bet.Name = "textBox_bet";
            this.textBox_bet.Size = new System.Drawing.Size(139, 34);
            this.textBox_bet.TabIndex = 23;
            this.textBox_bet.Text = "10";
            // 
            // label_bet
            // 
            this.label_bet.AutoSize = true;
            this.label_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bet.Location = new System.Drawing.Point(48, 274);
            this.label_bet.Name = "label_bet";
            this.label_bet.Size = new System.Drawing.Size(84, 29);
            this.label_bet.TabIndex = 24;
            this.label_bet.Text = "Bet($)";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(47, 166);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(105, 29);
            this.label_total.TabIndex = 26;
            this.label_total.Text = "Total($)";
            // 
            // textBox_total
            // 
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(52, 198);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(139, 34);
            this.textBox_total.TabIndex = 25;
            this.textBox_total.Text = "100";
            // 
            // label_tie
            // 
            this.label_tie.AutoSize = true;
            this.label_tie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tie.Location = new System.Drawing.Point(1087, 231);
            this.label_tie.Name = "label_tie";
            this.label_tie.Size = new System.Drawing.Size(27, 29);
            this.label_tie.TabIndex = 32;
            this.label_tie.Text = "0";
            // 
            // label_lose
            // 
            this.label_lose.AutoSize = true;
            this.label_lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lose.Location = new System.Drawing.Point(994, 231);
            this.label_lose.Name = "label_lose";
            this.label_lose.Size = new System.Drawing.Size(27, 29);
            this.label_lose.TabIndex = 31;
            this.label_lose.Text = "0";
            // 
            // label_win
            // 
            this.label_win.AutoSize = true;
            this.label_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_win.Location = new System.Drawing.Point(922, 231);
            this.label_win.Name = "label_win";
            this.label_win.Size = new System.Drawing.Size(27, 29);
            this.label_win.TabIndex = 30;
            this.label_win.Text = "0";
            // 
            // label_wlt
            // 
            this.label_wlt.AutoSize = true;
            this.label_wlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wlt.Location = new System.Drawing.Point(919, 198);
            this.label_wlt.Name = "label_wlt";
            this.label_wlt.Size = new System.Drawing.Size(215, 29);
            this.label_wlt.TabIndex = 29;
            this.label_wlt.Text = "WIN / LOSE / TIE";
            // 
            // button_start_game
            // 
            this.button_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_game.Location = new System.Drawing.Point(31, 626);
            this.button_start_game.Name = "button_start_game";
            this.button_start_game.Size = new System.Drawing.Size(261, 84);
            this.button_start_game.TabIndex = 33;
            this.button_start_game.Text = "Start Game";
            this.button_start_game.UseVisualStyleBackColor = true;
            this.button_start_game.Click += new System.EventHandler(this.button_start_game_Click);
            // 
            // label_ace
            // 
            this.label_ace.AutoSize = true;
            this.label_ace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ace.Location = new System.Drawing.Point(968, 476);
            this.label_ace.Name = "label_ace";
            this.label_ace.Size = new System.Drawing.Size(192, 29);
            this.label_ace.TabIndex = 37;
            this.label_ace.Text = "Last Card Dealt";
            // 
            // button_continue_playing
            // 
            this.button_continue_playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_continue_playing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_continue_playing.Location = new System.Drawing.Point(31, 626);
            this.button_continue_playing.Name = "button_continue_playing";
            this.button_continue_playing.Size = new System.Drawing.Size(261, 84);
            this.button_continue_playing.TabIndex = 38;
            this.button_continue_playing.Text = "Continue Playing";
            this.button_continue_playing.UseVisualStyleBackColor = true;
            this.button_continue_playing.Click += new System.EventHandler(this.button_continue_playing_Click);
            // 
            // comboBox_soft17
            // 
            this.comboBox_soft17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_soft17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_soft17.FormattingEnabled = true;
            this.comboBox_soft17.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_soft17.Location = new System.Drawing.Point(52, 408);
            this.comboBox_soft17.Name = "comboBox_soft17";
            this.comboBox_soft17.Size = new System.Drawing.Size(106, 37);
            this.comboBox_soft17.TabIndex = 41;
            this.comboBox_soft17.SelectedIndexChanged += new System.EventHandler(this.comboBox_soft17_SelectedIndexChanged);
            // 
            // label_soft17
            // 
            this.label_soft17.AutoSize = true;
            this.label_soft17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soft17.Location = new System.Drawing.Point(48, 376);
            this.label_soft17.Name = "label_soft17";
            this.label_soft17.Size = new System.Drawing.Size(107, 29);
            this.label_soft17.TabIndex = 39;
            this.label_soft17.Text = "Soft 17?";
            // 
            // pictureBox_card_display
            // 
            this.pictureBox_card_display.Location = new System.Drawing.Point(983, 508);
            this.pictureBox_card_display.Name = "pictureBox_card_display";
            this.pictureBox_card_display.Size = new System.Drawing.Size(162, 202);
            this.pictureBox_card_display.TabIndex = 36;
            this.pictureBox_card_display.TabStop = false;
            // 
            // pictureBox_shuffle
            // 
            this.pictureBox_shuffle.Location = new System.Drawing.Point(665, 161);
            this.pictureBox_shuffle.Name = "pictureBox_shuffle";
            this.pictureBox_shuffle.Size = new System.Drawing.Size(177, 145);
            this.pictureBox_shuffle.TabIndex = 27;
            this.pictureBox_shuffle.TabStop = false;
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.Location = new System.Drawing.Point(558, 176);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(85, 107);
            this.pictureBox_back.TabIndex = 13;
            this.pictureBox_back.TabStop = false;
            // 
            // pictureBox_back_deck
            // 
            this.pictureBox_back_deck.Location = new System.Drawing.Point(541, 166);
            this.pictureBox_back_deck.Name = "pictureBox_back_deck";
            this.pictureBox_back_deck.Size = new System.Drawing.Size(118, 136);
            this.pictureBox_back_deck.TabIndex = 12;
            this.pictureBox_back_deck.TabStop = false;
            // 
            // pictureBox_dealer_table
            // 
            this.pictureBox_dealer_table.InitialImage = global::MainForm.Properties.Resources.table_texture;
            this.pictureBox_dealer_table.Location = new System.Drawing.Point(237, 23);
            this.pictureBox_dealer_table.Name = "pictureBox_dealer_table";
            this.pictureBox_dealer_table.Size = new System.Drawing.Size(897, 137);
            this.pictureBox_dealer_table.TabIndex = 9;
            this.pictureBox_dealer_table.TabStop = false;
            // 
            // pictureBox_player_table
            // 
            this.pictureBox_player_table.InitialImage = global::MainForm.Properties.Resources.table_texture;
            this.pictureBox_player_table.Location = new System.Drawing.Point(237, 308);
            this.pictureBox_player_table.Name = "pictureBox_player_table";
            this.pictureBox_player_table.Size = new System.Drawing.Size(897, 137);
            this.pictureBox_player_table.TabIndex = 5;
            this.pictureBox_player_table.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 713);
            this.Controls.Add(this.comboBox_soft17);
            this.Controls.Add(this.label_soft17);
            this.Controls.Add(this.button_continue_playing);
            this.Controls.Add(this.label_ace);
            this.Controls.Add(this.pictureBox_card_display);
            this.Controls.Add(this.button_start_game);
            this.Controls.Add(this.label_tie);
            this.Controls.Add(this.label_lose);
            this.Controls.Add(this.label_win);
            this.Controls.Add(this.label_wlt);
            this.Controls.Add(this.pictureBox_shuffle);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label_bet);
            this.Controls.Add(this.textBox_bet);
            this.Controls.Add(this.comboBox_decksize);
            this.Controls.Add(this.label_dcards_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_seed);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_change_seed);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_back_deck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_dealer_table);
            this.Controls.Add(this.label_dealertotal);
            this.Controls.Add(this.button_stand);
            this.Controls.Add(this.label_playertotal);
            this.Controls.Add(this.pictureBox_player_table);
            this.Controls.Add(this.button_hit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlackJack";
            this.Text = "Black-Jack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_card_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back_deck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dealer_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.PictureBox pictureBox_player_table;
        private System.Windows.Forms.Label label_playertotal;
        private System.Windows.Forms.Button button_stand;
        private System.Windows.Forms.Label label_dealertotal;
        private System.Windows.Forms.PictureBox pictureBox_dealer_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_back_deck;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.Button button_change_seed;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label_seed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_dcards_num;
        private System.Windows.Forms.ComboBox comboBox_decksize;
        private System.Windows.Forms.TextBox textBox_bet;
        private System.Windows.Forms.Label label_bet;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.PictureBox pictureBox_shuffle;
        private System.Windows.Forms.Label label_tie;
        private System.Windows.Forms.Label label_lose;
        private System.Windows.Forms.Label label_win;
        private System.Windows.Forms.Label label_wlt;
        private System.Windows.Forms.Button button_start_game;
        private System.Windows.Forms.PictureBox pictureBox_card_display;
        private System.Windows.Forms.Label label_ace;
        private System.Windows.Forms.Button button_continue_playing;
        private System.Windows.Forms.ComboBox comboBox_soft17;
        private System.Windows.Forms.Label label_soft17;
    }
}