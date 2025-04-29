using System;

namespace DevotionalBlog.Services.Models;

public class FollowModel
{
public required UserModel FOLLOWER { get; set; }
public required UserModel FOLLOWING { get; set; }
public required DateTime FOLLOW_DATE { get; set; }

}
