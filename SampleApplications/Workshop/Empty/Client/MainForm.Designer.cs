/* ========================================================================
 * Copyright (c) 2005-2017 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace Quickstarts.EmptyClient
{
    partial class MainForm
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.ServerMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_DiscoverMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_ConnectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_DisconnectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ContentsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainPN = new System.Windows.Forms.Panel();
            this.BrowseCTRL = new Opc.Ua.Client.Controls.BrowseNodeCtrl();
            this.ConnectServerCTRL = new Opc.Ua.Client.Controls.ConnectServerCtrl();
            this.clientHeaderBranding1 = new Opc.Ua.Client.Controls.HeaderBranding();
            this.MenuBar.SuspendLayout();
            this.MainPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerMI,
            this.HelpMI});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(884, 24);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "menuStrip1";
            // 
            // ServerMI
            // 
            this.ServerMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Server_DiscoverMI,
            this.Server_ConnectMI,
            this.Server_DisconnectMI});
            this.ServerMI.Name = "ServerMI";
            this.ServerMI.Size = new System.Drawing.Size(51, 20);
            this.ServerMI.Text = "Server";
            // 
            // Server_DiscoverMI
            // 
            this.Server_DiscoverMI.Name = "Server_DiscoverMI";
            this.Server_DiscoverMI.Size = new System.Drawing.Size(127, 22);
            this.Server_DiscoverMI.Text = "Discover...";
            this.Server_DiscoverMI.Click += new System.EventHandler(this.Server_DiscoverMI_Click);
            // 
            // Server_ConnectMI
            // 
            this.Server_ConnectMI.Name = "Server_ConnectMI";
            this.Server_ConnectMI.Size = new System.Drawing.Size(127, 22);
            this.Server_ConnectMI.Text = "Connect";
            this.Server_ConnectMI.Click += new System.EventHandler(this.Server_ConnectMI_ClickAsync);
            // 
            // Server_DisconnectMI
            // 
            this.Server_DisconnectMI.Name = "Server_DisconnectMI";
            this.Server_DisconnectMI.Size = new System.Drawing.Size(127, 22);
            this.Server_DisconnectMI.Text = "Disconnect";
            this.Server_DisconnectMI.Click += new System.EventHandler(this.Server_DisconnectMI_Click);
            // 
            // HelpMI
            // 
            this.HelpMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_ContentsMI});
            this.HelpMI.Name = "HelpMI";
            this.HelpMI.Size = new System.Drawing.Size(40, 20);
            this.HelpMI.Text = "Help";
            // 
            // Help_ContentsMI
            // 
            this.Help_ContentsMI.Name = "Help_ContentsMI";
            this.Help_ContentsMI.Size = new System.Drawing.Size(118, 22);
            this.Help_ContentsMI.Text = "Contents";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 524);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(884, 22);
            this.StatusBar.TabIndex = 2;
            // 
            // MainPN
            // 
            this.MainPN.Controls.Add(this.BrowseCTRL);
            this.MainPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPN.Location = new System.Drawing.Point(0, 122);
            this.MainPN.Name = "MainPN";
            this.MainPN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.MainPN.Size = new System.Drawing.Size(884, 402);
            this.MainPN.TabIndex = 3;
            // 
            // BrowseCTRL
            // 
            this.BrowseCTRL.AttributesListCollapsed = false;
            this.BrowseCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseCTRL.Location = new System.Drawing.Point(2, 2);
            this.BrowseCTRL.Name = "BrowseCTRL";
            this.BrowseCTRL.Size = new System.Drawing.Size(880, 400);
            this.BrowseCTRL.SplitterDistance = 387;
            this.BrowseCTRL.TabIndex = 0;
            this.BrowseCTRL.View = null;
            // 
            // ConnectServerCTRL
            // 
            this.ConnectServerCTRL.Configuration = null;
            this.ConnectServerCTRL.DisableDomainCheck = false;
            this.ConnectServerCTRL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectServerCTRL.Location = new System.Drawing.Point(0, 99);
            this.ConnectServerCTRL.MaximumSize = new System.Drawing.Size(2048, 23);
            this.ConnectServerCTRL.MinimumSize = new System.Drawing.Size(500, 23);
            this.ConnectServerCTRL.Name = "ConnectServerCTRL";
            this.ConnectServerCTRL.PreferredLocales = null;
            this.ConnectServerCTRL.ServerUrl = "";
            this.ConnectServerCTRL.SessionName = null;
            this.ConnectServerCTRL.Size = new System.Drawing.Size(884, 23);
            this.ConnectServerCTRL.StatusStrip = this.StatusBar;
            this.ConnectServerCTRL.TabIndex = 4;
            this.ConnectServerCTRL.UserIdentity = null;
            this.ConnectServerCTRL.UseSecurity = true;
            this.ConnectServerCTRL.ConnectComplete += new System.EventHandler(this.Server_ConnectComplete);
            this.ConnectServerCTRL.ReconnectStarting += new System.EventHandler(this.Server_ReconnectStarting);
            this.ConnectServerCTRL.ReconnectComplete += new System.EventHandler(this.Server_ReconnectComplete);
            // 
            // clientHeaderBranding1
            // 
            this.clientHeaderBranding1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientHeaderBranding1.Location = new System.Drawing.Point(0, 24);
            this.clientHeaderBranding1.MaximumSize = new System.Drawing.Size(0, 75);
            this.clientHeaderBranding1.MinimumSize = new System.Drawing.Size(500, 75);
            this.clientHeaderBranding1.Name = "clientHeaderBranding1";
            this.clientHeaderBranding1.Size = new System.Drawing.Size(884, 75);
            this.clientHeaderBranding1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 546);
            this.Controls.Add(this.MainPN);
            this.Controls.Add(this.ConnectServerCTRL);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.clientHeaderBranding1);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.Text = "Quickstart Empty Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.MainPN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripMenuItem ServerMI;
        private System.Windows.Forms.ToolStripMenuItem Server_DiscoverMI;
        private System.Windows.Forms.ToolStripMenuItem Server_ConnectMI;
        private System.Windows.Forms.ToolStripMenuItem Server_DisconnectMI;
        private System.Windows.Forms.Panel MainPN;
        private System.Windows.Forms.ToolStripMenuItem HelpMI;
        private System.Windows.Forms.ToolStripMenuItem Help_ContentsMI;
        private Opc.Ua.Client.Controls.ConnectServerCtrl ConnectServerCTRL;
        private Opc.Ua.Client.Controls.BrowseNodeCtrl BrowseCTRL;
        private Opc.Ua.Client.Controls.HeaderBranding clientHeaderBranding1;
    }
}
