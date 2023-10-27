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
            comboBox1.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous" });
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
            comboBox2.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous" });
            comboBox2.Location = new Point(12, 396);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Choose the second variable";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Qualitative", "Quantitative discrete", "Quantitative continuous" });
            comboBox3.Location = new Point(12, 455);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 23);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "Choose the first variable";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 355);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(512, 206);
            textBox4.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(63, 510);
            button4.Name = "button4";
            button4.Size = new Size(145, 23);
            button4.TabIndex = 17;
            button4.Text = "Joint Distribution";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
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
    }
}