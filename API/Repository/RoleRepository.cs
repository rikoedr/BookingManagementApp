using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class RoleRepository : ITableRepository<Role>
{
    private readonly BookingManagementDbContext _context;

    public RoleRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public Role? Create(Role entity)
    {
        try
        {
            _context.Set<Role>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(Role entity)
    {
        try
        {
            _context.Set<Role>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Role> GetAll()
    {
        return _context.Set<Role>().ToList();
    }

    public Role? GetByGuid(Guid guid)
    {
        return _context.Set<Role>().Find(guid);
    }

    public bool Update(Role entity)
    {
        try
        {
            _context.Set<Role>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
