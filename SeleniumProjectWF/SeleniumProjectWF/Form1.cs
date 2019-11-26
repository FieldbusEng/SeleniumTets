using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProjectWF
{
    public partial class Form1 : Form
    {
        public IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
            textUrl.Text = "https://careers.veeam.com/";
            textCountry.Text = "Romania";
            textLang.Text = "English";
            textExpQ.Text = "10";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
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
            else {
                MessageBox.Show("Please fill text Boxes");
            }

        }
       
        bool methodCheckTextBox()
        {
            if (textUrl.TextLength > 10 && textCountry.TextLength > 3 && textLang.TextLength > 3 && textExpQ.TextLength > 0)
            { return true; }
            else { return false; }
        }

        public void methodFindCountry()
        {
            // Country
            var findCountry = Browser.FindElement(By.CssSelector("dd[id='country-element']"));
            findCountry.Click();
            string countryChoose = "span[data-value='" + textCountry.Text + "']";
            var findCountry1 = Browser.FindElement(By.CssSelector(countryChoose));
            findCountry1.Click();
            // Language
            var findLang = Browser.FindElement(By.CssSelector("div[id='language']"));
            findLang.Click();
            Thread.Sleep(2000);

            string langChoose = "span[data-value='" + textLang.Text + "']";
            var findLang1 = Browser.FindElement(By.CssSelector("label[for='ch-7']"));
            findLang1.Click();



        }

        private void butCountry_Click(object sender, EventArgs e)
        {
            methodFindCountry();
        }
    }
}
