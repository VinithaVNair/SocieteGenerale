using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ServerInformationShared;


namespace ServerInformationStorage
{
    public class ServerInformationProcessor : IServerInformationProcessor
    {
        private readonly string myConnectionstring = ConfigurationManager.ConnectionStrings["HostsConnectionString"].ConnectionString;
        private readonly SqlConnection mySqlConnection;
        private ICollection<string> myAllHosts;

        public ServerInformationProcessor()
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

        private void RunNonQuery(SqlCommand command)
        {
            mySqlConnection.Open();
            command.ExecuteNonQuery();
            mySqlConnection.Close();
        }
    }
}
