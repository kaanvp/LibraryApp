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
	public class CategoryManager : IGenericRepository<Category>
	{
		public void Add(Category entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public Category Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll()
		{
			using (var context = new LibraryContext())
			{
				return context.Categories.ToList();
			}
		}
		public Category GetByName(string categoryName)
		{
			using (var context = new LibraryContext())
			{
				Category category = context.Categories.FirstOrDefault(c => c.Name == categoryName);
				if (category == null)
				{
					category = new Category { Name = categoryName };
					context.Categories.Add(category);
					context.SaveChanges();
				}
				return category;
			}
		}
		public Category GetBySearch(string entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
