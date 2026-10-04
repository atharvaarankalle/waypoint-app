using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waypoint.Data.Models;

public class Respondent
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }

    [Required]
    public stirng Name { get; set; } = string.Empty;

    public string? LocationName { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

    // Navigation Properties
    public virtual Event? Event { get; set; }
    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
}
