namespace Asignment_5
{
    public class ChildsBed : Product, IBedroom
    {
        public ChildsBed(string name, float price) : base(name, price) {}
        
        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "Bedroom";
        }

        public override string Description()
        {
            return "The baby sleep good in the bed";
        }

        public string Bedroom()
        {
            return "Wonderful bed for the child's room";
        }
    }
}