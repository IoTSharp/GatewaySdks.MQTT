# GatewaySdks.MQTT

``` csharp 
      builder.Services.AddSingleton<MQTTClient>()
                     .Configure<MqttSettings>(builder.Configuration)
             .AddHostedService<MqttClientHost>();
```