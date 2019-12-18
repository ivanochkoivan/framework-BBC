using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Sel_2.Page_Object
{
	public class HaveYourSayPage
	{
		private IWebDriver driver;

		public HaveYourSayPage(IWebDriver dr)
		{
			this.driver = dr;
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//h3[text() = 'How to share with BBC News']/parent::a ")]
		private IWebElement HowToShare;

		public HowToSharePage HowToShareClick()
		{
			HowToShare.Click();
			return new HowToSharePage(driver);
		}
	}
}