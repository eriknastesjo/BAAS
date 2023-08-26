﻿using BAAS.Model;
using BAAS.Services;
using BAAS.View;
using BAAS.ViewModel;
using Microsoft.Extensions.Logging;

namespace BAAS
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FamiljenGrotesk-Regular.ttf", "FamiljenGroteskRegular");
                    fonts.AddFont("FamiljenGrotesk-SemiBold.ttf", "FamiljenGroteskSemibold");
                }); 

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<SubmarineService>();
            builder.Services.AddSingleton<SubmarineViewModel>();
            builder.Services.AddSingleton<MySubmarines>();
            return builder.Build();
        }
    }
}