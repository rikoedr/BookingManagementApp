using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class AccountRoleRepository : ITableRepository<AccountRole>
{
    private readonly BookingManagementDbContext _context;

    public AccountRoleRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public AccountRole? Create(AccountRole entity)
    {
        try
        {
            _context.Set<AccountRole>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(AccountRole entity)
    {
        try
        {
            _context.Set<AccountRole>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<AccountRole> GetAll()
    {
        return _context.Set<AccountRole>().ToList();
    }

    public AccountRole? GetByGuid(Guid guid)
    {
        return _context.Set<AccountRole>().Find(guid);
    }

    public bool Update(AccountRole entity)
    {

        try
        {
            _context.Set<AccountRole>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
