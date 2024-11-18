using FactoryMethodPattern.Streamer;

namespace FactoryMethodPattern.Player;
internal static class Player
{
    internal static void PlayStream(this StreamingService service)
    {
        var stream = service.GetStream();
        if (stream is null) 
        {
            Console.WriteLine("no stream to play");
            return;
        }
        Console.WriteLine($"Streaming {stream} via {service.GetType().Name}");
    }
}
