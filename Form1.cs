using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TestCef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://hao123.com");


            panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
