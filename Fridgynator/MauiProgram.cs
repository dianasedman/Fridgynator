using CommunityToolkit.Maui;
using Fridgynator.Models;
using Fridgynator.Repositories;
using Fridgynator.ViewModels;
using Fridgynator.Views;

namespace Fridgynator;

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
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//register DI for Views and ViewModels

		builder.Services.AddSingleton<Products>();
		builder.Services.AddSingleton<AddProductViewModel>();
		builder.Services.AddSingleton<FridgeViewModel>();

		// setup DB
		var dbName = "ProductsDatabase.db";
		var dbPath = FileAccessHelper.GetLocalFilePath(dbName);
		builder.Services.AddSingleton<ProductsRepository>(s => ActivatorUtilities.CreateInstance<ProductsRepository>(s, dbPath));
		


        return builder.Build();
	}
}
