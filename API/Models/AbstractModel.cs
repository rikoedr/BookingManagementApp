using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Abstract Model merupakan abstract class yang berisi attribute class serta attribute terkait class tersebut
 * untuk keperluan mapping dengan database [Column].
 * 
 * Di abstract ini berisi seluruh attribute atau fields yang dimiliki oleh seluruh table dalam database ini.
 * Dengan cara ini lebih menghemat waktu untuk coding, konsistensi data, serta efisiensi size.
 */
public abstract class AbstractModel
{
    [Column("created_date", TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_date", TypeName = "datetime2")]
    public DateTime ModifiedDate { get; set; }

    [Column("guid", TypeName = "uniqueidentifier")]
    public Guid Guid { get; set; }
}
