using Microsoft.EntityFrameworkCore.Migrations;



namespace template_csharp_blog.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Publishdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catergory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Firstname", "Lastname" },
                values: new object[] { 1, "MacAtack92", "Denzale", "McIntyre" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Firstname", "Lastname" },
                values: new object[] { 2, "Stormyweather", "Storm", "Kendall" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Firstname", "Lastname" },
                values: new object[] { 3, "FiremanCannon", "Chris", "Cannon" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Catergory", "Content", "Publishdate", "Title" },
                values: new object[] { 1, 1, "Sci-Fi", "Not only does he use his power for the need of others but he also inspires other as well", "2-4-2020", "Why Mirio is the G.O.A.T" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Catergory", "Content", "Publishdate", "Title" },
                values: new object[] { 2, 2, "Sports", "I just like Big Ben", "9 - 18 - 2020", "Why the steelers rule" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Catergory", "Content", "Publishdate", "Title" },
                values: new object[] { 3, 3, "Movies", "Andrew played his role of Peter Parker AND Spider-Man better than all the other actors", "05 - 12 - 2020", "Andrew was the best Spiderman" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
