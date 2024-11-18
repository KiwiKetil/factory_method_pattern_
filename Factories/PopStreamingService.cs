using FactoryMethodPattern.Streamer;
using FactoryMethodPattern.Streams;
using FactoryMethodPattern.Streams.Interfaces;

namespace FactoryMethodPattern.Factories;
public class PopStreamingService : StreamingService
{
    public override IStream GetStream()
    {
        return new PopStream();
    }
}
