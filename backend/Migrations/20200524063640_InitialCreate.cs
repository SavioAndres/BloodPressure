using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPressures",
                columns: table => new
                {
                    BPressureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Systolic = table.Column<string>(nullable: true),
                    Dyastolic = table.Column<string>(nullable: true),
                    MeanAraterial = table.Column<string>(nullable: true),
                    Pressure = table.Column<string>(nullable: true),
                    SleepStatus = table.Column<string>(nullable: true),
                    DyastolicEndpoint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPressures", x => x.BPressureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPressures");
        }
    }
}
