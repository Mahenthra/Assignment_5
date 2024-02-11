namespace Asignment_5
{
    public class Sofa : Product, ILivingRoom, IAssemblable
    {
        public Sofa(string name, float price) : base(name, price) { }

        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "Living Room";
        }

        public override string Description()
        {
            return "This sofa is amazing";
        }

        public string LivingRoom()
        {
            return "This sofa would look stunning in your living room";
        }

        public string Assemble()
        {
            return "Assemble the sofa according to the provided instructions.";
        }
    }
}