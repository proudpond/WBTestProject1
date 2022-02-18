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
public class VerifytheiconforsecurepaymentsTest {
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
  public void verifytheiconforsecurepayments() {
    driver.Navigate().GoToUrl("https://www.webhallen.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    var elements = driver.FindElements(By.CssSelector(".icon-column:nth-child(2) > .ximg:nth-child(1) > .ximg-content"));
    Assert.True(elements.Count > 0);
  }
}
