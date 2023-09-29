using API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model;

/*
 * Class Model untuk konfigurasi table rooms yang diturunkan dari class AbstractModel
 */

[Table("tb_m_rooms")]
public class Room : AbstractModel{
    [Column("name", TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    [Column("floor", TypeName = "int")]
    public int Floor { get; set; }

    [Column("capacity", TypeName = "int")]
    public int Capacity { get; set; }

    // Cardinality
    public ICollection<Booking>? Bookings { get; set; }
}
