namespace zad28
{
    public abstract class Furniture
    {
        private string typeProduct;
        private double productionPrice;

        protected Furniture(string typeProduct, double productionPrice)
        {
            TypeProduct = typeProduct;
            ProductionPrice = productionPrice;
        }

        public string TypeProduct
        {
            get { return typeProduct; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Type cannot be empty.");
                else typeProduct = value;
            }
        }
        public double ProductionPrice
        {
            get { return productionPrice; }
            set
            {
                if (value <= 0)
                    throw new Exception("Price must be positive");
                else productionPrice = value;
            }
        }

        public abstract double PriceClient();
    }
}
