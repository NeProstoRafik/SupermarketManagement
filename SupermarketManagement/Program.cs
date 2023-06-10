using Microsoft.EntityFrameworkCore;
using Plugins.DataStore;
using Plugins.SQL;
using SupermarketManagement.Data;
using UseCases;
using UseCases.CategoriesUseCases;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;
using UseCases.ProductUseCases;

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
            builder.Services.AddScoped<IProductRepository, ProductInMemoryRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
            builder.Services.AddScoped<ITransactionRepository, TransactionInMemoryRepository>();


            builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            builder.Services.AddTransient<IAddCategoryCase, AddCategoryCase>();
            builder.Services.AddTransient<IEditCategoryCase, EditCategoryCase>();
            builder.Services.AddTransient<IGetCategoryByIdCase, GetCategoryByIdCase>();
            builder.Services.AddTransient<IDeleteCategoryCase, DeleteCategoryCase>();
            builder.Services.AddTransient<IViewProductCase, ViewProductCase>();
            builder.Services.AddTransient<IAddProductCase, AddProductCase>();
            builder.Services.AddTransient<IEditProductCase, EditProductCase>();
            builder.Services.AddTransient<IGetProductByIdCase, GetProductByIdCase>();
            builder.Services.AddTransient<IDeleteProductCase, DeleteProductCase>();
            builder.Services.AddTransient<IViewProductByCategoryId, ViewProductByCategoryId>();
            builder.Services.AddTransient<ISellProductCase, SellProductCase>();
            builder.Services.AddTransient<IRecordTransactionUseCase, RecordTransactionUseCase>();
            builder.Services.AddTransient<IGetTodayTransactionUseCase, GetTodayTransactionUseCase>();
            builder.Services.AddTransient<IGetTransactionUseCase, GetTransactionUseCase>();

            builder.Services.AddDbContext<Context>(options =>
             {
                 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
             });

            var app = builder.Build();

          

            //var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");
            //builder.Services.AddDbContext<Context>(options =>
            //options.UseSqlServer(connectionStrings));


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