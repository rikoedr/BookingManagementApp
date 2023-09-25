using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table account roles yang diturunkan dari class AbstractModel
 */

[Table("tb_m_account_roles")]
public class AccountRole
{
    [Column("account_guid", TypeName = "uniqueidentifier")]
    public Guid AccountGuid { get; set; }

    [Column("role_guid", TypeName = "uniqueidentifier")]
    public Guid RoleGuid { get; set; }
}
