using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    ChromeOptions chromeOptions = new ChromeOptions();//

    IWebDriver driver = new ChromeDriver(chromeOptions);
    driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[1]/div[2]/div/div/ytd-player/div/div")).Click();
}

