namespace Asignment_5
{

    public class CookingPot : Product, IKitchen
    {
        public CookingPot(string name, float price) : base(name, price) { }

        public override float Price()
        {
            return price;
        }

        public override string GetShelf()
        {
            return "Kitchen";
        }

        public override string Description()
        {
            return "This cookingpot is amazing";
        }

        public string Kitchen()
        {
            return "This cooking pot will make delicious food";
        }
    }
}