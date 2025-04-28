using System;

namespace DevotionalBlog.Services.Models;

public class UserModel
{
    public required decimal USER_ID { get; set; }
    public required string USER_NAME { get; set; }
    public required string PASSWORD { get; set; }
    public required string EMAIL { get; set; }
    public required DateTime CREATED_DATE { get; set; }
    public required DateTime LAST_LOGIN_DATE { get; set; }
    public required string FIRST_NAME { get; set; }
    public string LAST_NAME { get; set; }
    public string PHONE { get; set; }

}
