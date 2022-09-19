
using Microsoft.Maui.LifecycleEvents;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Viewer_Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.ConfigureLifecycleEvents(events =>
			{

#if ANDROID
				events.AddAndroid(android => android
				.OnCreate((activity, bundle) => LogEvent("OnCreate")));


                static void LogEvent(string eventName, string type = null)
                {
                    System.Diagnostics.Debug.WriteLine($"Lifecycle event: {eventName}{(type == null ? string.Empty : $" ({type})")}");
                }
#endif

            })
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
