using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SupermarketManagement.Data;
using UseCases.Interfaces;
using Plugins.DataStore;
using UseCases;

namespace SupermarketManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddSingleton<WeatherForecastService>();

			builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();

			builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            builder.Services.AddTransient<IAddCategoryCase, AddCategoryCase>();
            builder.Services.AddTransient<IEditCategoryCase, EditCategoryCase>();
            builder.Services.AddTransient<IGetCategoryByIdCase, GetCategoryByIdCase>();
            builder.Services.AddTransient<IDeleteCategoryCase, DeleteCategoryCase>();
            var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}