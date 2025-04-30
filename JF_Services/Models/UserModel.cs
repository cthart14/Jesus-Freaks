using System;
using System.ComponentModel.DataAnnotations;

namespace JF_Services.Models;

public class UserModel
{
    [Key]   public required int USER_ID { get; set; }
    public required string USER_NAME { get; set; }
    public string? PROFILE_PIC { get; set; }

}
