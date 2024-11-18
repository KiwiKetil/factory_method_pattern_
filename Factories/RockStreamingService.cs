using FactoryMethodPattern.Streamer;
using FactoryMethodPattern.Streams;
using FactoryMethodPattern.Streams.Interfaces;

namespace FactoryMethodPattern.Factories;
public class RockStreamingService : StreamingService
{
    public override IStream GetStream()
    {
        return new RockStream();
    }
}
