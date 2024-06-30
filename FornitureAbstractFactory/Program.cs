using FornitureAbstractFactory.Bootstrap;
using FornitureAbstractFactory.Factory;
using FornitureAbstractFactory.Products.Chair;
using FornitureAbstractFactory.Products.Sofa;
using FornitureAbstractFactory.Products.Table;

namespace FornitureAbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        string? inputStyle = Console.ReadLine();

        int styleIndex = Convert.ToInt32(inputStyle);
        if (Enum.IsDefined(typeof(FurnitureStyles), styleIndex))
        {
            var style = (FurnitureStyles)styleIndex;

            FurnitureFactory furnitureFactory = MainConfigurator.GetFurnitureFactory(style);

            Chair chair = furnitureFactory.CreateChair();
            chair.sitOn();
            Table table = furnitureFactory.CreateTable();
            table.eatOn();
            Sofa sofa = furnitureFactory.CreateSofa();
            sofa.sleepOn();
        }

        Console.ReadLine();
    }
}
