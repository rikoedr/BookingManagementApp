using API.Contracts;
using API.Model;

namespace API.Controllers;

public class RoomController : AbstractController<Room>
{
    public RoomController(ITableRepository<Room> tableRepository) : base(tableRepository)
    {
    }
}
