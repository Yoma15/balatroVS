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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            deckListBox = new ListBox();
            handListBox = new ListBox();
            label1 = new Label();
            playlabel = new Label();
            discardLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 237);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 237);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // deckListBox
            // 
            deckListBox.FormattingEnabled = true;
            deckListBox.ItemHeight = 25;
            deckListBox.Location = new Point(485, -1);
            deckListBox.Name = "deckListBox";
            deckListBox.Size = new Size(180, 379);
            deckListBox.TabIndex = 2;
            // 
            // handListBox
            // 
            handListBox.FormattingEnabled = true;
            handListBox.ItemHeight = 25;
            handListBox.Location = new Point(321, 24);
            handListBox.Name = "handListBox";
            handListBox.SelectionMode = SelectionMode.MultiSimple;
            handListBox.Size = new Size(146, 354);
            handListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, -1);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 4;
            label1.Text = "hand";
            label1.Click += label1_Click;
            // 
            // playlabel
            // 
            playlabel.AutoSize = true;
            playlabel.Location = new Point(32, 164);
            playlabel.Name = "playlabel";
            playlabel.Size = new Size(57, 25);
            playlabel.TabIndex = 5;
            playlabel.Text = "plays:";
            playlabel.Click += label2_Click;
            // 
            // discardLabel
            // 
            discardLabel.AutoSize = true;
            discardLabel.Location = new Point(160, 164);
            discardLabel.Name = "discardLabel";
            discardLabel.Size = new Size(83, 25);
            discardLabel.TabIndex = 6;
            discardLabel.Text = "Discards:";
            // 
            // BadBalatro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 385);
            Controls.Add(discardLabel);
            Controls.Add(playlabel);
            Controls.Add(label1);
            Controls.Add(handListBox);
            Controls.Add(deckListBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "BadBalatro";
            Text = "Form1";
            Load += BadBalatro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox deckListBox;
        private ListBox handListBox;
        private Label label1;
        private Label playlabel;
        private Label discardLabel;
    }
}
