namespace Containers;

public interface IHazardNotifier
{
    public void SendHazardNotification(string serialNumber)
    {
        Console.WriteLine($"Dangerous situation in container {serialNumber}");
    }
}