﻿using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/*
 * Class Model untuk konfigurasi table accounts yang diturunkan dari class AbstractModel
 */

[Table("tb_m_accounts")]
public class Account : AbstractModel
{
    [Column("password", TypeName = "nvarchar(max)")]
    public string Password { get; set; }
    
    [Column("is_deleted", TypeName = "bit")]
    public Boolean IsDeleted { get; set; }

    [Column("otp", TypeName = "int")]
    public int OTP { get; set; }

    [Column("is_used", TypeName = "bit")]
    public Boolean IsUsed { get; set; }

    [Column("expired_time", TypeName = "datetime2")]
    public DateTime ExpiredTime { get; set; }
}
