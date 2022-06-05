using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_CRUD.Migrations
{
    public partial class CreateTablesinttttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Parent_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 75, nullable: true),
                    Meta_Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    MetaTitle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    First_Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Middle_Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password_Hash = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Registered_At = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Last_Login = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Intro = table.Column<string>(type: "TEXT", nullable: true),
                    Profile = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Author_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Parent_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Meta_Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    Published = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    Post_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Category_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.Post_Id, x.Category_Id });
                    table.ForeignKey(
                        name: "FK_PostCategories_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategories_Posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Post_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Parent_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Published = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostMetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Post_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostMetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostMetas_Posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Post_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Tag_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.Post_Id, x.Tag_Id });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_Tag_Id",
                        column: x => x.Tag_Id,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_Category_Id",
                table: "PostCategories",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_Post_Id",
                table: "PostComments",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostMetas_Post_Id",
                table: "PostMetas",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Author_Id",
                table: "Posts",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_Tag_Id",
                table: "PostTags",
                column: "Tag_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "PostMetas");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
