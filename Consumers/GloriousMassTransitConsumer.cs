using Microsoft.Extensions.Logging;

namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class GloriousMassTransitConsumer :
        IConsumer<GloriousMessage>
    {
        private readonly ILogger<GloriousMassTransitConsumer> _logger;

        public GloriousMassTransitConsumer(ILogger<GloriousMassTransitConsumer> logger)
        {
            _logger = logger;
        }
        
        public Task Consume(ConsumeContext<GloriousMessage> context)
        {
            _logger.LogInformation($"Hello, {context.Message.Name}.");
            
            return Task.CompletedTask;
        }
    }
}