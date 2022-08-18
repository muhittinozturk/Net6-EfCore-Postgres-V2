using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models;

public class Team : BaseEntity
{
    public Team()
    {
        Drivers = new HashSet<Driver>();
    }
    
    public string Name { get; set; } = "";

    [Column("racing_year")]
    public int Year { get; set; } = 2022;
    public string NumberOfPoints { get; set; } = "";

    public virtual ICollection<Driver> Drivers {get;set;}
}
