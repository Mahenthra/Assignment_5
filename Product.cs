namespace Asignment_5;

public abstract class Product
{
    protected string name;
    protected float price;

    public Product(string name, float price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract float Price();
    public abstract string GetShelf();
    public abstract string Description();
}

interface IAssemblable {
    string Assemble();
}

interface ILivingRoom {
    string LivingRoom();
}

interface IKitchen {
    string Kitchen();
}

interface IOffice {
    string Office();
}

interface IBedroom {
    string Bedroom();
}

    