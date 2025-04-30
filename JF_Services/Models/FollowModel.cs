using System;
using System.ComponentModel.DataAnnotations;

namespace JF_Services.Models;

public class FollowModel
{
    [Key]   public required int FOLLOW_ID { get; set; }
    public required UserModel FOLLOWER { get; set; }
    public required UserModel FOLLOWING { get; set; }
    public required DateTime FOLLOW_DATE { get; set; }

}
