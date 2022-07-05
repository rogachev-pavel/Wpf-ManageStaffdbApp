using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageStaffDBapp.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentsRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsRP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionsRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxNumber = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionsRP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionsRP_DepartmentsRP_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DepartmentsRP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersRP_PositionsRP_PositionId",
                        column: x => x.PositionId,
                        principalTable: "PositionsRP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PositionsRP_DepartmentId",
                table: "PositionsRP",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRP_PositionId",
                table: "UsersRP",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersRP");

            migrationBuilder.DropTable(
                name: "PositionsRP");

            migrationBuilder.DropTable(
                name: "DepartmentsRP");
        }
    }
}
