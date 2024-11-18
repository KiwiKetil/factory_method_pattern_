using FactoryMethodPattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Streams;
internal class PopStream : IStream
{
    public string Name => "PopStream";
    public string Category => "Pop";

    public override string ToString()
    {
        return $"{Name} of category {Category}";
    }
}
