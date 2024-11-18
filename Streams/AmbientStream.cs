using FactoryMethodPattern.Streams.Interfaces;

namespace FactoryMethodPattern.Streams;
internal class AmbientStream : IStream
{
    public string Name => "AmbientStream";
    public string Category => "Ambient";

    public override string ToString()
    {
        return $"{Name} of category {Category}";
    }
}
