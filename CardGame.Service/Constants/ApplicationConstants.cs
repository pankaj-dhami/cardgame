using CardGame.Service.Modal;
using System.Collections.Generic;

namespace CardGame.Service.Constants
{
    public class ApplicationConstants
    {
        public static readonly List<KeyValue> CardValues = new List<KeyValue>() {
                    new KeyValue(5, "2"),
                    new KeyValue(6, "3"),
                    new KeyValue(7, "4"),
                    new KeyValue(8, "5"),
                    new KeyValue(9, "6"),
                    new KeyValue(10, "7"),
                    new KeyValue(11, "8"),
                    new KeyValue(12, "9"),
                    new KeyValue(13, "10"),
                    new KeyValue(14, "J"),
                    new KeyValue(15, "Q"),
                    new KeyValue(16, "K"),
                    new KeyValue(17, "A")
        };
        public static readonly List<KeyValue> CardSuits = new List<KeyValue>()
        {           new KeyValue(1, "D"),
                    new KeyValue(2, "S"),
                    new KeyValue(3, "C"),
                    new KeyValue(4, "H"),

        };
        public static readonly List<KeyValue> SpecialCardValues = new List<KeyValue>()
        {           new KeyValue(0, "4"),
                    new KeyValue(1, "2"),
                    new KeyValue(2, "S"),
                    new KeyValue(3, "P"),
                    new KeyValue(4, "R")

        };
        public static readonly List<KeyValue> SpecialCardSuit = new List<KeyValue>()
        {           new KeyValue(0, "T"),
                   

        };

    }
}
