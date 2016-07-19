using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoesCafeLibrary;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace JoesCafeTestPlans
{
    [TestClass]
    public class TestCases
    {   
        [TestMethod]
        public void BowlOfFruitShouldBe4DollarsAnd99CentsInGoogleChrome()
        {
            Core app = new Core(new ChromeDriver());
            app.Open();
            app.ClickCalculateBillButton();
            Thread.Sleep(2000);
            string actual = app.GetTotalResult();
            string expected = "0";
            Assert.AreEqual(expected, actual);
            app.Kill();
        }
        [TestMethod]
        public void VegetarianMealsShouldEqualFiveInGoogleChrome()
        {
            Core app = new Core(new ChromeDriver());
            app.Open();
            int actual = app.NumberOfVegetarianMeals();
            int expected = 5;
            Assert.AreEqual(expected, actual);
            app.Kill();
        }
        [TestMethod]
        public void BowlOfFruitShouldBe4DollarsAnd99CentsInFireFox()
        {
            Core app = new Core(new FirefoxDriver());
            app.Open();
            app.ClickCalculateBillButton();
            //Thread.Sleep(2000);
            string actual = app.GetTotalResult();
            string expected = "0";
            Assert.AreEqual(expected, actual);
            app.Kill();
        }
        [TestMethod]
        public void VegetarianMealsShouldEqualFiveInFireFox()
        {
            Core app = new Core(new FirefoxDriver());
            app.Open();
            int actual = app.NumberOfVegetarianMeals();
            int expected = 5;
            Assert.AreEqual(expected, actual);
            app.Kill();
        }
        [TestMethod]
        public void CroissantAndFrenchToastShouldBe5And24()
        {
            Core app = new Core(new ChromeDriver());
            app.Open();
            app.SelectCroissant();
            app.SelectFrenchToast();
            app.ClickCalculateBillButton();
            string actual = app.GetTotalResult();
            Assert.AreEqual("5.24", actual);
            app.Kill();
        }
        [TestMethod]
        public void TotalMenuCostShouldBe78And6Cents()
        {
            Core app = new Core(new ChromeDriver());
            app.Open();
            app.SelectAllItems();
            app.ClickCalculateBillButton();
            string expected = "78.6";
            string actual = app.GetTotalResult();
            Assert.AreEqual(expected, actual);
            app.Kill();
        }
    }
}
