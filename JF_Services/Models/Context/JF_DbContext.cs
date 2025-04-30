using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace JF_Services.Models.Context;

public class JFDbContext : DbContext
{
public JFDbContext(DbContextOptions<JFDbContext> options) : base(options) {}
    
    public DbSet<UserModel> Users { get; set; }
    public DbSet<PostModel> Posts { get; set; }
    public DbSet<ProfileModel> Profiles { get; set; }
    public DbSet <FollowModel> Follows { get; set; }
    public DbSet<CommentModel> Comments { get; set; }
    public DbSet<LikeModel> Likes { get; set; }

}
