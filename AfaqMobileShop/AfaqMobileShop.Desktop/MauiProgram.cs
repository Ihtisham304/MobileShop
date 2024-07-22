using AfaqMobileShop.Desktop.Data;
using Microsoft.Extensions.Logging;
using Radzen;

namespace AfaqMobileShop.Desktop
{
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
            builder.Services.AddRadzenComponents();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(ServerContext.ServerBaseUrl)
            });
            builder.Services.AddScoped<IServerContext, ServerContext>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<ContextMenuService>();
#endif

            return builder.Build();
        }
    }
}
