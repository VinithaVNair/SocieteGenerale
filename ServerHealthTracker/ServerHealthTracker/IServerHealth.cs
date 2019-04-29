
using System.ServiceModel;
using ServerInformationShared;

namespace ServerHealthTracker
{
    [ServiceContract]
    public interface IServerHealth
    {

        [OperationContract]

        ServerInformation GetServerInformation();

    }
}
