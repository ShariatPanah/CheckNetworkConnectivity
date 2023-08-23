using System;
using System.Net.NetworkInformation;

namespace CheckNetworkConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkChange.NetworkAvailabilityChanged += NetworkAvailabilityChanged;

            Console.ReadKey();
        }

        private static void NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                Console.WriteLine("Available.");
            }
            else
            {
                Console.WriteLine("Not available.");
            }
        }
    }
}
