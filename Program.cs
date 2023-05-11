using Microsoft.EntityFrameworkCore;
using Purple_Buzz.DAL;

namespace Purple_Buzz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
			});
			var app = builder.Build();

			app.UseStaticFiles();
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
			app.Run();
		}
	}
}