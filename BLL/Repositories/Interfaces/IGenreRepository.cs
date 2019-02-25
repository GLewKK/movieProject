using DAL.Models;
using System.Collections.Generic;

namespace BLL.Repositories.Interfaces
{
	public interface IGenreRepository : IRepository<Genre>
	{
		IEnumerable<Genre> GetFristGenre();
	}
}