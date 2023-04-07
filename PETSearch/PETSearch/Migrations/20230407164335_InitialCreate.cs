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
                    Location_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Location_Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Clinic_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Clinic_Name = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    LocationsLocation_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Clinic_Id);
                    table.ForeignKey(
                        name: "FK_Clinics_Locations_LocationsLocation_Id",
                        column: x => x.LocationsLocation_Id,
                        principalTable: "Locations",
                        principalColumn: "Location_Id");
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
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    LocationsLocation_Id = table.Column<int>(type: "int", nullable: true),
                    Clinic_Id = table.Column<int>(type: "int", nullable: true),
                    ClinicsClinic_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Animal_Id);
                    table.ForeignKey(
                        name: "FK_Animals_Clinics_ClinicsClinic_Id",
                        column: x => x.ClinicsClinic_Id,
                        principalTable: "Clinics",
                        principalColumn: "Clinic_Id");
                    table.ForeignKey(
                        name: "FK_Animals_Locations_LocationsLocation_Id",
                        column: x => x.LocationsLocation_Id,
                        principalTable: "Locations",
                        principalColumn: "Location_Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vets",
                columns: table => new
                {
                    Vet_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Vet_Name = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Email = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Phone_Number = table.Column<string>(type: "longtext", nullable: false),
                    Clinic_Id = table.Column<int>(type: "int", nullable: true),
                    ClinicsClinic_Id = table.Column<int>(type: "int", nullable: true),
                    Vet_Username = table.Column<string>(type: "longtext", nullable: false),
                    Vet_Password = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vets", x => x.Vet_Id);
                    table.ForeignKey(
                        name: "FK_Vets_Clinics_ClinicsClinic_Id",
                        column: x => x.ClinicsClinic_Id,
                        principalTable: "Clinics",
                        principalColumn: "Clinic_Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Person_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Person_Name = table.Column<string>(type: "longtext", nullable: false),
                    Person_Email = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    LocationsLocation_Id = table.Column<int>(type: "int", nullable: true),
                    Person_Username = table.Column<string>(type: "longtext", nullable: false),
                    Person_Password = table.Column<string>(type: "longtext", nullable: false),
                    Animal_Id = table.Column<int>(type: "int", nullable: true),
                    AnimalsAnimal_Id = table.Column<int>(type: "int", nullable: true),
                    Person_Phone_Number = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Person_Id);
                    table.ForeignKey(
                        name: "FK_Persons_Animals_AnimalsAnimal_Id",
                        column: x => x.AnimalsAnimal_Id,
                        principalTable: "Animals",
                        principalColumn: "Animal_Id");
                    table.ForeignKey(
                        name: "FK_Persons_Locations_LocationsLocation_Id",
                        column: x => x.LocationsLocation_Id,
                        principalTable: "Locations",
                        principalColumn: "Location_Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ClinicsClinic_Id",
                table: "Animals",
                column: "ClinicsClinic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_LocationsLocation_Id",
                table: "Animals",
                column: "LocationsLocation_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_LocationsLocation_Id",
                table: "Clinics",
                column: "LocationsLocation_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AnimalsAnimal_Id",
                table: "Persons",
                column: "AnimalsAnimal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_LocationsLocation_Id",
                table: "Persons",
                column: "LocationsLocation_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vets_ClinicsClinic_Id",
                table: "Vets",
                column: "ClinicsClinic_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Vets");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
