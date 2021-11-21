
namespace MainForm.Forms
{
    partial class AceInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AceInput));
            this.label_ace = new System.Windows.Forms.Label();
            this.comboBox_ace = new System.Windows.Forms.ComboBox();
            this.button_ace = new System.Windows.Forms.Button();
            this.pictureBox_ace = new System.Windows.Forms.PictureBox();
            this.pictureBox_player_board = new System.Windows.Forms.PictureBox();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_up = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_playerscore = new System.Windows.Forms.Label();
            this.label_dealerscore = new System.Windows.Forms.Label();
            this.label_without = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player_board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ace
            // 
            this.label_ace.AutoSize = true;
            this.label_ace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label_ace.Location = new System.Drawing.Point(300, 23);
            this.label_ace.Name = "label_ace";
            this.label_ace.Size = new System.Drawing.Size(165, 29);
            this.label_ace.TabIndex = 1;
            this.label_ace.Text = "Set Ace of ♠";
            // 
            // comboBox_ace
            // 
            this.comboBox_ace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.comboBox_ace.FormattingEnabled = true;
            this.comboBox_ace.Items.AddRange(new object[] {
            "1",
            "11"});
            this.comboBox_ace.Location = new System.Drawing.Point(97, 466);
            this.comboBox_ace.Name = "comboBox_ace";
            this.comboBox_ace.Size = new System.Drawing.Size(121, 37);
            this.comboBox_ace.TabIndex = 2;
            this.comboBox_ace.SelectedIndexChanged += new System.EventHandler(this.comboBox_ace_SelectedIndexChanged);
            // 
            // button_ace
            // 
            this.button_ace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ace.Location = new System.Drawing.Point(250, 466);
            this.button_ace.Name = "button_ace";
            this.button_ace.Size = new System.Drawing.Size(109, 41);
            this.button_ace.TabIndex = 3;
            this.button_ace.Text = "Set Value";
            this.button_ace.UseVisualStyleBackColor = true;
            this.button_ace.Click += new System.EventHandler(this.button_ace_Click);
            // 
            // pictureBox_ace
            // 
            this.pictureBox_ace.Image = global::MainForm.Properties.Resources.joker_red;
            this.pictureBox_ace.Location = new System.Drawing.Point(422, 233);
            this.pictureBox_ace.Name = "pictureBox_ace";
            this.pictureBox_ace.Size = new System.Drawing.Size(235, 339);
            this.pictureBox_ace.TabIndex = 0;
            this.pictureBox_ace.TabStop = false;
            // 
            // pictureBox_player_board
            // 
            this.pictureBox_player_board.Location = new System.Drawing.Point(67, 80);
            this.pictureBox_player_board.Name = "pictureBox_player_board";
            this.pictureBox_player_board.Size = new System.Drawing.Size(618, 128);
            this.pictureBox_player_board.TabIndex = 4;
            this.pictureBox_player_board.TabStop = false;
            // 
            // pictureBox_left
            // 
            this.pictureBox_left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_left.Location = new System.Drawing.Point(-20, 0);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(28, 671);
            this.pictureBox_left.TabIndex = 5;
            this.pictureBox_left.TabStop = false;
            // 
            // pictureBox_right
            // 
            this.pictureBox_right.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_right.Location = new System.Drawing.Point(782, -19);
            this.pictureBox_right.Name = "pictureBox_right";
            this.pictureBox_right.Size = new System.Drawing.Size(28, 671);
            this.pictureBox_right.TabIndex = 6;
            this.pictureBox_right.TabStop = false;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_down.Location = new System.Drawing.Point(-6, 643);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(802, 41);
            this.pictureBox_down.TabIndex = 7;
            this.pictureBox_down.TabStop = false;
            // 
            // pictureBox_up
            // 
            this.pictureBox_up.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_up.Location = new System.Drawing.Point(-6, -34);
            this.pictureBox_up.Name = "pictureBox_up";
            this.pictureBox_up.Size = new System.Drawing.Size(802, 41);
            this.pictureBox_up.TabIndex = 8;
            this.pictureBox_up.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Cards";
            // 
            // label_playerscore
            // 
            this.label_playerscore.AutoSize = true;
            this.label_playerscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label_playerscore.Location = new System.Drawing.Point(127, 340);
            this.label_playerscore.Name = "label_playerscore";
            this.label_playerscore.Size = new System.Drawing.Size(205, 29);
            this.label_playerscore.TabIndex = 10;
            this.label_playerscore.Text = "Player Score: 99";
            // 
            // label_dealerscore
            // 
            this.label_dealerscore.AutoSize = true;
            this.label_dealerscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label_dealerscore.Location = new System.Drawing.Point(127, 377);
            this.label_dealerscore.Name = "label_dealerscore";
            this.label_dealerscore.Size = new System.Drawing.Size(209, 29);
            this.label_dealerscore.TabIndex = 11;
            this.label_dealerscore.Text = "Dealer Score: 99";
            // 
            // label_without
            // 
            this.label_without.AutoSize = true;
            this.label_without.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_without.Location = new System.Drawing.Point(129, 321);
            this.label_without.Name = "label_without";
            this.label_without.Size = new System.Drawing.Size(167, 17);
            this.label_without.TabIndex = 12;
            this.label_without.Text = "Without Ace of Hearts";
            // 
            // AceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 650);
            this.Controls.Add(this.label_without);
            this.Controls.Add(this.label_dealerscore);
            this.Controls.Add(this.label_playerscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_up);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_right);
            this.Controls.Add(this.pictureBox_left);
            this.Controls.Add(this.pictureBox_player_board);
            this.Controls.Add(this.button_ace);
            this.Controls.Add(this.comboBox_ace);
            this.Controls.Add(this.label_ace);
            this.Controls.Add(this.pictureBox_ace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AceInput";
            this.Text = "Ace Input";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player_board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ace;
        private System.Windows.Forms.Label label_ace;
        private System.Windows.Forms.ComboBox comboBox_ace;
        private System.Windows.Forms.Button button_ace;
        private System.Windows.Forms.PictureBox pictureBox_player_board;
        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.PictureBox pictureBox_right;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_playerscore;
        private System.Windows.Forms.Label label_dealerscore;
        private System.Windows.Forms.Label label_without;
    }
}