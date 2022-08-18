using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models;

public class Driver : BaseEntity
{
    public int TeamId { get; set; }
    public string Name { get; set; } = "";
    public int RacingNumber { get; set; }
    public string FavoriteColor { get; set; } = "";

    [NotMapped]
    public string NameAndRacingNumber { get; set; } = ""; // Sir Lewis 44

    public virtual Team Team {get;set;}
    public virtual DriverMedia DriverMedia {get; set;}
}
