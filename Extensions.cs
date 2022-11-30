using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IoTSharpServiceCollectionExtensions
    {
      

        public static Task<MqttClientPublishResult> PublishAsync(this IMqttClient client,string topic, string playload, MqttQualityOfServiceLevel mqttQualityOf)
        {
            return client.PublishAsync(new MqttApplicationMessage() { Topic = topic, Payload = System.Text.Encoding.UTF8.GetBytes(playload), QualityOfServiceLevel = mqttQualityOf });
        }
        public static Task<MqttClientPublishResult> PublishAsync(this IMqttClient client, string topic, string playload)
        {
            return client.PublishAsync(new MqttApplicationMessage() { Topic = topic, Payload = System.Text.Encoding.UTF8.GetBytes(playload)});
        }
    }
}