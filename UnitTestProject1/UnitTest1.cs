using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

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





            FileInfo file = new FileInfo(@"C:\Users\praj9\Downloads\C#-embed-vlc.mp4");

            var currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            // Default installation path of VideoLAN.LibVLC.Windows
            var libDirectory =
                new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            using (var mediaPlayer = new Vlc.DotNet.Core.VlcMediaPlayer(libDirectory))
            {




                // var mediaOptions = new[]
                {
                    //    ":sout=#rtp{sdp=rtsp://192.168.1.7:8008/test.sdp}",
                    //  ":sout-keep"
                    // };

                    mediaPlayer.SetMedia(new Uri("https://www.youtube.com/watch?v=e7EStbS1TWk"));
                    //mediaOptions);

                    // mediaPlayer.SetMedia(file, mediaOptions);

                    mediaPlayer.Play(file);


                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }



            }
        }
    }
}
