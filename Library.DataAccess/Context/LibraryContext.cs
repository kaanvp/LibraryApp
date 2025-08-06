using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Context
{
	public class LibraryContext : DbContext
	{
		public LibraryContext(DbContextOptions<LibraryContext> options)
	   : base(options)
		{
		}

		public LibraryContext() : base() { }

		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Borrow> Borrows { get; set; }
		public DbSet<TransactionLog> TransactionLogs { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-P8VVFDN;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Borrow>()
				.HasOne(b => b.Book)
				.WithMany(b => b.Borrows)
				.HasForeignKey(b => b.BookId);

			modelBuilder.Entity<Borrow>()
				.HasOne(b => b.User)
				.WithMany(u => u.Borrows)
				.HasForeignKey(b => b.UserId);
		}
		public class LibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
		{
			public LibraryContext CreateDbContext(string[] args)
			{
				IConfigurationRoot configuration = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json")
					.Build();

				var builder = new DbContextOptionsBuilder<LibraryContext>();
				var connectionString = configuration.GetConnectionString("Data Source=DESKTOP-P8VVFDN;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
				builder.UseSqlServer(connectionString);

				return new LibraryContext(builder.Options);
			}
		}
	}

	

}