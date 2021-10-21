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
    public partial class dummy_form : Form
    {
        public dummy_form()
        {
            InitializeComponent();
        }

        private void load_theme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primary_color;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondary_color;
                }
            }
        }

        private void dummy_form_Load(object sender, EventArgs e)
        {
            load_theme();
        }
    }
}
