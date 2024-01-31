using AsyncConsoleExample;

Console.WriteLine("Hello Async");
NetworkHelper networkHelper = new();
await networkHelper.CheckNetworkStatusAsync();
Console.WriteLine("Main Method complete");
Console.ReadKey();
