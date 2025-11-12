namespace BadBalatro
{
    public partial class BadBalatro : Form
    {

        List<string> deck = new List<string>();
        List<string> hand = new List<string>();

        //holds all the card class instances in one list
        //to acess a element from a card For example the suite use cards[i].getSuite() with i being the index;
        List<Card> cards = new List<Card>();

        //the max amount of cards that can be in a hand at a time 
        int maxCards = 8;
        //the max amount of cards that can be selected
        int maxSelection = 5;
        //still need to integrate a max selection for the list box




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

        //returns the amount of cards that are currently selected 
        int getSelected()
        {
            int x = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                //If the card is selected add it to a counter
                if (cards[i].getIsSelected())
                {
                    x++;
                }


            }
            return x;

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
                string[] split = handListBox.Items[i].ToString().Split(",");

                //sets the suite
                cards[i].setSuite(split[0]);

                //sets the number
                cards[i].setNumber(int.Parse(split[1]));
            }
        }


        //Function called before as it loads for the user 
        private void BadBalatro_Load(object sender, EventArgs e)
        {
            intializeDeck();

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
            }
            updateCardClasses();




        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }









        // Card clicking and selection  handling
        // I NEED TO CLEAN THIS UP -BEN 


        private void cardBox0_Click(object sender, EventArgs e)
        {
            //the box number 
            int x = 0;


            //clean this up into one function

            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox0.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                //MessageBox.Show("test");
                cards[x].setIsSelected(false);
                cardBox0.BackColor = Color.White;
            }
        }


        private void cardBox1_Click(object sender, EventArgs e)
        {
            int x = 1;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox1.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox1.BackColor = Color.White;
            }
        }

        /*for (int i = 0; i < cards.Count; i++)
           {

               MessageBox.Show("suite " + cards[i].getSuite().ToString() + " value " + cards[i].getValue().ToString());

           } */

        private void cardBox2_Click(object sender, EventArgs e)
        {
            int x = 2;


            //clean this up into one function

            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox2.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox2.BackColor = Color.White;
            }
        }


        private void cardBox3_Click(object sender, EventArgs e)
        {
            int x = 3;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox3.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox3.BackColor = Color.White;
            }
        }

        private void cardBox4_Click(object sender, EventArgs e)
        {
            int x = 4;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox4.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox4.BackColor = Color.White;
            }
        }

        private void cardBox5_Click(object sender, EventArgs e)
        {
            int x = 5;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox5.BackColor = Color.White;
            }
        }

        private void cardBox6_Click(object sender, EventArgs e)
        {
            int x = 6;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox6.BackColor = Color.White;
            }
        }

        private void cardBox7_Click(object sender, EventArgs e)
        {
            int x = 7;
            //toggle selection 
            //if its not selected
            if (cards[x].getIsSelected() == false)
            {
                if (getSelected() < maxSelection)
                {

                    cards[x].setIsSelected(true);

                    cardBox7.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x].getIsSelected() == true)
            {
                cards[x].setIsSelected(false);
                cardBox7.BackColor = Color.White;
            }
        }

        

        

        
    }
}
