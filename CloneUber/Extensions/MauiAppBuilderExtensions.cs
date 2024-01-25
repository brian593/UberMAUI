using System;
using CloneUber.Services;
using CloneUber.ViewModels;
using CloneUber.Views.Register;

namespace CloneUber.Extensions
{
	public static class MauiAppBuilderExtensions
	{
		public static void ConfigureUber(this MauiAppBuilder builder)
		{
			builder.Services.AddSingleton<INavigationService, NavigationService>();


			builder.Services.AddTransient<StartPageVM>();
			builder.Services.AddTransient<StartPage>();

        }
	}
}

