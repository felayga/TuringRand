namespace TuringRand
{
    partial class Form1
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
            this.button_randomize = new System.Windows.Forms.Button();
            this.textbox_boredom = new System.Windows.Forms.TextBox();
            this.label_boredom = new System.Windows.Forms.Label();
            this.numeric_width = new System.Windows.Forms.NumericUpDown();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_states = new System.Windows.Forms.NumericUpDown();
            this.numeric_values = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_instances = new System.Windows.Forms.NumericUpDown();
            this.checkbox_samemachine = new System.Windows.Forms.CheckBox();
            this.checkbox_autoreset = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new TuringRand.Forms.PictureBoxInterpolationMode();
            this.button_fromstring = new System.Windows.Forms.Button();
            this.textbox_machines = new TuringRand.Forms.TextBoxNonStupid();
            this.button_singlestep = new System.Windows.Forms.Button();
            this.checkbox_executionstate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_executionrate = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_states)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_values)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_instances)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_executionrate)).BeginInit();
            this.SuspendLayout();
            // 
            // button_randomize
            // 
            this.button_randomize.AutoSize = true;
            this.button_randomize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_randomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_randomize.Location = new System.Drawing.Point(500, 156);
            this.button_randomize.Margin = new System.Windows.Forms.Padding(0);
            this.button_randomize.Name = "button_randomize";
            this.button_randomize.Size = new System.Drawing.Size(125, 26);
            this.button_randomize.TabIndex = 0;
            this.button_randomize.Text = "Randomize";
            this.button_randomize.UseVisualStyleBackColor = true;
            // 
            // textbox_boredom
            // 
            this.textbox_boredom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_boredom.Enabled = false;
            this.textbox_boredom.Location = new System.Drawing.Point(500, 52);
            this.textbox_boredom.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.textbox_boredom.Name = "textbox_boredom";
            this.textbox_boredom.ReadOnly = true;
            this.textbox_boredom.Size = new System.Drawing.Size(125, 22);
            this.textbox_boredom.TabIndex = 3;
            // 
            // label_boredom
            // 
            this.label_boredom.AutoSize = true;
            this.label_boredom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_boredom.Enabled = false;
            this.label_boredom.Location = new System.Drawing.Point(500, 26);
            this.label_boredom.Margin = new System.Windows.Forms.Padding(0);
            this.label_boredom.MaximumSize = new System.Drawing.Size(0, 26);
            this.label_boredom.MinimumSize = new System.Drawing.Size(0, 26);
            this.label_boredom.Name = "label_boredom";
            this.label_boredom.Size = new System.Drawing.Size(125, 26);
            this.label_boredom.TabIndex = 5;
            this.label_boredom.Text = "Boredom:";
            this.label_boredom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numeric_width
            // 
            this.numeric_width.AutoSize = true;
            this.numeric_width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_width.Location = new System.Drawing.Point(500, 208);
            this.numeric_width.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_width.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numeric_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_width.Name = "numeric_width";
            this.numeric_width.Size = new System.Drawing.Size(125, 22);
            this.numeric_width.TabIndex = 6;
            this.numeric_width.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numeric_height
            // 
            this.numeric_height.AutoSize = true;
            this.numeric_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_height.Location = new System.Drawing.Point(625, 208);
            this.numeric_height.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_height.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numeric_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_height.Name = "numeric_height";
            this.numeric_height.Size = new System.Drawing.Size(125, 22);
            this.numeric_height.TabIndex = 7;
            this.numeric_height.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numeric_states
            // 
            this.numeric_states.AutoSize = true;
            this.numeric_states.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_states.Location = new System.Drawing.Point(500, 260);
            this.numeric_states.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_states.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numeric_states.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_states.Name = "numeric_states";
            this.numeric_states.Size = new System.Drawing.Size(125, 22);
            this.numeric_states.TabIndex = 8;
            this.numeric_states.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numeric_values
            // 
            this.numeric_values.AutoSize = true;
            this.numeric_values.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_values.Location = new System.Drawing.Point(625, 260);
            this.numeric_values.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_values.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.numeric_values.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_values.Name = "numeric_values";
            this.numeric_values.Size = new System.Drawing.Size(125, 22);
            this.numeric_values.TabIndex = 9;
            this.numeric_values.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(500, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(625, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Height:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(500, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "States:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(625, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Values:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button_restart
            // 
            this.button_restart.AutoSize = true;
            this.button_restart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_restart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_restart.Location = new System.Drawing.Point(625, 156);
            this.button_restart.Margin = new System.Windows.Forms.Padding(0);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(125, 26);
            this.button_restart.TabIndex = 14;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(500, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Instances:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numeric_instances
            // 
            this.numeric_instances.AutoSize = true;
            this.numeric_instances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_instances.Location = new System.Drawing.Point(500, 312);
            this.numeric_instances.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_instances.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numeric_instances.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_instances.Name = "numeric_instances";
            this.numeric_instances.Size = new System.Drawing.Size(125, 22);
            this.numeric_instances.TabIndex = 16;
            this.numeric_instances.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkbox_samemachine
            // 
            this.checkbox_samemachine.AutoSize = true;
            this.checkbox_samemachine.Checked = true;
            this.checkbox_samemachine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_samemachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox_samemachine.Location = new System.Drawing.Point(631, 312);
            this.checkbox_samemachine.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.checkbox_samemachine.Name = "checkbox_samemachine";
            this.checkbox_samemachine.Size = new System.Drawing.Size(119, 26);
            this.checkbox_samemachine.TabIndex = 17;
            this.checkbox_samemachine.Text = "Same Machine";
            this.checkbox_samemachine.UseVisualStyleBackColor = true;
            // 
            // checkbox_autoreset
            // 
            this.checkbox_autoreset.AutoSize = true;
            this.checkbox_autoreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox_autoreset.Enabled = false;
            this.checkbox_autoreset.Location = new System.Drawing.Point(631, 52);
            this.checkbox_autoreset.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.checkbox_autoreset.Name = "checkbox_autoreset";
            this.checkbox_autoreset.Size = new System.Drawing.Size(119, 26);
            this.checkbox_autoreset.TabIndex = 18;
            this.checkbox_autoreset.Text = "Auto-Random";
            this.checkbox_autoreset.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_boredom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textbox_boredom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkbox_autoreset, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_randomize, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_restart, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.numeric_width, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.numeric_height, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.numeric_states, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.numeric_values, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.numeric_instances, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.checkbox_samemachine, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.button_fromstring, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.textbox_machines, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.button_singlestep, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkbox_executionstate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numeric_executionrate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 480);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 16);
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_fromstring
            // 
            this.button_fromstring.AutoSize = true;
            this.button_fromstring.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_fromstring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_fromstring.Location = new System.Drawing.Point(500, 364);
            this.button_fromstring.Margin = new System.Windows.Forms.Padding(0);
            this.button_fromstring.Name = "button_fromstring";
            this.button_fromstring.Size = new System.Drawing.Size(125, 26);
            this.button_fromstring.TabIndex = 21;
            this.button_fromstring.Text = "From String";
            this.button_fromstring.UseVisualStyleBackColor = true;
            // 
            // textbox_machines
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textbox_machines, 2);
            this.textbox_machines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_machines.Location = new System.Drawing.Point(500, 390);
            this.textbox_machines.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_machines.Multiline = true;
            this.textbox_machines.Name = "textbox_machines";
            this.textbox_machines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_machines.Size = new System.Drawing.Size(250, 90);
            this.textbox_machines.TabIndex = 20;
            // 
            // button_singlestep
            // 
            this.button_singlestep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_singlestep.Enabled = false;
            this.button_singlestep.Location = new System.Drawing.Point(625, 0);
            this.button_singlestep.Margin = new System.Windows.Forms.Padding(0);
            this.button_singlestep.Name = "button_singlestep";
            this.button_singlestep.Size = new System.Drawing.Size(125, 26);
            this.button_singlestep.TabIndex = 22;
            this.button_singlestep.Text = "Single Step";
            this.button_singlestep.UseVisualStyleBackColor = true;
            // 
            // checkbox_executionstate
            // 
            this.checkbox_executionstate.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkbox_executionstate.AutoSize = true;
            this.checkbox_executionstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox_executionstate.Enabled = false;
            this.checkbox_executionstate.Location = new System.Drawing.Point(500, 0);
            this.checkbox_executionstate.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_executionstate.Name = "checkbox_executionstate";
            this.checkbox_executionstate.Size = new System.Drawing.Size(125, 26);
            this.checkbox_executionstate.TabIndex = 23;
            this.checkbox_executionstate.Text = "Execution State";
            this.checkbox_executionstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbox_executionstate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(500, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.MaximumSize = new System.Drawing.Size(0, 26);
            this.label7.MinimumSize = new System.Drawing.Size(0, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Execution Rate:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numeric_executionrate
            // 
            this.numeric_executionrate.DecimalPlaces = 2;
            this.numeric_executionrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_executionrate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_executionrate.Location = new System.Drawing.Point(500, 104);
            this.numeric_executionrate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.numeric_executionrate.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_executionrate.Name = "numeric_executionrate";
            this.numeric_executionrate.Size = new System.Drawing.Size(125, 22);
            this.numeric_executionrate.TabIndex = 25;
            this.numeric_executionrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(625, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_states)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_values)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_instances)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_executionrate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_randomize;
        private TuringRand.Forms.PictureBoxInterpolationMode pictureBox1;
        private System.Windows.Forms.TextBox textbox_boredom;
        private System.Windows.Forms.Label label_boredom;
        private System.Windows.Forms.NumericUpDown numeric_width;
        private System.Windows.Forms.NumericUpDown numeric_height;
        private System.Windows.Forms.NumericUpDown numeric_states;
        private System.Windows.Forms.NumericUpDown numeric_values;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_instances;
        private System.Windows.Forms.CheckBox checkbox_samemachine;
        private System.Windows.Forms.CheckBox checkbox_autoreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TuringRand.Forms.TextBoxNonStupid textbox_machines;
        private System.Windows.Forms.Button button_fromstring;
        private System.Windows.Forms.Button button_singlestep;
        private System.Windows.Forms.CheckBox checkbox_executionstate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_executionrate;
        private System.Windows.Forms.TextBox textBox1;
    }
}

