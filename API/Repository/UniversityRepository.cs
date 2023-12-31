﻿using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class UniversityRepository : ITableRepository<University>
{
    private readonly BookingManagementDbContext _context;

    public UniversityRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public University? Create(University entity)
    {
        try
        {
            _context.Set<University>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(University entity)
    {
        try
        {
            _context.Set<University>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<University> GetAll()
    {
        return _context.Set<University>().ToList();
    }

    public University? GetByGuid(Guid guid)
    {
        return _context.Set<University>().Find(guid);
    }

    public bool Update(University entity)
    {
        try
        {
            _context.Set<University>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
