using API.Contracts;
using API.Models;

namespace API.Controllers;

public class AccountRoleController : AbstractController<AccountRole>
{
    public AccountRoleController(ITableRepository<AccountRole> tableRepository) : base(tableRepository)
    {
    }
}
