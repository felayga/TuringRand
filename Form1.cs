//#define BOREDOM_ENABLED

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private DataTypes.BitmapUnsafe _image;
#if BOREDOM_ENABLED
        private const int boredomlimit = 8;
#endif
        
        public Form1()
        {
            InitializeComponent();

            this.pictureBox1.interpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            this.button_randomize.Click += new EventHandler(button_randomize_Click);
            this.checkbox_executionstate.CheckedChanged += new EventHandler(checkbox_executionstate_CheckedChanged);
            this.button_restart.Click += new EventHandler(button_restart_Click);
            this.button_fromstring.Click += new EventHandler(button_fromstring_Click);
            this.button_singlestep.Click += new EventHandler(button_singlestep_Click);

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);

#if BOREDOM_ENABLED
            this.checkbox_autoreset.Enabled = true;
            this.label1.Enabled = true;
            this.textbox_boredom.Enabled = true;
#endif
        }

        void button_fromstring_Click(object sender, EventArgs e)
        {
            FromString(this.textbox_machines.Text);
        }

        void button_restart_Click(object sender, EventArgs e)
        {
            boring = int.MinValue;
            boredom = 0;

            this.pictureBox1.BackgroundImage = null;

            for (int y = 0; y < this.numeric_height.Value; y++)
            {
                for (int x = 0; x < this.numeric_width.Value; x++)
                {
                    image.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }

            for (int n = 0; n < instances.Count; n++)
            {
                instances[n].Reset();
            }
        }

        private int boredom = 0;
        private BigInteger boring = -1;

        List<TuringRand.StateMachine> instances;

        void button_singlestep_Click(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = null;
            _image.Lock();

            for (int n = 0; n < this.numeric_width.Value * this.numeric_height.Value; n++)
            {
                for (int i = 0; i < instances.Count; i++)
                {
                    instances[i].Handle();
                }
            }

#if BOREDOM_ENABLED
            BigInteger _boring = _image.IsBoring();
#endif

            _image.Unlock();
            this.pictureBox1.BackgroundImage = image;

#if BOREDOM_ENABLED
            if (_boring == 0 || _boring == boring)
            {
                boredom++;
            }
            else
            {
                boredom = 0;
                boring = _boring;
            }

            if (boredom >= boredomlimit - 1)
            {
                if (boredom > boredomlimit - 1)
                {
                    this.textbox_boredom.Text = "probably halted";
                }
                else
                {
                    this.textbox_boredom.Text = boredom.ToString();
                }

                boredom = boredomlimit - 1;
                if (this.checkbox_autoreset.Checked && sender == null) button_randomize_Click(null, null);
            }
            else
            {
                this.textbox_boredom.Text = boredom.ToString();
            }
#endif
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            button_singlestep_Click(null, null);

            if (this.checkbox_executionstate.Checked) timer.Start();
        }

        private Timer timer;
        void checkbox_executionstate_CheckedChanged(object sender, EventArgs e)
        {

            if (this.checkbox_executionstate.Checked)
            {
                timer.Start();
                this.button_singlestep.Enabled = false;
            }
            else
            {
                timer.Stop();
                this.button_singlestep.Enabled = true;
            }
        }

        void button_randomize_Click(object sender, EventArgs e)
        {
            this.checkbox_executionstate.Enabled = true;
            this.button_singlestep.Enabled = !this.checkbox_executionstate.Checked;

            boring = int.MinValue;
            boredom = 0;

            this.textbox_boredom.Text = boredom.ToString();
            this.pictureBox1.BackgroundImage = null;

            string text = "w" + this.numeric_width.Value.ToString() + "h" + this.numeric_height.Value.ToString();

            image = new Bitmap((int)this.numeric_width.Value, (int)this.numeric_height.Value, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            _image = new DataTypes.BitmapUnsafe(image);

            for (int y = 0; y < this.numeric_height.Value; y++)
            {
                for (int x = 0; x < this.numeric_width.Value; x++)
                {
                    image.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }

            text += "v" + this.numeric_values.Value.ToString();

            if (this.checkbox_samemachine.Checked)
            {
                List<TuringRand.State> states = new List<TuringRand.State>();

                text += "m" + this.numeric_states.Value.ToString() + "s";

                for (int n = 0; n < this.numeric_states.Value; n++)
                {
                    TuringRand.State state = new TuringRand.State((int)this.numeric_values.Value);
                    states.Add(state);

                    text += state.ToString();
                }

                instances = new List<TuringRand.StateMachine>();

                text += "i" + this.numeric_instances.Value.ToString();

                for (int n = 0; n < this.numeric_instances.Value; n++)
                {
                    TuringRand.StateMachine what = new TuringRand.StateMachine(_image, states);
                    instances.Add(what);
                    text += what.ToString(true);
                }
            }
            else
            {
                instances = new List<TuringRand.StateMachine>();

                text += "i" + this.numeric_instances.Value.ToString();

                for (int n = 0; n < this.numeric_instances.Value; n++)
                {
                    List<TuringRand.State> states = new List<TuringRand.State>();

                    for (int subn = 0; subn < this.numeric_states.Value; subn++)
                    {
                        TuringRand.State state = new TuringRand.State((int)this.numeric_values.Value);
                        states.Add(state);
                    }

                    TuringRand.StateMachine what = new TuringRand.StateMachine(_image, states);
                    instances.Add(what);

                    text += what.ToString(false);
                }
            }

            this.textbox_machines.Text = text;
        }

        public void FromString(string value)
        {
            try
            {

                boring = int.MinValue;
                boredom = 0;

                value = value.Substring(1);
                int index;

                index = value.IndexOf('h');

                int width = Convert.ToInt32(value.Substring(0, index));
                this.numeric_width.Value = width;
                value = value.Substring(index + 1);

                index = value.IndexOf('v');

                int height = Convert.ToInt32(value.Substring(0, index));
                this.numeric_height.Value = height;
                value = value.Substring(index + 1);

                this.textbox_boredom.Text = boredom.ToString();
                this.pictureBox1.BackgroundImage = null;
                image = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                _image = new DataTypes.BitmapUnsafe(image);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        image.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                    }
                }


                int indexm, indexi;

                indexm = value.IndexOf('m');
                indexi = value.IndexOf('i');

                if (indexm < 0) indexm = int.MaxValue;
                if (indexi < 0) indexi = int.MaxValue;

                bool samemachine;
                samemachine = indexm < indexi;
                this.checkbox_samemachine.Checked = samemachine;

                index = indexm < indexi ? indexm : indexi;

                int numeric_values = Convert.ToInt32(value.Substring(0, index));
                this.numeric_values.Value = numeric_values;
                value = value.Substring(index + 1);

                if (samemachine)
                {
                    List<TuringRand.State> states = new List<TuringRand.State>();

                    index = value.IndexOf('s');

                    int statecount = Convert.ToInt32(value.Substring(0, index));
                    this.numeric_states.Value = statecount;
                    value = value.Substring(index + 1);

                    for (int n = 0; n < statecount; n++)
                    {
                        index = value.IndexOf(']');

                        TuringRand.State state = TuringRand.State.FromString(value.Substring(0, index + 1), numeric_values);
                        value = value.Substring(index + 1);
                        states.Add(state);
                    }

                    instances = new List<TuringRand.StateMachine>();

                    value = value.Substring(1);

                    index = value.IndexOf('(');

                    int instancecount = Convert.ToInt32(value.Substring(0, index));
                    this.numeric_instances.Value = instancecount;
                    value = value.Substring(index);

                    for (int n = 0; n < this.numeric_instances.Value; n++)
                    {
                        index = value.IndexOf(')');

                        TuringRand.StateMachine what = TuringRand.StateMachine.FromString(_image, value.Substring(0, index + 1), states);
                        value = value.Substring(index + 1);
                        instances.Add(what);
                    }
                }
                else
                {
                    instances = new List<TuringRand.StateMachine>();

                    index = value.IndexOf('(');

                    int instancecount = Convert.ToInt32(value.Substring(0, index));
                    this.numeric_instances.Value = instancecount;
                    value = value.Substring(index);

                    for (int n = 0; n < this.numeric_instances.Value; n++)
                    {
                        index = value.IndexOf(')');

                        TuringRand.StateMachine what = TuringRand.StateMachine.FromString(_image, value.Substring(0, index + 1), numeric_values);
                        value = value.Substring(index + 1);
                        instances.Add(what);
                    }

                    this.numeric_states.Value = instances[0]._states.Count;

                }

                this.checkbox_executionstate.Enabled = true;
                this.button_singlestep.Enabled = !this.checkbox_executionstate.Checked;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to parse string."+Environment.NewLine+Environment.NewLine+"Error given:" + Environment.NewLine + e.Message);
            }
        }

    }
}
