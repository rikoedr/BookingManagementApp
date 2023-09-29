﻿using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : ControllerBase
{
    private readonly IUniversityRepository _universityRepository;

    public UniversityController(IUniversityRepository universityRepository)
    {
        this._universityRepository = universityRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _universityRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)
    {
        var result = _universityRepository.GetByGuid(guid);

        if(result is null)
        {
            return NotFound("Id Not Found");
        }

        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(University university)
    {
        var result = _universityRepository.Create(university);

        if(result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(University university)
    {
        var result = _universityRepository.Delete(university);

        if (!result)
        {
            return NotFound("Delete Failed, Data Not Found");
        }

        return Ok(result);
    }

    [HttpPut]
    public IActionResult Update(University university)
    {
        var result = _universityRepository.Update(university);

        if (!result)
        {
            return NotFound("Update Failed, Data Not Found");
        }

        return Ok(result);
    }
}
