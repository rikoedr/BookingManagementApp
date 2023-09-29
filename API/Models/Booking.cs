using API.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table bookings yang diturunkan dari class AbstractModel
 */

[Table("tb_tr_bookings")]
public class Booking : AbstractModel
{
    [Column("start_date", TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime EndDate { get; set; }
    
    [Column("status", TypeName = "int")]
    public int Status { get; set; }

    [Column("remarks", TypeName = "nvarchar(max)")]
    public string Remarks { get; set; }

    [Column("room_guid", TypeName = "uniqueidentifier")]
    public Guid RoomGuid { get; set; }
    
    [Column("employee_guid", TypeName = "uniqueidentifier")]
    public Guid EmployeeGuid { get; set; }

    // Cardinality
    public Employee? Employee { get; set; }
    public Room? Room { get; set; }
}
