namespace Asignment_5
{
    public class Bookshelf : Product, ILivingRoom, IOffice
    {
        public Bookshelf(string name, float price) : base(name, price) {}
        
        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "LivingRoom, Office";
        }

        public override string Description()
        {
            return "It is a good place to put the books";
        }

        public string LivingRoom()
        {
            return "The Bookshelf is looking good in the livingroom";
        }
        public string Office()
        {
            return "The Bookshelf is a perfect match to the office where i can hide my secret books";
        }
    }
}