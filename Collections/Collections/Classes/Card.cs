using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    class Card
    {


        public Suite CardSuite { get; set; }
        public CardValue Value { get; set; }


        public Card(Suite suit, CardValue value)
        {
            CardSuite = suit;
            Value = value;
        }

    }


    enum Suite
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    enum CardValue
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }
}
