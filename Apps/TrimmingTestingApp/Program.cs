using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

Console.WriteLine("Hello, World!");

AppCenter.Start("appsecret", typeof(Crashes), typeof(Analytics));