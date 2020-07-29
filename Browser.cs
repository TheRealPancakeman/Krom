using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Krom
{
    public partial class Browser : Form
    {
        public ChromiumWebBrowser browser;
        public Browser()
        {
            InitializeComponent();
            InitilizeBrowser();
            InitializeForm();

        }
        private void InitializeForm()
        {
            BrowserTabs.Height = ClientRectangle.Height - 25;
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitilizeBrowser()
        {
            Cef.Initialize(new CefSettings());
            BrowserTabs.TabPages[0].Dispose();
            AddBrowserTab();
        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }

        private void toolStripButtonEnter_Click(object sender, EventArgs e)
        {
            Navigate(toolStripAdressBar.Text);
        }
        private void Navigate(string address)
        {
            try
            {
                var slectedBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];
                slectedBrowser.Load(address);
            }
            catch
            {

            }
        }

        private void toolStripAdressBar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    browser.Load(toolStripAdressBar.Text);
                }
            }
            catch 
            {
                
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                toolStripAdressBar.Text = e.Address;
            }));
        }

        private void toolStripButtonReFresh_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void toolStripButtonAddTab_Click(object sender, EventArgs e)
        {
            AddBrowserTab();
        }
        private void AddBrowserTab()
        {
            //adding a tab
            var newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            // BrowserTabs.TabPages.Add(newTabPage);
            BrowserTabs.TabPages.Insert(BrowserTabs.TabPages.Count - 1, newTabPage);
            //adding browser
            browser = new ChromiumWebBrowser("https://www.google.com");
            browser.Dock = DockStyle.Fill;
            browser.TitleChanged += Browser_TitleChanged;
            browser.AddressChanged += Browser_AddressChanged;
            newTabPage.Controls.Add(browser);
            BrowserTabs.SelectedTab = newTabPage;
        }
        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            var selectedBrowser = (ChromiumWebBrowser)sender;
            this.Invoke(new MethodInvoker(() =>
            {
                selectedBrowser.Parent.Text = e.Title;
            }));
        }
        private void BrowserTabs_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tab Index Changed");
            if (BrowserTabs.SelectedTab == BrowserTabs.TabPages[BrowserTabs.TabPages.Count - 1])
            {
                AddBrowserTab();
                //select the latest browser tab
                BrowserTabs.SelectedTab = BrowserTabs.TabPages[BrowserTabs.TabPages.Count - 2];
            }
        }
    }
}
