using System;

namespace DevotionalBlog.Services.Models;

public class UserModel
{
    public required int USER_ID { get; set; }
    public required string USER_NAME { get; set; }
    public string? PROFILE_PIC { get; set; }

}
