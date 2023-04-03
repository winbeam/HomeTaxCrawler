using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace cscwl;

public class Cwlr
{
	private IWebDriver _webDriver;

	public Cwlr()
	{
		new DriverManager().SetUpDriver(new ChromeConfig());
		_webDriver = new ChromeDriver();
	}

	~Cwlr()
	{
		Quit();
	}
	public void Quit()
	{
		_webDriver.Quit();
	}

	public void Test()
	{
		_webDriver.Navigate().GoToUrl("https://www.google.com");
		var aa = _webDriver.Title.Contains("Google");
	}
	public void Test2()
	{
		_webDriver.Navigate().GoToUrl("https://hometax.go.kr");
		var aa = _webDriver.Title.Contains("hometax");
		var trigger = _webDriver.FindElement(By.Id("textbox81212912"));

		trigger.Click();

		var iframe = _webDriver.FindElement(By.Id("txppIframe"));

		_webDriver.SwitchTo().Frame(iframe);
		_webDriver.FindElement(By.Id("anchor14")).Click();
		_webDriver.FindElement(By.Id("anchor23")).Click();






	}
}


