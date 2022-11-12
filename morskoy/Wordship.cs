using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    class Wordship
    {
        public int Deck { get; private set; }
        public Wordship(int deck)
        {
            Deck = deck;
        }
        public void Crash()
        {
            Deck -= 1;
        }
    }
}
