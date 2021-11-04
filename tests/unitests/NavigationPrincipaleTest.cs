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
public class NavigationPrincipaleTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    // driver = new FirefoxDriver();
    // js = (IJavaScriptExecutor)driver;
    // vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void navigationPrincipaleChrome() {
        driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    navigationPrincipale(); 
  }

    [Test]
  public void navigationPrincipaleFirefox() {
        driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    navigationPrincipale(); 
  }

 private void navigationPrincipale() {
    driver.Navigate().GoToUrl("http://192.168.18.104/index.jsp");
    driver.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
    driver.FindElement(By.CssSelector("h2")).Click();
    Assert.That(driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("Bienvenue sur votre Banque en ligne !!!"));
    driver.FindElement(By.LinkText("Accès client")).Click();
    driver.FindElement(By.CssSelector("h3")).Click();
    Assert.That(driver.FindElement(By.CssSelector("h3")).Text, Is.EqualTo("Identification Client"));
    driver.FindElement(By.Id("authIdentifiant")).Click();
    var elements = driver.FindElements(By.Id("authIdentifiant"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.Id("authMotdepasse")).Click();
    var elements2 = driver.FindElements(By.Id("authMotdepasse"));
    Assert.True(elements2.Count > 0);
    var elements3 = driver.FindElements(By.CssSelector(".btn"));
    Assert.True(elements3.Count > 0);
    driver.FindElement(By.CssSelector("html")).Click();
    driver.FindElement(By.LinkText("Nous Contacter")).Click();
    driver.FindElement(By.CssSelector("h3")).Click();
    Assert.That(driver.FindElement(By.CssSelector("h3")).Text, Is.EqualTo("Nous contacter"));
    driver.Close();
  }
}