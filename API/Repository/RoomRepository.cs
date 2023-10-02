using API.Contracts;
using API.Data;
using API.Model;
using API.Models;

namespace API.Repository;

public class RoomRepository : ITableRepository<Room>
{
    private readonly BookingManagementDbContext _context;

    public RoomRepository(BookingManagementDbContext context)
    {
        _context = context;
    }

    public Room? Create(Room entity)
    {
        try
        {
            _context.Set<Room>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool Delete(Room entity)
    {
        try
        {
            _context.Set<Room>().Remove(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Room> GetAll()
    {
        return _context.Set<Room>().ToList();
    }

    public Room? GetByGuid(Guid guid)
    {
        return _context.Set<Room>().Find(guid);
    }

    public bool Update(Room entity)
    {
        try
        {
            _context.Set<Room>().Update(entity);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
