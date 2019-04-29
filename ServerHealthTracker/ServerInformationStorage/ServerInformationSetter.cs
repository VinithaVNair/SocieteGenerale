using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ServerInformationShared;


namespace ServerInformationStorage
{
    public class ServerInformationSetter : IServerInformationSetter
    {
        private readonly string myConnectionstring = ConfigurationManager.ConnectionStrings["HostsConnectionString"].ConnectionString;
        private readonly SqlConnection mySqlConnection;
        private ICollection<string> myAllHosts;

        public ServerInformationSetter()
        {
            mySqlConnection = new SqlConnection(myConnectionstring);
        }

        public void AddServer(string hostName)
        {
            SqlCommand command = new SqlCommand(ConfigurationManager.AppSettings["AddServer"], mySqlConnection);
            command.Parameters.AddWithValue("@hostName", hostName);

            RunNonQuery(command);

            myAllHosts.Add(hostName);
        }

       
        public void SetServerInformation(ServerInformation serverInformation)
        {
            var allhost = GetAllHostAvailable();
            if (!allhost.Contains(serverInformation.ServerName))
            {
                AddServer(serverInformation.ServerName);
            }

            var command = new SqlCommand(ConfigurationManager.AppSettings["SetServerInformation"], mySqlConnection);
            command.Parameters.AddWithValue("@hostName", serverInformation.ServerName);
            command.Parameters.AddWithValue("@processorUsage", serverInformation.ProcessorUsage);
            command.Parameters.AddWithValue("@memoryUsage", serverInformation.MemoryUsage);
            command.Parameters.AddWithValue("@time", serverInformation.Time);

            RunNonQuery(command);
        }

        private ICollection<string> GetAllHostAvailable()
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
        private void RunNonQuery(SqlCommand command)
        {
            mySqlConnection.Open();
            command.ExecuteNonQuery();
            mySqlConnection.Close();
        }
    }
}
