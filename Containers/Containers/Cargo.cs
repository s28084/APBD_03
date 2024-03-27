namespace Containers;

public class Cargo
{
    public string Name { set; get; }
    public double Weight { set; get; }
    public bool Safety { set; get; }
    
    public Cargo(string name, double weight, bool safety)
    {
        Name = name;
        Weight = weight;
        Safety = safety;
    }
    
}