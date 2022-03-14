using CardGame.Service.Constants;
using CardGame.Service.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Service.Service
{
    public class CardDeckService : ICardDeckService
    {
        public IEnumerable<Card> GetSortedCardDeck(string[] input)
        {
            //input = new string[] {  };
            List<Card> cardList = new List<Card>();
            List<Card> specialList = new List<Card>();

            foreach (var item in input)
            {

                if (item.Length > 1)
                {
                    switch (GetSuit(item))
                    {
                        case "T":
                            var specialcard = new Card(0, GetSuit(item), GetSpecialCardIndex(GetValue(item)),
                                GetValue(item));
                            cardList.Add(specialcard);
                            break;
                        case "D":
                        case "S":
                        case "H":
                        case "C":
                            var suitIndex = GetSuitIndex(GetSuit(item));
                            var valueIndex = GetCardValueIndex(GetValue(item));
                            if(suitIndex > -1 && valueIndex> -1)
                            {
                                var card = new Card(suitIndex, GetSuit(item),
                               valueIndex, GetValue(item));
                                cardList.Add(card);
                            }
                            break;

                    }
                }
            }
            var res = cardList.OrderBy(a => a.SuitIndex).ThenBy(a => a.ValueIndex);
            return res;

        }

        private string GetSuit(string input)
        {
            return input[input.Length - 1].ToString().ToUpper();
        }
        private string GetValue(string input)
        {
           return input.Remove(input.Length - 1).ToUpper();
        }

        private int GetSuitIndex(string input)
        {
            var card = ApplicationConstants.CardSuits.FirstOrDefault(a => a.Value.ToLower() == input.ToLower());
            if (card != null)
            {
                return card.Key;
            }
            return -1;
        }
        private int GetCardValueIndex(string input)
        {
            var card = ApplicationConstants.CardValues.FirstOrDefault(a => a.Value.ToLower() == input.ToLower());
            if (card != null)
            {
                return card.Key;
            }
            return -1;
        }
        private int GetSpecialCardIndex(string input)
        {
            var card = ApplicationConstants.SpecialCardValues
                .FirstOrDefault(a => a.Value.ToLower() == input.ToLower());
            if (card != null)
            {
                return card.Key;
            }
            return -1;
        }

    }
}
