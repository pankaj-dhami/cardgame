namespace CardGame.Service.Modal
{
    public class Card
    {
        public Card(int suitIndex, string suit, int valueIndex, string value)
        {
            SuitIndex = suitIndex;
            ValueIndex = valueIndex;
            Suit = suit;
            Value = value;
        }
        public int SuitIndex { get; set; }
        public int ValueIndex { get; set; }

        public string Suit { get; set; }
        public string Value { get; set; }
    }
}
