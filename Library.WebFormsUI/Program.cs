using Library.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Library.WebFormsUI
{

	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Ensure SetBasePath is recognized
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
			var services = new ServiceCollection();
			services.AddDbContext<LibraryContext>(options =>
		    	options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
			
			services.AddScoped<IBookService, BookManager>();
			services.AddScoped<IBookRepository, EfBookRepository>();
			IConfiguration configuration = builder.Build();

			var services = new ServiceCollection();
			services.AddDbContext<LibraryContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("Data Source=DESKTOP-P8VVFDN;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True")));
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new LoginForm());
		}
	}
}
