using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Linq.Expressions;
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

        int plays = 4;
        int discards = 4;
        int round = 1;
        int chips = 0;
        int targetChip;
        

        
        public int calculatetargetChip()
        {
            int currentChips = 0;

            currentChips = 150 + (150*round);
            //For each round, 150 points is added, and the round level is * by round #
            return currentChips;

            
        }

        //Function called as it loads for the user 

        private void BadBalatro_Load(object sender, EventArgs e)
        {
            intializeDeck();
            cardPictureBoxes.Add(cardBox0); cardPictureBoxes.Add(cardBox1); cardPictureBoxes.Add(cardBox2); cardPictureBoxes.Add(cardBox3); cardPictureBoxes.Add(cardBox4); cardPictureBoxes.Add(cardBox5); cardPictureBoxes.Add(cardBox6); cardPictureBoxes.Add(cardBox7);


            playlabel.Text = "plays: " + plays.ToString();
            discardLabel.Text = "discards: " + discards.ToString();
            targetChip = calculatetargetChip();


            deck = shuffle(deck, 4);
            for (int i = 0; i < maxCards; i++)
            {
                moveTolist(i, deck, hand);
                updateBox(handListBox, hand);
                updateBox(deckListBox, deck);
                //handListBox.Items.Add(hand[i]);
            }
            for (int i = 0; i < maxCards; i++)
            {
                cards.Add(new Card());
                cards[i].setPictureBox(cardPictureBoxes[i]);
            }
            updateCardClasses();

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

        //takes a list and populate all of it into a listbox 
        //int list overload
        public void updateBox(ListBox box, List<int> list)
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
                for (int y = 1; y <= 12; y++)
                {
                    deck.Add(currentSuite + "," + y);
                    currentIndex++;
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
                //local variable to store the suite and number 
                // the first element is the  suite and the second element is the number
                string[] split = hand[i].ToString().Split(",");

                //sets the suite
                cards[i].setSuite(split[0]);

                //sets the number
                cards[i].setNumber(int.Parse(split[1]));
            }
        }




        string scoringFramework()
        {
            string a = "";
            string currentSuite;
            string[] split;
            int count = 0;

            //cards = selectedCards;




            cards.Sort((x, y) => x.getNumber().CompareTo(y.getNumber()));

            string temp = "";
            for (int i = 0; i < selectedCards.Count; i++)
            {
                temp += selectedCards[i].getSuite() + "," + selectedCards[i].getNumber().ToString() + " ";
            }
            MessageBox.Show(temp);



            //straight flush 
            for (int i = 1; i < cards.Count; i++)
            {   // check for a straight
                if (selectedCards[i].getNumber() == selectedCards[i - 1].getNumber() + 1
                    //check for flush
                    && selectedCards[0].getSuite() == selectedCards[i].getSuite())
                {
                    count++;
                }
                if (count == 4)
                {
                    return "straight flush";
                }
            }

            //four of a kind
            temp = "";
            count = 0;
            //ref 
            if (selectedCards.Count >= 4)
            {
                for (int x = 0; x < 2; x++)
                {

                    for (int y = 0; y < selectedCards.Count; y++)
                    {
                        if (selectedCards[x].getNumber() == selectedCards[y].getNumber())
                        {
                            count++;

                        }
                    }
                    
                    if (count == 4)
                    { return "four of a kind"; }
                    else { count = 0; }

                }
            }



            //full house
            int CountX=0;
            int CountY=0;
            count = 0;
            int z = 0;
            if (selectedCards.Count >= 5)
            {
                for (int x = 0; x < 2; x++)
                {
                    

                    for (int y = 0; y < selectedCards.Count; y++)
                    {
                        if (x == 0)
                        {
                            z = x;
                        }
                        if (selectedCards[z].getNumber() == selectedCards[y].getNumber())
                        {
                            count++;

                        }
                    }
                    if (x == 0)
                    {
                        CountX = count;
                        count = 0;
                        z = selectedCards.Count - 1;
                        MessageBox.Show("x " + CountX.ToString());
                    }
                    else
                    { CountY = count;
                        count = 0;
                        MessageBox.Show("y " + CountY.ToString());
                    }


                }
                if ((CountX == 3 && CountY == 2) || (CountX == 2 && CountY == 3)){
                    return "full house";
                }
            }
            //flush
            for (int i = 1; i < cards.Count; i++)
            {   // check for a straight
                if (selectedCards[0].getSuite() == selectedCards[i].getSuite())
                {
                    count++;
                }
                if (count == 4)
                {
                    return "flush";
                }
            }

            //straight
            for (int i = 1; i < cards.Count; i++)
            {   // check for a straight
                if (selectedCards[i].getNumber() == selectedCards[i - 1].getNumber() + 1)
                    //check for flush
                {
                    count++;
                }
                if (count == 4)
                {
                    return "straight";
                }
            }
            //three of a kind

            //two pair

            //pair 


            //high card
            return "highCard";


        }
        private void playButton_click(object sender, EventArgs e)
        {
            if (selectedCards.Count > 0)
            {
                playButton.Enabled = false;
                canSelect = false;
                plays--;
                playlabel.Text = "plays: " + plays.ToString();
                //discard cards that dont go towards scoring 

               //targetChip = calculatetargetChip();
               //round ends when player reaches goal points
               //when play button is clicked, everything will be run. We will need  to double check the logic of a player wining a round
                
            }
        }


        // Card clicking and selection  handling
        void cardSelection(int index)
        {
            if (canSelect)
            {
                if (cards[index].getIsSelected() == false)
                {
                    if (selectedCards.Count < maxSelection)
                    {

                        cards[index].setIsSelected(true);

                        cardPictureBoxes[index].BackColor = Color.Blue;
                        MessageBox.Show(cards[index].getCardString());
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
                    cardPictureBoxes[index].BackColor = Color.White;
                    selectedCards.Remove(cards[index]);

                }
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

        private void discardButton_Click(object sender, EventArgs e)
        {

            
            discardPile.ToList().ForEach(Console.WriteLine);
            if (discards > 0)
            {
                discards = discards - 1;
                discardLabel.Text = "discards: " + discards.ToString();



                for (int i = 0; i < selectedCards.Count; i++)
                {
                    selectedCards[i].GetPictureBox().BackColor = Color.Transparent;

                    selectedCards[i].setIsSelected(false);

                    string x = selectedCards[i].getSuite() + "," + selectedCards[i].getNumber().ToString();
                    MessageBox.Show(x);
                    int y = hand.IndexOf(x);
                    moveTolist(y, hand, discardPile);
                    //draw new cards
                    hand.Insert(y, deck[0]);
                    deck.RemoveAt(0);
                    updateBox(deckListBox, deck);
                    updateBox(handListBox, hand);
                    updateCardClasses();

                }
                selectedCards.Clear();
            }
            else
            {
                MessageBox.Show("No more discards left", "No Discards");
            }
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

                handLabel.Text = scoringFramework();
            




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
