using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Deck<T>
    {
        T[] cards = new T[5];
        int count;


        public void Add(T card)
        {
            if (count == cards.Length)
                Array.Resize(ref cards, cards.Length * 2);

            cards[count++] = card;  
        }

        public int Count()
        {
            return count;
        }

        public void Remove(T card)
        {

        }
    }
}
