using System;
using BLL.Repositories.Interfaces;
using DAL.Models;

namespace BLL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenreRepository Genres { get; }
        IRepository<MovieImage> MovieImages { get; }
		ISeatRepostory Seats { get; }

		int Complete();
	}
}