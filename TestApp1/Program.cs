// See https://aka.ms/new-console-template for more information

using NATS.Net;

Console.WriteLine("Testing!");

await using var client = new NatsClient();
var rtt = await client.PingAsync();
Console.WriteLine($"rtt {rtt}");

var response = await client.RequestAsync<string, string>("tester.create.server", "{}");
Console.WriteLine($"response {response.Data}");
