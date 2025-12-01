namespace BadBalatro
{
    partial class BadBalatro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadBalatro));
            cardBox0 = new PictureBox();
            cardBox2 = new PictureBox();
            deckListBox = new ListBox();
            handListBox = new ListBox();
            label1 = new Label();
            playlabel = new Label();
            discardLabel = new Label();
            cardBox4 = new PictureBox();
            cardBox3 = new PictureBox();
            cardBox1 = new PictureBox();
            cardBox7 = new PictureBox();
            cardBox6 = new PictureBox();
            cardBox5 = new PictureBox();
            targetBindLabel = new Label();
            chipLabel = new Label();
            handLabel = new Label();
            playButton = new Button();
            discardButton = new Button();
            button1 = new Button();
            testBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            roundLabel = new Label();
            chipMultlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cardBox0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBox5).BeginInit();
            SuspendLayout();
            // 
            // cardBox0
            // 
            cardBox0.Image = (Image)resources.GetObject("cardBox0.Image");
            cardBox0.Location = new Point(61, 237);
            cardBox0.Margin = new Padding(1, 2, 1, 2);
            cardBox0.Name = "cardBox0";
            cardBox0.Size = new Size(81, 120);
            cardBox0.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox0.TabIndex = 0;
            cardBox0.TabStop = false;
            cardBox0.Click += cardBox0_Click;
            // 
            // cardBox2
            // 
            cardBox2.Image = (Image)resources.GetObject("cardBox2.Image");
            cardBox2.Location = new Point(257, 237);
            cardBox2.Margin = new Padding(1, 2, 1, 2);
            cardBox2.Name = "cardBox2";
            cardBox2.Size = new Size(81, 120);
            cardBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox2.TabIndex = 1;
            cardBox2.TabStop = false;
            cardBox2.Click += cardBox2_Click;
            // 
            // deckListBox
            // 
            deckListBox.FormattingEnabled = true;
            deckListBox.ItemHeight = 25;
            deckListBox.Location = new Point(729, 57);
            deckListBox.Name = "deckListBox";
            deckListBox.Size = new Size(180, 304);
            deckListBox.TabIndex = 2;
            // 
            // handListBox
            // 
            handListBox.FormattingEnabled = true;
            handListBox.ItemHeight = 25;
            handListBox.Location = new Point(540, 70);
            handListBox.Name = "handListBox";
            handListBox.SelectionMode = SelectionMode.MultiSimple;
            handListBox.Size = new Size(145, 179);
            handListBox.TabIndex = 3;
            handListBox.SelectedIndexChanged += handListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 32);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 4;
            label1.Text = "hand";
            // 
            // playlabel
            // 
            playlabel.AutoSize = true;
            playlabel.Location = new Point(61, 165);
            playlabel.Name = "playlabel";
            playlabel.Size = new Size(57, 25);
            playlabel.TabIndex = 5;
            playlabel.Text = "plays:";
            // 
            // discardLabel
            // 
            discardLabel.AutoSize = true;
            discardLabel.Location = new Point(190, 165);
            discardLabel.Name = "discardLabel";
            discardLabel.Size = new Size(83, 25);
            discardLabel.TabIndex = 6;
            discardLabel.Text = "Discards:";
            // 
            // cardBox4
            // 
            cardBox4.Image = (Image)resources.GetObject("cardBox4.Image");
            cardBox4.Location = new Point(61, 390);
            cardBox4.Margin = new Padding(1, 2, 1, 2);
            cardBox4.Name = "cardBox4";
            cardBox4.Size = new Size(81, 120);
            cardBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox4.TabIndex = 8;
            cardBox4.TabStop = false;
            cardBox4.Click += cardBox4_Click;
            // 
            // cardBox3
            // 
            cardBox3.Image = (Image)resources.GetObject("cardBox3.Image");
            cardBox3.Location = new Point(349, 237);
            cardBox3.Margin = new Padding(1, 2, 1, 2);
            cardBox3.Name = "cardBox3";
            cardBox3.Size = new Size(81, 120);
            cardBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox3.TabIndex = 7;
            cardBox3.TabStop = false;
            cardBox3.Click += cardBox3_Click;
            // 
            // cardBox1
            // 
            cardBox1.BackColor = SystemColors.Control;
            cardBox1.BorderStyle = BorderStyle.FixedSingle;
            cardBox1.Image = (Image)resources.GetObject("cardBox1.Image");
            cardBox1.Location = new Point(161, 237);
            cardBox1.Margin = new Padding(1, 2, 1, 2);
            cardBox1.Name = "cardBox1";
            cardBox1.Size = new Size(81, 120);
            cardBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox1.TabIndex = 12;
            cardBox1.TabStop = false;
            cardBox1.Click += cardBox1_Click;
            // 
            // cardBox7
            // 
            cardBox7.Image = (Image)resources.GetObject("cardBox7.Image");
            cardBox7.Location = new Point(349, 390);
            cardBox7.Margin = new Padding(1, 2, 1, 2);
            cardBox7.Name = "cardBox7";
            cardBox7.Size = new Size(81, 120);
            cardBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox7.TabIndex = 11;
            cardBox7.TabStop = false;
            cardBox7.Click += cardBox7_Click;
            // 
            // cardBox6
            // 
            cardBox6.Image = (Image)resources.GetObject("cardBox6.Image");
            cardBox6.Location = new Point(257, 390);
            cardBox6.Margin = new Padding(1, 2, 1, 2);
            cardBox6.Name = "cardBox6";
            cardBox6.Size = new Size(81, 120);
            cardBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox6.TabIndex = 10;
            cardBox6.TabStop = false;
            cardBox6.Click += cardBox6_Click;
            // 
            // cardBox5
            // 
            cardBox5.Image = (Image)resources.GetObject("cardBox5.Image");
            cardBox5.Location = new Point(161, 390);
            cardBox5.Margin = new Padding(1, 2, 1, 2);
            cardBox5.Name = "cardBox5";
            cardBox5.Size = new Size(81, 120);
            cardBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox5.TabIndex = 9;
            cardBox5.TabStop = false;
            cardBox5.Click += cardBox5_Click;
            // 
            // targetBindLabel
            // 
            targetBindLabel.AutoSize = true;
            targetBindLabel.Location = new Point(61, 32);
            targetBindLabel.Name = "targetBindLabel";
            targetBindLabel.Size = new Size(166, 25);
            targetBindLabel.TabIndex = 13;
            targetBindLabel.Text = "Round Target Bind: ";
            // 
            // chipLabel
            // 
            chipLabel.AutoSize = true;
            chipLabel.Location = new Point(61, 70);
            chipLabel.Name = "chipLabel";
            chipLabel.Size = new Size(116, 25);
            chipLabel.TabIndex = 14;
            chipLabel.Text = "Current chips";
            // 
            // handLabel
            // 
            handLabel.AutoSize = true;
            handLabel.Location = new Point(349, 165);
            handLabel.Name = "handLabel";
            handLabel.Size = new Size(116, 25);
            handLabel.TabIndex = 15;
            handLabel.Text = "current hand:";
            // 
            // playButton
            // 
            playButton.Location = new Point(99, 123);
            playButton.Margin = new Padding(1, 2, 1, 2);
            playButton.Name = "playButton";
            playButton.Size = new Size(111, 35);
            playButton.TabIndex = 16;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_click;
            // 
            // discardButton
            // 
            discardButton.Location = new Point(257, 123);
            discardButton.Margin = new Padding(1, 2, 1, 2);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(111, 35);
            discardButton.TabIndex = 17;
            discardButton.Text = "Discard";
            discardButton.UseVisualStyleBackColor = true;
            discardButton.Click += discardButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(686, 413);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 18;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testBox
            // 
            testBox.Location = new Point(527, 285);
            testBox.Name = "testBox";
            testBox.Size = new Size(150, 31);
            testBox.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(527, 390);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(527, 447);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(527, 505);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 24;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(329, 32);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(68, 25);
            roundLabel.TabIndex = 25;
            roundLabel.Text = "Round:";
            // 
            // chipMultlabel
            // 
            chipMultlabel.AutoSize = true;
            chipMultlabel.Location = new Point(299, 80);
            chipMultlabel.Name = "chipMultlabel";
            chipMultlabel.Size = new Size(16, 25);
            chipMultlabel.TabIndex = 26;
            chipMultlabel.Text = ":";
            // 
            // BadBalatro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 612);
            Controls.Add(chipMultlabel);
            Controls.Add(roundLabel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(testBox);
            Controls.Add(button1);
            Controls.Add(discardButton);
            Controls.Add(playButton);
            Controls.Add(handLabel);
            Controls.Add(chipLabel);
            Controls.Add(targetBindLabel);
            Controls.Add(cardBox1);
            Controls.Add(cardBox7);
            Controls.Add(cardBox6);
            Controls.Add(cardBox5);
            Controls.Add(cardBox4);
            Controls.Add(cardBox3);
            Controls.Add(discardLabel);
            Controls.Add(playlabel);
            Controls.Add(label1);
            Controls.Add(handListBox);
            Controls.Add(deckListBox);
            Controls.Add(cardBox2);
            Controls.Add(cardBox0);
            Margin = new Padding(1, 2, 1, 2);
            Name = "BadBalatro";
            Text = "Form1";
            Load += BadBalatro_Load;
            ((System.ComponentModel.ISupportInitialize)cardBox0).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cardBox0;
        private PictureBox cardBox2;
        private ListBox deckListBox;
        private ListBox handListBox;
        private Label label1;
        private Label playlabel;
        private Label discardLabel;
        private PictureBox cardBox4;
        private PictureBox cardBox3;
        private PictureBox cardBox1;
        private PictureBox cardBox7;
        private PictureBox cardBox6;
        private PictureBox cardBox5;
        private Label targetBindLabel;
        private Label chipLabel;
        private Label handLabel;
        private Button playButton;
        private Button discardButton;
        private Button button1;
        private TextBox testBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label roundLabel;
        private Label chipMultlabel;
    }
}
