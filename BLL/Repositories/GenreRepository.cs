using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Repositories.Interfaces;
using DAL.Models;

namespace BLL.Repositories
{
	public class GenreRepository : Repository<Genre>,IGenreRepository
	{
		private readonly ApplicationDbContext context;

		public GenreRepository()
		{
		}

		public GenreRepository(ApplicationDbContext _context)
		{
			context = _context;
		}

		public IEnumerable<Genre> GetFristGenre()
		{
			return context.Genres.Where(x => x.Title.Equals("asd")).ToList();
		}
	}
}
