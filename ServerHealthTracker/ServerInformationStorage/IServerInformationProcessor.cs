
using System.Collections.Generic;
using System.ServiceModel;
using ServerInformationShared;

namespace ServerInformationStorage
{
    [ServiceContract]
    public interface IServerInformationProcessor
    {
        [OperationContract]
        ICollection<string> GetAllHostAvailable();

        [OperationContract]
        IList<ServerInformation> GetHostInformation(string hostName);

        [OperationContract]
        void AddServer(string hostName);

        [OperationContract]
        void SetServerInformation(ServerInformation serverInformation);
    }
}
