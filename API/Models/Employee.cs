using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table employee yang diturunkan dari class AbstractModel
 */

[Table("tb_m_employees")]
public class Employee : AbstractModel
{
    [Column("nik", TypeName = "nchar(6)")]
    public string NIK { get; set; }

    [Column("first_name", TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [Column("last_name", TypeName = "nvarchar(100)")]
    public string LastName { get; set; }
    
    [Column("birth_date", TypeName = "datetime")]
    public DateTime BirthDate { get; set; }

    [Column("gender", TypeName = "int")]
    public int Gender { get; set; }

    [Column("hiring_date", TypeName = "datetime")]
    public DateTime HiringDate { get; set; }

    [Column("email", TypeName = "nvarchar(100)")]
    public string Email { get; set; }

    [Column("phone_number", TypeName = "nvarchar(20)")]
    public string PhoneNumber { get; set; }

    // Cardinality 
    public Account? Account { get; set; }
    public Education? Education { get; set; }
    public ICollection<Booking>? Bookings { get; set; }
}
