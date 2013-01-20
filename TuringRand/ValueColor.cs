using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TuringRand.TuringMachine
{
    public class ColorValues : Dictionary<Color, int>
    {
        private ColorValues()
            : base()
        {
            this.Add(Color.FromArgb(255, 0, 0, 0), 0);
            this.Add(Color.FromArgb(255, 255, 255, 255), 1);
            this.Add(Color.FromArgb(255, 255, 0, 0), 2);
            this.Add(Color.FromArgb(255, 0, 255, 0), 3);
            this.Add(Color.FromArgb(255, 0, 0, 255), 4);
            this.Add(Color.FromArgb(255, 255, 255, 0), 5);
            this.Add(Color.FromArgb(255, 0, 255, 255), 6);
            this.Add(Color.FromArgb(255, 255, 0, 255), 7);

            this.Add(Color.FromArgb(255, 127, 127, 127), 8);
            this.Add(Color.FromArgb(255, 127, 0, 0), 9);
            this.Add(Color.FromArgb(255, 0, 127, 0), 10);
            this.Add(Color.FromArgb(255, 0, 0, 127), 11);
            this.Add(Color.FromArgb(255, 127, 127, 0), 12);
            this.Add(Color.FromArgb(255, 0, 127, 127), 13);
            this.Add(Color.FromArgb(255, 127, 0, 127), 14);

            this.Add(Color.FromArgb(255, 191, 191, 191), 15);
            this.Add(Color.FromArgb(255, 191, 0, 0), 16);
            this.Add(Color.FromArgb(255, 0, 191, 0), 17);
            this.Add(Color.FromArgb(255, 0, 0, 191), 18);
            this.Add(Color.FromArgb(255, 191, 191, 0), 19);
            this.Add(Color.FromArgb(255, 0, 191, 191), 20);
            this.Add(Color.FromArgb(255, 191, 0, 191), 21);

            this.Add(Color.FromArgb(255, 63, 63, 63), 22);
            this.Add(Color.FromArgb(255, 63, 0, 0), 23);
            this.Add(Color.FromArgb(255, 0, 63, 0), 24);
            this.Add(Color.FromArgb(255, 0, 0, 63), 25);
            this.Add(Color.FromArgb(255, 63, 63, 0), 26);
            this.Add(Color.FromArgb(255, 0, 63, 63), 27);
            this.Add(Color.FromArgb(255, 63, 0, 63), 28);

            /*
            int index = 0;
            for (int b = 0; b < 3; b++)
            {
                for (int g = 0; g < 3; g++)
                {
                    for (int r = 0; r < 3; r++)
                    {
                        this.Add(Color.FromArgb(255, r * 127, g * 127, b * 127), index);
                        index++;
                    }
                }
            }
            */

            color_from_value = new Dictionary<int, Color>();
            intcolor_from_value = new Dictionary<int, int>();
            value_from_intcolor = new Dictionary<int, int>();

            foreach (KeyValuePair<Color, int> pair in this)
            {
                color_from_value.Add(pair.Value, pair.Key);
                value_from_intcolor.Add(pair.Key.ToArgb(), pair.Value);
                intcolor_from_value.Add(pair.Value, pair.Key.ToArgb());
            }
        }

        public static Dictionary<Color, int> value_from_color = new ColorValues();
        public static Dictionary<int, Color> color_from_value;

        public static Dictionary<int, int> value_from_intcolor;
        public static Dictionary<int, int> intcolor_from_value;
    }

}
