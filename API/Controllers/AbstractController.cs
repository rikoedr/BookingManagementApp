using API.Contracts;
using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/* 
* ABSTRACT CONTROLLER BERFUNGSI UNTUK MEWARISKAN FUNGSI CRUD
* PADA SELURUH CONTROLLER MENGINGAT SELURUH CONTROLLER
* MEMILIKI HTTP RESPONSE YANG SAMA SEHINGGA UNTUK MENGHINDARI
* REDUDANSI MAKA DIBUAT ABSTRACT YANG DIKOMBINASIKAN DENGAN GENERICS.
*/

[ApiController]
[Route("api/[controller]")]
public class AbstractController<T> : ControllerBase
{
    private readonly ITableRepository<T> _tableRepository;

    public AbstractController(ITableRepository<T> tableRepository)
    {
        this._tableRepository = tableRepository;
    }

    /*
    * METHOD UNTUK PENGAMBILAN SELURUH RECORDS/DATA
    * DITANDAI DENGAN ADANYA ATTRIBUTE [HTTPGET] 
    * JIKA BERHASIL AKAN MENGEMBALIKAN COLLECTIONS
    * JIKA GAGAL AKAN MEMBERIKAN PEMBERITAHUAN NOT FOUND.
    */

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _tableRepository.GetAll();

        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    /*
    * METHOD UNTUK MENGAMBIL DATA BERDASAR GUID DITANDAI DENGAN
    * ADANYA ATTRIBUTE [HTTPGET]
    * AKAN MENGEMBALIKAN SINGLE OBJECT JIKA BERHASIL
    */

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)
    {
        var result = _tableRepository.GetByGuid(guid);

        if (result is null)
        {
            return NotFound("Id Not Found");
        }

        return Ok(result);
    }

    /*
    * METHOD UNTUK MELAKUKAN CREATE DATA ATAU POST DI API DITANDAI 
    * DENGAN ADANYA [HTTPPOST]
    * AKAN MENGEMBALIKAN OK JIKA BERHASIL
    */

    [HttpPost]
    public IActionResult Create(T entity)
    {
        var result = _tableRepository.Create(entity);

        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }

    /*
    * METHOD UNTUK MENGHAPUS DATA DITANDAI DENGAN ATTRIBUTE
    * [HTTPDELETE] BERDASARKAN GUID ATAU
    * OBJECT YANG DIKIRIMKAN
    */

    [HttpDelete]
    public IActionResult Delete(T entity)
    {
        var result = _tableRepository.Delete(entity);

        if (!result)
        {
            return NotFound("Delete Failed, Data Not Found");
        }

        return Ok(result);
    }

    /*
    * METHOD UNTUK MENGUPDATE DATA DITANDARI DENGAN ADANYA ATTRIBUTE 
    * [HTTPPUT].
    */

    [HttpPut]
    public IActionResult Update(T entity)
    {
        var result = _tableRepository.Update(entity);

        if (!result)
        {
            return NotFound("Update Failed, Data Not Found");
        }

        return Ok(result);
    }

}
