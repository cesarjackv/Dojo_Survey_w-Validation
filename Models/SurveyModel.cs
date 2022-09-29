#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_w_Validation.Models;
public class Survey
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Language { get; set; } = null!;

    [MinLength(20)]
    public string? Message { get; set; } = null!;
}