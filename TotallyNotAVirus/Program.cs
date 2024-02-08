using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

int totalCores = Environment.ProcessorCount;

for(int i=0; i < totalCores; i++)
{
    new Thread(new ThreadStart(loopForever)).Start();
}


static void loopForever()
{
    while (true)
    {
        runOnce();
    }
}

static void runOnce()
{
    EdgeOptions edgeOptions = new EdgeOptions();
    ChromeOptions chromeOptions = new ChromeOptions();//

    IWebDriver driver = new EdgeDriver(edgeOptions);
    driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[1]/div[2]/div/div/ytd-player/div/div")).Click();
}

