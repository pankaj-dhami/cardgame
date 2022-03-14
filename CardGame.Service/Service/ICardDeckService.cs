using CardGame.Service.Modal;
using System.Collections.Generic;

namespace CardGame.Service.Service
{
    public interface ICardDeckService
    {
        IEnumerable<Card> GetSortedCardDeck(string[] input);
    }
}