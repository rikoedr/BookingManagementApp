using API.Contracts;
using API.Models;

namespace API.Controllers;

public class BookingController : AbstractController<Booking>
{
    public BookingController(ITableRepository<Booking> tableRepository) : base(tableRepository)
    {
    }
}
