using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuringRand.TuringMachine
{
    public class StateMachine
    {
        private static Random rand = new Random();

        public int startx, starty;
        public State startstate;

        public int x, y;
        public State state;

        private DataTypes.BitmapUnsafe _bitmap;

        internal List<State> _states;

        private StateMachine() { }

        public StateMachine(DataTypes.BitmapUnsafe bitmap, List<State> states)
        {
            _bitmap = bitmap;
            _states = states;

            startx = rand.Next(0, bitmap.Width);
            starty = rand.Next(0, bitmap.Height);
            startstate = states[rand.Next(0, states.Count)];

            Reset();
        }

        public void Reset()
        {
            x = startx;
            y = starty;
            state = startstate;
        }

        public void Handle()
        {
            int newstate = state.Handle(ref _bitmap, ref x, ref y);
            if (newstate < 0)
            {
                int reprogramindex = -newstate - 1;

                int otherparam=0;
                while (reprogramindex >= _states.Count)
                {
                    reprogramindex -= _states.Count;
                    otherparam++;
                }

                _states[reprogramindex] = new State(_states.Count);
            }
            else
            {
                while (newstate >= _states.Count) newstate -= _states.Count;
                state = _states[newstate];
            }
        }

        public string ToString(bool dupmachine)
        {
            string retval = "(";

            if (dupmachine) retval += "d";
            else retval += "s";

            retval += _states.Count.ToString() + "i" + _states.IndexOf(startstate) + "x" + x.ToString() + "y" + y.ToString();

            if (!dupmachine)
            {
                for (int n = 0; n < _states.Count; n++)
                {
                    retval += _states[n].ToString();
                }
            }

            retval += ")";

            return retval;
        }

        public static StateMachine FromString(DataTypes.BitmapUnsafe image, string value, int maxstates)
        {
            StateMachine retval = new StateMachine();
            retval._bitmap = image;

            value = value.Substring(1);
            if (value[0] != 's') throw new Exception("wrong function for dupmachine");

            value = value.Substring(1);

            int index;

            index = value.IndexOf('i');

            int statecount = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf('x');

            int initialstate = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf('y');

            retval.startx = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf('[');

            retval.starty = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index);

            retval._states = new List<State>();

            for (int n = 0; n < statecount; n++)
            {
                index = value.IndexOf(']');
                retval._states.Add(State.FromString(value.Substring(0, index + 1), maxstates));
                value = value.Substring(index + 1);
            }

            if (value != ")") throw new Exception("end mismatch");

            retval.startstate = retval._states[initialstate];

            retval.Reset();
            return retval;
        }

        public static StateMachine FromString(DataTypes.BitmapUnsafe image, string value, List<State> states)
        {
            StateMachine retval = new StateMachine();
            retval._bitmap = image;

            value = value.Substring(1);
            if (value[0] != 'd') throw new Exception("wrong function for not dupmachine");

            value = value.Substring(1);

            int index;

            index = value.IndexOf('i');

            int statecount = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf('x');

            int initialstate = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf('y');

            retval.startx = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index + 1);

            index = value.IndexOf(')');

            retval.starty = Convert.ToInt32(value.Substring(0, index));
            value = value.Substring(index);

            retval._states = states;

            if (value != ")") throw new Exception("end mismatch");

            retval.startstate = retval._states[initialstate];

            retval.Reset();
            return retval;
        }
    }

}
