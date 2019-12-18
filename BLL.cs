using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sel_2.Page_Object;

namespace Sel_2
{
	public class BLL
	{
		private IWebDriver driver;
		public BLL(IWebDriver driver)
		{
			this.driver = driver;
		}
		public void SubmitQuestionBBC(Dictionary<string, string> FormContent)
		{
			HomePage bbc = new HomePage(driver);
			bbc.Navigate();
			NewsPage news = bbc.NewsClick();
			HaveYourSayPage HaveSay = news.HaveYourSayClick();
			HowToSharePage share = HaveSay.HowToShareClick();
			share.FillForm(FormContent);
			//share.SendHistory();
		}

		
	}
}