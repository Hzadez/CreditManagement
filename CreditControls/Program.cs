using CreditControls.Data;
using CreditControls.Repostories.Implamentation;
using CreditControls.Repostories.Interfaces;
using CreditControls.Services.Implamentation;
using CreditControls.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CreditControls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CreditControlsDb>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            builder.Services.AddScoped(typeof(IGenericRepostory<>), typeof(GenericRepostory<>));
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
        
            app.MapControllerRoute(
                name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
