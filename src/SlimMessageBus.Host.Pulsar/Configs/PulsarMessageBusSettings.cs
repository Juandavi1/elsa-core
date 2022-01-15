
namespace SlimMessageBus.Host.Pulsar.Configs
{
    public class PulsarMessageBusSettings
    {
        /// <summary>
        /// The Pulsar Broker Root Url
        /// </summary>
        public string PulsarBrokerRootUrl { get; set; }
        
        public PulsarMessageBusSettings(string pulsarBrokerRootUrl)
        {
            PulsarBrokerRootUrl = pulsarBrokerRootUrl;
        }
    }
}