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
        }

        private void InitilizeBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://www.google.com");
            browser.Dock = DockStyle.Fill;
            BrowserTabs.TabPages[0].Controls.Add(browser);
            browser.AddressChanged += Browser_AddressChanged;
        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }

        private void toolStripButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                browser.Load(toolStripAdressBar.Text);
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
            var newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            BrowserTabs.TabPages.Add(newTabPage);
        }
    }
}
