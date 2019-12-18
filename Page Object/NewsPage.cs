using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Sel_2.Page_Object
{
	public class NewsPage
	{
		private IWebDriver driver;

		public NewsPage(IWebDriver dr)
		{
			this.driver = dr;
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//button[contains(@type, 'button')]/descendant::span[text()='More']")]
		private IWebElement More;

		[FindsBy(How = How.XPath, Using = "//span[text() = 'Have Your Say']")]
		private IWebElement HaveYourSay;

		public HaveYourSayPage HaveYourSayClick()
		{
		    More.Click();
			HaveYourSay.Click();
			return new HaveYourSayPage(driver);
		}
	}
}