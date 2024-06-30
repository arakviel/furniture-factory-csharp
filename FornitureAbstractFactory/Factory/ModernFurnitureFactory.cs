using FornitureAbstractFactory.Products.Chair;
using FornitureAbstractFactory.Products.Sofa;
using FornitureAbstractFactory.Products.Table;

namespace FornitureAbstractFactory.Factory;

internal class ModernFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public Sofa CreateSofa()
    {
        return new ModernSofa();
    }

    public Table CreateTable()
    {
        return new ModernTable();
    }
}
