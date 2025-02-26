using System.ComponentModel.DataAnnotations;

namespace Moment_4_MusicApi.Models;

public class Music
{
    //Properties
    public int MusicId { get; set; }

    [Required]
    public string? Artist { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public int? Length { get; set; }
    [Required]
    public string? Category { get; set; }

}