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

        //if the card is currenlty selected to be apart of play
        private bool isSelected;
        //how many chips the player will get when scored
        private int chipAmount;

        


        public void card(int Value,string Suite)
        {
            number = Value;
            suite = Suite;
        }

       public void setNumber(int Number)
        {
            number = Number;
            if(number == 10 || number == 11 || number == 12)
            {
                chipAmount = 13;
            }
            chipAmount = number;
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

        public int getNumber() {return number; }

        public int getChipAmount() { return chipAmount;}

        public string getSuite() { return suite;}

        public bool getIsSelected() { return isSelected;}




    }
}
