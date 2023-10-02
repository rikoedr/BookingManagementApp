using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class EducationRepository : ITableRepository<Education>
{
    private readonly BookingManagementDbContext _context;

    public EducationRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public Education? Create(Education entity)
    {
        try
        {
            _context.Set<Education>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch
        {
            return null;
        }
    }

    public bool Delete(Education entity)
    {
        try
        {
            _context.Set<Education>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Education> GetAll()
    {
        return _context.Set<Education>().ToList();
    }

    public Education? GetByGuid(Guid guid)
    {
        return _context.Set<Education>().Find(guid);
    }

    public bool Update(Education entity)
    {
        try
        {
            _context.Set<Education>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
