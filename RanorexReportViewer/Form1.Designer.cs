namespace RanorexReportViewer
{
    partial class frmReportViewer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBuild = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lvReportsInFolder = new System.Windows.Forms.ListView();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtReportFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadSingleReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReportFodler = new System.Windows.Forms.Label();
            this.lblReportLocation = new System.Windows.Forms.Label();
            this.txtReportFolder = new System.Windows.Forms.TextBox();
            this.btnConfigureReportFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cbBuild);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblServer);
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.cbServer);
            this.panel1.Controls.Add(this.lvReportsInFolder);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 633);
            this.panel1.TabIndex = 3;
            // 
            // cbBuild
            // 
            this.cbBuild.FormattingEnabled = true;
            this.cbBuild.Location = new System.Drawing.Point(289, 35);
            this.cbBuild.Name = "cbBuild";
            this.cbBuild.Size = new System.Drawing.Size(137, 20);
            this.cbBuild.TabIndex = 1;
            this.cbBuild.SelectedIndexChanged += new System.EventHandler(this.cbBuild_SelectedIndexChanged);
            this.cbBuild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuild_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Build Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Name:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(3, 12);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(65, 23);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(146, 35);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(137, 20);
            this.cbJob.TabIndex = 1;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            this.cbJob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbJob_KeyPress);
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(3, 35);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(137, 20);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            this.cbServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbServer_KeyPress);
            // 
            // lvReportsInFolder
            // 
            this.lvReportsInFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvReportsInFolder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReportsInFolder.Location = new System.Drawing.Point(3, 60);
            this.lvReportsInFolder.MultiSelect = false;
            this.lvReportsInFolder.Name = "lvReportsInFolder";
            this.lvReportsInFolder.ShowItemToolTips = true;
            this.lvReportsInFolder.Size = new System.Drawing.Size(567, 570);
            this.lvReportsInFolder.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvReportsInFolder.TabIndex = 0;
            this.lvReportsInFolder.UseCompatibleStateImageBehavior = false;
            this.lvReportsInFolder.View = System.Windows.Forms.View.SmallIcon;
            this.lvReportsInFolder.DoubleClick += new System.EventHandler(this.lvReportsInFolder_DoubleClick);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(432, 33);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(137, 21);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reset";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtReportFilePath
            // 
            this.txtReportFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportFilePath.Location = new System.Drawing.Point(13, 36);
            this.txtReportFilePath.Name = "txtReportFilePath";
            this.txtReportFilePath.Size = new System.Drawing.Size(442, 21);
            this.txtReportFilePath.TabIndex = 0;
            this.txtReportFilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReportFilePath_KeyPress);
            // 
            // btnLoadSingleReport
            // 
            this.btnLoadSingleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSingleReport.Location = new System.Drawing.Point(318, 60);
            this.btnLoadSingleReport.Name = "btnLoadSingleReport";
            this.btnLoadSingleReport.Size = new System.Drawing.Size(137, 21);
            this.btnLoadSingleReport.TabIndex = 1;
            this.btnLoadSingleReport.Text = "Load Single Report";
            this.btnLoadSingleReport.UseVisualStyleBackColor = true;
            this.btnLoadSingleReport.Click += new System.EventHandler(this.btnLoadSingleReport_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lblReportFodler);
            this.panel2.Controls.Add(this.lblReportLocation);
            this.panel2.Controls.Add(this.txtReportFolder);
            this.panel2.Controls.Add(this.txtReportFilePath);
            this.panel2.Controls.Add(this.btnConfigureReportFolder);
            this.panel2.Controls.Add(this.btnLoadSingleReport);
            this.panel2.Location = new System.Drawing.Point(588, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 632);
            this.panel2.TabIndex = 4;
            // 
            // lblReportFodler
            // 
            this.lblReportFodler.AutoSize = true;
            this.lblReportFodler.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportFodler.Location = new System.Drawing.Point(9, 111);
            this.lblReportFodler.Name = "lblReportFodler";
            this.lblReportFodler.Size = new System.Drawing.Size(120, 23);
            this.lblReportFodler.TabIndex = 2;
            this.lblReportFodler.Text = "Report Folder:";
            // 
            // lblReportLocation
            // 
            this.lblReportLocation.AutoSize = true;
            this.lblReportLocation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportLocation.Location = new System.Drawing.Point(9, 12);
            this.lblReportLocation.Name = "lblReportLocation";
            this.lblReportLocation.Size = new System.Drawing.Size(137, 23);
            this.lblReportLocation.TabIndex = 2;
            this.lblReportLocation.Text = "Report Location:";
            // 
            // txtReportFolder
            // 
            this.txtReportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportFolder.Location = new System.Drawing.Point(13, 135);
            this.txtReportFolder.Name = "txtReportFolder";
            this.txtReportFolder.Size = new System.Drawing.Size(442, 21);
            this.txtReportFolder.TabIndex = 0;
            this.txtReportFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReportFolder_KeyPress);
            // 
            // btnConfigureReportFolder
            // 
            this.btnConfigureReportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigureReportFolder.Location = new System.Drawing.Point(318, 159);
            this.btnConfigureReportFolder.Name = "btnConfigureReportFolder";
            this.btnConfigureReportFolder.Size = new System.Drawing.Size(137, 21);
            this.btnConfigureReportFolder.TabIndex = 1;
            this.btnConfigureReportFolder.Text = "Configure Report Fodler";
            this.btnConfigureReportFolder.UseVisualStyleBackColor = true;
            this.btnConfigureReportFolder.Click += new System.EventHandler(this.btnConfigureReportFolder_Click);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmReportViewer";
            this.Text = "ReportViewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.ListView lvReportsInFolder;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtReportFilePath;
        private System.Windows.Forms.Button btnLoadSingleReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReportFodler;
        private System.Windows.Forms.Label lblReportLocation;
        private System.Windows.Forms.TextBox txtReportFolder;
        private System.Windows.Forms.Button btnConfigureReportFolder;
    }
}

