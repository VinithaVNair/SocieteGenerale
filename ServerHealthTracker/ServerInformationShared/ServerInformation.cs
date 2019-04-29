
using System;
using System.Runtime.Serialization;

namespace ServerInformationShared
{
    [DataContract]
    public class ServerInformation
    {
        [DataMember]
        public float ProcessorUsage { get; private set; }

        [DataMember]
        public float MemoryUsage { get; private set; }

        [DataMember]
        public string ServerName { get; private set; }

        [DataMember]
        public DateTime Time { get; private set; }

        public ServerInformation(string serverName, DateTime time, float processorUsage, float memoryUsage)

        {
            ServerName = serverName;
            Time = time;
            ProcessorUsage = processorUsage;
            MemoryUsage = memoryUsage;
        }
    }
}
