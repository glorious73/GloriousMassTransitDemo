namespace Company.Consumers
{
    using MassTransit;

    public class GloriousMassTransitConsumerDefinition :
        ConsumerDefinition<GloriousMassTransitConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GloriousMassTransitConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}