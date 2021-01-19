# Unit-Test-Solution

This is a unit test to automate Vlc player using WinAppDriver within visual studio 2019 using C#

To view all the code for the test , please make sure you are in the master branch.


The WinAppDriver was downloaded and installed on my local machine and then we have to open the WinAppDriver.exe file found under your program files location,  to start the server.

Once that is started you can easily run the unit test code from visual studio 2019 IDE.
Without the WinAppDriver installed , one cannot run the automation tests included in this project.

Appium web driver package was also installed from the nuget package manager within visual studio 2019

There were various packages used in this project as shown in the code file provided.



The code snippet below is written to run the unit tests needed for the project.This also illustrates how the unit tests were designed and built out using C# within Visual Studio IDE 2019.


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindowsDriver<WindowsElement> myDriver = null;
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", @"C:\Program Files\VideoLAN\VLC\vlc.exe");

            myDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
            myDriver.Manage().Window.Maximize();


            myDriver.FindElementByClassName("Media").Click();


}
}
}


To run the unit tests make sure to right click on the UnitTest1.cs code file and select run tests
This will run the tests and then open vlc player via the drivers installed and code written.


Template design pattern was followed during this project , In the superclass, it determines the skeleton of an algorithm, but allows subclasses to bypass particular algorithm steps without modifying its structure. The pattern is readable and consistent , easy to identify different parts of the code. It will only fail when a bug has been introduced and this pattern clearly shows which scenario is being tested and when.


