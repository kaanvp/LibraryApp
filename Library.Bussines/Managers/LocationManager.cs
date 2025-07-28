using Library.DataAccess.Context;
using Library.DataAccess.Repositories;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Managers
{
	public class LocationManager : IGenericRepository<Location>
	{
		private readonly LibraryContext _context;

		public void Add(Location entity)
		{
			using (var context = new LibraryContext())
			{
				context.Locations.Add(entity);
				context.SaveChanges();
			}
		}

		public void Delete(Location entity)
		{
			throw new NotImplementedException();
		}

		public Location Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Location> GetAll()
		{
			using (var context = new LibraryContext())
			{
				return context.Locations.ToList();
			}
		}

		public Location GetByFullLocation(string locationName)
		{
			using (var context = new LibraryContext())
			{
				Location location = null;
				var parts = locationName.Split('-');

				if (parts.Length == 3)
				{
					string shelf = parts[0].Trim();
					string row = parts[1].Trim();
					string position = parts[2].Trim();

					location = context.Locations.FirstOrDefault(l =>
						l.Shelf == shelf &&
						l.Row == row &&
						l.Position == position);

					if (location == null)
					{
						location = new Location
						{
							Shelf = shelf,
							Row = row,
							Position = position
						};
						context.Locations.Add(location);
						context.SaveChanges();
					}
				}

				// Tüm durumlarda location nesnesini döndür (null olabilir)
				return location;
			}
		}

		public Location GetBySearch(string entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Location entity)
		{
			throw new NotImplementedException();
		}
	}
}
