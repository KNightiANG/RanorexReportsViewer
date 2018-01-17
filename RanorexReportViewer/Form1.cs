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

namespace RanorexReportViewer
{
    public partial class Form1 : Form
    {
        private string _defaultReportPath = @".\TestReprot\";
        private List<string> _reports = new List<string>();
        private int _depth = 0;
        public Form1()
        {
            InitializeComponent();
            loadAllReports(_defaultReportPath);
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
    }
}
