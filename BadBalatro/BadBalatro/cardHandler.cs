using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadBalatro
{
    internal class cardHandler //: BadBalatro
    {

        List<string> deck; //new List<string>();
        List<string> hand;//= new List<string>();
        BadBalatro form = new BadBalatro();

        public cardHandler()
        {
            deck = new List<string>();
            hand = new List<string>();
        }

      
        public void intializeDeck()
        {
            string currentSuite = "";
            int currentIndex =0;
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
                    form.setDeckBox(deck[currentIndex]);
                    currentIndex++;

                   
                    
                    
                }
            }
            
        }

        public List<string> shuffle(List<string> list) 
        { 
            

            return list;
        }
    }
}
