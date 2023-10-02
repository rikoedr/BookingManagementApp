using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class EmployeeRepository : ITableRepository<Employee>
{
    private readonly BookingManagementDbContext _context;

    public EmployeeRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public Employee? Create(Employee entity)
    {
        try
        {
            _context.Set<Employee>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch
        {
            return null;
        }
    }

    public bool Delete(Employee entity)
    {
        try
        {
            _context.Set<Employee>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Employee> GetAll()
    {
        return _context.Set<Employee>().ToList();
    }

    public Employee? GetByGuid(Guid guid)
    {
        return _context.Set<Employee>().Find(guid);
    }

    public bool Update(Employee entity)
    {
        try
        {
            _context.Set<Employee>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
