using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class aCard
    {
        private int value;
        private string face;
        private string picture; // picture is a reference to the resources
        public aCard(int new_vlaue, string new_face, string new_picture)
        {
            value = new_vlaue;
            face = new_face;
            picture = new_picture;
        }
        /*
         * The following functions are pretty slef-explanatory
         * Most of them are just getters and setters
         */
        public int ret_value() { return value; }
        public string ret_face() { return face; }
        public string ret_picture() { return picture; }

    }
}
