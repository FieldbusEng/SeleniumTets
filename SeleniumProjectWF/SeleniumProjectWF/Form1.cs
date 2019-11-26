using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace SeleniumProjectWF
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //https://careers.veeam.com/
            if (methodCheckTextBox())
            {
                Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
                Browser.Manage().Window.Maximize();
                try
                {
                    Browser.Navigate().GoToUrl(textUrl.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("exception : " + ee);
                }
                
            }

        }

        bool methodCheckTextBox()
        {
            if (textUrl.TextLength > 10 && textCountry.TextLength > 3 && textLang.TextLength > 3 && textExpQ.TextLength > 0)
            { return true; }
            else { return false; }
        }


    }
}
