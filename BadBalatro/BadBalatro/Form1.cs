using BadBalatro.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BadBalatro
{
    public partial class BadBalatro : Form
    {
        List<string> deck = new List<string>();
        List<string> hand = new List<string>();
        List<string> discardPile = new List<string>();
        List<PictureBox> cardPictureBoxes = new List<PictureBox>();
        List<Card> selectedCards = new List<Card>();

        bool deselecting = false;

        //holds all the card class instances in one list
        //to acess a element from a card For example the suite use cards[i].getSuite() with i being the index;
        List<Card> cards = new List<Card>();

        //the max amount of cards that can be in a hand at a time 
        int maxCards = 8;
        //the max amount of cards that can be selected
        int maxSelection = 5;
        bool canSelect = true;
        //still need to integrate a max selection for the list box


        string handType;


        int plays = 4;
        int discards = 4;
        int round = 1;
        int chips = 0;
        int targetChip;

        int roundChips = 0;
        int roundMult = 0;

        int cardBoxY;




        //HH
        public int calculatetargetChip()
        {
            int currentChips = 0;

            currentChips = 150 + (150 * round);
            //For each round, 150 points is added, and the round level is * by round #
            return currentChips;


        }
        // Function that updates cardBox image based on value taken from list when called 
        public void setCardImage()
        {
             for (int i = 0; i < hand.Count; i++)
             {
                int currentNumber = cards[i].getNumber();
                string currentSuit = cards[i].getSuite();

                string imagePath = $"CardSprites\\{currentSuit}\\{currentNumber}{currentSuit}.png";

                if (System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        cardPictureBoxes[i].ImageLocation = imagePath;
                        cardPictureBoxes[i].Load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"File exists but failed to load: {imagePath}");
                    }
                }
                else
                {
                    // This prevents the "File Not Found" crash
                   
                }
            }
        }

        //Function called as it loads for the user
        private void BadBalatro_Load(object sender, EventArgs e)
        {
            cardBoxY = cardBox0.Location.Y;
            //BN
            try { 
            scoringRulesBox.ImageLocation = ("scoring rules.png");
            }catch(Exception ex)
            {
                MessageBox.Show("scoring Rules failed to load in code");
            }
            intializeDeck();

            cardPictureBoxes.Add(cardBox0); cardPictureBoxes.Add(cardBox1); cardPictureBoxes.Add(cardBox2); cardPictureBoxes.Add(cardBox3); cardPictureBoxes.Add(cardBox4); cardPictureBoxes.Add(cardBox5); cardPictureBoxes.Add(cardBox6); cardPictureBoxes.Add(cardBox7);


            playlabel.Text = "plays: " + plays.ToString();
            discardLabel.Text = "discards: " + discards.ToString();
            targetChip = calculatetargetChip();
            targetBindLabel.Text = "Round Target Bind: " + targetChip.ToString();
            deck = shuffle(deck, 4);
            for (int i = 0; i < maxCards; i++)
            {
                moveTolist(i, deck, hand);
                //updateBox(handListBox, hand);
                //updateBox(deckListBox, deck);
                //handListBox.Items.Add(hand[i]);
            }
            for (int i = 0; i < maxCards; i++)
            {
                cards.Add(new Card());
                cards[i].setPictureBox(cardPictureBoxes[i]);
            }
            updateCardClasses();
            updateCardPosition();
            setCardImage();

        }




        //takes a list and populate all of it into a listbox 
        //string list overload
        public void updateBox(ListBox box, List<string> list)
        {
            box.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                box.Items.Add(list[i]);
            }
        }





        //takes a element at a index of the originList and moves it to the destinationList
        //The function will remove it from the origin list.
        //ex: Can be used to move a card from the deck to the hand or vise versa
        public void moveTolist(int index, List<string> originList, List<string> destinationList)
        {
            destinationList.Add(originList[index]);
            originList.RemoveAt(index);
        }
        //adds all 52 cards to the deck 
        public void intializeDeck()
        {
            string currentSuite = "";
            int currentIndex = 0;

            //sets the suite 
            for (int x = 0; x < 4; x++)
            {
                switch (x)
                {
                    case 0:
                        currentSuite = "Hearts";
                        
                        break;
                    case 1:
                        currentSuite = "Diamonds";
                        break;
                    case 2:
                        currentSuite = "Spades";
                        
                        break;
                    case 3:
                        currentSuite = "Clubs";

                        break;
                }
                //sets the card number and adds the two together into  the deck
                for (int y = 1; y <= 13; y++)
                {
                    deck.Add(currentSuite + "," + y);
                    currentIndex++;
                }
            }

        }


        public void updateCardPosition() // TK
        {
            // MessageBox.Show("function run ");

            for (int i = 0; i < 8; i++)
            {
                if (canSelect == true)
                {

                    if (cards[i].getIsSelected() == false)
                    {
                        //MessageBox.Show("if ran");

                        cardPictureBoxes[i].Location = new Point(cardPictureBoxes[i].Location.X, cardBoxY);
                    }
                    else if (cards[i].getIsSelected() == true)
                    {
                         //MessageBox.Show("else if ran");
                        cardPictureBoxes[i].Location = new Point(cardPictureBoxes[i].Location.X, cardBoxY - 35);
                    }

                }

                else
                {
                    cardPictureBoxes[i].Location = new Point(cardPictureBoxes[i].Location.X, cardBoxY);
                }
            }
        }


        //Shuffles and returns a list that you give it. Shuffle Value is how many times the program will shuffle the list
        //use by making the list eual it like so, deckList = shuffle(deckList,2)
        public List<string> shuffle(List<string> list, int shuffleValue)
        {
            //used for seeded random
            Random random = new Random();

            int randomInt;
            string tempValue;

            for (int x = 0; x < shuffleValue; x++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    //chooses a random index that list[i] will switch with 
                    randomInt = random.Next(0, list.Count);

                    //switches the two values
                    tempValue = list[i];
                    list[i] = list[randomInt];
                    list[randomInt] = tempValue;

                }
            }

            return list;
        }

        public BadBalatro()
        {
            InitializeComponent();
        }

        //Makes the card classes match with the deck List and layout  
        //call this anytime a card is getting played/discared so the new ones will take there place
        public void updateCardClasses()
        {
            //looks at every card 
            for (int i = 0; i < maxCards; i++)
            {
                string[] split;
                //local variable to store the suite and number 
                // the first element is the  suite and the second element is the number
                if (i < hand.Count)
                {
                    split = hand[i].ToString().Split(",");

                    //sets the suite
                    cards[i].setSuite(split[0]);

                    //sets the number
                    cards[i].setNumber(int.Parse(split[1]));
                    cards[i].GetPictureBox().Visible = true;
                }
                else
                {
                    cards[i].GetPictureBox().Visible = false;
                }
            }
        }

        // New function to handle Next Round Logic
        public void startNextRound()
        {
            MessageBox.Show("Round Complete! Starting Round " + (round + 1));

            // the round variable will have to increase by one
            round++;

            // then you will need to update the target bind variable and the text box to match.
            // You can do this by making the targetChips = calculateTargetChips
            targetChip = calculatetargetChip();
            targetBindLabel.Text = "Round Target Bind: " + targetChip.ToString();

            // then move any cards from the discard pile and the hand back into the deck 
            // Move hand to deck
            while (hand.Count > 0)
            {
                moveTolist(0, hand, deck);
            }
            // Move discard pile to deck
            while (discardPile.Count > 0)
            {
                moveTolist(0, discardPile, deck);
            }

            // shuffle the deck 
            deck = shuffle(deck, 4);

            // then draw the players 8 more cards
            for (int i = 0; i < maxCards; i++)
            {
                if (deck.Count > 0)
                {
                    moveTolist(0, deck, hand);
                }
            }

            // Update visual cards to reflect changes
            setCardImage();

            updateCardClasses();
            //MR
            // Additional resets to make sure the game is playable in the new round
            selectedCards.Clear();

            plays = 4;
            discards = 4;
            chips = 0;
            chipLabel.Text = $"Chips: {chips}";
            playlabel.Text = "plays: " + plays.ToString();
            discardLabel.Text = "discards: " + discards.ToString();
            canSelect = true;
            playButton.Enabled = true;
            
        }




        //MR
        string scoringFramework()
        {

            List<Card> sorted = selectedCards.OrderBy(x => x.getNumber()).ToList();

            //  Check Flush
            bool isFlush = true;
            if (sorted.Count == 5)
            {
                for (int i = 1; i < sorted.Count; i++)
                {
                    if (sorted[i].getSuite() != sorted[0].getSuite())
                        isFlush = false;
                }
            }
            else
            {
                isFlush = false;
            }

            //  Check Straight
            bool isStraight = true;
            if (sorted.Count == 5)
            {

                for (int i = 1; i < sorted.Count; i++)
                {
                    if (sorted[i].getNumber() != sorted[i - 1].getNumber() + 1)
                        isStraight = false;
                }
            }
            else
            {
                isStraight = false;
            }

            //  Group cards by Rank 
            var groups = sorted.GroupBy(x => x.getNumber())
                                .Select(g => new { Num = g.Key, Count = g.Count() })
                                .OrderByDescending(g => g.Count).ToList();

            // SCORING DECISION

            if (isStraight && isFlush)
            {
                roundChips = 100; roundMult = 8;
                return "Straight Flush";
            }

            if (groups.Count > 0 && groups[0].Count == 4)
            {
                roundChips = 60; roundMult = 7;
                return "Four of a Kind";
            }

            if (groups.Count > 1 && groups[0].Count == 3 && groups[1].Count == 2)
            {
                roundChips = 40; roundMult = 4;
                return "Full House";
            }

            if (isFlush)
            {
                roundChips = 35; roundMult = 4;
                return "Flush";
            }

            if (isStraight)
            {
                roundChips = 30; roundMult = 4;
                return "Straight";
            }

            if (groups.Count > 0 && groups[0].Count == 3)
            {
                roundChips = 30; roundMult = 3;
                return "Three of a Kind";
            }

            if (groups.Count > 1 && groups[0].Count == 2 && groups[1].Count == 2)
            {
                roundChips = 20; roundMult = 2;
                return "Two Pair";
            }

            if (groups.Count > 0 && groups[0].Count == 2)
            {
                roundChips = 10; roundMult = 2;
                return "Pair";
            }

            // High Card default
            roundChips = 5; roundMult = 1;
            return "High Card";
        }

        private void playButton_click(object sender, EventArgs e)
        {
            if (selectedCards.Count > 0)
            {

                playButton.Enabled = false;
                canSelect = false;
                updateCardPosition();
                plays--;
                playlabel.Text = "plays: " + plays.ToString();
                //MR
                // Calculate chips and mult from scoring Framework (Base hand score)
                handType = scoringFramework();
                handLabel.Text = handType;

                // Calculate the chips from each selected card and add to roundChips
                //if(handType != "High Card")
                for (int i = 0; i < selectedCards.Count; i++)
                {

                    roundChips += selectedCards[i].getChips();
                }



                //calculate total points
                int totalPlayScore = roundChips * roundMult;

                chips += totalPlayScore;
                chipLabel.Text = $"Chips: {chips}";
                //MessageBox.Show($"Hand: {handType}\nScore: {totalPlayScore}");
                discardSelected(true);

                roundChips = 0;
                canSelect = true;
                playButton.Enabled = true;


                if (chips >= targetChip)
                {
                    startNextRound();
                }
                else if (plays == 0)
                {
                    MessageBox.Show("Game Over! You ran out of plays.");
                }

                //targetChip = calculatetargetChip();
                //round ends when player reaches goal points
                //when play button is clicked, everything will be run. We will need  to double check the logic of a player wining a round
                setCardImage();
            }
        }

        public void discardSelected(bool drawMore)
        {

            for (int i = 0; i < selectedCards.Count; i++)
            {
                selectedCards[i].GetPictureBox().BackColor = Color.Transparent;

                string x = selectedCards[i].getSuite() + "," + selectedCards[i].getNumber().ToString();



                int y = hand.IndexOf(x);
                cards[y].setIsSelected(false);
                updateCardPosition();
                moveTolist(y, hand, discardPile);

                //draw new cards
                if (drawMore)
                {
                    hand.Insert(y, deck[0]);
                    deck.RemoveAt(0);
                    //updateBox(deckListBox, deck);
                    //updateBox(handListBox, hand);
                    updateCardClasses();
                }
            }
            selectedCards.Clear();
            setCardImage();
        }
        private void discardButton_Click(object sender, EventArgs e)
        {


            discardPile.ToList().ForEach(Console.WriteLine);
            if (discards > 0)
            {
                discards = discards - 1;
                discardLabel.Text = "discards: " + discards.ToString();


                //unselect cards 
                discardSelected(true);
                setCardImage();
            }
            else
            {
                MessageBox.Show("No more discards left", "No Discards");
            }

        }


        // Card clicking and selection  handling
        void cardSelection(int index)
        {
            int yFactor = 35;

            if (canSelect)
            {
                if (cards[index].getIsSelected() == false)
                {
                    if (selectedCards.Count < maxSelection)
                    {

                        cards[index].setIsSelected(true);

                        //cardPictureBoxes[index].BackColor = Color.Blue;
                        //cardPictureBoxes[index].Location = new Point(cardPictureBoxes[index].Location.X, cardPictureBoxes[index].Location.Y - yFactor);
                        //cardPictureBoxes[index].bo
                        //MessageBox.Show(cards[index].getCardString());
                        selectedCards.Add(cards[index]);


                    }
                    else
                    {
                        MessageBox.Show("Only 5 cards can be selected at a time");
                    }
                }
                //if it is selected 
                else if (cards[index].getIsSelected() == true)
                {
                    cards[index].setIsSelected(false);
                    //cardPictureBoxes[index].BackColor = Color.White;
                   // cardPictureBoxes[index].Location = new Point(cardPictureBoxes[index].Location.X, cardPictureBoxes[index].Location.Y + yFactor);

                    selectedCards.Remove(cards[index]);

                }
                updateCardPosition();
                handLabel.Text = $"{scoringFramework()} \n C: {roundChips} X M: {roundMult} ";


            }
        }

        private void cardBox0_Click(object sender, EventArgs e)
        {
            cardSelection(0);

        }

        private void cardBox1_Click(object sender, EventArgs e)
        {
            cardSelection(1);
        }

        private void cardBox2_Click(object sender, EventArgs e)
        {
            cardSelection(2);
        }

        private void cardBox3_Click(object sender, EventArgs e)
        {
            cardSelection(3);
        }

        private void cardBox4_Click(object sender, EventArgs e)
        {
            cardSelection(4);
        }

        private void cardBox5_Click(object sender, EventArgs e)
        {
            cardSelection(5);
        }

        private void cardBox6_Click(object sender, EventArgs e)
        {
            cardSelection(6);
        }

        private void cardBox7_Click(object sender, EventArgs e)
        {
            cardSelection(7);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            selectedCards.Clear();
            for (int i = 0; i < 5; i++)
            {

                selectedCards.Add(new Card());

            }
            string[] split = testBox.Text.Split(',');
            selectedCards[0].setSuite(split[0]);
            selectedCards[0].setNumber(int.Parse(split[1]));

            split = textBox1.Text.Split(",");
            selectedCards[1].setSuite(split[0]);
            selectedCards[1].setNumber(int.Parse(split[1]));

            split = textBox2.Text.Split(",");
            selectedCards[2].setSuite(split[0]);
            selectedCards[2].setNumber(int.Parse(split[1]));

            split = textBox3.Text.Split(",");
            selectedCards[3].setSuite(split[0]);
            selectedCards[3].setNumber(int.Parse(split[1]));

            split = textBox4.Text.Split(",");
            selectedCards[4].setSuite(split[0]);
            selectedCards[4].setNumber(int.Parse(split[1]));
            roundChips = 0; roundMult = 0;



            //calculate total points
            handType = scoringFramework();

            for (int i = 0; i < selectedCards.Count; i++)
            {

                roundChips += selectedCards[i].getChips();
            }

            int totalPlayScore = roundChips * roundMult;

            handLabel.Text = $"{handType}, C: {roundChips}, M: {roundMult} total {totalPlayScore}";

        }

        private void handListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //HH
        private void Rules_Click(object sender, EventArgs e)
        {
        
            {
                string rules = "Rules:\n" +
                               "1. Each game consists of multiple rounds where the difficulty increases each time\n" +
                               "2.You can play a poker hand up to 5-cards at a time in order to achieve the target score(chips).\n" +
                               "3 Poker hands and scores can be found to the right of the window\n" +
                               "4.When you reach the target score, you can proceed to the next round.\n" + 
                               "5.You can discard up to 5 cards 4 times per round and trade those cards for additional cards in order to create better hands.\n"+
                               "6. Each round you can only discard 4 hands and play 4 hands if you run out of plays you lose so use each strategically ";

                MessageBox.Show(rules, "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };


        }
    }
}
