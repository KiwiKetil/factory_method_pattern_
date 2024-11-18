using FactoryMethodPattern.Streams.Interfaces;

namespace FactoryMethodPattern.Streamer;
public abstract class StreamingService
{
    public abstract IStream GetStream();

    public void GetInfo()
    {
        var stream = GetStream();
        Console.WriteLine($"You retrieved: {stream} ");
    }
}
