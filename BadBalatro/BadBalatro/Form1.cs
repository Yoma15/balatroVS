namespace BadBalatro
{
    public partial class BadBalatro : Form
    {

        List<string> deck = new List<string>();
        List<string> hand = new List<string>();
        List<Card> cards = new List<Card>();
        int maxCards = 8;
        //still need to integrate a max selection for the list box
        


        public void updateBox(ListBox box,List<string> list)
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

        public void moveToHand(int index)
        {
            hand.Add(deck[index]);
            deck.RemoveAt(index);


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
                    deck.Add(currentSuite + y);
                    currentIndex++;




                }
            }

        }

        public List<string> shuffle(List<string> list,int shuffleValue)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BadBalatro_Load(object sender, EventArgs e)
        {
            intializeDeck();
            deck = shuffle(deck,4);
            for (int i = 0; i < maxCards; i++)
            {
                moveToHand(i);
                updateBox(handListBox, hand);
                updateBox(deckListBox, deck);
                //handListBox.Items.Add(hand[i]);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
