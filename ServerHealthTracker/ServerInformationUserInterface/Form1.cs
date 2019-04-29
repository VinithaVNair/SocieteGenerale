using System.Windows.Forms;

using ServerInformationUserInterface.ServerInformationProviderReference;


namespace ServerInformationUserInterface
{
    public partial class Form1 : Form
    {
        private ServerInformationProviderClient myServerClient;
        public Form1()
        {
            InitializeComponent();
            myServerClient = myServerClient ?? new ServerInformationProviderClient();
            var allHosts = myServerClient.GetAllHostAvailable();
            int count = 1;
            foreach (var host in allHosts)
            {
                this.ServerGridView.Rows.Add(count, host);
                count++;
            }
        }

        private void ServerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var hostName = this.ServerGridView[e.ColumnIndex,e.RowIndex].Value.ToString();
            if (!string.IsNullOrEmpty(hostName))
            {
                myServerClient = myServerClient ?? new ServerInformationProviderClient();
                var allHosts = myServerClient.GetHostInformation(hostName);
                int count = 1;
                foreach (var item in allHosts)
                {
                    this.InformationGridView.Rows.Add(count, item.ServerName, item.ProcessorUsage, item.MemoryUsage, item.Time);
                    count++;
                }


                this.InformationGridView.Visible = true;

            }
        }
    }
}
