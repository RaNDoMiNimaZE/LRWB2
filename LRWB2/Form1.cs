using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;

namespace LRWB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            if (webView != null && webView.CoreWebView2 != null && addressBar.Text != webView.CoreWebView2.Source) { addressBar.Text = webView.CoreWebView2.Source; }
        }

        private void CoreWebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            addressBar.Text = webView.CoreWebView2.Source;
        }


        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            AddTabButton.Left = this.ClientSize.Width - AddTabButton.Width - 55;
            addressBar.Width = goButton.Left - addressBar.Left- 100;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            goButton_Click(sender, e);
        }

        public void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (addressBar.Text.Contains("https:")) { webView.CoreWebView2.Navigate(addressBar.Text); }
                else { webView.CoreWebView2.Navigate("https://" + addressBar.Text); }
                addressBar.Text = webView.CoreWebView2.Source;
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                goButton_Click(sender, e);
        }

        private void AddTabButton_Click(object sender, EventArgs e)
        {
            Form1 nTab = new Form1();
            nTab.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Process c_p = System.Diagnostics.Process.GetCurrentProcess();
            float m_u = c_p.WorkingSet64;
            var mbUsed = (c_p.PrivateMemorySize64 / 1024) / 1024;
            RamLabel.Text = (m_u / 1000000).ToString();
        }

        private void Form1_SystemColorsChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Desktop;
        }
    }
}
