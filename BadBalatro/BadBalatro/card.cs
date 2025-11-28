using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BadBalatro
{
    internal class Card
    {
        //the number on the card
        private int number;
        //the suite of the card
        private string suite;
        bool isScoring;

        private PictureBox cardPictureBox;
        //if the card is currenlty selected to be apart of play
        private bool isSelected;
        //how many chips the player will get when scored
        private int chipAmount;

        private bool willScore = false;

        

        

        public Card() { }

        public Card(string Suite, int Value)
        {
            number = Value;
            suite = Suite;
        }
        //MR
        public int GetNumber()
        {
            return number;
        }

        public void setNumber(int Number)
        {
            this.number = Number;

            // MR
            if (number == 10 || number == 11 || number == 12 || number == 13)
            {
                chipAmount = 13; 
            }
            else if (number == 1)
            {
                chipAmount = 11; 
            }
            else
            {
                chipAmount = number; 
            }
        }
        public void setSuite(string Suite)
        {
            suite = Suite;
        }
        public void setIsSelected(bool selected)
        {
                isSelected = selected;
           // MessageBox.Show(isSelected.ToString());

            
        }
        public void setIsScored(bool scoring)
        {
            isScoring = scoring;
            // MessageBox.Show(isSelected.ToString());


        }
        public void setPictureBox(PictureBox box)
        {
            cardPictureBox = box;
            // MessageBox.Show(isSelected.ToString());


        }




        public PictureBox GetPictureBox() { return cardPictureBox; }

        public int getNumber() {return number; }

        public int getChips() { return chipAmount; }

        public string getSuite() { return suite;}

        public bool getIsSelected() { return isSelected;}

        public bool getIsScoring() { return isScoring; }


        public string getCardString()
        {

            return suite + "," +  number.ToString();
        }




    }
}
