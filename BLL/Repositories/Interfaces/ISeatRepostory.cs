using System.Collections.Generic;
using DAL.Models;

namespace BLL.Repositories.Interfaces
{
	public interface ISeatRepostory :IRepository<Seat>
	{
		IEnumerable<Seat> GetAllSeats();
	}
}