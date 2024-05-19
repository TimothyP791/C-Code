//Abstract classes

using Abstract_Classes;

PingIPv6 pingIPV6 = new PingIPv6();
Console.WriteLine(pingIPV6.Init());
Console.WriteLine(pingIPV6.SendPing());

PingIPv4 pingIPV4 = new PingIPv4();
Console.WriteLine(pingIPV4.Init());
Console.WriteLine(pingIPV4.SendPing());