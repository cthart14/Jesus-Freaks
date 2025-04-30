using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JF_Services.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    PROFILE_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    USER_NAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "TEXT", nullable: false),
                    LAST_NAME = table.Column<string>(type: "TEXT", nullable: false),
                    PHONE = table.Column<string>(type: "TEXT", nullable: true),
                    EMAIL = table.Column<string>(type: "TEXT", nullable: false),
                    BIO = table.Column<string>(type: "TEXT", nullable: true),
                    PROFILE_PIC = table.Column<string>(type: "TEXT", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.PROFILE_ID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    COMMENT_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    COMMENTERUSER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    POST_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    REPLY_TO_COMMENT_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    COMMENT_TEXT = table.Column<string>(type: "TEXT", nullable: false),
                    COMMENT_DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PostModelPOST_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    ProfileModelPROFILE_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.COMMENT_ID);
                    table.ForeignKey(
                        name: "FK_Comments_Profiles_ProfileModelPROFILE_ID",
                        column: x => x.ProfileModelPROFILE_ID,
                        principalTable: "Profiles",
                        principalColumn: "PROFILE_ID");
                });

            migrationBuilder.CreateTable(
                name: "Follows",
                columns: table => new
                {
                    FOLLOW_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FOLLOWERUSER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    FOLLOWINGUSER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    FOLLOW_DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProfileModelPROFILE_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    ProfileModelPROFILE_ID1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.FOLLOW_ID);
                    table.ForeignKey(
                        name: "FK_Follows_Profiles_ProfileModelPROFILE_ID",
                        column: x => x.ProfileModelPROFILE_ID,
                        principalTable: "Profiles",
                        principalColumn: "PROFILE_ID");
                    table.ForeignKey(
                        name: "FK_Follows_Profiles_ProfileModelPROFILE_ID1",
                        column: x => x.ProfileModelPROFILE_ID1,
                        principalTable: "Profiles",
                        principalColumn: "PROFILE_ID");
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    LIKE_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    POST_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    COMMENT_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    LIKERUSER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    LIKE_DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PostModelPOST_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.LIKE_ID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    POST_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USER_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    CAPTION = table.Column<string>(type: "TEXT", nullable: true),
                    POST_DATA = table.Column<string>(type: "TEXT", nullable: false),
                    POST_DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProfileModelPROFILE_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.POST_ID);
                    table.ForeignKey(
                        name: "FK_Posts_Profiles_ProfileModelPROFILE_ID",
                        column: x => x.ProfileModelPROFILE_ID,
                        principalTable: "Profiles",
                        principalColumn: "PROFILE_ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USER_NAME = table.Column<string>(type: "TEXT", nullable: false),
                    PROFILE_PIC = table.Column<string>(type: "TEXT", nullable: true),
                    PostModelPOST_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.USER_ID);
                    table.ForeignKey(
                        name: "FK_Users_Posts_PostModelPOST_ID",
                        column: x => x.PostModelPOST_ID,
                        principalTable: "Posts",
                        principalColumn: "POST_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_COMMENTERUSER_ID",
                table: "Comments",
                column: "COMMENTERUSER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostModelPOST_ID",
                table: "Comments",
                column: "PostModelPOST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProfileModelPROFILE_ID",
                table: "Comments",
                column: "ProfileModelPROFILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FOLLOWERUSER_ID",
                table: "Follows",
                column: "FOLLOWERUSER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FOLLOWINGUSER_ID",
                table: "Follows",
                column: "FOLLOWINGUSER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_ProfileModelPROFILE_ID",
                table: "Follows",
                column: "ProfileModelPROFILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_ProfileModelPROFILE_ID1",
                table: "Follows",
                column: "ProfileModelPROFILE_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_LIKERUSER_ID",
                table: "Likes",
                column: "LIKERUSER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostModelPOST_ID",
                table: "Likes",
                column: "PostModelPOST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ProfileModelPROFILE_ID",
                table: "Posts",
                column: "ProfileModelPROFILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_USER_ID",
                table: "Posts",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostModelPOST_ID",
                table: "Users",
                column: "PostModelPOST_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostModelPOST_ID",
                table: "Comments",
                column: "PostModelPOST_ID",
                principalTable: "Posts",
                principalColumn: "POST_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_COMMENTERUSER_ID",
                table: "Comments",
                column: "COMMENTERUSER_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Follows_Users_FOLLOWERUSER_ID",
                table: "Follows",
                column: "FOLLOWERUSER_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Follows_Users_FOLLOWINGUSER_ID",
                table: "Follows",
                column: "FOLLOWINGUSER_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Posts_PostModelPOST_ID",
                table: "Likes",
                column: "PostModelPOST_ID",
                principalTable: "Posts",
                principalColumn: "POST_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LIKERUSER_ID",
                table: "Likes",
                column: "LIKERUSER_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_USER_ID",
                table: "Posts",
                column: "USER_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Posts_PostModelPOST_ID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
