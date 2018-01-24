namespace RanorexReportViewer
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this.txtReportFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadSingleReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBuild = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lvReportsInFolder = new System.Windows.Forms.ListView();
            this.Report = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxMsg = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReportFodler = new System.Windows.Forms.Label();
            this.lblReportLocation = new System.Windows.Forms.Label();
            this.txtReportFolder = new System.Windows.Forms.TextBox();
            this.btnConfigureReportFolder = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReportFilePath
            // 
            this.txtReportFilePath.AllowDrop = true;
            this.txtReportFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportFilePath.Location = new System.Drawing.Point(13, 39);
            this.txtReportFilePath.Name = "txtReportFilePath";
            this.txtReportFilePath.Size = new System.Drawing.Size(585, 20);
            this.txtReportFilePath.TabIndex = 0;
            this.txtReportFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.txtReportFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.txtReportFilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReportFilePath_KeyPress);
            // 
            // btnLoadSingleReport
            // 
            this.btnLoadSingleReport.AllowDrop = true;
            this.btnLoadSingleReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadSingleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSingleReport.Location = new System.Drawing.Point(461, 65);
            this.btnLoadSingleReport.Name = "btnLoadSingleReport";
            this.btnLoadSingleReport.Size = new System.Drawing.Size(137, 23);
            this.btnLoadSingleReport.TabIndex = 1;
            this.btnLoadSingleReport.Text = "Load Single Report";
            this.btnLoadSingleReport.UseVisualStyleBackColor = false;
            this.btnLoadSingleReport.Click += new System.EventHandler(this.btnLoadSingleReport_Click);
            this.btnLoadSingleReport.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.btnLoadSingleReport.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbBuild);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblServer);
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.cbServer);
            this.panel1.Controls.Add(this.lvReportsInFolder);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 964);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // cbBuild
            // 
            this.cbBuild.AllowDrop = true;
            this.cbBuild.FormattingEnabled = true;
            this.cbBuild.Location = new System.Drawing.Point(572, 36);
            this.cbBuild.Name = "cbBuild";
            this.cbBuild.Size = new System.Drawing.Size(137, 21);
            this.cbBuild.TabIndex = 1;
            this.cbBuild.SelectedIndexChanged += new System.EventHandler(this.cbBuild_SelectedIndexChanged);
            this.cbBuild.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.cbBuild.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.cbBuild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuild_KeyPress);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Build Number:";
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Name:";
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // lblServer
            // 
            this.lblServer.AllowDrop = true;
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(3, 34);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(65, 23);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            this.lblServer.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.lblServer.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // cbJob
            // 
            this.cbJob.AllowDrop = true;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(303, 36);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(137, 21);
            this.cbJob.TabIndex = 1;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            this.cbJob.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.cbJob.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.cbJob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbJob_KeyPress);
            // 
            // cbServer
            // 
            this.cbServer.AllowDrop = true;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(74, 38);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(137, 21);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            this.cbServer.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.cbServer.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.cbServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbServer_KeyPress);
            // 
            // lvReportsInFolder
            // 
            this.lvReportsInFolder.AllowDrop = true;
            this.lvReportsInFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvReportsInFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvReportsInFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Report});
            this.lvReportsInFolder.ContextMenuStrip = this.contextMenuStrip1;
            this.lvReportsInFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvReportsInFolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReportsInFolder.LargeImageList = this.iml;
            this.lvReportsInFolder.Location = new System.Drawing.Point(0, 89);
            this.lvReportsInFolder.MultiSelect = false;
            this.lvReportsInFolder.Name = "lvReportsInFolder";
            this.lvReportsInFolder.ShowItemToolTips = true;
            this.lvReportsInFolder.Size = new System.Drawing.Size(911, 875);
            this.lvReportsInFolder.SmallImageList = this.iml;
            this.lvReportsInFolder.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvReportsInFolder.TabIndex = 0;
            this.lvReportsInFolder.TileSize = new System.Drawing.Size(248, 40);
            this.lvReportsInFolder.UseCompatibleStateImageBehavior = false;
            this.lvReportsInFolder.View = System.Windows.Forms.View.SmallIcon;
            this.lvReportsInFolder.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvReportsInFolder_ColumnWidthChanged);
            this.lvReportsInFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.lvReportsInFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.lvReportsInFolder.DoubleClick += new System.EventHandler(this.lvReportsInFolder_DoubleClick);
            // 
            // Report
            // 
            this.Report.Text = "Report";
            this.Report.Width = 560;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.displayToolStripMenuItem,
            this.saveReportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIconToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveReportToolStripMenuItem.Text = "Open Location";
            this.saveReportToolStripMenuItem.Click += new System.EventHandler(this.saveReportToolStripMenuItem_Click);
            // 
            // iml
            // 
            this.iml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml.ImageStream")));
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            this.iml.Images.SetKeyName(0, "report.ico");
            // 
            // btnReload
            // 
            this.btnReload.AllowDrop = true;
            this.btnReload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(771, 34);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(137, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reset";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.btnReload.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.rtxMsg);
            this.panel2.Controls.Add(this.lblReportFodler);
            this.panel2.Controls.Add(this.lblReportLocation);
            this.panel2.Controls.Add(this.txtReportFolder);
            this.panel2.Controls.Add(this.txtReportFilePath);
            this.panel2.Controls.Add(this.btnConfigureReportFolder);
            this.panel2.Controls.Add(this.btnLoadSingleReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(916, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 964);
            this.panel2.TabIndex = 2;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // rtxMsg
            // 
            this.rtxMsg.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMsg.ContextMenuStrip = this.contextMenuStrip2;
            this.rtxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxMsg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMsg.ForeColor = System.Drawing.Color.Tomato;
            this.rtxMsg.Location = new System.Drawing.Point(0, 201);
            this.rtxMsg.Name = "rtxMsg";
            this.rtxMsg.ReadOnly = true;
            this.rtxMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxMsg.Size = new System.Drawing.Size(601, 763);
            this.rtxMsg.TabIndex = 3;
            this.rtxMsg.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // lblReportFodler
            // 
            this.lblReportFodler.AllowDrop = true;
            this.lblReportFodler.AutoSize = true;
            this.lblReportFodler.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportFodler.Location = new System.Drawing.Point(9, 120);
            this.lblReportFodler.Name = "lblReportFodler";
            this.lblReportFodler.Size = new System.Drawing.Size(120, 23);
            this.lblReportFodler.TabIndex = 2;
            this.lblReportFodler.Text = "Report Folder:";
            this.lblReportFodler.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.lblReportFodler.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // lblReportLocation
            // 
            this.lblReportLocation.AllowDrop = true;
            this.lblReportLocation.AutoSize = true;
            this.lblReportLocation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportLocation.Location = new System.Drawing.Point(9, 13);
            this.lblReportLocation.Name = "lblReportLocation";
            this.lblReportLocation.Size = new System.Drawing.Size(137, 23);
            this.lblReportLocation.TabIndex = 2;
            this.lblReportLocation.Text = "Report Location:";
            this.lblReportLocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.lblReportLocation.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // txtReportFolder
            // 
            this.txtReportFolder.AllowDrop = true;
            this.txtReportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportFolder.Location = new System.Drawing.Point(13, 146);
            this.txtReportFolder.Name = "txtReportFolder";
            this.txtReportFolder.Size = new System.Drawing.Size(585, 20);
            this.txtReportFolder.TabIndex = 0;
            this.txtReportFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.txtReportFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.txtReportFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReportFolder_KeyPress);
            // 
            // btnConfigureReportFolder
            // 
            this.btnConfigureReportFolder.AllowDrop = true;
            this.btnConfigureReportFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfigureReportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigureReportFolder.Location = new System.Drawing.Point(461, 172);
            this.btnConfigureReportFolder.Name = "btnConfigureReportFolder";
            this.btnConfigureReportFolder.Size = new System.Drawing.Size(137, 23);
            this.btnConfigureReportFolder.TabIndex = 1;
            this.btnConfigureReportFolder.Text = "Configure Report Fodler";
            this.btnConfigureReportFolder.UseVisualStyleBackColor = false;
            this.btnConfigureReportFolder.Click += new System.EventHandler(this.btnConfigureReportFolder_Click);
            this.btnConfigureReportFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.btnConfigureReportFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(279, 172);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 26);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Latest Report";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmReportViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1517, 964);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranorex Report Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportViewer_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmReportViewer_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReportFilePath;
        private System.Windows.Forms.Button btnLoadSingleReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReportFodler;
        private System.Windows.Forms.Label lblReportLocation;
        private System.Windows.Forms.TextBox txtReportFolder;
        private System.Windows.Forms.Button btnConfigureReportFolder;
        private System.Windows.Forms.ListView lvReportsInFolder;
        private System.Windows.Forms.ComboBox cbBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.ColumnHeader Report;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxMsg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

