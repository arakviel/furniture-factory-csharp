using FornitureAbstractFactory.Products.Chair;
using FornitureAbstractFactory.Products.Sofa;
using FornitureAbstractFactory.Products.Table;

namespace FornitureAbstractFactory.Factory;

internal class ArDecoFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair()
    {
        return new ArDecoChair();
    }

    public Sofa CreateSofa()
    {
        return new ArDecoSofa();
    }

    public Table CreateTable()
    {
        return new ArDecoTable();
    }
}
