using FornitureAbstractFactory.Factory;

namespace FornitureAbstractFactory.Bootstrap;

internal enum FurnitureStyles
{
    Modern,
    ArDeco,
    Victorian
}

internal static class MainConfigurator
{
    internal static FurnitureFactory GetFurnitureFactory(FurnitureStyles style)
    {
        return style switch
        {
            FurnitureStyles.Modern => new ModernFurnitureFactory(),
            FurnitureStyles.ArDeco => new ArDecoFurnitureFactory(),
            FurnitureStyles.Victorian => new VictorianFurnitureFactory(),
            _ => throw new NotImplementedException(),
        };
    }
}
