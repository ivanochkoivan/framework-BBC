using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Sel_2.Page_Object
{
	public class HomePage
	{
		public IWebDriver driver;
		private string url = "https://www.bbc.com/";
		
		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//a[text()='News']")]
		private IWebElement News;


		public void Navigate()
		{
			this.driver.Navigate().GoToUrl(this.url);
		}

		public NewsPage NewsClick()
		{
			News.Click();
			return new NewsPage(driver);
		}

	}

	
}