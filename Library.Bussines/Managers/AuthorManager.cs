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
	public class AuthorManager : IGenericRepository<Author>
	{
		public void Add(Author entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Author entity)
		{
			throw new NotImplementedException();
		}

		public Author Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Author> GetAll()
		{
			using (var context = new LibraryContext())
			{
				return context.Authors.ToList();
			}
		}

		public Author GetBySearch(string entity)
		{
			throw new NotImplementedException();
		}
		public Author GetByName(string authorName)
		{
			using (var context = new LibraryContext())
			{
				Author author = context.Authors.FirstOrDefault(a => a.FullName == authorName);
				if (author == null)
				{
					author = new Author { FullName = authorName };
					context.Authors.Add(author);
					context.SaveChanges();
				}
				return author;
			}
		}
		public void Update(Author entity)
		{
			throw new NotImplementedException();
		}
	}
}
