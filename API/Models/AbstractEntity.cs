using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public abstract class AbstractEntity
{
    [Column("created_date", TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_date", TypeName = "datetime2")]
    public DateTime ModifiedDate { get; set; }

    [Column("guid", TypeName = "uniqueidentifier")]
    public Guid Guid { get; set; }
}
