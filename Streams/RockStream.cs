using FactoryMethodPattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Streams;
internal class RockStream : IStream
{
    public string Name => "RockStream";
    public string Category => "Rock";

    public override string ToString()
    {
        return $"{Name} of category {Category}";
    }
}

