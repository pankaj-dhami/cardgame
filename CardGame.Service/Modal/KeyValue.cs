namespace CardGame.Service.Modal
{
    public class KeyValue
    {
        public KeyValue(int key, string value)
        {
            Key = key;
            Value = value;
        }
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
