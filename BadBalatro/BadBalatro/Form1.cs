namespace BadBalatro
{
    public partial class BadBalatro : Form
    {

        List<string> deck = new List<string>();
        List<string> hand = new List<string>();
        List<Card> cards = new List<Card>();

        int maxCards = 8;
        //still need to integrate a max selection for the list box

        


        public void updateBox(ListBox box, List<string> list)
        {
            box.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                box.Items.Add(list[i]);
            }
        }
        public void updateBox(ListBox box, List<int> list)
        {
            box.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                box.Items.Add(list[i]);
            }
        }

        public void moveTolist(int index, List<string> originList, List<string> destinationList)
        {
            destinationList.Add(originList[index]);
            originList.RemoveAt(index);


        }

        public void setCard()
        {

        }

        public void intializeDeck()
        {
            string currentSuite = "";
            int currentIndex = 0;
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
            for(int i = 0; i < cards.Count; i++)
            {
                //If the card is selected add it to a counter
                if (cards[i].getIsSelected())
                {
                    x++;
                }
                

            }
            return x;

        }


        public List<string> shuffle(List<string> list, int shuffleValue)
        {
            Random random = new Random();

            int randomInt;
            string tempValue;

            for (int x = 0; x < shuffleValue; x++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    randomInt = random.Next(0, list.Count);
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

        public void setDeckBox(string input)
        {
            deckListBox.Items.Add(input);
        }

        public void updateCardClasses()
        {

            for (int i = 0; i < maxCards; i++)
            {
                string[] split = handListBox.Items[i].ToString().Split(",");
                cards[i].setSuite(split[0]);
                cards[i].setValue(int.Parse(split[1]));
            }
        }

        

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

       

        private void cardBox1_Click(object sender, EventArgs e)
        {



            for (int i = 0; i < cards.Count; i++)
            {

                MessageBox.Show("suite " + cards[i].getSuite().ToString() + " value " + cards[i].getValue().ToString());

            }


        }

        private void cardBox2_Click(object sender, EventArgs e)
        {
            int x = 2;


            //clean this up into one function

            //toggle selection 
            //if its not selected
            if (cards[x-1].getIsSelected() == false)
            {
                if (getSelected() <= 5)
                {

                    cards[x-1].setIsSelected(true);

                    cardBox2.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true) 
            {
                //MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox2.BackColor = Color.White;
            }
        }

           
        private void cardBox3_Click(object sender, EventArgs e)
        {
            int x = 3;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() <= 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox3.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox3.BackColor = Color.White;
            }
        }

        private void cardBox4_Click(object sender, EventArgs e)
        {
            int x = 4;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() < 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox4.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox4.BackColor = Color.White;
            }
        }

        private void cardBox5_Click(object sender, EventArgs e)
        {
            int x = 5;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() < 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox5.BackColor = Color.White;
            }
        }

        private void cardBox6_Click(object sender, EventArgs e)
        {
            int x = 6;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() < 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox6.BackColor = Color.White;
            }
        }

        private void cardBox7_Click(object sender, EventArgs e)
        {
            int x = 7;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() < 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox7.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox7.BackColor = Color.White;
            }
        }

        private void cardBox8_Click(object sender, EventArgs e)
        {
            int x = 8;
            //toggle selection 
            //if its not selected
            if (cards[x - 1].getIsSelected() == false)
            {
                if (getSelected() < 5)
                {

                    cards[x - 1].setIsSelected(true);

                    cardBox8.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Only 5 cards can be selected at a time");
                }
            }
            //if it is selected 
            else if (cards[x - 1].getIsSelected() == true)
            {
                MessageBox.Show("test");
                cards[x - 1].setIsSelected(false);
                cardBox8.BackColor = Color.White;
            }
        }
    }
}
