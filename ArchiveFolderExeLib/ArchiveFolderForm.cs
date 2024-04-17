using System.Reflection;

namespace ArchiveFolderExeLib
{
    public partial class ArchiveFolderForm : Form
    {
        private static DateTime GetBuildDate(Assembly assembly)
        {
            var attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
            return attribute != null ? attribute.DateTime : default(DateTime);
        }
        private static DateTime GetBuildDate()
        {
            return GetBuildDate(Assembly.GetExecutingAssembly());
        }
        public ArchiveFolderForm()
        {
            InitializeComponent();
            System.Windows.Forms.Application.EnableVisualStyles();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (new FolderBrowserDialog() is FolderBrowserDialog fd && fd.ShowDialog() == DialogResult.OK && fd.SelectedPath is string path && path.Length > 0)
            {
                folderLocationTextbox.Text = path;
                goButton.Enabled = path.Length > 0;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            var location = folderLocationTextbox.Text;
            progressBar.Style = ProgressBarStyle.Marquee;
            Task.Run(async () => await ArchiveFolder(location));
        }
        private async Task ArchiveFolder(string location)
        {
            await Task.Yield();
            ArchiveFolderLib.Util.BackupFolder(location);
            Finished();

        }
        private void Finished()
        {
            this.Invoke(FinishedSafe);
        }
        private void FinishedSafe()
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 100;
        }

        private void ArchiveFolderForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureBoxInfo, $"{Application.ProductName}: {Application.ProductVersion} ({GetBuildDate()})");
        }
    }
}
