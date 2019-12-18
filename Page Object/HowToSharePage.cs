using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;

namespace Sel_2.Page_Object
{
	public class HowToSharePage
	{
		private IWebDriver driver;
		public string url = "https://www.bbc.com/news/10725415";
		public HowToSharePage(IWebDriver dr)
		{
			this.driver = dr;
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//input[contains(@name, 'fullName')]")]
		private IWebElement fullName;

		[FindsBy(How = How.XPath, Using = "//input[contains(@name, 'email')]")]
		private IWebElement email;

		[FindsBy(How = How.XPath, Using = "//input[contains(@name, 'town')]")]
		private IWebElement town;

		[FindsBy(How = How.XPath, Using = "//input[contains(@name, 'phone')]")]
		private IWebElement phone;

		[FindsBy(How = How.XPath, Using = "//textarea[contains(@name, 'message')]")]
		private IWebElement comment;

		[FindsBy(How = How.XPath, Using = "//input[contains(@type,'submit')]")]
		private IWebElement sendHistory;

		public void PushName(string name)
		{
			fullName.SendKeys(name);
		}

		public void PushEmail(string email)
		{
			this.email.SendKeys(email);
		}

		public void PushTown(string tow)
		{
			town.SendKeys(tow);
		}

		public void PushPhone(string telephone)
		{
			phone.SendKeys(telephone);
		}

		public void PushComment(string com)
		{
			comment.SendKeys(com);
		}

		public void SendHistory()
		{
			sendHistory.Click();
		}

		public void FillForm(Dictionary<string, string> dictionary)
		{
			string str;
			foreach (string key in dictionary.Keys)
			{
				string teg;
				if (key == "message")
				{
					teg = "textarea";
				}
				else
				{
					teg = "input";
				}

				str = String.Format("//label[contains(@for, '{0}')]/following-sibling::{1}", key, teg);
				IWebElement field = driver.FindElement(By.XPath(str)); 
				field.SendKeys(dictionary[key]);
				
			}
		}
	}
}