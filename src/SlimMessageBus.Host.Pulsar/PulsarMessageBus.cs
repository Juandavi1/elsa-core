using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotPulsar;
using DotPulsar.Abstractions;
using Microsoft.Extensions.Logging;
using SlimMessageBus.Host.Config;
using SlimMessageBus.Host.Pulsar.Configs;

namespace SlimMessageBus.Host.Pulsar
{


    /// <summary>
    /// <see cref="IMessageBus"/> implementation for Apache Pulsar.
    /// </summary>
    public class PulsarMessageBus : MessageBusBase
    {
        private readonly ILogger _logger;
        private IPulsarClient _pulsarClient;

        public PulsarMessageBusSettings ProviderSettings { get; }
        
        public PulsarMessageBus(MessageBusSettings settings, PulsarMessageBusSettings providerSettings)
            : base(settings)
        {
            _logger = LoggerFactory.CreateLogger<PulsarMessageBus>();
            ProviderSettings = providerSettings ?? throw new ArgumentNullException(nameof(providerSettings));

            OnBuildProvider();

        }
        
        protected override void Build()
        {
            base.Build();

            CreateClient();
            //CreateGroupConsumers();
            //CreateProviders();
        }

        private void CreateClient()
        {
            _logger.LogDebug("Creating pulsar client: {0}", ProviderSettings);
            
            _pulsarClient = PulsarClient
                .Builder()
                .ServiceUrl(new Uri(ProviderSettings.PulsarBrokerRootUrl))
                .Build();
            
            _logger.LogDebug("Created pulsar client");
        }

        public override Task ProduceToTransport(Type messageType, object message, string path, byte[] messagePayload,
            IDictionary<string, object> messageHeaders = null)
        {
            throw new NotImplementedException();
        }
    }
}