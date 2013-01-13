using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication2.TuringRand
{
    public class State
    {
        public static Random rand = new Random();

        public enum Action
        {
            MoveLeft,
            MoveRight,
            MoveUp,
            MoveDown,
            MoveNone,
            readvalue  // this entry must be at the bottom, integer maths from enum
        }

        public Action action;
        public int magnitude;
        private int maxstates;

        private State() { }

        public State(int states)
        {
            maxstates = states;

            //if (maxstates > ColorValues.value_from_color.Count - 1) maxstates = ColorValues.value_from_color.Count - 1;
            magnitude = rand.Next(0, maxstates);

            switch (rand.Next(0, 12))
            {
                case 1:
                    action = Action.MoveLeft;
                    break;
                case 2:
                    action = Action.MoveRight;
                    break;
                case 3:
                    action = Action.MoveUp;
                    break;
                case 4:
                    action = Action.MoveDown;
                    break;
                case 5:
                    action = Action.MoveNone;
                    break;
                default:
                    action = Action.readvalue;
                    break;
            }
        }

        private void handle(Action action, ref DataTypes.BitmapUnsafe image, ref int x, ref int y)
        {
            switch (action)
            {
                case Action.MoveLeft:
                    x--;
                    if (x < 0)
                    {
                        x += image.Width;
                        y--;
                        if (y < 0)
                        {
                            y += image.Height;
                        }
                    }
                    goto case Action.MoveNone;
                case Action.MoveRight:
                    x++;
                    if (x >= image.Width)
                    {
                        x -= image.Width;
                        y++;
                        if (y >= image.Height)
                        {
                            y -= image.Height;
                        }
                    }
                    goto case Action.MoveNone;
                case Action.MoveUp:
                    y--;
                    if (y < 0)
                    {
                        y += image.Height;
                    }
                    goto case Action.MoveNone;
                case Action.MoveDown:
                    y++;
                    if (y >= image.Height)
                    {
                        y -= image.Height;
                    }
                    goto case Action.MoveNone;
                case Action.MoveNone:
                    int subwrite = ColorValues.value_from_intcolor[image.GetPixel(x, y)] + magnitude;
                    while (subwrite >= maxstates) subwrite -= maxstates;
                    image.SetPixel(x, y, ColorValues.intcolor_from_value[subwrite]);
                    break;
                case Action.readvalue:
                    int subread = ColorValues.value_from_intcolor[image.GetPixel(x, y)] + magnitude;

                    while (subread >= (int)Action.readvalue) subread -= (int)(Action.readvalue + 1);
                    handle((Action)subread, ref image, ref x, ref y);
                    break;
            }
        }

        public int Handle(ref DataTypes.BitmapUnsafe image, ref int x, ref int y)
        {
            handle(action, ref image, ref x, ref y);

            return ColorValues.value_from_intcolor[image.GetPixel(x, y)];
        }

        public override string ToString()
        {
            return "[" + (int)action + "m" + magnitude.ToString() + "]";
        }

        public static State FromString(string value, int maxstates)
        {
            State retval = new State();

            value = value.Substring(1);
            int index;

            index = value.IndexOf('m');

            retval.action = (Action)Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf(']');

            retval.magnitude = Convert.ToInt32(value.Substring(0, index));

            retval.maxstates = maxstates;

            return retval;
        }
    }

}
