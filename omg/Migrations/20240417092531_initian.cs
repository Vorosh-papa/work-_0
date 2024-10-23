using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace omg.Migrations
{
    /// <inheritdoc />
    public partial class initian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subject_taught",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_of_subject_taughts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teacher_id = table.Column<int>(type: "int", nullable: false),
                    classroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number_of_hours_per_1_course = table.Column<int>(type: "int", nullable: false),
                    number_of_hours_per_2_course = table.Column<int>(type: "int", nullable: false),
                    number_of_hours_per_3_course = table.Column<int>(type: "int", nullable: false),
                    number_of_hours_per_4_course = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject_taught", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subject_taught");
        }
    }
}
