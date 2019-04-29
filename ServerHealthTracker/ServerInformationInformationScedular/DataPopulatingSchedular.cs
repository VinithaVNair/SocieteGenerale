

namespace ServerInformationInformationSchedular
{
    /// <summary>
    /// This needs to be installed in different server and need to be run on schedular
    /// </summary>
    public class DataPopulatingSchedular
    {
        static void Main(string[] args)
        {
            var serverInforationClient = new ServerHealthReference.ServerHealthClient();

            var hostinformation = serverInforationClient.GetServerInformation();

            var serverInformationProcessorClient = new ServerInformationReference.ServerInformationSetterClient();
            
            serverInformationProcessorClient.SetServerInformation(hostinformation);
        }
    }
}
