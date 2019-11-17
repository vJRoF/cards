using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cards.MessageBroker
{
    public sealed class MessageBus : IDisposable
    {
        private readonly IProducer<Null, string> _producer;
        //private Consumer<Null, string> _consumer;

        //private readonly IDictionary<string, object> _producerConfig;
        private readonly IDictionary<string, object> _consumerConfig;

        public MessageBus() : this("localhost") { }

        public MessageBus(string host)
        {
            var producerConfig = new ProducerConfig { BootstrapServers = host };
            _consumerConfig = new Dictionary<string, object>
            {
                { "group.id", "custom-group"},
                { "bootstrap.servers", host }
            };
            
            _producer = new ProducerBuilder<Null, string>(producerConfig).Build();
        }

        public async Task SendMessage(string topic, string message)
        {
            await _producer.ProduceAsync(topic,new Message<Null, string> { Value = message });
        }

        //public void SubscribeOnTopic<T>(string topic, Action<T> action, CancellationToken cancellationToken) where T : class
        //{
        //    var msgBus = new MessageBus();
        //    using (msgBus._consumer = new Consumer<Null, string>(_consumerConfig, null, new StringDeserializer(Encoding.UTF8)))
        //    {
        //        msgBus._consumer.Assign(new List<TopicPartitionOffset> { new TopicPartitionOffset(topic, 0, -1) });

        //        while (true)
        //        {
        //            if (cancellationToken.IsCancellationRequested)
        //                break;

        //            Message<Null, string> msg;
        //            if (msgBus._consumer.Consume(out msg, TimeSpan.FromMilliseconds(10)))
        //            {
        //                action(msg.Value as T);
        //            }
        //        }
        //    }
        //}

        public void Dispose()
        {
            _producer?.Dispose();
            //_consumer?.Dispose();
        }
    }
}
