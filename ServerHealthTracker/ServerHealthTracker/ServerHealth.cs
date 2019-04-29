using System;
using System.Diagnostics;
using ServerInformationShared;

namespace ServerHealthTracker
{
    /// <summary>
    /// Information about the server 
    /// </summary>
    public class ServerHealth : IServerHealth
    {
        public ServerInformation GetServerInformation()
        {
            var hostName= System.Net.Dns.GetHostName();
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            
            return new ServerInformation(hostName,DateTime.Now, (int)cpuCounter.NextValue(), ramCounter.NextValue());
        }
    }
}
