using NATS.Net;
using Xunit.Abstractions;

namespace TestProject1;

public class UnitTest1(ITestOutputHelper outputHelper)
{
    [Fact]
    public async Task Test1()
    {
        await using var client = new NatsClient("nats:4222");
        var rtt = await client.PingAsync();
        outputHelper.WriteLine($"rtt {rtt}");
    }
}