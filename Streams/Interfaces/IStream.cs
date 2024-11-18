using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Streams.Interfaces;
public interface IStream
{
    public string Name { get; }
    public string Category { get; }
}
