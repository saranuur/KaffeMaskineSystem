using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaffeMaskineSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeMachines",
                columns: table => new
                {
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WaterLevel = table.Column<int>(type: "int", nullable: false),
                    CoffeeBeansLevel = table.Column<int>(type: "int", nullable: false),
                    MilkPowderLevel = table.Column<int>(type: "int", nullable: false),
                    SugarLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeMachines", x => x.CoffeeMachineID);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    HistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.HistoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Cleanings",
                columns: table => new
                {
                    CleaningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    CleanedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CleaningDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cleanings", x => x.CleaningID);
                    table.ForeignKey(
                        name: "FK_Cleanings_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineMaintenanceRecords",
                columns: table => new
                {
                    MachineMaintenanceRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineMaintenanceRecords", x => x.MachineMaintenanceRecordID);
                    table.ForeignKey(
                        name: "FK_MachineMaintenanceRecords_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrayEmptyingRecords",
                columns: table => new
                {
                    TrayEmptyingRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TimeEmptied = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrayEmptyingRecords", x => x.TrayEmptyingRecordID);
                    table.ForeignKey(
                        name: "FK_TrayEmptyingRecords_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TubeChanges",
                columns: table => new
                {
                    TubeChangeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TubeChanges", x => x.TubeChangeID);
                    table.ForeignKey(
                        name: "FK_TubeChanges_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    NotificationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refills",
                columns: table => new
                {
                    RefillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CoffeeMachineID = table.Column<int>(type: "int", nullable: false),
                    CoffeeAmount = table.Column<int>(type: "int", nullable: false),
                    SugarAmount = table.Column<int>(type: "int", nullable: false),
                    MilkPowderAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refills", x => x.RefillID);
                    table.ForeignKey(
                        name: "FK_Refills_CoffeeMachines_CoffeeMachineID",
                        column: x => x.CoffeeMachineID,
                        principalTable: "CoffeeMachines",
                        principalColumn: "CoffeeMachineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cleanings_CoffeeMachineID",
                table: "Cleanings",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineMaintenanceRecords_CoffeeMachineID",
                table: "MachineMaintenanceRecords",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CoffeeMachineID",
                table: "Notifications",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Refills_CoffeeMachineID",
                table: "Refills",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_Refills_UserID",
                table: "Refills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TrayEmptyingRecords_CoffeeMachineID",
                table: "TrayEmptyingRecords",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_TubeChanges_CoffeeMachineID",
                table: "TubeChanges",
                column: "CoffeeMachineID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cleanings");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "MachineMaintenanceRecords");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Refills");

            migrationBuilder.DropTable(
                name: "TrayEmptyingRecords");

            migrationBuilder.DropTable(
                name: "TubeChanges");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CoffeeMachines");
        }
    }
}
