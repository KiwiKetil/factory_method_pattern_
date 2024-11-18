using FactoryMethodPattern.Factories.Types;
using FactoryMethodPattern.Streamer;

namespace FactoryMethodPattern.Factories;
internal class StreamingServiceFactory
{    public static StreamingService GetStreamService(StreamingTypes stream)
    {
        return stream switch
        {
            StreamingTypes.Ambient => new AmbientStreamingService(),
            StreamingTypes.Pop => new PopStreamingService(),
            StreamingTypes.Rock => new RockStreamingService(),
            _ => throw new ArgumentException("Invalid category")
        };
    }
}
