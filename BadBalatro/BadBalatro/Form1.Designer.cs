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
            label2 = new Label();
            playButton = new Button();
            discardButton = new Button();
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
            cardBox0.Location = new Point(105, 389);
            cardBox0.Name = "cardBox0";
            cardBox0.Size = new Size(139, 197);
            cardBox0.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox0.TabIndex = 0;
            cardBox0.TabStop = false;
            cardBox0.Click += cardBox0_Click;
            // 
            // cardBox2
            // 
            cardBox2.Image = (Image)resources.GetObject("cardBox2.Image");
            cardBox2.Location = new Point(437, 389);
            cardBox2.Name = "cardBox2";
            cardBox2.Size = new Size(139, 197);
            cardBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox2.TabIndex = 1;
            cardBox2.TabStop = false;
            cardBox2.Click += cardBox2_Click;
            // 
            // deckListBox
            // 
            deckListBox.FormattingEnabled = true;
            deckListBox.ItemHeight = 41;
            deckListBox.Location = new Point(1239, 93);
            deckListBox.Margin = new Padding(5, 5, 5, 5);
            deckListBox.Name = "deckListBox";
            deckListBox.Size = new Size(303, 496);
            deckListBox.TabIndex = 2;
            deckListBox.SelectedIndexChanged += deckListBox_SelectedIndexChanged;
            // 
            // handListBox
            // 
            handListBox.FormattingEnabled = true;
            handListBox.ItemHeight = 41;
            handListBox.Location = new Point(918, 115);
            handListBox.Margin = new Padding(5, 5, 5, 5);
            handListBox.Name = "handListBox";
            handListBox.SelectionMode = SelectionMode.MultiSimple;
            handListBox.Size = new Size(245, 578);
            handListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(918, 52);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 41);
            label1.TabIndex = 4;
            label1.Text = "hand";
            label1.Click += label1_Click;
            // 
            // playlabel
            // 
            playlabel.AutoSize = true;
            playlabel.Location = new Point(105, 271);
            playlabel.Margin = new Padding(5, 0, 5, 0);
            playlabel.Name = "playlabel";
            playlabel.Size = new Size(93, 41);
            playlabel.TabIndex = 5;
            playlabel.Text = "plays:";
            playlabel.Click += label2_Click;
            // 
            // discardLabel
            // 
            discardLabel.AutoSize = true;
            discardLabel.Location = new Point(323, 271);
            discardLabel.Margin = new Padding(5, 0, 5, 0);
            discardLabel.Name = "discardLabel";
            discardLabel.Size = new Size(136, 41);
            discardLabel.TabIndex = 6;
            discardLabel.Text = "Discards:";
            // 
            // cardBox4
            // 
            cardBox4.Image = (Image)resources.GetObject("cardBox4.Image");
            cardBox4.Location = new Point(105, 640);
            cardBox4.Name = "cardBox4";
            cardBox4.Size = new Size(139, 197);
            cardBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox4.TabIndex = 8;
            cardBox4.TabStop = false;
            cardBox4.Click += cardBox4_Click;
            // 
            // cardBox3
            // 
            cardBox3.Image = (Image)resources.GetObject("cardBox3.Image");
            cardBox3.Location = new Point(592, 389);
            cardBox3.Name = "cardBox3";
            cardBox3.Size = new Size(139, 197);
            cardBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox3.TabIndex = 7;
            cardBox3.TabStop = false;
            cardBox3.Click += cardBox3_Click;
            // 
            // cardBox1
            // 
            cardBox1.BackColor = SystemColors.Control;
            cardBox1.Image = (Image)resources.GetObject("cardBox1.Image");
            cardBox1.Location = new Point(274, 389);
            cardBox1.Name = "cardBox1";
            cardBox1.Size = new Size(139, 197);
            cardBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox1.TabIndex = 12;
            cardBox1.TabStop = false;
            cardBox1.Click += cardBox1_Click;
            // 
            // cardBox7
            // 
            cardBox7.Image = (Image)resources.GetObject("cardBox7.Image");
            cardBox7.Location = new Point(592, 640);
            cardBox7.Name = "cardBox7";
            cardBox7.Size = new Size(139, 197);
            cardBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox7.TabIndex = 11;
            cardBox7.TabStop = false;
            cardBox7.Click += cardBox7_Click;
            // 
            // cardBox6
            // 
            cardBox6.Image = (Image)resources.GetObject("cardBox6.Image");
            cardBox6.Location = new Point(437, 640);
            cardBox6.Name = "cardBox6";
            cardBox6.Size = new Size(139, 197);
            cardBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox6.TabIndex = 10;
            cardBox6.TabStop = false;
            cardBox6.Click += cardBox6_Click;
            // 
            // cardBox5
            // 
            cardBox5.Image = (Image)resources.GetObject("cardBox5.Image");
            cardBox5.Location = new Point(274, 640);
            cardBox5.Name = "cardBox5";
            cardBox5.Size = new Size(139, 197);
            cardBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBox5.TabIndex = 9;
            cardBox5.TabStop = false;
            cardBox5.Click += cardBox5_Click;
            // 
            // targetBindLabel
            // 
            targetBindLabel.AutoSize = true;
            targetBindLabel.Location = new Point(105, 52);
            targetBindLabel.Margin = new Padding(5, 0, 5, 0);
            targetBindLabel.Name = "targetBindLabel";
            targetBindLabel.Size = new Size(277, 41);
            targetBindLabel.TabIndex = 13;
            targetBindLabel.Text = "Round Target Bind: ";
            targetBindLabel.Click += label2_Click_1;
            targetBindLabel.ChangeUICues += label2_ChangeUICues;
            // 
            // chipLabel
            // 
            chipLabel.AutoSize = true;
            chipLabel.Location = new Point(105, 115);
            chipLabel.Margin = new Padding(5, 0, 5, 0);
            chipLabel.Name = "chipLabel";
            chipLabel.Size = new Size(194, 41);
            chipLabel.TabIndex = 14;
            chipLabel.Text = "Current chips";
            chipLabel.Click += chipLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 271);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 41);
            label2.TabIndex = 15;
            label2.Text = "current hand:";
            // 
            // playButton
            // 
            playButton.Location = new Point(168, 203);
            playButton.Name = "playButton";
            playButton.Size = new Size(188, 58);
            playButton.TabIndex = 16;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += button1_Click;
            // 
            // discardButton
            // 
            discardButton.Location = new Point(437, 203);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(188, 58);
            discardButton.TabIndex = 17;
            discardButton.Text = "Discard";
            discardButton.UseVisualStyleBackColor = true;
            // 
            // BadBalatro
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 1002);
            Controls.Add(discardButton);
            Controls.Add(playButton);
            Controls.Add(label2);
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
        private Label label2;
        private Button playButton;
        private Button discardButton;
    }
}
