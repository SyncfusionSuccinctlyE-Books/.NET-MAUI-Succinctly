using Microsoft.Maui.LifecycleEvents;

namespace Chapter10_AppLifecycle;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).
            ConfigureLifecycleEvents(events =>
            {
#if ANDROID
				events.AddAndroid(android => 
					android.OnBackPressed((activity) => 
						{ return false; }));
#endif
            }); 

		return builder.Build();
	}
}
