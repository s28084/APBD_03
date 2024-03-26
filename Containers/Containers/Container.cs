namespace Containers;

public class Container
{
    public double CargoWeight { set; get; }
    public int Height { set; get; }
    public double ContainerWeight { set; get; }
    public int Depth { set; get; }
    public double Capacity { set; get; }
    public string Type { set; get; }
    protected static int SerialNumber = 0;

    public Container(double cargoWeight, int height, double containerWeight, int depth, double capacity, string type = "")
    {
        CargoWeight = cargoWeight;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        Capacity = capacity;
        Type = type;
        SerialNumber += 1;
    }

    public string GetSerialCode()
    {
        string code = $"KON-{Type}-{SerialNumber}";
        return code;
    }

    public static int GetSerialNumber()
    {
        return SerialNumber;
    }

    public void Unload()
    {
        CargoWeight = 0;
        Console.WriteLine($"Conatiner: {GetSerialCode()} - unloaded");
    }
    
    public void Load(double cargo)
    {
        if (cargo <= Capacity)
        {
            CargoWeight += cargo;
        }
        else
        {
            throw new OverfillException($"Your cargo is too heavy for container {GetSerialCode()} - loading failed");
        }

        Console.WriteLine($"Conatiner: {GetSerialCode()} - loaded");
    }
    
}