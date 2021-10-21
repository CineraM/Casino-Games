
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_hit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "test";
            // 
            // button_hit
            // 
            this.button_hit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hit.Location = new System.Drawing.Point(369, 136);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(186, 54);
            this.button_hit.TabIndex = 2;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.button_hit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "test";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_hit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BlackJack";
            this.Text = "Black-Jack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Label label2;
    }
}