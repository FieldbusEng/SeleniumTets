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
                Browser.Close();
                return;
             }

            // wating for all searching
            Browser.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(15);
            // can test another way to handle waiting
            //WebDriverWait ww = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
            //IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[id='language']"));
            
            // Language
            var findLang = Browser.FindElement(By.CssSelector("div[id='language']"));
            findLang.Click();

            IList<IWebElement> elementsLang = Browser.FindElements(By.CssSelector("label[class='controls-checkbox']"));
            foreach (IWebElement item in elementsLang)
            {
                if (item.Text.Contains(comboLang.Text))
                {
                    try
                    {
                        item.Click();
                        break;
                    }
                    catch
                    {
                        return;
                    }
                    
                    
                }
                else
                {
                    textResult.Text ="Language not found";
                    return;
                }
            }

            //string langChoose = "span[data-value='" + comboLang.SelectedValue + "']";
            //var findLang1 = Browser.FindElement(By.CssSelector("label[for='ch-7']"));
            //findLang1.Click();
            
            //---------------------------------------------------------------------------

            // Country
            var findCountry = Browser.FindElement(By.CssSelector("dd[id='country-element']"));
            findCountry.Click();
            
            string countryChoose = "span[data-value='" + comboCountry.Text + "']";
            var findCountry1 = Browser.FindElement(By.CssSelector(countryChoose));
            findCountry1.Click();
            Thread.Sleep(5000);

            // Quantity of jobs
            IList<IWebElement> elementsH3 = Browser.FindElements(By.CssSelector("h3"));
            int countH3 = elementsH3.Count;
            foreach (IWebElement item in elementsH3)
            {
                if (item.Text.Contains("jobs found"))
                {
                    String iitem = item.Text;
                    char ch = ' ';
                    String[] splitStr = iitem.Trim().Split(ch);
                    textRealQ.Text = iitem;
                    int vacanNumber = Convert.ToInt32(splitStr[0]);

                    if (vacanNumber == Convert.ToInt32(textExpQ.Text))
                    {
                        textResult.Text = "Good - As expected";
                    }
                    else if (vacanNumber > Convert.ToInt32(textExpQ.Text))
                    {
                        textResult.Text = "Wrong - Real is Bigger than expected";
                    }
                    else if (vacanNumber < Convert.ToInt32(textExpQ.Text))
                    {
                        textResult.Text = "Wrong - Real is Lower than expected";
                    }
                    break;

                }
                                    
                else
                {
                    textRealQ.Text = "not found";
                }
            }

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
