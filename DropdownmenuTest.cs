// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DropdownmenuTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void dropdownmenu() {
    driver.Navigate().GoToUrl("https://www.webhallen.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    {
      var element = driver.FindElement(By.LinkText("Spel"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements = driver.FindElements(By.CssSelector(".root:nth-child(1) h2"));
    Assert.True(elements.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Gaming"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements1 = driver.FindElements(By.CssSelector(".root:nth-child(2) h2"));
    Assert.True(elements1.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Datorer & Tillbehör"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements2 = driver.FindElements(By.CssSelector(".root:nth-child(3) h2"));
    Assert.True(elements2.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Datorkomponenter"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements3 = driver.FindElements(By.CssSelector(".root:nth-child(4) h2"));
    Assert.True(elements3.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Nätverk & Smarta Hem"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements4 = driver.FindElements(By.CssSelector(".root:nth-child(5) h2"));
    Assert.True(elements4.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("TV, Ljud & Bild"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements5 = driver.FindElements(By.CssSelector(".root:nth-child(6) h2"));
    Assert.True(elements5.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Apple"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements6 = driver.FindElements(By.CssSelector(".root:nth-child(7) h2"));
    Assert.True(elements6.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Mobil"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements7 = driver.FindElements(By.CssSelector(".root:nth-child(8) h2"));
    Assert.True(elements7.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Hem & Hälsa"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements8 = driver.FindElements(By.CssSelector(".root:nth-child(9) h2"));
    Assert.True(elements8.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Leksaker & Hobby"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements9 = driver.FindElements(By.CssSelector(".root:nth-child(10) h2"));
    Assert.True(elements9.Count > 0);
    {
      var element = driver.FindElement(By.LinkText("Fyndvaror"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    var elements10 = driver.FindElements(By.CssSelector(".root:nth-child(11) h2"));
    Assert.True(elements10.Count > 0);

    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    driver.Manage().Cookies.DeleteAllCookies();
    
    }
}
