namespace Asignment_5
{
    public class Desk : Product, ILivingRoom, IOffice, IBedroom
    {
        public Desk(string name, float price) : base(name, price) {}
        
        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "LivingRoom, Office, Bedroom";
        }

        public override string Description()
        {
            return "Wow that was a big desk";
        }

        public string LivingRoom()
        {
            return "The desk is a desk in the livingroom";
        }
        public string Office()
        {
            return "The desk is a perfect match in the office, just need a desk lamp";
        }
        
        public string Bedroom()
        {
            return "Maybe a wrong place to put the desk";
        }
    }
}