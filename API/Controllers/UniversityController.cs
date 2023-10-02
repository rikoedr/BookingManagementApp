using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : AbstractController<University>
{
    public UniversityController(ITableRepository<University> tableRepository) : base(tableRepository)
    {
    }
}

