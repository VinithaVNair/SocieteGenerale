/* -------------------------------------------------------------------------------------------------
   Restricted - Copyright (C) Siemens Healthcare GmbH/Siemens Medical Solutions USA, Inc., 2019. All rights reserved
   ------------------------------------------------------------------------------------------------- */
   
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using ServerInformationShared;


namespace ServerInformationStorage
{
    public class ServerInformationProvider : IServerInformationProvider
    {
        private readonly SqlConnection mySqlConnection;
        private ICollection<string> myAllHosts;

        public ServerInformationProvider()
        {
            mySqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HostsConnectionString"].ConnectionString);
        }

        public ICollection<string> GetAllHostAvailable()
        {
            if (myAllHosts == null || myAllHosts.Count == 0)
            {
                myAllHosts = new List<string>();
                mySqlConnection.Open();
                var command = new SqlCommand(ConfigurationManager.AppSettings["AllHosts"], mySqlConnection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        myAllHosts.Add(reader["HostName"].ToString());

                    }
                }

                mySqlConnection.Close();
            }

            return myAllHosts;
        }

        public IList<ServerInformation> GetHostInformation(string hostName)
        {
            IList<ServerInformation> allInformation = new List<ServerInformation>();

            var command = new SqlCommand(ConfigurationManager.AppSettings["GetServerInformation"], mySqlConnection);
            command.Parameters.Add("@hostName", SqlDbType.NVarChar);
            command.Parameters["@hostName"].Value = hostName;
            mySqlConnection.Open();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    allInformation.Add(new ServerInformation(reader["HostName"].ToString(), Convert.ToDateTime(reader["Time"].ToString()),
                        float.Parse(reader["ProcessorUsage"].ToString()), float.Parse(reader["MemoryUsage"].ToString())));

                }
            }

            mySqlConnection.Close();
            return allInformation;
        }
    }
}
