using DAL.Models;
using System.Collections.Generic;
using System.Linq;
using BLL.Repositories.Interfaces;

namespace BLL.Repositories
{
	public class SeatRepostory :Repository<Seat>, ISeatRepostory
	{
		private readonly ApplicationDbContext _context;

		public SeatRepostory(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Seat> GetAllSeats()
		{
			return _context.Seats.ToList();
		}
	}
}