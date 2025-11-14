using BeeBuzz.Data.Entities;
using BeeBuzz.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Dutch_Treat.Data;

namespace WebBookingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // MVC + Razor
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();


            builder.Services.AddTransient<BeebuzzSeeder>();

            var app = builder.Build();

            RunSeeding(app);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
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
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
        private static void RunSeeding(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var seeder = scope.ServiceProvider.GetRequiredService<BeebuzzSeeder>();
            seeder.Seed();
        }
    }
}

//using BeeBuzz.Data;
//using BeeBuzz.Data.Entities;
//using Dutch_Treat.Data;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString)
//            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//// register customizeble user
//builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
//               .AddEntityFrameworkStores<ApplicationDbContext>()
//               .AddDefaultTokenProviders();

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//// register seeder
//builder.Services.AddTransient<BeebuzzSeeder>();


//var app = builder.Build();

//RunSeeding(app);


//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();

// void RunSeeding(IHost host)
//{
//    using var scope = host.Services.CreateScope();
//    var seeder = scope.ServiceProvider.GetRequiredService<BeebuzzSeeder>();
//    seeder.Seed();
//}