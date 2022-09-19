using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;

namespace Viewer_Maui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Intent.ActionView }, Categories = new[] { Intent.CategoryDefault,Intent.CategoryDefault,
            Intent.CategoryBrowsable }, DataMimeType = "application/*", DataPathPattern = ".*\\.sxe")]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnNewIntent(Intent? intent)
    {
        int o = 5;
    }

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        int u = 5;

        if (Intent.Type == "text/plain" && Intent.Action == "android.intent.action.SEND")
        {
            //handleSendUrl();
            int yy = 88;
        }

        //Viewer_Maui.App myApp = (Viewer_Maui.App)Viewer_Maui.MainApplication.Current.Application;

 
        
        base.OnCreate(savedInstanceState);
    }
}
