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
        private int value;
        private string suite;
        private bool isSelected;

        


        public void card(int Value,string Suite)
        {
            value = Value;
            suite = Suite;
        }

       public void setValue(int Value)
        {
            value = Value;
        }
        public void setSuite(string Suite)
        {
            suite = Suite;
        }

        public int getValue() {return value;}

        public string getSuite() { return suite;}

        public bool getIsSelected() { return isSelected;}




    }
}
