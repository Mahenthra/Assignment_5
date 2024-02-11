namespace Asignment_5
{
    public class Carpet : Product, ILivingRoom, IKitchen, IOffice, IBedroom
    {
        public Carpet(string name, float price) : base(name, price) {}
        
        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "LivingRoom, Kitchen, Office, Bedroom";
        }

        public override string Description()
        {
            return "The carpet is good for the foot";
        }

        public string LivingRoom()
        {
            return "Carpet is best in the living room";
        }

        public string Kitchen()
        {
            return "Carpet is best in the kitchen";
        }

        public string Office()
        {
            return "Carpet is best in the office";
        }

        public string Bedroom()
        {
            return "Carpet is best in the bedroom";
        }
    }
}