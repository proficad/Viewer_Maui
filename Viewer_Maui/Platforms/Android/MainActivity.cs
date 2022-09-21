#nullable enable

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
        //int o = 5;
    }

    protected override void OnCreate(Bundle? savedInstanceState)
    {

        base.OnCreate(savedInstanceState);//it crashes here


        if (Intent?.Data is not null)
        {
            Android.Net.Uri uri = Intent.Data;

            if (ContentResolver is not null)
            {
                MyContext.m_stream = ContentResolver.OpenInputStream(uri);
            }

        }


    }
}
