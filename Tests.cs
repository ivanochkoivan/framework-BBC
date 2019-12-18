using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Sel_2.Page_Object;


namespace Sel_2
{
	[TestFixture]
	public class Tests
	{
		private IWebDriver Mozila;

		[SetUp]
		public void SetUp()
		{
			Mozila = new FirefoxDriver();
			Mozila.Manage().Window.Maximize();
		}

		[Test]
		public void Test1()
		{
			Dictionary<string, string> form = new Dictionary<string, string>();
			form.Add("fullName", "Ivan");
			form.Add("email", "exapleemail@gmail.com");
			form.Add("town", "New York");
			form.Add("phone", "+3809678265480");
			form.Add("message",
				"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean mollis arcu quis augue consequat tempor. Nunc facilisis condimentum eros vitae porttitor. In hac habitasse platea dictumst. Sed aliquam sem gravida, vulputate lectus quis, condimentum nunc. Ut lobortis purus ac dui sagittis mattis. Etiam rutrum bibendum cursus. Praesent consectetur suscipit auctor. Donec quis tellus tincidunt, dapibus purus a, bibendum massa. In ut dui sem. Aliquam a quam neque. Donec tincidunt mi id lorem varius tincidunt. Aenean imperdiet tortor vel sagittis lacinia. Ut eget ligula metus. Suspendisse sed fermentum felis, quis lobortis ipsum. Maecenas tortor ipsum, porttitor ullamcorper convallis eget, tincidunt a.");
			BLL SubmitQuestion = new BLL(Mozila);
			SubmitQuestion.SubmitQuestionBBC(form);
		}

		[Test]
		public void Test2()
		{
			Dictionary<string, string> form = new Dictionary<string, string>();
			form.Add("fullName", "Ivan");
			form.Add("email", "exapleemail@gmail.com");
			form.Add("town", "New York");
			form.Add("phone", "+3809678265480");
			form.Add("message", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed velit quam, varius nec leo sed, convallis lacinia lectus. Duis metus libero, semper mollis ultricies non, mollis a enim. Etiam euismod, eros non vestibulum porta, turpis ex feugiat urna, tincidunt volutpat lacus metus eu nisl. Maecenas vehicula pharetra nisl ac sagittis. Morbi nulla risus, molestie sit amet ligula in, consequat dapibus eros. Maecenas vitae luctus augue. Pellentesque diam nisi, commodo sit amet mattis sodales, laoreet eget neque. Duis tempus elit vel ligula tristique tincidunt. Praesent ultricies nulla neque, a convallis eros hendrerit ac. Integer nisl justo, pretium vel felis vel, semper aliquam nisi. Nulla facilisi. Sed commodo tellus eu malesuada tincidunt. Aenean venenatis augue at diam consectetur, et pellentesque diam dapibus. Morbi aliquam sodales ex. In eleifend enim urna, et dictum nisl cursus et. Aliquam consectetur sem laoreet, imperdiet risus nec, pretium lectus. Nam ac finibus est. Integer commodo, neque eu commodo scelerisque, elit lorem varius erat, id sagittis sem lorem quis dui. Fusce efficitur blandit pharetra. Cras arcu erat, maximus et elit eu, lobortis dignissim orci. Phasellus consequat nulla quis enim pulvinar, a rhoncus sem posuere. Donec eget quam eget nisi rutrum consectetur. Aliquam erat volutpat. Donec efficitur laoreet efficitur. ");
			BLL SubmitQuestion = new BLL(Mozila);
			SubmitQuestion.SubmitQuestionBBC(form);
		}
		
		[Test]
		public void Test3() 
		{
			Dictionary<string, string> form = new Dictionary<string, string>();
			form.Add("fullName", "Ivan");
			form.Add("town", "New York");
			form.Add("phone", "+3809678265480");
			form.Add("message", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean mollis arcu quis augue consequat tempor. Nunc facilisis condimentum eros vitae porttitor. In hac habitasse platea dictumst. Sed aliquam sem gravida, vulputate lectus quis, condimentum nunc. Ut lobortis purus ac dui sagittis mattis. Etiam rutrum bibendum cursus. Praesent consectetur suscipit auctor. Donec quis tellus tincidunt, dapibus purus a, bibendum massa. In ut dui sem. Aliquam a quam neque. Donec tincidunt mi id lorem varius tincidunt. Aenean imperdiet tortor vel sagittis lacinia. Ut eget ligula metus. Suspendisse sed fermentum felis, quis lobortis ipsum. Maecenas tortor ipsum, porttitor ullamcorper convallis eget, tincidunt a.");
			BLL SubmitQuestion = new BLL(Mozila);
			SubmitQuestion.SubmitQuestionBBC(form);
			/*if (Mozila.Url == share.url)
			{
				Assert.Pass();
			}
			else
			{
				Assert.Fail();
			}*/
		}
	}
}