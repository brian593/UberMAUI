using System;
using CloneUber.Services;
using CloneUber.ViewModels;
using CloneUber.Views.Landing;
using CloneUber.Views.Register;
using Material.Components.Maui.Extensions;

namespace CloneUber.Extensions
{
	public static class MauiAppBuilderExtensions
	{
		public static void ConfigureUber(this MauiAppBuilder builder)
		{
			builder.Services.AddSingleton<INavigationService, NavigationService>();


			builder.Services.AddTransient<StartPageVM>();
			builder.Services.AddTransient<StartPage>();

            builder.Services.AddTransient<CreateAccountPageVM>();
            builder.Services.AddTransient<CreateAccountPage>();

            builder.Services.AddTransient<CompleteRegistrationPageVM>();
            builder.Services.AddTransient<CompleteRegistrationPage>();

            builder.Services.AddTransient<VerificationCodePageVM>();
            builder.Services.AddTransient<VerificationCodePage>();

            builder.Services.AddTransient<AccountPageVM>();
            builder.Services.AddTransient<AccountPage>();

            builder.Services.AddTransient<ActivityPageVM>();
            builder.Services.AddTransient<ActivityPage>();

            builder.Services.AddTransient<HomePageVM>();
            builder.Services.AddTransient<HomePage>();

            builder.Services.AddTransient<ServicesPageVM>();
            builder.Services.AddTransient<ServicesPage>();

            builder
           .UseMaterialComponents();

        }
	}
}

