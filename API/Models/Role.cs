using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table roles yang diturunkan dari class AbstractModel
 */

[Table("tb_m_roles")]
public class Role
{
    [Column("name", TypeName = "nvarchar(100)")]
    public string Name { get; set; }
}