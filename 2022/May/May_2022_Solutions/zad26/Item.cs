namespace zad26
{
    class Item : IComparable<Item>
    {
        public int CompareTo(Item other)
        {
            if (other == null) return 1;
            int result = this.description.CompareTo(other.description);
            if (result != 0) return result;
            return this.price.CompareTo(other.price);
        }
        public override string ToString()
        {
            return $"{description} ({price:F2})";
        }

        private readonly string description;
        private readonly double price;

        public Item(double price, string description)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Цената трябва да е положително число.");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Описанието не трябва да е празно.");
            }

            this.price = price;
            this.description = description;
        }

        public double Price => price;
        public string Description => description;
    }
}
