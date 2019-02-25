using BLL.Repositories;
using BLL.Repositories.Interfaces;
using DAL.Models;

namespace BLL.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		public readonly ApplicationDbContext _context;

		public UnitOfWork(ApplicationDbContext context, ISeatRepostory seats, IRepository<MovieImage> movieImages)
		{
			_context = context;
			Seats = seats;
			MovieImages = movieImages;
			Genres = new GenreRepository(_context);
		}

		public IGenreRepository Genres { get; }

        public IRepository<MovieImage> MovieImages { get; }
		public ISeatRepostory Seats { get; }

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}