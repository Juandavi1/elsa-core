using SlimMessageBus.Host.Config;

namespace SlimMessageBus.Host.Pulsar.Configs
{
    public static class PulsarMessageBusBuilderExtensions
    {
        public static MessageBusBuilder WithProviderPulsar(this MessageBusBuilder mbb, PulsarMessageBusSettings pulsarSettings)
        {
            return mbb.WithProvider(settings => new PulsarMessageBus(settings, pulsarSettings));
        }
    }
}