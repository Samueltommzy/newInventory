namespace salesSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beverageBox = new System.Windows.Forms.ComboBox();
            this.maincourseBox = new System.Windows.Forms.ComboBox();
            this.appetizerBox = new System.Windows.Forms.ComboBox();
            this.dessertBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Samuel Sales Enterprise";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Calculator";
            // 
            // beverageBox
            // 
            this.beverageBox.FormattingEnabled = true;
            this.beverageBox.Items.AddRange(new object[] {
            "Vitamilk #200",
            "Tea #50",
            "Coke #100",
            "Fanta #100",
            "Five Alive #250",
            "Sprite #50",
            "Pepsi #60"});
            this.beverageBox.Location = new System.Drawing.Point(12, 83);
            this.beverageBox.Name = "beverageBox";
            this.beverageBox.Size = new System.Drawing.Size(121, 21);
            this.beverageBox.TabIndex = 2;
            this.beverageBox.Text = "BEVERAGES";
            this.beverageBox.SelectedIndexChanged += new System.EventHandler(this.beverageBox_SelectedIndexChanged);
            // 
            // maincourseBox
            // 
            this.maincourseBox.FormattingEnabled = true;
            this.maincourseBox.Items.AddRange(new object[] {
            "Jollof Rice& Chicken(Plate) #450",
            "Spaghetti(pate) #250",
            "Lobster Pie #300",
            "Yam & Friedegg #300"});
            this.maincourseBox.Location = new System.Drawing.Point(175, 83);
            this.maincourseBox.Name = "maincourseBox";
            this.maincourseBox.Size = new System.Drawing.Size(121, 21);
            this.maincourseBox.TabIndex = 3;
            this.maincourseBox.Text = "MAIN COURSE ";
            this.maincourseBox.SelectedIndexChanged += new System.EventHandler(this.beverageBox_SelectedIndexChanged);
            // 
            // appetizerBox
            // 
            this.appetizerBox.FormattingEnabled = true;
            this.appetizerBox.Items.AddRange(new object[] {
            "Popcorn #150",
            "Potato Sausage #150",
            "Mushroom Caps #200",
            "Egg roll #80",
            "Fish roll #80",
            "Chips #50"});
            this.appetizerBox.Location = new System.Drawing.Point(12, 185);
            this.appetizerBox.Name = "appetizerBox";
            this.appetizerBox.Size = new System.Drawing.Size(121, 21);
            this.appetizerBox.TabIndex = 4;
            this.appetizerBox.Text = "APPETIZERS";
            this.appetizerBox.SelectedIndexChanged += new System.EventHandler(this.beverageBox_SelectedIndexChanged);
            // 
            // dessertBox
            // 
            this.dessertBox.FormattingEnabled = true;
            this.dessertBox.Items.AddRange(new object[] {
            "Apple Pie #150",
            "Ice cream #200",
            "Special Vegetable #50"});
            this.dessertBox.Location = new System.Drawing.Point(175, 185);
            this.dessertBox.Name = "dessertBox";
            this.dessertBox.Size = new System.Drawing.Size(121, 21);
            this.dessertBox.TabIndex = 5;
            this.dessertBox.Text = "DESSERTS";
            this.dessertBox.SelectedIndexChanged += new System.EventHandler(this.beverageBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 281);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 173);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(113, 479);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 479);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(308, 524);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dessertBox);
            this.Controls.Add(this.appetizerBox);
            this.Controls.Add(this.maincourseBox);
            this.Controls.Add(this.beverageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox beverageBox;
        private System.Windows.Forms.ComboBox maincourseBox;
        private System.Windows.Forms.ComboBox appetizerBox;
        private System.Windows.Forms.ComboBox dessertBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

