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

namespace RanorexReportViewer
{
    public partial class Form1 : Form
    {
        private string _defaultReportPath = @".\TestReprot\";
        private List<string> _reports = new List<string>();
        private string _cef = @".\CEF\CEF.exe";
        private int _depth = 0;
        public Form1()
        {
            InitializeComponent();
            loadAllReports(_defaultReportPath);
            openReport(transformReportToHtml(_reports[0]));
        }
        private void loadAllReports(string path)
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

        private string transformReportToHtml(string reportPath)
        {
            string htmlPath = "";
            try
            {
                FileInfo report = new FileInfo(reportPath);

                if (report.FullName.EndsWith("rxlog"))
                {
                    htmlPath = report.FullName.Replace("rxlog", "html");
                    File.Copy(reportPath, htmlPath,true);
                }
                else
                {
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message+"\r\n"+e.StackTrace);
            }

            return htmlPath;
        }

        private void openReport(string reportPath)
        {
            Process p = new Process();
            p.StartInfo.FileName = _cef;
            p.StartInfo.Arguments = @"/url='"+reportPath+ "' --allow-file-access-from-files";
            p.Start();
        }
    }
}
