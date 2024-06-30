using FornitureAbstractFactory.Products.Chair;
using FornitureAbstractFactory.Products.Sofa;
using FornitureAbstractFactory.Products.Table;

namespace FornitureAbstractFactory.Factory;

internal class VictorianFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair()
    {
        return new VictorianChair();
    }

    public Sofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public Table CreateTable()
    {
        return new VictorianTable();
    }
}
