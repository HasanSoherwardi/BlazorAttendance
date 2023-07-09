using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

//using Android.Telephony;

namespace BlazorAttendance;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{

    //public void sendSms(string mobile, string name, string Stdattendence)
    //{
    //    SmsManager.Default.SendTextMessage(mobile, null, "Dear Parents, Today " + name + " is " + Stdattendence, null, null);
    //}

}
