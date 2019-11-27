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
            textExpQ.Text = "10";
            methodInitComboBox();
                      
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttSelect_Click(object sender, EventArgs e)
        {
            methodFindCountry();
        }

        private void buttBrowser_Click(object sender, EventArgs e)
        {

            if(!methodCheckTextBox())
            {
                MessageBox.Show("Please enter Correct data");
                return;
            }

            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            try
             {
               Browser.Navigate().GoToUrl(textUrl.Text);
             }
            catch (Exception ee)
             {
               MessageBox.Show("exception : " + ee);
                return;
             }

            Browser

            // Language
            var findLang = Browser.FindElement(By.CssSelector("div[id='language']"));
            findLang.Click();
            Thread.Sleep(300);
            string langChoose = "span[data-value='" + comboLang.SelectedValue + "']";
            var findLang1 = Browser.FindElement(By.CssSelector("label[for='ch-7']"));
            findLang1.Click();
            Thread.Sleep(300);

            // Country
            var findCountry = Browser.FindElement(By.CssSelector("dd[id='country-element']"));
            findCountry.Click();
            Thread.Sleep(300);
            string countryChoose = "span[data-value='" + comboCountry.Text + "']";
            var findCountry1 = Browser.FindElement(By.CssSelector(countryChoose));
            findCountry1.Click();




        }

        void methodInitComboBox()
        {

            List<ComboClass> itemsCount = new List<ComboClass>();
            itemsCount.Add(new ComboClass() { ID = "1", Text = "Romania" });
            itemsCount.Add(new ComboClass() { ID = "2", Text = "Czech Republic" });
            itemsCount.Add(new ComboClass() { ID = "3", Text = "Russia" });
            itemsCount.Add(new ComboClass() { ID = "4", Text = "Germany" });

            comboCountry.DataSource = itemsCount;
            comboCountry.DisplayMember = "Text";
            comboCountry.ValueMember = "ID";

            List<ComboClass> itemsLang = new List<ComboClass>();
            itemsLang.Add(new ComboClass() { ID = "1", Text = "English" });
            itemsLang.Add(new ComboClass() { ID = "2", Text = "Czech" });
            itemsLang.Add(new ComboClass() { ID = "3", Text = "Russian" });
            itemsLang.Add(new ComboClass() { ID = "4", Text = "German" });

            comboLang.DataSource = itemsLang;
            comboLang.DisplayMember = "Text";
            comboLang.ValueMember = "ID";
        }
       
        bool methodCheckTextBox()
        {
            try
            {
                int expectedVac = Convert.ToInt32(textExpQ.Text);
                if (expectedVac > 1 && expectedVac <= 1000)
                {

                }
                else
                {
                    MessageBox.Show("Please enter number from 1-1000");
                    textExpQ.Text = "Please enter number from 1-1000";
                    return false;
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter number from 1-1000");
                textExpQ.Text = "Please enter number from 1-1000";
                return false;
            }
            return true;
            //if (textUrl.TextLength > 10  && (comboLang.Text=="English") && (comboCountry.Text=="Romania"))
            //{ return true; }
            //else { return false; }
        }

        public void methodFindCountry()
        {
            // Language
            var findLang = Browser.FindElement(By.CssSelector("div[id='language']"));
            findLang.Click();
            Thread.Sleep(300);
            string langChoose = "span[data-value='" + comboLang.SelectedValue + "']";
            var findLang1 = Browser.FindElement(By.CssSelector("label[for='ch-7']"));
            findLang1.Click();
            Thread.Sleep(300);

            // Country
            var findCountry = Browser.FindElement(By.CssSelector("dd[id='country-element']"));
            findCountry.Click();
            Thread.Sleep(300);
            string countryChoose = "span[data-value='" + comboCountry.Text + "']";
            var findCountry1 = Browser.FindElement(By.CssSelector(countryChoose));
            findCountry1.Click();
            



        }
               
    }
}
