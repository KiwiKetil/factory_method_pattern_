using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Factories.Types;
using FactoryMethodPattern.Player;
using FactoryMethodPattern.Streamer;

StreamingService service = StreamingServiceFactory.GetStreamService(StreamingTypes.Ambient);
service.PlayStream();
service.GetInfo();
