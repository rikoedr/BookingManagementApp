using API.Contracts;
using API.Models;

namespace API.Controllers;

public class RoleController : AbstractController<Role>
{
    public RoleController(ITableRepository<Role> tableRepository) : base(tableRepository)
    {
    }
}
