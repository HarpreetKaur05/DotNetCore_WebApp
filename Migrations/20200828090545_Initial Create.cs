using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(nullable: false),
                    DoctorAddress = table.Column<string>(nullable: true),
                    DoctorAge = table.Column<int>(nullable: false),
                    RMPNumber = table.Column<string>(nullable: true),
                    HighestQualification = table.Column<string>(nullable: true),
                    Speciality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    userId = table.Column<string>(nullable: false),
                    userName = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
