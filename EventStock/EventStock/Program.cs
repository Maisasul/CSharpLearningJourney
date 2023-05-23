namespace EventStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock s = new Stock("Vodafone");
            s.Price = 150m;
            s.changePrice(0.7m);

            //event subscribtion
            s.OnPriceChange += S_OnPriceChange;
            s.changePrice(0.4m);
            s.changePrice(-0.6m);
            s.changePrice(0.2m);
            s.changePrice(0.6m);
            s.changePrice(-0.1m);
        }

        public static void S_OnPriceChange(Stock stock, decimal previousPrice)
        {
            string res = "";
            if(stock.Price > previousPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                res = "Up";
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                res = "Down";
            }
            Console.WriteLine($"{stock.Name} :: {stock.Price} --> {res}");
        }
    }

    class Stock
    {
        private string name;
        private decimal price;
        public string Name => this.name;
        public Stock(string name)
        {
            this.name = name;
        }

        public delegate void priceChangeObserver(Stock stock, decimal previousPrice);

        //    eventType   delegateName    eventName
        public event priceChangeObserver OnPriceChange;
        public decimal Price 
        {
            get {
                return this.price; 
            }
            set {
                this.price = value;
            }
        }
        public void changePrice(decimal Percentage)
        {
            decimal previousPrice = this.price;
            this.price += this.price * Percentage;
            
            //event condition
            if(OnPriceChange != null)
            {
                OnPriceChange(this, previousPrice);
            }
        }
    }
}