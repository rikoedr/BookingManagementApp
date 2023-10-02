using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EducationController : ControllerBase
{
    private readonly ITableRepository<Education> _educationRepository;

    public EducationController(ITableRepository<Education> educationRepository)
    {
        _educationRepository = educationRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _educationRepository.GetAll();

        if (!result.Any())
        {
            return NotFound("Data Not Found!");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)
    {
        var result = _educationRepository.GetByGuid(guid);

        if(result is null)
        {
            return NotFound("Id Not Found!");
        }

        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(Education education)
    {
        var result = _educationRepository.Create(education);

        if(result is null)
        {
            return BadRequest("Failed to create data!");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(Education education)
    {
        var result = _educationRepository.Delete(education);

        if (!result)
        {
            return NotFound("Delete Failed, Data Not Found!");
        }

        return Ok(result);
    }

    [HttpPut]
    public IActionResult Update(Education education)
    {
        var result = _educationRepository.Update(education);

        if (!result)
        {
            return NotFound("Update Failed, Data Not Found");
        }

        return Ok(result);
    }
}
