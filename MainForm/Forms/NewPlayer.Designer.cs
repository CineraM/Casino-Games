
namespace MainForm.Forms
{
    partial class Form_new_player
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
            this.button_launch_game = new System.Windows.Forms.Button();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.comboBox_decks = new System.Windows.Forms.ComboBox();
            this.label_decks = new System.Windows.Forms.Label();
            this.label_seed = new System.Windows.Forms.Label();
            this.comboBox_s17 = new System.Windows.Forms.ComboBox();
            this.label_17 = new System.Windows.Forms.Label();
            this.pictureBox_anim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anim)).BeginInit();
            this.SuspendLayout();
            // 
            // button_launch_game
            // 
            this.button_launch_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_launch_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_launch_game.Location = new System.Drawing.Point(361, 510);
            this.button_launch_game.Name = "button_launch_game";
            this.button_launch_game.Size = new System.Drawing.Size(446, 123);
            this.button_launch_game.TabIndex = 2;
            this.button_launch_game.Text = "Launch Black Jack-Game";
            this.button_launch_game.UseVisualStyleBackColor = true;
            this.button_launch_game.Click += new System.EventHandler(this.button_launch_game_Click);
            // 
            // textBox_seed
            // 
            this.textBox_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_seed.Location = new System.Drawing.Point(361, 352);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(222, 34);
            this.textBox_seed.TabIndex = 5;
            this.textBox_seed.Text = "999";
            // 
            // comboBox_decks
            // 
            this.comboBox_decks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_decks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.comboBox_decks.FormattingEnabled = true;
            this.comboBox_decks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_decks.Location = new System.Drawing.Point(361, 196);
            this.comboBox_decks.Name = "comboBox_decks";
            this.comboBox_decks.Size = new System.Drawing.Size(121, 37);
            this.comboBox_decks.TabIndex = 6;
            // 
            // label_decks
            // 
            this.label_decks.AutoSize = true;
            this.label_decks.BackColor = System.Drawing.Color.Transparent;
            this.label_decks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decks.Location = new System.Drawing.Point(186, 197);
            this.label_decks.Name = "label_decks";
            this.label_decks.Size = new System.Drawing.Size(111, 36);
            this.label_decks.TabIndex = 7;
            this.label_decks.Text = "Decks:";
            // 
            // label_seed
            // 
            this.label_seed.AutoSize = true;
            this.label_seed.BackColor = System.Drawing.Color.Transparent;
            this.label_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seed.Location = new System.Drawing.Point(186, 350);
            this.label_seed.Name = "label_seed";
            this.label_seed.Size = new System.Drawing.Size(97, 36);
            this.label_seed.TabIndex = 8;
            this.label_seed.Text = "Seed:";
            // 
            // comboBox_s17
            // 
            this.comboBox_s17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_s17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.comboBox_s17.FormattingEnabled = true;
            this.comboBox_s17.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_s17.Location = new System.Drawing.Point(361, 270);
            this.comboBox_s17.Name = "comboBox_s17";
            this.comboBox_s17.Size = new System.Drawing.Size(121, 37);
            this.comboBox_s17.TabIndex = 9;
            // 
            // label_17
            // 
            this.label_17.AutoSize = true;
            this.label_17.BackColor = System.Drawing.Color.Transparent;
            this.label_17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_17.Location = new System.Drawing.Point(186, 271);
            this.label_17.Name = "label_17";
            this.label_17.Size = new System.Drawing.Size(135, 36);
            this.label_17.TabIndex = 10;
            this.label_17.Text = "Soft 17?";
            // 
            // pictureBox_anim
            // 
            this.pictureBox_anim.Location = new System.Drawing.Point(666, 90);
            this.pictureBox_anim.Name = "pictureBox_anim";
            this.pictureBox_anim.Size = new System.Drawing.Size(399, 397);
            this.pictureBox_anim.TabIndex = 12;
            this.pictureBox_anim.TabStop = false;
            // 
            // Form_new_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 723);
            this.Controls.Add(this.pictureBox_anim);
            this.Controls.Add(this.label_17);
            this.Controls.Add(this.comboBox_s17);
            this.Controls.Add(this.label_seed);
            this.Controls.Add(this.label_decks);
            this.Controls.Add(this.comboBox_decks);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.button_launch_game);
            this.Name = "Form_new_player";
            this.Text = "New Player";
            this.Load += new System.EventHandler(this.Form_new_player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_launch_game;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.ComboBox comboBox_decks;
        private System.Windows.Forms.Label label_decks;
        private System.Windows.Forms.Label label_seed;
        private System.Windows.Forms.ComboBox comboBox_s17;
        private System.Windows.Forms.Label label_17;
        private System.Windows.Forms.PictureBox pictureBox_anim;
    }
}