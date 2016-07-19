using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.ObjectModel;

namespace JoesCafeLibrary
{
    public class Core
    {
        #region Fields
        IWebDriver _driver;
        private By txtbox = By.Name("txtBillAmt");
        private By highlight = By.Name("showVeg");
        private By button = By.Id("calcBill");
        private By tableRow = By.TagName("tr");
        private By item0 = By.Name("item0");
        private By item1 = By.Name("item1");
        private By item2 = By.Name("item2");
        private By item3 = By.Name("item3");
        private By item4 = By.Name("item4");
        private By item5 = By.Name("item5");
        private By item6 = By.Name("item6");
        private By item7 = By.Name("item7");
        private By item8 = By.Name("item8");
        private By item9 = By.Name("item9");
        private By item10 = By.Name("item10");
        private By item11 = By.Name("item11");
        private By item12 = By.Name("item12");
        private By item13 = By.Name("item13");
        string applicationPath = "file:///D:/Lynda.com-Classes/Ex_Files_XMLEssT/Exercise%20Files/05_dom/JoesCafe.html";
        #endregion
        public Core(IWebDriver d)
        {
            this._driver = d;
        }             
        public void Open()
        {
            _driver.Navigate().GoToUrl(applicationPath);
        }
        public void Kill()
        {
            _driver.Close();
        }
        #region CheckBoxes
        public void SelectPotatoSalad()
        {
            if(!_driver.FindElement(item0).Selected)
            {
                _driver.FindElement(item0).Click();
            }
        }
        public void SelectJoesFrenchFries()
        {
            if (!_driver.FindElement(item1).Selected)
            {
                _driver.FindElement(item1).Click();
            }
        }
        public void SelectHuevosRancheros()
        {
            if (!_driver.FindElement(item2).Selected)
            {
                _driver.FindElement(item2).Click();
            }
        }
        public void SelectTwoEggsAnyStyle()
        {
            if (!_driver.FindElement(item3).Selected)
            {
                _driver.FindElement(item3).Click();
            }
        }
        public void SelectJoesFamousPeppersAndEggs()
        {
            if (!_driver.FindElement(item4).Selected)
            {
                _driver.FindElement(item4).Click();
            }
        }
        public void SelectBowlOfFruit()
        {
            if (!_driver.FindElement(item5).Selected)
            {
                _driver.FindElement(item5).Click();
            }
        }
        public void SelectFrenchToast()
        {
            if (!_driver.FindElement(item6).Selected)
            {
                _driver.FindElement(item6).Click();
            }
        }
        public void SelectCroissant()
        {
            if (!_driver.FindElement(item7).Selected)
            {
                _driver.FindElement(item7).Click();
            }
        }
        public void SelectGrilledChickenSandwich()
        {
            if (!_driver.FindElement(item8).Selected)
            {
                _driver.FindElement(item8).Click();
            }
        }
        public void SelectTunaMelt()
        {
            if (!_driver.FindElement(item9).Selected)
            {
                _driver.FindElement(item9).Click();
            }
        }
        public void SelectPastaSalad()
        {
            if (!_driver.FindElement(item10).Selected)
            {
                _driver.FindElement(item10).Click();
            }
        }
        public void SelectNewYorkSteak()
        {
            if (!_driver.FindElement(item11).Selected)
            {
                _driver.FindElement(item11).Click();
            }
        }
        public void SelectChileanSeaBass()
        {
            if (!_driver.FindElement(item12).Selected)
            {
                _driver.FindElement(item12).Click();
            }
        }
        public void SelectLinguiniwithGrilledPorciniMushroom()
        {
            if (!_driver.FindElement(item13).Selected)
            {
                _driver.FindElement(item13).Click();
            }
        }
        #endregion
        public void ClickCalculateBillButton()
        {
            _driver.FindElement(button).Click();     
        }
        public void HighlightVegetarianMeals()
        {  
             if (!_driver.FindElement(highlight).Selected)
                {
                _driver.FindElement(highlight).Click();
                }        
        }
        public string GetTotalResult()
        {
          return _driver.FindElement(txtbox).GetAttribute("value");
        }
        public void SelectAllItems()
        {
            By[] items =
                {item0, item1,item2,item3,item4,item5,item6,item7,item8,item9,item10,
            item11,item12,item13};
            foreach (By item in items)
            {
                if (!_driver.FindElement(item).Selected)
                {
                    _driver.FindElement(item).Click();
                }
            }
        }
        public int NumberOfVegetarianMeals()
        {
            int veggiMealcounter = 0;     
                ReadOnlyCollection<IWebElement> allMeals = _driver.FindElements(tableRow);
                foreach (IWebElement meal in allMeals)
                {
                    if (meal.GetAttribute("vegetarian") == "true")
                    {
                        veggiMealcounter++;
                    }
                }           
            return veggiMealcounter;
        }
    }
}
