using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RanorexReportViewer
{
    public partial class frmReportViewer : Form
    {
        private string _defaultReportPath = string.Empty;
        private List<string> _reports = new List<string>();
        private string _cef = Application.StartupPath + @"/CEF/CEF.exe";
        private List<string> _filesDelete = new List<string>();
        private List<string> _directoryDelete = new List<string>();
        private Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private bool _isFirst = false;
        private List<string> _filterResult;
        private List<string> _servers;
        private List<string> _jobs;
        private List<string> _builds;
        private List<int> _processNeedShutDown;
        private const string SMALLICON = "SmallIcon";
        private const string LARGEICON = "LargeIcon";
        private const string DETAILS = "Details";
        private const string TILE = "Tile";
        private const string LIST = "List";
        public frmReportViewer()
        {
            try
            {
                _processNeedShutDown = new List<int>();
                InitializeComponent();
                cbServer.Items.Add("");
                loadConfig();
                if (!_isFirst)
                {
                    loadAllReports(_defaultReportPath);
                    loadReportIntoList();
                    getSearchElements();
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        public frmReportViewer(string reportPath)
        {
            try
            {
                _processNeedShutDown = new List<int>();
                InitializeComponent();
                cbServer.Items.Add("");
                loadConfig();
                if (!_isFirst)
                {
                    loadAllReports(_defaultReportPath);
                    loadReportIntoList();
                    getSearchElements();
                }
                if (File.Exists(reportPath))
                {
                    if (reportPath.EndsWith(".rxlog"))
                    {
                        openReport(transformReportToHtml(reportPath));
                    }
                    else
                    {
                        writeLog("Initilization", "Not a Ranorex report.");
                        MessageBox.Show("Not a Ranorex report.", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    writeLog("Initilization", "Report does not exist.");
                    MessageBox.Show("Report does not exist.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace + "\r\nReport path: " + reportPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void loadAllReports(string path)
        {
            try
            {
                IEnumerable<string> filesInFOlder = Directory.EnumerateFiles(path);
                IEnumerable<string> directoriesInFolder = Directory.EnumerateDirectories(path);
                if (filesInFOlder.Count<string>() > 0)
                {
                    foreach (string s in filesInFOlder)
                    {
                        if (s.ToLower().EndsWith("rxlog"))
                        {
                            _reports.Add(s);
                        }
                    }
                }

                if (directoriesInFolder.Count<string>() > 0)
                {
                    foreach (string d in directoriesInFolder)
                    {
                        loadAllReports(d);
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private string transformReportToHtml(string reportPath)
        {
            string htmlPath = "";
            try
            {
                FileInfo report = new FileInfo(reportPath);

                if (report.FullName.EndsWith("rxlog"))
                {
                    FileInfo fi = new FileInfo(report.FullName);
                    IEnumerable<string> f = Directory.EnumerateFiles(fi.Directory.ToString());
                    IEnumerable<string> d = Directory.EnumerateDirectories(fi.Directory.ToString());
                    foreach (string s in f)
                    {
                        FileInfo t = new FileInfo(s);
                        if (t.FullName.EndsWith(".rxlog"))
                        {
                            htmlPath = Application.StartupPath + @"\" + t.Name.Replace(".rxlog", ".html");
                            File.Copy(t.FullName, Application.StartupPath + @"\" + t.Name.Replace(".rxlog", ".html"), true);
                            _filesDelete.Add(Application.StartupPath + @"\" + t.Name.Replace(".rxlog", ".html"));
                        }
                        else if (t.FullName.EndsWith(".rxlog.data"))
                        {
                            File.Copy(t.FullName, Application.StartupPath + @"\" + t.Name.Replace(".rxlog", ".html"), true);
                            _filesDelete.Add(Application.StartupPath + @"\" + t.Name.Replace(".rxlog", ".html"));
                        }
                        else
                        {
                            File.Copy(t.FullName, Application.StartupPath + @"\" + t.Name, true);
                            _filesDelete.Add(Application.StartupPath + @"\" + t.Name);
                        }

                    }
                    if (d.Count<string>() > 0)
                    {
                        foreach (string dd in d)
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\" + new DirectoryInfo(dd).Name);
                            _directoryDelete.Add(Application.StartupPath + @"\" + new DirectoryInfo(dd).Name);
                            IEnumerable<string> ff = Directory.EnumerateFiles(dd);
                            if (ff.Count<string>() > 0)
                            {
                                foreach (string fff in ff)
                                {
                                    FileInfo ffiii = new FileInfo(fff);
                                    File.Copy(ffiii.FullName, Application.StartupPath + @"\" + new DirectoryInfo(dd).Name + @"\" + ffiii.Name);
                                    _filesDelete.Add(new DirectoryInfo(dd).Name + @"\" + ffiii.Name);
                                }
                            }
                        }
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                writeLog("transformReportToHtml", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }

            return htmlPath;
        }

        private void openReport(string reportPath)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = _cef;
                p.StartInfo.Arguments = "/url=\"" + reportPath + "\" --allow-file-access-from-files";
                p.Start();
                _processNeedShutDown.Add(p.Id);
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void updateConfig()
        {
            try
            {
                string str = txtReportFolder.Text.Trim();

                _config.AppSettings.Settings["DefaultReportFolder"].Value = str;
                _config.AppSettings.Settings["FirstRun"].Value = "False";
                _config.Save();
                loadConfig();
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void loadConfig()
        {
            try
            {
                txtReportFolder.Text = _config.AppSettings.Settings["DefaultReportFolder"].Value;
                _defaultReportPath = txtReportFolder.Text;
                _isFirst = bool.Parse(_config.AppSettings.Settings["FirstRun"].Value);
                string view = _config.AppSettings.Settings["View"].Value;
                switch (view)
                {
                    case LIST:
                        lvReportsInFolder.View = View.List;
                        //lvReportsInFolder.Columns.Clear();
                        //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                        break;
                    case SMALLICON:
                        lvReportsInFolder.View = View.SmallIcon;
                        //lvReportsInFolder.Columns.Clear();
                        //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                        break;
                    case LARGEICON:
                        lvReportsInFolder.View = View.LargeIcon;
                        break;
                    case TILE:
                        lvReportsInFolder.View = View.Tile;
                        break;
                    case DETAILS:
                        lvReportsInFolder.View = View.Details;
                        //lvReportsInFolder.Columns.Clear();
                        //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                        break;
                    default: break;
                }

                if (_isFirst)
                {
                    if (DialogResult.OK == MessageBox.Show("Do you want to configure Default Report Folder?", "Welcome"))
                    {
                        txtReportFolder.Focus();
                    }
                }
                _config.AppSettings.Settings["FirstRun"].Value = "False";
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void btnLoadSingleReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtReportFilePath.Text.Trim()))
                {
                    openReport(transformReportToHtml(txtReportFilePath.Text));
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void btnConfigureReportFolder_Click(object sender, EventArgs e)
        {
            try
            {
                lvReportsInFolder.Clear();
                _reports.Clear();
                if (!string.IsNullOrEmpty(txtReportFolder.Text.Trim()))
                {
                    updateConfig();
                    loadAllReports(_defaultReportPath);
                    loadReportIntoList();
                    getSearchElements();
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void getSearchElements()
        {
            try
            {
                cbServer.Items.Clear();
                if (_servers == null)
                    _servers = new List<string>();
                else
                    _servers.Clear();
                string t = string.Empty;
                if (_reports.Count > 0)
                {
                    _servers = new List<string>();
                    foreach (string r in _reports)
                    {
                        string temp = string.Empty;
                        temp = r.Substring(r.IndexOf(@"TestReport\") + 11);
                        int position = temp.IndexOf("\\");
                        if (temp.Substring(0, position < 0 ? temp.Length : position) != t)
                        {
                            _servers.Add(temp.Substring(0, position < 0 ? temp.Length : position));
                            cbServer.Items.Add(temp.Substring(0, position < 0 ? temp.Length : position));
                            t = temp.Substring(0, position < 0 ? temp.Length : position);
                        }
                    }
                    if (_servers.Count == 0)
                    {
                        throw new Exception("No Server Found");
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void setSearch()
        {
            try
            {
                lvReportsInFolder.Clear();
                _filterResult = new List<string>();
                foreach (string r in _reports)
                {
                    string server = cbServer.Text.Trim();
                    string job = cbJob.Text.Trim();
                    string build = cbBuild.Text.Trim();

                    if (r.Contains(server) && r.Contains(job) && r.Contains(build))
                        _filterResult.Add(r);
                }

                if (_filterResult.Count == 0)
                {
                    writeLog("setSearch", "No Report Found.");
                    MessageBox.Show("No Report Found.", "Search Result");
                }
                else
                {
                    foreach (string r in _filterResult)
                    {
                        string item = transformReportText(r);
                        ListViewItem lvi = new ListViewItem(item);
                        lvi.ImageIndex = 0;
                        lvi.ToolTipText = r;
                        lvReportsInFolder.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void loadReportIntoList()
        {
            try
            {
                if (_reports.Count > 0)
                {
                    foreach (string r in _reports)
                    {
                        string item = transformReportText(r);
                        ListViewItem lvi = new ListViewItem(item);
                        lvi.ToolTipText = r;
                        lvi.ImageIndex = 0;
                        lvReportsInFolder.Items.Add(lvi);
                    }

                }
                else
                {
                    writeLog("loadReportIntoList", "No Reports in Fodler:\r\n" + _defaultReportPath);
                    MessageBox.Show("No Reports in Fodler:\r\n" + _defaultReportPath, "No Reports Found");
                }
            }
            catch (Exception ex)
            {
                writeLog("Initilization", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private string transformReportText(string r)
        {
            string name = string.Empty;

            try
            {
                name = r.Substring(r.IndexOf(@"TestReport\") + 11);
            }
            catch (Exception ex)
            {
                writeLog("transformReportText", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
            return name;
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbJob.Items.Clear();
                if (_jobs == null)
                    _jobs = new List<string>();
                else
                    _jobs.Clear();
                string t = string.Empty;
                string ser = cbServer.Text.Trim();
                if (_reports.Count > 0)
                {
                    _jobs = new List<string>();
                    foreach (string r in _reports)
                    {
                        string temp = string.Empty;
                        temp = r.Substring(r.IndexOf(ser + @"\") + ser.Length + 1);
                        int position = temp.IndexOf("\\");
                        if (temp.Substring(0, position) != t)
                        {
                            _jobs.Add(temp.Substring(0, position));
                            cbJob.Items.Add(temp.Substring(0, position));
                            t = temp.Substring(0, position);
                        }
                    }
                    if (_servers.Count == 0)
                    {
                        throw new Exception("No Job Found");
                    }
                }
                setSearch();
            }
            catch (Exception ex)
            {
                writeLog("cbServer_SelectedIndexChanged", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbBuild.Items.Clear();
                if (_builds == null)
                    _builds = new List<string>();
                else
                    _builds.Clear();
                string t = string.Empty;
                string jo = cbJob.Text.Trim();
                if (_reports.Count > 0)
                {
                    _builds = new List<string>();
                    foreach (string r in _reports)
                    {
                        string temp = string.Empty;
                        temp = r.Substring(r.IndexOf(jo + @"\") + jo.Length + 1);
                        int position = temp.IndexOf("\\");
                        if (temp.Substring(0, position) != t)
                        {
                            _builds.Add(temp.Substring(0, position));
                            cbBuild.Items.Add(temp.Substring(0, position));
                            t = temp.Substring(0, position);
                        }
                    }
                    if (_servers.Count == 0)
                    {
                        throw new Exception("No Build Found");
                    }
                }
                setSearch();
            }
            catch (Exception ex)
            {
                writeLog("cbJob_SelectedIndexChanged", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void cbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSearch();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                cbBuild.SelectedIndex = -1;
                cbJob.SelectedIndex = -1;
                cbServer.SelectedIndex = -1;
                lvReportsInFolder.Clear();
                loadReportIntoList();
            }
            catch (Exception ex)
            {
                writeLog("btnReload_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void lvReportsInFolder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openReport(transformReportToHtml(lvReportsInFolder.SelectedItems[0].ToolTipText.Trim()));
            }
            catch (Exception ex)
            {
                writeLog("lvReportsInFolder_DoubleClick", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void txtReportFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (File.Exists(txtReportFilePath.Text.Trim()))
                    {
                        openReport(transformReportToHtml(txtReportFilePath.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("txtReportFilePath_KeyPress", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void txtReportFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (!string.IsNullOrEmpty(txtReportFolder.Text.Trim()))
                    {
                        updateConfig();
                        loadAllReports(_defaultReportPath);
                        loadReportIntoList();
                        getSearchElements();
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("txtReportFolder_KeyPress", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void cbServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string t = string.Empty;
                string ser = cbServer.Text.Trim();
                if (_reports.Count > 0)
                {
                    _jobs = new List<string>();
                    foreach (string r in _reports)
                    {
                        string temp = string.Empty;
                        temp = r.Substring(r.IndexOf(ser + @"\") + ser.Length + 1);
                        int position = temp.IndexOf("\\");
                        if (temp.Substring(0, position) != t)
                        {
                            _jobs.Add(temp.Substring(0, position));
                            cbJob.Items.Add(temp.Substring(0, position));
                            t = temp.Substring(0, position);
                        }
                    }
                    if (_servers.Count == 0)
                    {
                        throw new Exception("No Job Found");
                    }
                }
                setSearch();
            }
            catch (Exception ex)
            {
                writeLog("cbServer_KeyPress", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void cbJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string t = string.Empty;
                string jo = cbJob.Text.Trim();
                if (_reports.Count > 0)
                {
                    _builds = new List<string>();
                    foreach (string r in _reports)
                    {
                        string temp = string.Empty;
                        temp = r.Substring(r.IndexOf(jo + @"\") + jo.Length + 1);
                        int position = temp.IndexOf("\\");
                        if (temp.Substring(0, position) != t)
                        {
                            _builds.Add(temp.Substring(0, position));
                            cbBuild.Items.Add(temp.Substring(0, position));
                            t = temp.Substring(0, position);
                        }
                    }
                    if (_servers.Count == 0)
                    {
                        throw new Exception("No Build Found");
                    }
                }
                setSearch();
            }
            catch (Exception ex)
            {
                writeLog("cbJob_KeyPress", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void cbBuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    setSearch();
            }
            catch (Exception ex)
            {
                writeLog("cbBuild_KeyPress", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void frmReportViewer_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Link;
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (s.Length > 0)
                    openReport(transformReportToHtml(s[0]));
            }
            catch (Exception ex)
            {
                writeLog("frmReportViewer_DragDrop", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void frmReportViewer_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Move;
            }
            catch (Exception ex)
            {
                writeLog("frmReportViewer_DragEnter", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void frmReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_filesDelete.Count > 0)
                {
                    foreach (string f in _filesDelete)
                        File.Delete(f);
                }
                if(_directoryDelete.Count>0)
                {
                    foreach (string d in _directoryDelete)
                        Directory.Delete(d);
                }
                if (_processNeedShutDown.Count > 0)
                {
                    foreach (int pid in _processNeedShutDown)
                    {
                        Process p = Process.GetProcessById(pid);
                        if (!p.HasExited)
                            p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("frmReportViewer_FormClosed", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lvReportsInFolder.Columns.Clear();
                //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                lvReportsInFolder.View = View.SmallIcon;
                _config.AppSettings.Settings["View"].Value = SMALLICON;
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("smallIconToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lvReportsInFolder.View = View.LargeIcon;
                _config.AppSettings.Settings["View"].Value = LARGEICON;
                _config.Save();
                //lvReportsInFolder.Columns.Clear();
                //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
            }
            catch (Exception ex)
            {
                writeLog("largeIconToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lvReportsInFolder.Columns.Clear();
                lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                lvReportsInFolder.View = View.Details;
                _config.AppSettings.Settings["View"].Value = DETAILS;
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("detailToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lvReportsInFolder.Columns.Clear();
                //lvReportsInFolder.Columns.Add("Report", int.Parse(_config.AppSettings.Settings["ColumnWidth"].Value));
                lvReportsInFolder.View = View.List;
                _config.AppSettings.Settings["View"].Value = LIST;
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("listToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lvReportsInFolder.View = View.Tile;
                _config.AppSettings.Settings["View"].Value = TILE;
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("tileToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void lvReportsInFolder_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            try
            {
                _config.AppSettings.Settings["ColumnWidth"].Value = lvReportsInFolder.Columns[0].Width.ToString();
                _config.Save();
            }
            catch (Exception ex)
            {
                writeLog("lvReportsInFolder_ColumnWidthChanged", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void saveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvReportsInFolder.SelectedItems.Count < 1)
                {
                    writeLog("saveReportToolStripMenuItem_Click", "No reports selected.");
                    MessageBox.Show("No reports selected.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (ListViewItem lvi in lvReportsInFolder.SelectedItems)
                    {
                        FileInfo fi = new FileInfo(lvi.ToolTipText.Trim());

                        Process.Start(fi.Directory.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("saveReportToolStripMenuItem_Click", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }

        private void writeLog(string tagger, string msg)
        {
            rtxMsg.Text += tagger + ": " + msg + "\r\n";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxMsg.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                List<FileInfo> f = new List<FileInfo>();
                btnConfigureReportFolder_Click(sender, e);
                foreach (string s in _reports)
                {
                    f.Add(new FileInfo(s));
                }
                f.Sort(delegate (FileInfo x, FileInfo y) { return y.CreationTime.CompareTo(x.CreationTime); });
                openReport(transformReportToHtml(f[0].FullName));
            }
            catch (Exception ex)
            {
                writeLog("linkLabel1_LinkClicked", ex.Message + "\r\nStackStrace: " + ex.StackTrace);
            }
        }
    }
}
