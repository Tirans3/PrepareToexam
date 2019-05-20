namespace Indexers
{
    class Index
    {
        public int? X { get; set; }
        public string Y { get; set; }

        public int? this[string i]
        {
            get
            {
                return i == Y ? X : null;
            }

            set
            {
                X = i == Y ? value : null;
            }
        }
    }
}
