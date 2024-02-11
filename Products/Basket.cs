namespace Asignment_5
{
    public class Basket : Product, IOffice
    {
        public Basket(string name, float price) : base(name, price) {}
        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "Office";
        }

        public override string Description()
        {
            return "This basket is good to have";
        }

        public string Office()
        {
            return "Basket is good to have in the office";
        }
    }
}