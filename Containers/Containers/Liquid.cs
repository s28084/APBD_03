namespace Containers;

public class Liquid : Container, IHazardNotifier
{
    public Liquid(double cargoWeight, int height, double containerWeight, int depth, double capacity) : base(cargoWeight, height, containerWeight, depth, capacity)
    {
        Type = "L";
    }
}