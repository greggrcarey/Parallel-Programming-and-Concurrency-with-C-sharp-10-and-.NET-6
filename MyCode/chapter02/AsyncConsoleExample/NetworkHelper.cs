using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsoleExample;

internal class NetworkHelper
{
    internal async Task CheckNetworkStatusAsync()
    {
        Task t = NetworkCheckInteralAsync();

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Top level method working...");
            await Task.Delay(500);
        }
        await t;
    }

    private static async Task NetworkCheckInteralAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            bool isNetworkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            Console.WriteLine($"Is Network Available? Answer: {isNetworkUp}");

            await Task.Delay(100);
        }
    }


}



