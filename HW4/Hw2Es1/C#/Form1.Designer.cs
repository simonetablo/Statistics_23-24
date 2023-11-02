namespace HW2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox4 = new TextBox();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 247);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(63, 38);
            button1.Name = "button1";
            button1.Size = new Size(145, 23);
            button1.TabIndex = 3;
            button1.Text = "Absolute Distribution";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 38);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 9;
            button2.Text = "Relative Distribution";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(588, 38);
            button3.Name = "button3";
            button3.Size = new Size(145, 23);
            button3.TabIndex = 10;
            button3.Text = "Percentage Distribution";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 67);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 247);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(538, 67);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 247);
            textBox3.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5", "Quantitative continuous 6" });
            comboBox1.Location = new Point(276, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Choose a type of variable";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox2.Location = new Point(12, 360);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Choose the first variable";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox3.Location = new Point(12, 389);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(209, 23);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "Choose the second variable";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(304, 327);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(484, 234);
            textBox4.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(63, 538);
            button4.Name = "button4";
            button4.Size = new Size(145, 23);
            button4.TabIndex = 17;
            button4.Text = "Joint Distribution";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(132, 325);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 327);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 19;
            label1.Text = "Number of variables";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox4.Location = new Point(12, 418);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(209, 23);
            comboBox4.TabIndex = 20;
            comboBox4.Text = "Choose the third variable";
            comboBox4.Visible = false;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox5.Location = new Point(12, 447);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(209, 23);
            comboBox5.TabIndex = 21;
            comboBox5.Text = "Choose the fourth variable";
            comboBox5.Visible = false;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox6.Location = new Point(12, 476);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(209, 23);
            comboBox6.TabIndex = 22;
            comboBox6.Text = "Choose the fifth variable";
            comboBox6.Visible = false;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous 1", "Quantitative continuous 2", "Quantitative continuous 3", "Quantitative continuous 4", "Quantitative continuous 5" });
            comboBox7.Location = new Point(12, 505);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(209, 23);
            comboBox7.TabIndex = 23;
            comboBox7.Text = "Choose the sixth variable";
            comboBox7.Visible = false;
            comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(675, 9);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(39, 23);
            numericUpDown2.TabIndex = 24;
            numericUpDown2.Visible = false;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(588, 13);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 25;
            label2.Text = "Class intervals";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 330);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 27;
            label3.Text = "Intervals";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(240, 362);
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(39, 23);
            numericUpDown3.TabIndex = 26;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Visible = false;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(240, 390);
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(39, 23);
            numericUpDown4.TabIndex = 28;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Visible = false;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(240, 419);
            numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(39, 23);
            numericUpDown5.TabIndex = 30;
            numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Visible = false;
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(240, 448);
            numericUpDown6.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(39, 23);
            numericUpDown6.TabIndex = 32;
            numericUpDown6.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.Visible = false;
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(240, 477);
            numericUpDown7.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(39, 23);
            numericUpDown7.TabIndex = 34;
            numericUpDown7.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown7.Visible = false;
            numericUpDown7.ValueChanged += numericUpDown7_ValueChanged;
            // 
            // numericUpDown8
            // 
            numericUpDown8.Location = new Point(240, 506);
            numericUpDown8.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(39, 23);
            numericUpDown8.TabIndex = 36;
            numericUpDown8.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown8.Visible = false;
            numericUpDown8.ValueChanged += numericUpDown8_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(numericUpDown8);
            Controls.Add(numericUpDown7);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(label3);
            Controls.Add(numericUpDown3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox4;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
    }
}