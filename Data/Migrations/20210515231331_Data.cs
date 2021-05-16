using Microsoft.EntityFrameworkCore.Migrations;

namespace Major_Project_UBA_ProtoType.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patterns = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Home_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data");
        }
    }
}
