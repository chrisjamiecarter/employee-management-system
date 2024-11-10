using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagementSystem.Blazor.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeType = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeType", "ImageUrl", "JobTitle", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("02f9690a-811e-2011-451c-ea43ee536d6d"), 2, "https://avatars.githubusercontent.com/u/17587903", 4, "Cordia Aufderhar", 122600.771739427340000m },
                    { new Guid("0647d6e0-cf6a-72f0-9bbd-2e2bf404ba72"), 0, "https://avatars.githubusercontent.com/u/97899522", 2, "Jaylon Robel", 93158.212654831880000m },
                    { new Guid("0ee71227-045d-956f-8cf8-0435ceb2ac68"), 1, "https://avatars.githubusercontent.com/u/19835731", 6, "Ernestina Crona", 86951.432296517960000m },
                    { new Guid("14f0f612-6b2b-71d2-0c1c-48d1422eafcd"), 2, "https://avatars.githubusercontent.com/u/2638945", 5, "Maeve Dickens", 32942.968845806540000m },
                    { new Guid("291a235e-9244-da89-3519-02ddee386f47"), 1, "https://avatars.githubusercontent.com/u/99325548", 1, "Chad Herman", 41757.74032331900000m },
                    { new Guid("2ad4ce0b-e685-b18e-b5b6-6aa1c07c5853"), 1, "https://avatars.githubusercontent.com/u/80657846", 2, "Keara Stroman", 73946.377939519640000m },
                    { new Guid("30f0c9d2-4a68-66f9-2e4d-0eb32140aa5c"), 0, "https://avatars.githubusercontent.com/u/29401469", 2, "Hazel McCullough", 137691.401186255420000m },
                    { new Guid("340236d2-73ee-c026-41d6-ea0ebf873765"), 0, "https://avatars.githubusercontent.com/u/80655746", 2, "Ethan Sawayn", 129933.062740570520000m },
                    { new Guid("34d243ed-6716-8010-cd27-0ea3e99e3e96"), 1, "https://avatars.githubusercontent.com/u/67682405", 3, "Lilly McGlynn", 199031.753725852700000m },
                    { new Guid("3ab0a5cc-dfad-6e13-0df7-08ac4525d4ee"), 0, "https://avatars.githubusercontent.com/u/3092000", 2, "Trace Lesch", 185915.775944439560000m },
                    { new Guid("3bf6bb35-68d2-2f8b-e298-d3616e4c647e"), 0, "https://avatars.githubusercontent.com/u/84756549", 5, "Dasia Moen", 52551.327763382060000m },
                    { new Guid("3ed3962e-ddb7-52c1-3b3a-a2ecfaa2cdf8"), 1, "https://avatars.githubusercontent.com/u/83780396", 5, "Everette Donnelly", 110458.948719528920000m },
                    { new Guid("4f99ee44-a1fc-6b73-9262-698b7ac2fbea"), 1, "https://avatars.githubusercontent.com/u/36305665", 5, "Mariana Reynolds", 185104.66722077900000m },
                    { new Guid("53ab6278-5c2c-2f39-00c9-c9ed800e1f08"), 2, "https://avatars.githubusercontent.com/u/77360452", 2, "Dorthy Satterfield", 159379.795677671120000m },
                    { new Guid("5652dec9-5fef-f871-8bd4-cdb696c300e9"), 0, "https://avatars.githubusercontent.com/u/25945246", 2, "Terence Lubowitz", 121288.119936961700000m },
                    { new Guid("5693ab37-cff1-10d0-b8d7-94ae3bdefb19"), 2, "https://avatars.githubusercontent.com/u/35914091", 0, "Taya Parker", 124381.66967797160000m },
                    { new Guid("592da611-1299-1a7b-f816-20da5ee45a17"), 2, "https://avatars.githubusercontent.com/u/30653491", 3, "Trevor Reichel", 80307.440301546560000m },
                    { new Guid("5d1dc088-b19e-4254-ec24-a0e1e9247598"), 1, "https://avatars.githubusercontent.com/u/24734431", 5, "Colleen Nikolaus", 168578.09873697260000m },
                    { new Guid("6642b476-fe90-e252-9e60-ba76e0701d3b"), 2, "https://avatars.githubusercontent.com/u/39918760", 5, "Kirsten Hayes", 177404.131636677380000m },
                    { new Guid("66e460e3-610f-f286-b7ff-8240d1225e54"), 0, "https://avatars.githubusercontent.com/u/23580114", 8, "Orpha Rutherford", 38066.009524309100000m },
                    { new Guid("6d608720-c6dd-e519-e51c-65b9d48ff2b8"), 0, "https://avatars.githubusercontent.com/u/54448862", 1, "Eloise Ankunding", 80824.413877364360000m },
                    { new Guid("6f2dec93-a44e-371c-538b-616546b55193"), 2, "https://avatars.githubusercontent.com/u/30513961", 7, "Elissa Beahan", 70844.059386683660000m },
                    { new Guid("6fcf9ba7-9254-0a75-33aa-0f96ca1ba7bd"), 0, "https://avatars.githubusercontent.com/u/73435073", 4, "Christopher Rosenbaum", 101059.622057275760000m },
                    { new Guid("709eb7cb-7ad7-c19c-2e91-725c9c3c1e89"), 1, "https://avatars.githubusercontent.com/u/64138193", 8, "Mossie Reinger", 78392.095211144540000m },
                    { new Guid("70dd5c9b-e0c9-2705-25b0-bb5d725e71a2"), 1, "https://avatars.githubusercontent.com/u/97972102", 2, "Julius Kohler", 112904.136792246260000m },
                    { new Guid("74f10840-4365-b6e4-1383-15b58572c109"), 2, "https://avatars.githubusercontent.com/u/58847393", 2, "Shanon Altenwerth", 35326.0291625401160000m },
                    { new Guid("75ce324f-8960-e75f-9ac2-8dbb743a148f"), 2, "https://avatars.githubusercontent.com/u/20634297", 7, "Martine Denesik", 58417.049235858500000m },
                    { new Guid("7bb1f933-a3fc-2883-82f7-a3000f14cb11"), 2, "https://avatars.githubusercontent.com/u/51689363", 2, "Jabari Casper", 56142.362149498640000m },
                    { new Guid("7f9b2ea4-6273-76d5-b71d-484a9cde841f"), 2, "https://avatars.githubusercontent.com/u/43897044", 6, "Monserrate Ward", 27230.9404645259120000m },
                    { new Guid("8053f94d-a64b-fbc8-47da-20b7738f455f"), 1, "https://avatars.githubusercontent.com/u/36281122", 8, "Jeffery Wiegand", 156397.383602521040000m },
                    { new Guid("9f65d7dd-bad9-9fa0-c48c-05faa37d758a"), 1, "https://avatars.githubusercontent.com/u/91199534", 7, "Audra Kuhic", 108808.420053128420000m },
                    { new Guid("ab840761-a253-6247-d08f-a2b2510425d3"), 0, "https://avatars.githubusercontent.com/u/84806153", 5, "Aurelie Jacobs", 157154.004758761220000m },
                    { new Guid("acafa487-4f63-39d9-cd37-865118d63b35"), 2, "https://avatars.githubusercontent.com/u/8075100", 1, "Montana Nitzsche", 144824.450409423740000m },
                    { new Guid("af834aec-8402-5099-829d-e6be1c0b1260"), 2, "https://avatars.githubusercontent.com/u/12324583", 6, "Rafaela Wilderman", 115985.516177483660000m },
                    { new Guid("b027bf80-4076-f108-26ca-87bbcdf8740e"), 2, "https://avatars.githubusercontent.com/u/4193283", 3, "Jaime Klocko", 182065.401450761240000m },
                    { new Guid("b1d764dc-a850-4d46-2869-943e3dac542b"), 0, "https://avatars.githubusercontent.com/u/53389472", 2, "Shaniya Barrows", 56914.992656984900000m },
                    { new Guid("b6ef43cf-f4a3-015d-dff6-7947c95b9da2"), 2, "https://avatars.githubusercontent.com/u/1420506", 5, "Monte Jacobs", 120846.674768648420000m },
                    { new Guid("b904e12b-fbc0-a174-5461-6dbf53ea84fb"), 1, "https://avatars.githubusercontent.com/u/59063076", 8, "Mikayla Jacobi", 145052.378580464300000m },
                    { new Guid("c3faaf49-5ef3-f9e1-b0ae-82e6d1ea83e0"), 1, "https://avatars.githubusercontent.com/u/49628153", 2, "Kameron Schroeder", 89407.435622721680000m },
                    { new Guid("c6921369-3486-4dfe-2271-19ee6f92ec19"), 1, "https://avatars.githubusercontent.com/u/68531746", 3, "Ilene Waters", 77466.861008418260000m },
                    { new Guid("c700aa48-6bba-566c-1748-e9ab4ae32693"), 2, "https://avatars.githubusercontent.com/u/12132621", 6, "London Schmidt", 105370.416084942560000m },
                    { new Guid("d916f14a-2f91-2a13-9113-c5126ff4b527"), 0, "https://avatars.githubusercontent.com/u/28423627", 4, "Deontae Leuschke", 114647.187169011260000m },
                    { new Guid("dc55b46b-fa06-341a-3592-c7429f8cf3c1"), 2, "https://avatars.githubusercontent.com/u/52631914", 5, "Nathen Kris", 111202.455382422680000m },
                    { new Guid("e3d4a12a-7ff8-633c-c2b4-7284f5f66223"), 2, "https://avatars.githubusercontent.com/u/69798401", 6, "Toby Bergstrom", 165835.585699340060000m },
                    { new Guid("e594e058-e336-d1dd-31e9-4be16d24e298"), 1, "https://avatars.githubusercontent.com/u/28931204", 7, "Tracey Feest", 66447.798193640900000m },
                    { new Guid("ef67b77e-44d0-fc94-6c18-2624700525f8"), 2, "https://avatars.githubusercontent.com/u/55723525", 7, "Sydney Quigley", 28499.034572625080000m },
                    { new Guid("f516995a-7a09-736a-a8fb-58167b9198b2"), 0, "https://avatars.githubusercontent.com/u/91566007", 8, "Idell Bradtke", 52776.169382397080000m },
                    { new Guid("f5ea9617-a5f2-6be3-47e3-0f8c00ed96f2"), 0, "https://avatars.githubusercontent.com/u/44125326", 7, "Catherine Moore", 51176.320971537440000m },
                    { new Guid("f6700042-9d72-0979-c585-6b798d281409"), 2, "https://avatars.githubusercontent.com/u/69451499", 5, "Leatha Mraz", 88562.898360454880000m },
                    { new Guid("ffbfa5aa-d5ff-db68-123b-6c3b6e04a657"), 0, "https://avatars.githubusercontent.com/u/42667110", 4, "Thelma Kulas", 120956.372926457060000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
