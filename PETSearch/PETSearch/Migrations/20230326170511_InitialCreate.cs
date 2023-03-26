using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace PETSearch.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Location = table.Column<string>(type: "varchar(255)", nullable: false),
                    Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Location);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Clinic_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Clinic_Name = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Clinic_Id);
                    table.ForeignKey(
                        name: "FK_Clinics_Locations_Location",
                        column: x => x.Location,
                        principalTable: "Locations",
                        principalColumn: "Location");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Animal_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Race = table.Column<string>(type: "longtext", nullable: false),
                    Color = table.Column<string>(type: "longtext", nullable: false),
                    Gender = table.Column<string>(type: "longtext", nullable: false),
                    Height = table.Column<string>(type: "longtext", nullable: false),
                    Species = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", nullable: true),
                    Clinic_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Animal_Id);
                    table.ForeignKey(
                        name: "FK_Animals_Clinics_Clinic_Id",
                        column: x => x.Clinic_Id,
                        principalTable: "Clinics",
                        principalColumn: "Clinic_Id");
                    table.ForeignKey(
                        name: "FK_Animals_Locations_Location",
                        column: x => x.Location,
                        principalTable: "Locations",
                        principalColumn: "Location");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vet",
                columns: table => new
                {
                    Vet_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Vet_Name = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Email = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Phone_Number = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", nullable: true),
                    Clinic_Id = table.Column<int>(type: "int", nullable: true),
                    Clinic_Name = table.Column<string>(type: "longtext", nullable: true),
                    Vet_Username = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Password = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vet", x => x.Vet_Id);
                    table.ForeignKey(
                        name: "FK_Vet_Clinics_Clinic_Id",
                        column: x => x.Clinic_Id,
                        principalTable: "Clinics",
                        principalColumn: "Clinic_Id");
                    table.ForeignKey(
                        name: "FK_Vet_Locations_Location",
                        column: x => x.Location,
                        principalTable: "Locations",
                        principalColumn: "Location");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Person_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Person_Name = table.Column<string>(type: "longtext", nullable: false),
                    Person_Email = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", nullable: true),
                    Person_Username = table.Column<string>(type: "longtext", nullable: false),
                    Person_Password = table.Column<string>(type: "longtext", nullable: false),
                    Animal_Id = table.Column<int>(type: "int", nullable: true),
                    Person_Phone_Number = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Person_Id);
                    table.ForeignKey(
                        name: "FK_Person_Animals_Animal_Id",
                        column: x => x.Animal_Id,
                        principalTable: "Animals",
                        principalColumn: "Animal_Id");
                    table.ForeignKey(
                        name: "FK_Person_Locations_Location",
                        column: x => x.Location,
                        principalTable: "Locations",
                        principalColumn: "Location");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Clinic_Id",
                table: "Animals",
                column: "Clinic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Location",
                table: "Animals",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_Location",
                table: "Clinics",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Animal_Id",
                table: "Person",
                column: "Animal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Location",
                table: "Person",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Vet_Clinic_Id",
                table: "Vet",
                column: "Clinic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vet_Location",
                table: "Vet",
                column: "Location");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Vet");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
