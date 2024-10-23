using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace omg.Migrations
{
    /// <inheritdoc />
    public partial class enitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    place_of_residence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacher", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "teacher");
        }
    }
}
