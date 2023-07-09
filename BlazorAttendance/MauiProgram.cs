using Microsoft.Extensions.Logging;
using BlazorAttendance.Data;
using BlazorAttendance.Services;

namespace BlazorAttendance;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IStudentService, StudentService>();
        builder.Services.AddSingleton<IAttendanceService, AttendanceService>();
        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
