using FornitureAbstractFactory.Products.Chair;
using FornitureAbstractFactory.Products.Sofa;
using FornitureAbstractFactory.Products.Table;

namespace FornitureAbstractFactory.Factory;

internal interface FurnitureFactory
{
    Chair CreateChair();
    Sofa CreateSofa();
    Table CreateTable();
}
