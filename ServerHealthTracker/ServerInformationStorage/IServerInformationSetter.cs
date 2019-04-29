
using System.Collections.Generic;
using System.ServiceModel;
using ServerInformationShared;

namespace ServerInformationStorage
{
    [ServiceContract]
    public interface IServerInformationSetter
    {
        [OperationContract]
        void AddServer(string hostName);

        [OperationContract]
        void SetServerInformation(ServerInformation serverInformation);
    }
}
