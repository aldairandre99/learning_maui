using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MauiApp1.ViewModel;

namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		}).UseMauiCommunityToolkit();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModal>();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}