namespace Asignment_5
{
    public class DeskLamp : Product, ILivingRoom, IOffice, IBedroom
    {
        public DeskLamp(string name, float price) : base(name, price) {}
        
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
            return "What, for a brightness to the desk";
        }

        public string LivingRoom()
        {
            return "The desklamp is a desklamp in the livingroom";
        }
        public string Office()
        {
            return "The desk is a perfect match in the office, and now i got the desklamp, FINALLY";
        }
        
        public string Bedroom()
        {
            return "Maybe a wrong place to put the desk, and even the desklamp";
        }
    }
}