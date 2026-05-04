namespace FarmerGame
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(58, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(335, 802);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(452, 307);
            button1.Name = "button1";
            button1.Size = new Size(126, 58);
            button1.TabIndex = 3;
            button1.Text = "-->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 654);
            button2.Name = "button2";
            button2.Size = new Size(126, 58);
            button2.TabIndex = 4;
            button2.Text = "<--";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(670, 107);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(335, 802);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1241, 107);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(335, 802);
            listBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(670, 957);
            button3.Name = "button3";
            button3.Size = new Size(126, 58);
            button3.TabIndex = 7;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(879, 957);
            button4.Name = "button4";
            button4.Size = new Size(126, 58);
            button4.TabIndex = 8;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1752, 1057);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "v";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button3;
        private Button button4;
    }
}
