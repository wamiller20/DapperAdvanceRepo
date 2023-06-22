using Microsoft.Extensions.Configuration;

namespace WindowsFormsFrontEnd
{
    public partial class MainForm : Form
    {
        private string dbConnectionString;
        private List<string> lstAvailableTablesAndViews;
        private AppSettings appSettings;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.appSettings = Program.Configuration.GetSection("MySettings").Get<AppSettings>() ?? new AppSettings();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.dbConnectionString = tbDBConnectionString.Text.Trim();
            this.lstAvailableTablesAndViews = this.GetAllTablesAndViews(this.dbConnectionString);
        }

        private List<string> GetAllTablesAndViews(string dbConnectionString)
        {
            throw new NotImplementedException();
        }
    }
}