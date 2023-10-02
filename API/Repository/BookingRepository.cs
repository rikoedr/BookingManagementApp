using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repository;

public class BookingRepository : ITableRepository<Booking>
{
    private readonly BookingManagementDbContext _context;

    public BookingRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public Booking? Create(Booking entity)
    {
        try
        {
            _context.Set<Booking>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(Booking entity)
    {
        try
        {
            _context.Set<Booking>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Booking> GetAll()
    {
        return _context.Set<Booking>().ToList();
    }

    public Booking? GetByGuid(Guid guid)
    {
        return _context.Set<Booking>().Find(guid);
    }

    public bool Update(Booking entity)
    {
        try
        {
            _context.Set<Booking>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
