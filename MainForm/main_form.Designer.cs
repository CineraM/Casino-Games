
namespace MainForm
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_dice = new System.Windows.Forms.Button();
            this.button_add_bjform = new System.Windows.Forms.Button();
            this.button_black_jack = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox_logo64 = new System.Windows.Forms.PictureBox();
            this.panel_title_bar = new System.Windows.Forms.Panel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_close_child_form = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_desktop_panel = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo64)).BeginInit();
            this.panel_title_bar.SuspendLayout();
            this.panel_desktop_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_menu.Controls.Add(this.button_dice);
            this.panel_menu.Controls.Add(this.button_add_bjform);
            this.panel_menu.Controls.Add(this.button_black_jack);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(220, 850);
            this.panel_menu.TabIndex = 0;
            // 
            // button_dice
            // 
            this.button_dice.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dice.FlatAppearance.BorderSize = 0;
            this.button_dice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_dice.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_dice.Image = global::MainForm.Properties.Resources.dicon;
            this.button_dice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dice.Location = new System.Drawing.Point(0, 380);
            this.button_dice.Name = "button_dice";
            this.button_dice.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_dice.Size = new System.Drawing.Size(220, 150);
            this.button_dice.TabIndex = 5;
            this.button_dice.Text = " Dice Simulator";
            this.button_dice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dice.UseVisualStyleBackColor = true;
            this.button_dice.Click += new System.EventHandler(this.button_dice_Click);
            // 
            // button_add_bjform
            // 
            this.button_add_bjform.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_add_bjform.FlatAppearance.BorderSize = 0;
            this.button_add_bjform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_bjform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_add_bjform.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_add_bjform.Image = global::MainForm.Properties.Resources.cardicon;
            this.button_add_bjform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add_bjform.Location = new System.Drawing.Point(0, 230);
            this.button_add_bjform.Name = "button_add_bjform";
            this.button_add_bjform.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_add_bjform.Size = new System.Drawing.Size(220, 150);
            this.button_add_bjform.TabIndex = 4;
            this.button_add_bjform.Text = "  New Player";
            this.button_add_bjform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add_bjform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add_bjform.UseVisualStyleBackColor = true;
            this.button_add_bjform.Click += new System.EventHandler(this.button_add_bjform_Click);
            // 
            // button_black_jack
            // 
            this.button_black_jack.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_black_jack.FlatAppearance.BorderSize = 0;
            this.button_black_jack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_black_jack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_black_jack.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_black_jack.Image = global::MainForm.Properties.Resources.cardicon;
            this.button_black_jack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_black_jack.Location = new System.Drawing.Point(0, 80);
            this.button_black_jack.Name = "button_black_jack";
            this.button_black_jack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_black_jack.Size = new System.Drawing.Size(220, 150);
            this.button_black_jack.TabIndex = 3;
            this.button_black_jack.Text = "   Black-Jack";
            this.button_black_jack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_black_jack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_black_jack.UseVisualStyleBackColor = true;
            this.button_black_jack.Click += new System.EventHandler(this.button_black_jack_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_logo.Controls.Add(this.pictureBox_logo64);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(220, 80);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox_logo64
            // 
            this.pictureBox_logo64.ErrorImage = null;
            this.pictureBox_logo64.Location = new System.Drawing.Point(79, 15);
            this.pictureBox_logo64.Name = "pictureBox_logo64";
            this.pictureBox_logo64.Size = new System.Drawing.Size(55, 47);
            this.pictureBox_logo64.TabIndex = 1;
            this.pictureBox_logo64.TabStop = false;
            // 
            // panel_title_bar
            // 
            this.panel_title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_title_bar.Controls.Add(this.button_minimize);
            this.panel_title_bar.Controls.Add(this.button_close);
            this.panel_title_bar.Controls.Add(this.button_close_child_form);
            this.panel_title_bar.Controls.Add(this.label_title);
            this.panel_title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar.Location = new System.Drawing.Point(220, 0);
            this.panel_title_bar.Name = "panel_title_bar";
            this.panel_title_bar.Size = new System.Drawing.Size(1210, 80);
            this.panel_title_bar.TabIndex = 1;
            this.panel_title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_minimize.Image")));
            this.button_minimize.Location = new System.Drawing.Point(1156, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 39);
            this.button_minimize.TabIndex = 4;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(1180, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 39);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_close_child_form
            // 
            this.button_close_child_form.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_close_child_form.FlatAppearance.BorderSize = 0;
            this.button_close_child_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_child_form.Image = ((System.Drawing.Image)(resources.GetObject("button_close_child_form.Image")));
            this.button_close_child_form.Location = new System.Drawing.Point(0, 0);
            this.button_close_child_form.Name = "button_close_child_form";
            this.button_close_child_form.Size = new System.Drawing.Size(75, 80);
            this.button_close_child_form.TabIndex = 1;
            this.button_close_child_form.UseVisualStyleBackColor = true;
            this.button_close_child_form.Click += new System.EventHandler(this.button_close_child_form_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(506, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(92, 29);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "HOME";
            // 
            // panel_desktop_panel
            // 
            this.panel_desktop_panel.Controls.Add(this.pictureBox_logo);
            this.panel_desktop_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop_panel.Location = new System.Drawing.Point(220, 80);
            this.panel_desktop_panel.Name = "panel_desktop_panel";
            this.panel_desktop_panel.Size = new System.Drawing.Size(1210, 770);
            this.panel_desktop_panel.TabIndex = 2;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.ErrorImage = null;
            this.pictureBox_logo.Location = new System.Drawing.Point(317, 128);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(555, 444);
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 850);
            this.Controls.Add(this.panel_desktop_panel);
            this.Controls.Add(this.panel_title_bar);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "main_form";
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo64)).EndInit();
            this.panel_title_bar.ResumeLayout(false);
            this.panel_title_bar.PerformLayout();
            this.panel_desktop_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_title_bar;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_black_jack;
        private System.Windows.Forms.Panel panel_desktop_panel;
        private System.Windows.Forms.Button button_close_child_form;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox_logo64;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_add_bjform;
        private System.Windows.Forms.Button button_dice;
    }
}

