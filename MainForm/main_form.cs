using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class main_form : Form {
        // fields
        private Button current_button;
        private Random random = new Random();
        private int temp_index;
        private Form activate_form;


        public main_form()
        {
            InitializeComponent();
            this.CenterToScreen();
            default_image();
            button_close_child_form.Visible = false;
            this.Text = string.Empty;                                          // remove titile
            this.ControlBox = false;                                           // remove borders
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // dont over exted to the task bar
            this.MaximizeBox = false;                                          // cant rezie the windows with the corners     
            this.MinimizeBox = false;                                          // need to properly design the elements again to do so

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);


            while (temp_index == index)                     // if collor is the same, select another color!
                index = random.Next(ThemeColor.ColorList.Count);

            temp_index = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void default_image() {
            pictureBox_logo64.Image = Properties.Resources.logo64;
            pictureBox_logo64.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.Image = Properties.Resources.Logo_name;
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void activate_button(object btn_sender)
        {
            if (btn_sender != null)
            {
                if (current_button != (Button)btn_sender)
                {
                    button_close_child_form.Visible = true;
                    disable_button();
                    Color color = SelectThemeColor();
                    current_button = (Button)btn_sender;
                    current_button.BackColor = color;
                    current_button.ForeColor = Color.White;
                    current_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panel_title_bar.BackColor = color;
                    panel_logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    // second parameter must be a in decimals (0.1, -0.3, 0.05... This value is a percentage)
                    ThemeColor.primary_color = color;
                    ThemeColor.secondary_color = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void disable_button()
        {
            foreach (Control previous_btn in panel_menu.Controls)
            {
                if (previous_btn.GetType() == typeof(Button))
                {
                    previous_btn.BackColor = Color.FromArgb(51, 51, 76);    // this is a specific color
                    previous_btn.ForeColor = Color.Gainsboro;               // this is a color given by c#
                    previous_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void open_child_form(Form child_form, object btn_sender)
        {
            if (activate_form != null)
                activate_form.Close();

            activate_button(btn_sender);
            activate_form = child_form;
            activate_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            this.panel_desktop_panel.Controls.Add(child_form);
            this.panel_desktop_panel.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
            label_title.Text = child_form.Text;
        }

        private void reset() {
            disable_button();
            label_title.Text = "HOME";
            panel_title_bar.BackColor = Color.FromArgb(0, 150, 136);
            panel_logo.BackColor = Color.FromArgb(39, 39, 58);
            current_button = null;
            button_close_child_form.Visible = false;
        }

        private void panel_title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // not using this
        private void button_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button_black_jack_Click(object sender, EventArgs e)
        {
            open_child_form(new Forms.BlackJack(), sender);
        }
        private void button_add_bjform_Click(object sender, EventArgs e)
        {
            open_child_form(new Forms.Form_new_player(), sender);
        }

        private void button_dice_Click(object sender, EventArgs e)
        {
            open_child_form(new Forms.Dice(), sender);
        }

        private void button_close_child_form_Click(object sender, EventArgs e)
        {
            if (activate_form != null)
                activate_form.Close();
            reset();
        }


    }
}
