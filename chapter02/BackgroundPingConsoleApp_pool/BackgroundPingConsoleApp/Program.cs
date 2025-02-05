﻿Console.WriteLine("Hello, World!");

ThreadPool.QueueUserWorkItem((o) =>
{
    for (int i = 0; i < 20; i++)
    {
        bool isNetworkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        Console.WriteLine($"Is network available? Answer: {isNetworkUp}");
        Thread.Sleep(100);
    }
});
/*
 Since we are using the ThreadPool, there is no need 
to set the Thread.IsBackground property or call Thread.Start()
That happens automatically. 
 */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Main thread working...");
    Task.Delay(500);
}

Console.WriteLine("Done");
Console.ReadKey();
