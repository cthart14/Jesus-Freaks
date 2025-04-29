using System;

namespace DevotionalBlog.Services.Models;

public class ProfileModel
{
    public required int USER_ID { get; set; }
    public required int PROFILE_ID { get; set; }
    public required string USER_NAME { get; set; }
    public required string PASSWORD { get; set; }
    public required string FIRST_NAME { get; set; }
    public required string LAST_NAME { get; set; }
    public string PHONE { get; set; }
    public required string EMAIL { get; set; }
    public string? BIO { get; set; }
    public string? PROFILE_PIC { get; set; }
    public required DateTime CREATED_DATE { get; set; }
    public required DateTime UPDATED_DATE { get; set; }
    public ICollection<PostModel> POSTS { get; set; }
    public ICollection<CommentModel> COMMENTS { get; set; }
    public ICollection<FollowModel> FOLLOWERS { get; set; }
    public ICollection<FollowModel> FOLLOWINGS { get; set; }

}
