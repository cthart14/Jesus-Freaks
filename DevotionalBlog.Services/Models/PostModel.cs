using System;

namespace DevotionalBlog.Services.Models;

public class PostModel
{
public required decimal USER_ID { get; set; }
public required string USER_NAME { get; set; }
public required decimal POST_ID { get; set; }
public required string CAPTION { get; set; }
public required string POST_DATA { get; set; }
public required DateTime POST_DATE { get; set; }

}
