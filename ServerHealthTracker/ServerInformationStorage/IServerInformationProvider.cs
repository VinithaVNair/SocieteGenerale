/* -------------------------------------------------------------------------------------------------
   Restricted - Copyright (C) Siemens Healthcare GmbH/Siemens Medical Solutions USA, Inc., 2019. All rights reserved
   ------------------------------------------------------------------------------------------------- */
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using ServerInformationShared;


namespace ServerInformationStorage
{
    [ServiceContract]
    interface IServerInformationProvider
    {
        [OperationContract]
        ICollection<string> GetAllHostAvailable();

        [OperationContract]
        IList<ServerInformation> GetHostInformation(string hostName);
    }
}
