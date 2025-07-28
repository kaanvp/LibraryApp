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
	public class UserManager : IGenericRepository<User>
	{
		public void Add(User entity)
		{
			using (var context = new LibraryContext())
			{
				context.Users.Add(entity);
				context.SaveChanges();
			}
		}

		public void Delete(User entity)
		{
			entity = GetById(entity.UserId);
			if (entity != null)
			{
				using (var context = new LibraryContext())
				{
					context.Users.Remove(entity);
					context.SaveChanges();
				}
			}
		}

		public User Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<User> GetAll()
		{
			using (var context = new LibraryContext())
			{
				return context.Users.ToList();
			}
		}

		public User GetBySearch(string entity)
		{
			throw new NotImplementedException();
		}
		public User GetById(int id)
		{
			using (var context = new LibraryContext())
			{
				return context.Users.Find(id);
			}
		}

		public void Update(User entity)
		{
			using(var context = new LibraryContext())
			{
				var existingUser = context.Users.Find(entity.UserId);
				if (existingUser != null)
				{
					existingUser.UserName = entity.UserName;
					existingUser.Password = entity.Password;
					existingUser.Role = entity.Role;
					existingUser.PhoneNumber = entity.PhoneNumber;
					existingUser.Email = entity.Email;
					context.SaveChanges();
				}
			}
		}
	}
}
