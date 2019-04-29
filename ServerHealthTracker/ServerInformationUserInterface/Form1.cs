using System.Windows.Forms;

namespace ServerInformationUserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServerInformationProcessorReference.ServerInformationProcessorClient serverInformation = new ServerInformationProcessorReference.ServerInformationProcessorClient();
            var allHosts = serverInformation.GetAllHostAvailable();
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
                ServerInformationProcessorReference.ServerInformationProcessorClient serverInformation = new ServerInformationProcessorReference.ServerInformationProcessorClient();
                var allHosts = serverInformation.GetHostInformation(hostName);
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
