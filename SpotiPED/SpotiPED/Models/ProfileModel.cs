using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace SpotiPED.Models;
public class ProfileModel
{
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required string Sex { get; set; }
    
    [Required]
    public DateTime DateOfBirth { get; set; }
    
    /*
     * Profile images are stored in wwwroot/imgs/pfps/
     * (At least I plan to store them there :P)
     */
    [Required] 
    public required string ProfileImagePath { get; set; }
}