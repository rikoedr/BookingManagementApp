using API.Models;

namespace API.Controllers;

public class EmployeeController : AbstractController<Employee>
{
    public EmployeeController(Contracts.ITableRepository<Employee> tableRepository) : base(tableRepository)
    {
    }
}
