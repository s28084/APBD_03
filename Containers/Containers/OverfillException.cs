namespace Containers;

public class OverfillException : Exception
{
    public OverfillException(string msg) : base(msg) { }
}