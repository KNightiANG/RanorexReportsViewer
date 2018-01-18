using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace RanorexReportViewer
{
    public partial class frmReportViewer : Form
    {
        private string _defaultReportPath = string.Empty;
        private List<string> _reports = new List<string>();
        private string _cef = Application.StartupPath + @"/CEF/CEF.exe";
        private List<string> _filesDelete = new List<string>();
        private Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private bool _isFirst = false;
        private List<string> _filterResult;
        private List<string> _servers;
        private List<string> _jobs;
        private List<string> _builds;
        private List<string> _processNeedShutDown;
        public frmReportViewer()
        {
            _processNeedShutDown = new List<string>();
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
            catch (Exception e)
            {

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
                    htmlPath = report.FullName.Replace("rxlog", "html");
                    File.Copy(reportPath, htmlPath, true);
                    File.Copy(reportPath + ".data", htmlPath + ".data", true);
                    _filesDelete.Add(htmlPath);
                    _filesDelete.Add(htmlPath + ".data");
                }
                else
                {
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\r\n" + e.StackTrace);
            }

            return htmlPath;
        }

        private void openReport(string reportPath)
        {
            Process p = new Process();
            p.StartInfo.FileName = _cef;
            p.StartInfo.Arguments = "/url=\"" + reportPath + "\" --allow-file-access-from-files";
            p.Start();

        }

        private void updateConfig()
        {
            string str = txtReportFolder.Text.Trim();

            _config.AppSettings.Settings["DefaultReportFolder"].Value = str;
            _config.AppSettings.Settings["FirstRun"].Value = "False";
            _config.Save();
            loadConfig();
        }

        private void loadConfig()
        {
            txtReportFolder.Text = _config.AppSettings.Settings["DefaultReportFolder"].Value;
            _defaultReportPath = txtReportFolder.Text;
            _isFirst = bool.Parse(_config.AppSettings.Settings["FirstRun"].Value);
        }

        private void btnLoadSingleReport_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtReportFilePath.Text.Trim()))
            {
                openReport(transformReportToHtml(txtReportFilePath.Text));
            }
        }

        private void btnConfigureReportFolder_Click(object sender, EventArgs e)
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

        private void getSearchElements()
        {
            string t = string.Empty;
            if (_reports.Count > 0)
            {
                _servers = new List<string>();
                foreach (string r in _reports)
                {
                    string temp = string.Empty;
                    temp = r.Substring(r.IndexOf(@"TestReport\") + 11);
                    int position = temp.IndexOf("\\");
                    if (temp.Substring(0, position) != t)
                    {
                        _servers.Add(temp.Substring(0, position));
                        cbServer.Items.Add(temp.Substring(0, position));
                        t = temp.Substring(0, position);
                    }
                }
                if (_servers.Count == 0)
                {
                    throw new Exception("No Server Found");
                }
            }
        }

        private void setSearch()
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
                MessageBox.Show("No Report Found.", "Search Result");
            else
            {
                foreach (string r in _filterResult)
                {
                    string item = transformReportText(r);
                    ListViewItem lvi = new ListViewItem(item);
                    lvi.ToolTipText = r;
                    lvReportsInFolder.Items.Add(lvi);
                }
            }
        }

        private void loadReportIntoList()
        {
            if (_reports.Count > 0)
            {
                foreach (string r in _reports)
                {
                    string item = transformReportText(r);
                    ListViewItem lvi = new ListViewItem(item);
                    lvi.ToolTipText = r;
                    lvReportsInFolder.Items.Add(lvi);
                }

            }
            else
            {
                MessageBox.Show("No Reports in Fodler:\r\n" + _defaultReportPath, "No Reports Found");
            }
        }

        private string transformReportText(string r)
        {
            string name = string.Empty;

            name = r.Substring(r.IndexOf(@"TestReprot\") + 11);

            return name;
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSearch();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cbBuild.SelectedIndex = -1;
            cbJob.SelectedIndex = -1;
            cbServer.SelectedIndex = -1;
            lvReportsInFolder.Clear();
            loadReportIntoList();
        }

        private void lvReportsInFolder_DoubleClick(object sender, EventArgs e)
        {
            openReport(transformReportToHtml(lvReportsInFolder.SelectedItems[0].ToolTipText.Trim()));
        }

        private void txtReportFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (File.Exists(txtReportFilePath.Text.Trim()))
                {
                    openReport(transformReportToHtml(txtReportFilePath.Text));
                }
            }
        }

        private void txtReportFolder_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbServer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbJob_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbBuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                setSearch();
        }

        private void frmReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_filesDelete.Count > 0)
            {
                foreach (string f in _filesDelete)
                    File.Delete(f);
            }
            Process[] processes = Process.GetProcessesByName("CEF.exe");
            if (processes.Length > 0)
            {
                foreach (Process p in processes)
                    p.Close();
            }
        }
    }
}
