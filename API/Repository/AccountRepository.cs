using API.Contracts;
using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class AccountRepository : ITableRepository<Account>
{
    private readonly BookingManagementDbContext _context;

    public AccountRepository(BookingManagementDbContext context)
    {
        _context = context;
    }
    public Account? Create(Account entity)
    {
        try
        {
            _context.Set<Account>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(Account entity)
    {
        try
        {
            _context.Set<Account>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Account> GetAll()
    {
        return _context.Set<Account>().ToList();
    }

    public Account? GetByGuid(Guid guid)
    {
        return _context.Set<Account>().Find(guid);
    }

    public bool Update(Account entity)
    {
        try
        {
            _context.Set<Account>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
