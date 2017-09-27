﻿namespace SA45Team07B
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.adjustStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.crosstabReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconLibraryManagement = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBorrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 9);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.findToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1276, 31);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.toolStripMenuItem1,
            this.adjustStockToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.managementToolStripMenuItem.Text = "Transaction";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // adjustStockToolStripMenuItem
            // 
            this.adjustStockToolStripMenuItem.Name = "adjustStockToolStripMenuItem";
            this.adjustStockToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.adjustStockToolStripMenuItem.Text = "Adjust Stock";
            this.adjustStockToolStripMenuItem.Click += new System.EventHandler(this.adjustStockToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.memberToolStripMenuItem1,
            this.publisherToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.modifyInformationToolStripMenuItem});
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.bookToolStripMenuItem1.Text = "Book";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // modifyInformationToolStripMenuItem
            // 
            this.modifyInformationToolStripMenuItem.Name = "modifyInformationToolStripMenuItem";
            this.modifyInformationToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.modifyInformationToolStripMenuItem.Text = "Modify Information";
            this.modifyInformationToolStripMenuItem.Click += new System.EventHandler(this.modifyInformationToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.modifyInformationToolStripMenuItem1});
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.memberToolStripMenuItem1.Text = "Member";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.addNewToolStripMenuItem1.Text = "Add New";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // modifyInformationToolStripMenuItem1
            // 
            this.modifyInformationToolStripMenuItem1.Name = "modifyInformationToolStripMenuItem1";
            this.modifyInformationToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.modifyInformationToolStripMenuItem1.Text = "Modify Information";
            this.modifyInformationToolStripMenuItem1.Click += new System.EventHandler(this.modifyInformationToolStripMenuItem1_Click);
            // 
            // publisherToolStripMenuItem
            // 
            this.publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            this.publisherToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.publisherToolStripMenuItem.Text = "Publisher";
            this.publisherToolStripMenuItem.Click += new System.EventHandler(this.publisherToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.memberListToolStripMenuItem,
            this.toolStripMenuItem2,
            this.crosstabReportToolStripMenuItem,
            this.chartReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.bookListToolStripMenuItem.Text = "Book Assessment";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.memberListToolStripMenuItem.Text = "Member List";
            this.memberListToolStripMenuItem.Click += new System.EventHandler(this.memberListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(262, 6);
            // 
            // crosstabReportToolStripMenuItem
            // 
            this.crosstabReportToolStripMenuItem.Name = "crosstabReportToolStripMenuItem";
            this.crosstabReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.crosstabReportToolStripMenuItem.Text = "[cross-tab report]";
            // 
            // chartReportToolStripMenuItem
            // 
            this.chartReportToolStripMenuItem.Name = "chartReportToolStripMenuItem";
            this.chartReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.chartReportToolStripMenuItem.Text = "Subject Category Pie Chart";
            this.chartReportToolStripMenuItem.Click += new System.EventHandler(this.chartReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.getHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // getHelpToolStripMenuItem
            // 
            this.getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            this.getHelpToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.getHelpToolStripMenuItem.Text = "Get Help";
            this.getHelpToolStripMenuItem.Click += new System.EventHandler(this.getHelpToolStripMenuItem_Click);
            // 
            // notifyIconLibraryManagement
            // 
            this.notifyIconLibraryManagement.Text = "Library Management";
            this.notifyIconLibraryManagement.Visible = true;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBorrow,
            this.toolStripButtonReturn,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 40);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1276, 28);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonBorrow
            // 
            this.toolStripButtonBorrow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBorrow.Image")));
            this.toolStripButtonBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBorrow.Name = "toolStripButtonBorrow";
            this.toolStripButtonBorrow.Size = new System.Drawing.Size(85, 25);
            this.toolStripButtonBorrow.Text = "Borrow";
            this.toolStripButtonBorrow.Click += new System.EventHandler(this.toolStripButtonBorrow_Click);
            // 
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReturn.Image")));
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(81, 25);
            this.toolStripButtonReturn.Text = "Return";
            this.toolStripButtonReturn.Click += new System.EventHandler(this.toolStripButtonReturn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 25);
            this.toolStripButton1.Text = "Find Book";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SA45Team07B.Properties.Resources.greybackground3_modi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Library Management System SA45Team07B";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adjustStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crosstabReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconLibraryManagement;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem publisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
    }
}

