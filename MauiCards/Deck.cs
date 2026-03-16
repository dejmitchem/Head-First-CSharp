using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CardClass;

namespace MauiCards
{
    class Deck : ObservableCollection<Card> 
    {
        public Deck() 
        {
            Reset();
        }

        public void Reset() 
        {
            Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Add(new Card((Suits)i, (Values)j));
                }
            }
        }

        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0) 
            {
                int index = Random.Shared.Next(copy.Count);
                Add(copy[index]);
                copy.RemoveAt(index);
            }

        }

        public void Sort()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            CardComparerByValue comparer = new CardComparerByValue();
            copy.Sort(comparer);
            for(int i = 0; i < 52; i++)
            {
                Add((Card)copy[i]);
                
            }
        }
    }   
}
