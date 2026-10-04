using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waypoint.Data.Models;

public class Event
{
    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    public string CreatedBy { get; set; } = string.Empty;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    // Navigation Properties
    public virtual ICollection<Respondent> Respondents { get; set; } = new List<Respondent>();
    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
    public virtual AiRecommendation? AiRecommendation { get; set; }
}
