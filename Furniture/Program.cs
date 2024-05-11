abstract class Chair { }
abstract class Sofa { }
abstract class CoffeeTable { }

abstract class Factory
{
    public abstract Chair CreateChair();
    public abstract Sofa CreateSofa();
    public abstract CoffeeTable CreateCoffeeTable();
}


class VictorianChair : Chair
{
    public VictorianChair()
        => Console.WriteLine(GetType().Name);
}

class VictorianSofa : Sofa
{
    public VictorianSofa()
        => Console.WriteLine(GetType().Name);
}

class VictorianCoffeeTable : CoffeeTable
{
    public VictorianCoffeeTable()
        => Console.WriteLine(GetType().Name);
}

class VictorianFactory : Factory
{
    public override Chair CreateChair()
        => new VictorianChair();

    public override Sofa CreateSofa()
        => new VictorianSofa();

    public override CoffeeTable CreateCoffeeTable()
        => new VictorianCoffeeTable();
}



class ModernChair : Chair
{
    public ModernChair()
        => Console.WriteLine(GetType().Name);
}
class ModernSofa : Sofa
{
    public ModernSofa()
        => Console.WriteLine(GetType().Name);
}

class ModernCoffeeTable : CoffeeTable
{
    public ModernCoffeeTable()
        => Console.WriteLine(GetType().Name);
}

class ModernFactory : Factory
{
    public override Chair CreateChair()
        => new ModernChair();

    public override Sofa CreateSofa()
        => new ModernSofa();

    public override CoffeeTable CreateCoffeeTable()
        => new ModernCoffeeTable();
}



class ArtDecoChair : Chair
{
    public ArtDecoChair()
        => Console.WriteLine(GetType().Name);
}

class ArtDecoSofa : Sofa
{
    public ArtDecoSofa()
        => Console.WriteLine(GetType().Name);
}

class ArtDecoCoffeeTable : CoffeeTable
{
    public ArtDecoCoffeeTable()
        => Console.WriteLine(GetType().Name);
}
class ArtDecoFactory : Factory
{
    public override Chair CreateChair()
        => new ArtDecoChair();

    public override Sofa CreateSofa()
        => new ArtDecoSofa();

    public override CoffeeTable CreateCoffeeTable()
        => new ArtDecoCoffeeTable();
}


class Program
{
    static void Main()
    {
        Factory factory = null;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(@"
                        1: Victorian
                        2: Modern
                        3: ArtDeco
                        Any: Exit");

            Console.Write("\n\tEnter choice: ");

            factory = Console.ReadLine() switch
            {
                "1" => new VictorianFactory(),
                "2" => new ModernFactory(),
                "3" => new ArtDecoFactory(),
                _ => null
            };

            if (factory == null)
                break;
            Console.WriteLine();
            factory.CreateChair();
            factory.CreateSofa();
            factory.CreateCoffeeTable();

            Console.ReadKey();
        }
    }
}
