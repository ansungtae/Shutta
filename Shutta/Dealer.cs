﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Dealer
    {
        public Card[] Cards;

        List<int> kwangNumbers = new List<int> { 1, 3, 8 };

        public void Shuffle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Card card = new Card();
                    card.Number = i + 1;
                    card.IsKwang = false;

                    if (j == 0)
                        if (kwangNumbers.Contains(card.Number))
                            card.IsKwang = true;
                }
            }



        }

        public Card GetCard()
        {
            return null;
        }
    }
}