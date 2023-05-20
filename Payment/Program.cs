namespace Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashiar cashiar = new Cashiar(new Cash(999.34m));
            Cashiar cashiar1 = new Cashiar(new Visa(999.34m));
            Cashiar cashiar2 = new Cashiar(new MasterCard(999.34m));
            cashiar.Checkout();
            cashiar1.Checkout();
            cashiar1.Checkout();
        }
    }

    class Cashiar
    {
        public IPayment payment { get; set; }
        public Cashiar(IPayment payment)
        {
            this.payment = payment;
        }
        public void Checkout()
        {
            payment.Pay();
        }

    }

    interface IPayment
    {
        void Pay();
    }

    class Cash : IPayment
    {
        public decimal amount { get; set; }

        public Cash(decimal amount)
        {
            this.amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Pay by Cash, amount = {amount}");
        }
    }

    class Visa : IPayment
    {
        public decimal amount { get; set; }

        public Visa(decimal amount)
        {
            this.amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Pay by Visa, amount = {amount}");
        }
    }

    class MasterCard : IPayment
    {
        public decimal amount { get; set; }

        public MasterCard(decimal amount)
        {
            this.amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Pay by MasterCard, amount = {amount}");
        }
    }
}