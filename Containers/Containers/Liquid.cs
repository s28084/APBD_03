namespace Containers;

public class Liquid : Container, IHazardNotifier
{
    public Liquid(double cargoWeight, int height, double containerWeight, int depth, double capacity)
        : base(cargoWeight, height, containerWeight, depth, capacity)
    {
        Type = "L";
    }

    public void Load(Cargo cargo)
    {
        if ((IsCapacityOk(cargo)) && (cargo.Safety) && (cargo.Weight <= Capacity*0.9))
        {
            CargoWeight += cargo.Weight;
            Console.WriteLine($"Container {GetSerialCode()} - loaded");
        }
        if ((IsCapacityOk(cargo)) && (!cargo.Safety) && (cargo.Weight <= Capacity*0.5))
        {
            CargoWeight += cargo.Weight;
            Console.WriteLine($"Container {GetSerialCode()} - loaded with dangerous cargo");
        }

        if (((cargo.Safety) && (cargo.Weight <= Capacity * 0.9)) ||
            ((!cargo.Safety) && (cargo.Weight <= Capacity * 0.5)))
        {
            Console.WriteLine($"You attempt to perform a dangerous action on container {GetSerialCode()}");
            Console.WriteLine("Your actions on have been withdrawn");
        }
        
    }
    
}