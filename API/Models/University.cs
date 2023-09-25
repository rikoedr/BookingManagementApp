using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table universities yang diturunkan dari class AbstractModel
 */

[Table("tb_m_universities")]
public class University : AbstractModel
{
    [Column("code", TypeName = "nvarchar(50)")]
    public string Code { get; set; }

    [Column("name", TypeName = "nvarchar(100)")]
    public string Name { get; set; }
}
