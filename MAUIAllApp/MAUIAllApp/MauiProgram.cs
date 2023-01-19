using CommunityToolkit.Maui;

namespace MAUIAllApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("JosefinSans-SemiBold.ttf", "Jose");
			});

		return builder.Build();
	}
}
