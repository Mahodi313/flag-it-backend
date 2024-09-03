using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace flag_it_backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfResult = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfCompletion = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Description", "FlagImage", "Name" },
                values: new object[,]
                {
                    { 1, "Asien", "Afghanistan, beläget i Centralasien, blev självständigt från Storbritannien den 19 augusti 1919. Landet har cirka 38 miljoner invånare. De officiella språken är pashto och dari.", "https://flagcdn.com/af.svg", "Afghanistan" },
                    { 2, "Europa", "Albanien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 28 november 1912. Landet har cirka 2,9 miljoner invånare. Det officiella språket är albanska.", "https://flagcdn.com/al.svg", "Albanien" },
                    { 3, "Afrika", "Algeriet, beläget i Nordafrika, blev självständigt från Frankrike den 5 juli 1962. Landet har cirka 44 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/dz.svg", "Algeriet" },
                    { 4, "Europa", "Andorra, en liten landlocked nation i Pyrenéerna mellan Frankrike och Spanien, har cirka 77 000 invånare. Det officiella språket är katalanska.", "https://flagcdn.com/ad.svg", "Andorra" },
                    { 5, "Afrika", "Angola, beläget på västkusten av södra Afrika, blev självständigt från Portugal den 11 november 1975. Landet har cirka 32 miljoner invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/ao.svg", "Angola" },
                    { 6, "Nordamerika", "Antigua och Barbuda är en ö-nation i Karibien som blev självständigt från Storbritannien den 1 november 1981. Landet har cirka 97 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/ag.svg", "Antigua och Barbuda" },
                    { 7, "Sydamerika", "Argentina, beläget i Sydamerika, förklarade sig självständigt från Spanien den 9 juli 1816. Landet har cirka 45 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/ar.svg", "Argentina" },
                    { 8, "Asien", "Armenien, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 21 september 1991. Landet har cirka 3 miljoner invånare. Det officiella språket är armeniska.", "https://flagcdn.com/am.svg", "Armenien" },
                    { 9, "Oceanien", "Australien, en kontinent och land i Oceanien, blev självständigt från Storbritannien den 1 januari 1901. Landet har cirka 25 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/au.svg", "Australien" },
                    { 10, "Europa", "Österrike, beläget i Centraleuropa, har en historia av självständighet som går tillbaka till 1156. Landet har cirka 9 miljoner invånare. Det officiella språket är tyska.", "https://flagcdn.com/at.svg", "Österrike" },
                    { 11, "Asien", "Azerbajdzjan, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 30 augusti 1991. Landet har cirka 10 miljoner invånare. Det officiella språket är azerbajdzjanska.", "https://flagcdn.com/az.svg", "Azerbajdzjan" },
                    { 12, "Nordamerika", "Bahamas, en ö-nation i Karibien, blev självständigt från Storbritannien den 10 juli 1973. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/bs.svg", "Bahamas" },
                    { 13, "Asien", "Bahrain, en ö-nation i Persiska viken, blev självständigt från Storbritannien den 15 augusti 1971. Landet har cirka 1,7 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/bh.svg", "Bahrain" },
                    { 14, "Asien", "Bangladesh, beläget i Sydasien, blev självständigt från Pakistan den 26 mars 1971. Landet har cirka 163 miljoner invånare. Det officiella språket är bengali.", "https://flagcdn.com/bd.svg", "Bangladesh" },
                    { 15, "Nordamerika", "Barbados, en ö-nation i Karibien, blev självständigt från Storbritannien den 30 november 1966. Landet har cirka 287 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/bb.svg", "Barbados" },
                    { 16, "Europa", "Vitryssland, beläget i Östeuropa, blev självständigt från Sovjetunionen den 25 augusti 1991. Landet har cirka 9,4 miljoner invånare. Det officiella språket är vitryska.", "https://flagcdn.com/by.svg", "Vitryssland" },
                    { 17, "Europa", "Belgien, beläget i Västeuropa, blev självständigt från Nederländerna den 4 oktober 1830. Landet har cirka 11,5 miljoner invånare. De officiella språken är nederländska, franska och tyska.", "https://flagcdn.com/be.svg", "Belgien" },
                    { 18, "Nordamerika", "Belize, ett land i Centralamerika, blev självständigt från Storbritannien den 21 september 1981. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/bz.svg", "Belize" },
                    { 19, "Afrika", "Benin, ett västafrikanskt land, blev självständigt från Frankrike den 1 augusti 1960. Landet har cirka 12 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/bj.svg", "Benin" },
                    { 20, "Asien", "Bhutan, ett litet kungarike i Himalaya, har aldrig varit under utländsk kontroll. Landet har cirka 770 000 invånare. Det officiella språket är dzongkha.", "https://flagcdn.com/bt.svg", "Bhutan" },
                    { 21, "Sydamerika", "Bolivia, beläget i Sydamerika, blev självständigt från Spanien den 6 augusti 1825. Landet har cirka 11 miljoner invånare. De officiella språken är spanska och flera inhemska språk.", "https://flagcdn.com/bo.svg", "Bolivia" },
                    { 22, "Europa", "Bosnien och Hercegovina, beläget i Balkanregionen i Sydöstra Europa, blev självständigt från Jugoslavien den 1 mars 1992. Landet har cirka 3,5 miljoner invånare. De officiella språken är bosniska, kroatiska och serbiska.", "https://flagcdn.com/ba.svg", "Bosnien och Hercegovina" },
                    { 23, "Afrika", "Botswana, beläget i södra Afrika, blev självständigt från Storbritannien den 30 september 1966. Landet har cirka 2,3 miljoner invånare. Det officiella språket är engelska, men setswana talas också brett.", "https://flagcdn.com/bw.svg", "Botswana" },
                    { 24, "Sydamerika", "Brasilien, det största landet i Sydamerika, blev självständigt från Portugal den 7 september 1822. Landet har cirka 211 miljoner invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/br.svg", "Brasilien" },
                    { 25, "Asien", "Brunei, beläget på ön Borneo i Sydostasien, blev självständigt från Storbritannien den 1 januari 1984. Landet har cirka 437 000 invånare. Det officiella språket är malajiska.", "https://flagcdn.com/bn.svg", "Brunei" },
                    { 26, "Europa", "Bulgarien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 22 september 1908. Landet har cirka 7 miljoner invånare. Det officiella språket är bulgariska.", "https://flagcdn.com/bg.svg", "Bulgarien" },
                    { 27, "Afrika", "Burkina Faso, ett land i Västafrika, blev självständigt från Frankrike den 5 augusti 1960. Landet har cirka 21 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/bf.svg", "Burkina Faso" },
                    { 28, "Afrika", "Burundi, beläget i Östafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kirundi, franska och engelska.", "https://flagcdn.com/bi.svg", "Burundi" },
                    { 29, "Afrika", "Cabo Verde, en ögrupp utanför nordvästra Afrikas kust, blev självständigt från Portugal den 5 juli 1975. Landet har cirka 550 000 invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/cv.svg", "Cabo Verde" },
                    { 30, "Asien", "Kambodja, beläget i Sydostasien, blev självständigt från Frankrike den 9 november 1953. Landet har cirka 16 miljoner invånare. Det officiella språket är khmer.", "https://flagcdn.com/kh.svg", "Kambodja" },
                    { 31, "Afrika", "Kamerun, ett land i Centralafrika, blev självständigt från Frankrike den 1 januari 1960. Landet har cirka 26 miljoner invånare. De officiella språken är franska och engelska.", "https://flagcdn.com/cm.svg", "Kamerun" },
                    { 32, "Nordamerika", "Kanada, världens näst största land till ytan, blev självständigt från Storbritannien den 1 juli 1867. Landet har cirka 37 miljoner invånare. De officiella språken är engelska och franska.", "https://flagcdn.com/ca.svg", "Kanada" },
                    { 33, "Afrika", "Centralafrikanska republiken, beläget i hjärtat av Afrika, blev självständigt från Frankrike den 13 augusti 1960. Landet har cirka 4,8 miljoner invånare. De officiella språken är franska och sango.", "https://flagcdn.com/cf.svg", "Centralafrikanska republiken" },
                    { 34, "Afrika", "Tchad, beläget i Nord-Centralafrika, blev självständigt från Frankrike den 11 augusti 1960. Landet har cirka 17 miljoner invånare. De officiella språken är franska och arabiska.", "https://flagcdn.com/td.svg", "Tchad" },
                    { 35, "Sydamerika", "Chile, beläget i Sydamerika, blev självständigt från Spanien den 18 september 1810. Landet har cirka 19 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/cl.svg", "Chile" },
                    { 36, "Asien", "Kina, världens mest folkrika land med cirka 1,4 miljarder invånare, är en av världens äldsta kontinuerliga civilisationer. Landet grundades som Folkrepubliken Kina den 1 oktober 1949. Det officiella språket är mandarin.", "https://flagcdn.com/cn.svg", "Kina" },
                    { 37, "Sydamerika", "Colombia, beläget i norra Sydamerika, blev självständigt från Spanien den 20 juli 1810. Landet har cirka 50 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/co.svg", "Colombia" },
                    { 38, "Afrika", "Komorerna är en ögruppsnation utanför Afrikas östkust som blev självständigt från Frankrike den 6 juli 1975. Landet har cirka 870 000 invånare. De officiella språken är komoriska, arabiska och franska.", "https://flagcdn.com/km.svg", "Komorerna" },
                    { 39, "Afrika", "Kongo-Brazzaville, officiellt Republiken Kongo, blev självständigt från Frankrike den 15 augusti 1960. Landet har cirka 5,5 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/cg.svg", "Kongo-Brazzaville" },
                    { 40, "Afrika", "Kongo-Kinshasa, officiellt Demokratiska republiken Kongo, blev självständigt från Belgien den 30 juni 1960. Landet har cirka 89 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/cd.svg", "Kongo-Kinshasa" },
                    { 41, "Nordamerika", "Costa Rica, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 5 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/cr.svg", "Costa Rica" },
                    { 42, "Europa", "Kroatien, beläget i Sydöstra Europa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 4 miljoner invånare. Det officiella språket är kroatiska.", "https://flagcdn.com/hr.svg", "Kroatien" },
                    { 43, "Nordamerika", "Kuba, en ö-nation i Karibien, blev självständigt från Spanien den 20 maj 1902. Landet har cirka 11 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/cu.svg", "Kuba" },
                    { 44, "Asien", "Cypern, en ö i östra Medelhavet, blev självständigt från Storbritannien den 16 augusti 1960. Landet har cirka 1,2 miljoner invånare. De officiella språken är grekiska och turkiska.", "https://flagcdn.com/cy.svg", "Cypern" },
                    { 45, "Europa", "Tjeckien, beläget i Centraleuropa, blev självständigt som Tjeckoslovakien från Österrike-Ungern den 28 oktober 1918. Landet har cirka 10,7 miljoner invånare. Det officiella språket är tjeckiska.", "https://flagcdn.com/cz.svg", "Tjeckien" },
                    { 46, "Europa", "Danmark, ett nordiskt land i Europa, har en lång historia som självständig nation och är världens äldsta monarki. Landet har cirka 5,8 miljoner invånare. Det officiella språket är danska.", "https://flagcdn.com/dk.svg", "Danmark" },
                    { 47, "Afrika", "Djibouti, beläget i Afrikas horn, blev självständigt från Frankrike den 27 juni 1977. Landet har cirka 1 miljon invånare. De officiella språken är franska och arabiska.", "https://flagcdn.com/dj.svg", "Djibouti" },
                    { 48, "Nordamerika", "Dominica, en ö-nation i Karibien, blev självständigt från Storbritannien den 3 november 1978. Landet har cirka 71 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/dm.svg", "Dominica" },
                    { 49, "Nordamerika", "Dominikanska republiken, beläget på ön Hispaniola i Karibien, blev självständigt från Haiti den 27 februari 1844. Landet har cirka 10,8 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/do.svg", "Dominikanska republiken" },
                    { 50, "Asien", "Östtimor, beläget i Sydostasien, blev självständigt från Indonesien den 20 maj 2002. Landet har cirka 1,3 miljoner invånare. Det officiella språket är portugisiska och tetum.", "https://flagcdn.com/tl.svg", "Östtimor" },
                    { 51, "Sydamerika", "Ecuador, beläget i nordvästra Sydamerika, blev självständigt från Spanien den 24 maj 1822. Landet har cirka 17 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/ec.svg", "Ecuador" },
                    { 52, "Afrika", "Egypten, beläget i Nordafrika, blev självständigt från Storbritannien den 28 februari 1922. Landet har cirka 100 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/eg.svg", "Egypten" },
                    { 53, "Nordamerika", "El Salvador, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,5 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/sv.svg", "El Salvador" },
                    { 54, "Afrika", "Ekvatorialguinea, beläget i Centralafrika, blev självständigt från Spanien den 12 oktober 1968. Landet har cirka 1,4 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/gq.svg", "Ekvatorialguinea" },
                    { 55, "Afrika", "Eritrea, beläget i östra Afrika vid Röda havet, blev självständigt från Etiopien den 24 maj 1993. Landet har cirka 5,3 miljoner invånare. De officiella språken är tigrinska, arabiska och engelska.", "https://flagcdn.com/er.svg", "Eritrea" },
                    { 56, "Europa", "Estland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 20 augusti 1991. Landet har cirka 1,3 miljoner invånare. Det officiella språket är estniska.", "https://flagcdn.com/ee.svg", "Estland" },
                    { 57, "Afrika", "Eswatini, tidigare känt som Swaziland, är ett litet land i södra Afrika. Det blev självständigt från Storbritannien den 6 september 1968. Landet har cirka 1,1 miljoner invånare. De officiella språken är swazi och engelska.", "https://flagcdn.com/sz.svg", "Eswatini" },
                    { 58, "Afrika", "Etiopien, beläget i östra Afrika, är en av världens äldsta nationer och har aldrig varit koloniserat. Landet har cirka 115 miljoner invånare. Det officiella språket är amhariska.", "https://flagcdn.com/et.svg", "Etiopien" },
                    { 59, "Oceanien", "Fiji, en ögrupp i Stilla havet, blev självständigt från Storbritannien den 10 oktober 1970. Landet har cirka 900 000 invånare. De officiella språken är engelska, fijianska och hindi.", "https://flagcdn.com/fj.svg", "Fiji" },
                    { 60, "Europa", "Finland, beläget i norra Europa, blev självständigt från Ryssland den 6 december 1917. Landet har cirka 5,5 miljoner invånare. De officiella språken är finska och svenska.", "https://flagcdn.com/fi.svg", "Finland" },
                    { 61, "Europa", "Frankrike, beläget i Västeuropa, är en av världens äldsta nationer. Landet har cirka 67 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/fr.svg", "Frankrike" },
                    { 62, "Afrika", "Gabon, beläget i Centralafrika, blev självständigt från Frankrike den 17 augusti 1960. Landet har cirka 2,2 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/ga.svg", "Gabon" },
                    { 63, "Afrika", "Gambia, ett litet land i Västafrika, blev självständigt från Storbritannien den 18 februari 1965. Landet har cirka 2,4 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/gm.svg", "Gambia" },
                    { 64, "Asien", "Georgien, beläget vid gränsen mellan Europa och Asien, blev självständigt från Sovjetunionen den 9 april 1991. Landet har cirka 3,7 miljoner invånare. Det officiella språket är georgiska.", "https://flagcdn.com/ge.svg", "Georgien" },
                    { 65, "Europa", "Tyskland, beläget i Centraleuropa, återförenades som en nation den 3 oktober 1990 efter att ha varit uppdelat efter andra världskriget. Landet har cirka 83 miljoner invånare. Det officiella språket är tyska.", "https://flagcdn.com/de.svg", "Tyskland" },
                    { 66, "Afrika", "Ghana, beläget i Västafrika, blev självständigt från Storbritannien den 6 mars 1957. Landet har cirka 31 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/gh.svg", "Ghana" },
                    { 67, "Europa", "Grekland, beläget i Sydöstra Europa, är känt som demokratins födelseplats. Landet blev självständigt från Osmanska riket den 25 mars 1821. Landet har cirka 10,4 miljoner invånare. Det officiella språket är grekiska.", "https://flagcdn.com/gr.svg", "Grekland" },
                    { 68, "Nordamerika", "Grenada, en ö-nation i Karibien, blev självständigt från Storbritannien den 7 februari 1974. Landet har cirka 112 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/gd.svg", "Grenada" },
                    { 69, "Nordamerika", "Guatemala, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 18 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/gt.svg", "Guatemala" },
                    { 70, "Afrika", "Guinea, beläget i Västafrika, blev självständigt från Frankrike den 2 oktober 1958. Landet har cirka 13 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/gn.svg", "Guinea" },
                    { 71, "Afrika", "Guinea-Bissau, beläget i Västafrika, blev självständigt från Portugal den 24 september 1973. Landet har cirka 2 miljoner invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/gw.svg", "Guinea-Bissau" },
                    { 72, "Sydamerika", "Guyana, beläget i norra Sydamerika, blev självständigt från Storbritannien den 26 maj 1966. Landet har cirka 786 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/gy.svg", "Guyana" },
                    { 73, "Nordamerika", "Haiti, beläget på ön Hispaniola i Karibien, blev självständigt från Frankrike den 1 januari 1804. Landet har cirka 11 miljoner invånare. De officiella språken är franska och haitisk kreol.", "https://flagcdn.com/ht.svg", "Haiti" },
                    { 74, "Nordamerika", "Honduras, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 9,9 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/hn.svg", "Honduras" },
                    { 75, "Europa", "Ungern, beläget i Centraleuropa, blev en självständig stat efter första världskriget den 31 oktober 1918. Landet har cirka 9,6 miljoner invånare. Det officiella språket är ungerska.", "https://flagcdn.com/hu.svg", "Ungern" },
                    { 76, "Europa", "Island, beläget i norra Atlanten, blev en självständig republik den 17 juni 1944. Landet har cirka 364 000 invånare. Det officiella språket är isländska.", "https://flagcdn.com/is.svg", "Island" },
                    { 77, "Asien", "Indien, beläget i Sydasien, blev självständigt från Storbritannien den 15 augusti 1947. Landet har cirka 1,3 miljarder invånare. De officiella språken är hindi och engelska.", "https://flagcdn.com/in.svg", "Indien" },
                    { 78, "Asien", "Indonesien, en ö-nation i Sydostasien, blev självständigt från Nederländerna den 17 augusti 1945. Landet har cirka 270 miljoner invånare. Det officiella språket är indonesiska.", "https://flagcdn.com/id.svg", "Indonesien" },
                    { 79, "Asien", "Iran, beläget i Mellanöstern, blev en islamisk republik efter revolutionen den 11 februari 1979. Landet har cirka 83 miljoner invånare. Det officiella språket är persiska.", "https://flagcdn.com/ir.svg", "Iran" },
                    { 80, "Asien", "Irak, beläget i Mellanöstern, blev självständigt från Storbritannien den 3 oktober 1932. Landet har cirka 40 miljoner invånare. De officiella språken är arabiska och kurdiska.", "https://flagcdn.com/iq.svg", "Irak" },
                    { 81, "Europa", "Irland, beläget i nordvästra Europa, blev en självständig stat från Storbritannien den 6 december 1922. Landet har cirka 4,9 miljoner invånare. Det officiella språket är engelska och iriska.", "https://flagcdn.com/ie.svg", "Irland" },
                    { 82, "Europa", "Italien, beläget i södra Europa på den apenninska halvön, blev en enad nation 1861. Landet har cirka 60 miljoner invånare. Det officiella språket är italienska.", "https://flagcdn.com/it.svg", "Italien" },
                    { 83, "Afrika", "Elfenbenskusten, beläget i Västafrika, blev självständigt från Frankrike den 7 augusti 1960. Landet har cirka 26 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/ci.svg", "Elfenbenskusten" },
                    { 84, "Nordamerika", "Jamaica, en ö-nation i Karibien, blev självständigt från Storbritannien den 6 augusti 1962. Landet har cirka 3 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/jm.svg", "Jamaica" },
                    { 85, "Asien", "Japan, en ö-nation i Östasien, har en lång historia som en enad stat. Landet har cirka 126 miljoner invånare. Det officiella språket är japanska.", "https://flagcdn.com/jp.svg", "Japan" },
                    { 86, "Asien", "Jordanien, beläget i Mellanöstern, blev självständigt från Storbritannien den 25 maj 1946. Landet har cirka 10 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/jo.svg", "Jordanien" },
                    { 87, "Asien", "Kazakstan, beläget i Centralasien, blev självständigt från Sovjetunionen den 16 december 1991. Landet har cirka 18 miljoner invånare. De officiella språken är kazakiska och ryska.", "https://flagcdn.com/kz.svg", "Kazakstan" },
                    { 88, "Afrika", "Kenya, beläget i Östafrika, blev självständigt från Storbritannien den 12 december 1963. Landet har cirka 54 miljoner invånare. De officiella språken är engelska och swahili.", "https://flagcdn.com/ke.svg", "Kenya" },
                    { 89, "Oceanien", "Kiribati, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 12 juli 1979. Landet har cirka 119 000 invånare. De officiella språken är engelska och kiribatiska.", "https://flagcdn.com/ki.svg", "Kiribati" },
                    { 90, "Asien", "Nordkorea, officiellt Demokratiska folkrepubliken Korea, grundades den 9 september 1948 efter Koreas delning. Landet har cirka 25 miljoner invånare. Det officiella språket är koreanska.", "https://flagcdn.com/kp.svg", "Nordkorea" },
                    { 91, "Asien", "Sydkorea, officiellt Republiken Korea, grundades den 15 augusti 1948 efter Koreas delning. Landet har cirka 51 miljoner invånare. Det officiella språket är koreanska.", "https://flagcdn.com/kr.svg", "Sydkorea" },
                    { 92, "Europa", "Kosovo, beläget på Balkanhalvön, förklarade självständighet från Serbien den 17 februari 2008. Landet har cirka 1,8 miljoner invånare. Det officiella språket är albanska och serbiska.", "https://flagcdn.com/xk.svg", "Kosovo" },
                    { 93, "Asien", "Kuwait, beläget i Mellanöstern vid Persiska viken, blev självständigt från Storbritannien den 19 juni 1961. Landet har cirka 4,2 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/kw.svg", "Kuwait" },
                    { 94, "Asien", "Kirgizistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 31 augusti 1991. Landet har cirka 6,5 miljoner invånare. De officiella språken är kirgiziska och ryska.", "https://flagcdn.com/kg.svg", "Kirgizistan" },
                    { 95, "Asien", "Laos, beläget i Sydostasien, blev självständigt från Frankrike den 22 oktober 1953. Landet har cirka 7,3 miljoner invånare. Det officiella språket är laotiska.", "https://flagcdn.com/la.svg", "Laos" },
                    { 96, "Europa", "Lettland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 21 augusti 1991. Landet har cirka 1,9 miljoner invånare. Det officiella språket är lettiska.", "https://flagcdn.com/lv.svg", "Lettland" },
                    { 97, "Asien", "Libanon, beläget i Mellanöstern vid Medelhavet, blev självständigt från Frankrike den 22 november 1943. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/lb.svg", "Libanon" },
                    { 98, "Afrika", "Lesotho, ett litet bergigt land omgiven av Sydafrika, blev självständigt från Storbritannien den 4 oktober 1966. Landet har cirka 2 miljoner invånare. De officiella språken är sesotho och engelska.", "https://flagcdn.com/ls.svg", "Lesotho" },
                    { 99, "Afrika", "Liberia, beläget i Västafrika, grundades av frigivna amerikanska slavar och blev en självständig stat den 26 juli 1847. Landet har cirka 5 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/lr.svg", "Liberia" },
                    { 100, "Afrika", "Libyen, beläget i Nordafrika vid Medelhavet, blev självständigt från Italien den 24 december 1951. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/ly.svg", "Libyen" },
                    { 101, "Europa", "Liechtenstein, ett litet alpland mellan Schweiz och Österrike, blev en suverän stat 1719. Landet har cirka 39 000 invånare. Det officiella språket är tyska.", "https://flagcdn.com/li.svg", "Liechtenstein" },
                    { 102, "Europa", "Litauen, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 11 mars 1990. Landet har cirka 2,8 miljoner invånare. Det officiella språket är litauiska.", "https://flagcdn.com/lt.svg", "Litauen" },
                    { 103, "Europa", "Luxemburg, ett litet land i Västeuropa, är ett av världens rikaste länder. Landet har cirka 630 000 invånare. De officiella språken är luxemburgiska, franska och tyska.", "https://flagcdn.com/lu.svg", "Luxemburg" },
                    { 104, "Afrika", "Madagaskar, en stor ö utanför Afrikas sydöstra kust, blev självständigt från Frankrike den 26 juni 1960. Landet har cirka 26 miljoner invånare. De officiella språken är malagassiska och franska.", "https://flagcdn.com/mg.svg", "Madagaskar" },
                    { 105, "Afrika", "Malawi, beläget i sydöstra Afrika, blev självständigt från Storbritannien den 6 juli 1964. Landet har cirka 19 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/mw.svg", "Malawi" },
                    { 106, "Asien", "Malaysia, beläget i Sydostasien, blev självständigt från Storbritannien den 31 augusti 1957. Landet har cirka 32 miljoner invånare. Det officiella språket är malajiska.", "https://flagcdn.com/my.svg", "Malaysia" },
                    { 107, "Asien", "Maldiverna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 26 juli 1965. Landet har cirka 540 000 invånare. Det officiella språket är dhivehi.", "https://flagcdn.com/mv.svg", "Maldiverna" },
                    { 108, "Afrika", "Mali, beläget i Västafrika, blev självständigt från Frankrike den 22 september 1960. Landet har cirka 20 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/ml.svg", "Mali" },
                    { 109, "Europa", "Malta, en ö-nation i Medelhavet, blev självständigt från Storbritannien den 21 september 1964. Landet har cirka 514 000 invånare. De officiella språken är maltesiska och engelska.", "https://flagcdn.com/mt.svg", "Malta" },
                    { 110, "Oceanien", "Marshallöarna, en ö-nation i Stilla havet, blev självständigt från USA den 21 oktober 1986. Landet har cirka 59 000 invånare. De officiella språken är engelska och marshallesiska.", "https://flagcdn.com/mh.svg", "Marshallöarna" },
                    { 111, "Afrika", "Mauretanien, beläget i Västafrika, blev självständigt från Frankrike den 28 november 1960. Landet har cirka 4,5 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/mr.svg", "Mauretanien" },
                    { 112, "Afrika", "Mauritius, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 12 mars 1968. Landet har cirka 1,3 miljoner invånare. De officiella språken är engelska och franska.", "https://flagcdn.com/mu.svg", "Mauritius" },
                    { 113, "Nordamerika", "Mexiko, beläget i Nordamerika, blev självständigt från Spanien den 16 september 1810. Landet har cirka 128 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/mx.svg", "Mexiko" },
                    { 114, "Oceanien", "Mikronesien, en ö-nation i Stilla havet, blev självständigt från USA den 3 november 1986. Landet har cirka 104 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/fm.svg", "Mikronesien" },
                    { 115, "Europa", "Moldavien, beläget i Östeuropa, blev självständigt från Sovjetunionen den 27 augusti 1991. Landet har cirka 2,6 miljoner invånare. Det officiella språket är rumänska.", "https://flagcdn.com/md.svg", "Moldavien" },
                    { 116, "Europa", "Monaco, en liten stadsstat på franska rivieran, är världens näst minsta land. Landet har cirka 39 000 invånare. Det officiella språket är franska.", "https://flagcdn.com/mc.svg", "Monaco" },
                    { 117, "Asien", "Mongoliet, beläget i Östasien, blev självständigt från Kina den 11 juli 1921. Landet har cirka 3,2 miljoner invånare. Det officiella språket är mongoliska.", "https://flagcdn.com/mn.svg", "Mongoliet" },
                    { 118, "Europa", "Montenegro, beläget på Balkanhalvön, blev självständigt från Serbien och Montenegro den 3 juni 2006. Landet har cirka 620 000 invånare. Det officiella språket är montenegrinska.", "https://flagcdn.com/me.svg", "Montenegro" },
                    { 119, "Afrika", "Marocko, beläget i Nordafrika vid Atlanten och Medelhavet, blev självständigt från Frankrike den 2 mars 1956. Landet har cirka 36 miljoner invånare. De officiella språken är arabiska och berbiska.", "https://flagcdn.com/ma.svg", "Marocko" },
                    { 120, "Afrika", "Moçambique, beläget i sydöstra Afrika, blev självständigt från Portugal den 25 juni 1975. Landet har cirka 30 miljoner invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/mz.svg", "Moçambique" },
                    { 121, "Asien", "Myanmar, tidigare känt som Burma, beläget i Sydostasien, blev självständigt från Storbritannien den 4 januari 1948. Landet har cirka 54 miljoner invånare. Det officiella språket är burmesiska.", "https://flagcdn.com/mm.svg", "Myanmar" },
                    { 122, "Afrika", "Namibia, beläget i sydvästra Afrika, blev självständigt från Sydafrika den 21 mars 1990. Landet har cirka 2,5 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/na.svg", "Namibia" },
                    { 123, "Oceanien", "Nauru, en liten ö-nation i Stilla havet, blev självständigt från Australien, Nya Zeeland och Storbritannien den 31 januari 1968. Landet har cirka 10 000 invånare. Det officiella språket är nauruanska.", "https://flagcdn.com/nr.svg", "Nauru" },
                    { 124, "Asien", "Nepal, beläget i Himalaya, är en av världens äldsta suveräna stater. Landet har cirka 29 miljoner invånare. Det officiella språket är nepalesiska.", "https://flagcdn.com/np.svg", "Nepal" },
                    { 125, "Europa", "Nederländerna, beläget i Västeuropa, har en lång historia som självständig nation. Landet har cirka 17 miljoner invånare. Det officiella språket är nederländska.", "https://flagcdn.com/nl.svg", "Nederländerna" },
                    { 126, "Oceanien", "Nya Zeeland, en ö-nation i sydvästra Stilla havet, blev självständigt från Storbritannien den 26 september 1907. Landet har cirka 5 miljoner invånare. De officiella språken är engelska och maori.", "https://flagcdn.com/nz.svg", "Nya Zeeland" },
                    { 127, "Nordamerika", "Nicaragua, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,6 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/ni.svg", "Nicaragua" },
                    { 128, "Afrika", "Niger, beläget i Västafrika, blev självständigt från Frankrike den 3 augusti 1960. Landet har cirka 24 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/ne.svg", "Niger" },
                    { 129, "Afrika", "Nigeria, beläget i Västafrika, blev självständigt från Storbritannien den 1 oktober 1960. Landet har cirka 206 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/ng.svg", "Nigeria" },
                    { 130, "Europa", "Nordmakedonien, beläget på Balkanhalvön, blev självständigt från Jugoslavien den 8 september 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är makedonska.", "https://flagcdn.com/mk.svg", "Nordmakedonien" },
                    { 131, "Europa", "Norge, beläget i norra Europa på Skandinaviska halvön, blev självständigt från Sverige den 7 juni 1905. Landet har cirka 5,4 miljoner invånare. Det officiella språket är norska.", "https://flagcdn.com/no.svg", "Norge" },
                    { 132, "Asien", "Oman, beläget på Arabiska halvön, blev en självständig stat efter att ha avskaffat det portugisiska styret 1651. Landet har cirka 5 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/om.svg", "Oman" },
                    { 133, "Asien", "Pakistan, beläget i Sydasien, bildades som en självständig stat från Indien den 14 augusti 1947. Landet har cirka 220 miljoner invånare. Det officiella språket är urdu.", "https://flagcdn.com/pk.svg", "Pakistan" },
                    { 134, "Oceanien", "Palau, en ö-nation i Stilla havet, blev självständigt från USA den 1 oktober 1994. Landet har cirka 18 000 invånare. De officiella språken är palauanska och engelska.", "https://flagcdn.com/pw.svg", "Palau" },
                    { 135, "Asien", "Palestina, beläget i Mellanöstern, består av Västbanken och Gaza. Befolkningen uppgår till cirka 5 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/ps.svg", "Palestina" },
                    { 136, "Nordamerika", "Panama, beläget i Centralamerika, blev självständigt från Colombia den 3 november 1903. Landet har cirka 4,2 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/pa.svg", "Panama" },
                    { 137, "Oceanien", "Papua Nya Guinea, beläget i sydvästra Stilla havet, blev självständigt från Australien den 16 september 1975. Landet har cirka 8,9 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/pg.svg", "Papua Nya Guinea" },
                    { 138, "Sydamerika", "Paraguay, beläget i Sydamerika, blev självständigt från Spanien den 14 maj 1811. Landet har cirka 7 miljoner invånare. De officiella språken är spanska och guarani.", "https://flagcdn.com/py.svg", "Paraguay" },
                    { 139, "Sydamerika", "Peru, beläget i västra Sydamerika, blev självständigt från Spanien den 28 juli 1821. Landet har cirka 33 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/pe.svg", "Peru" },
                    { 140, "Asien", "Filippinerna, en ö-nation i Sydostasien, blev självständigt från USA den 4 juli 1946. Landet har cirka 109 miljoner invånare. Det officiella språket är filippinska och engelska.", "https://flagcdn.com/ph.svg", "Filippinerna" },
                    { 141, "Europa", "Polen, beläget i Centraleuropa, återfick sin självständighet den 11 november 1918 efter att ha varit uppdelat mellan olika imperier i över ett sekel. Landet har cirka 38 miljoner invånare. Det officiella språket är polska.", "https://flagcdn.com/pl.svg", "Polen" },
                    { 142, "Europa", "Portugal, beläget på den iberiska halvön i södra Europa, är en av världens äldsta nationer. Landet har cirka 10 miljoner invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/pt.svg", "Portugal" },
                    { 143, "Asien", "Qatar, beläget på Arabiska halvön vid Persiska viken, blev självständigt från Storbritannien den 3 september 1971. Landet har cirka 2,8 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/qa.svg", "Qatar" },
                    { 144, "Europa", "Rumänien, beläget i sydöstra Europa, blev självständigt från Osmanska riket den 9 maj 1877. Landet har cirka 19 miljoner invånare. Det officiella språket är rumänska.", "https://flagcdn.com/ro.svg", "Rumänien" },
                    { 145, "Europa", "Ryssland, världens största land till ytan, blev självständigt från Sovjetunionen den 25 december 1991. Landet har cirka 146 miljoner invånare. Det officiella språket är ryska.", "https://flagcdn.com/ru.svg", "Ryssland" },
                    { 146, "Afrika", "Rwanda, beläget i Centralafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kinyarwanda, franska och engelska.", "https://flagcdn.com/rw.svg", "Rwanda" },
                    { 147, "Nordamerika", "Saint Kitts och Nevis, en ö-nation i Karibien, blev självständigt från Storbritannien den 19 september 1983. Landet har cirka 53 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/kn.svg", "Saint Kitts och Nevis" },
                    { 148, "Nordamerika", "Saint Lucia, en ö-nation i Karibien, blev självständigt från Storbritannien den 22 februari 1979. Landet har cirka 180 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/lc.svg", "Saint Lucia" },
                    { 149, "Nordamerika", "Saint Vincent och Grenadinerna, en ö-nation i Karibien, blev självständigt från Storbritannien den 27 oktober 1979. Landet har cirka 110 000 invånare. Det officiella språket är engelska.", "https://flagcdn.com/vc.svg", "Saint Vincent och Grenadinerna" },
                    { 150, "Oceanien", "Samoa, en ö-nation i Stilla havet, blev självständigt från Nya Zeeland den 1 januari 1962. Landet har cirka 200 000 invånare. Det officiella språket är samoanska och engelska.", "https://flagcdn.com/ws.svg", "Samoa" },
                    { 151, "Europa", "San Marino, en mikrostatsrepublik belägen i norra Italien, anses vara världens äldsta republik. Landet har cirka 34 000 invånare. Det officiella språket är italienska.", "https://flagcdn.com/sm.svg", "San Marino" },
                    { 152, "Afrika", "Sao Tomé och Principe, en ö-nation i Guineabukten, blev självständigt från Portugal den 12 juli 1975. Landet har cirka 200 000 invånare. Det officiella språket är portugisiska.", "https://flagcdn.com/st.svg", "Sao Tomé och Principe" },
                    { 153, "Asien", "Saudiarabien, beläget på Arabiska halvön, grundades som ett enat kungarike den 23 september 1932. Landet har cirka 34 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/sa.svg", "Saudiarabien" },
                    { 154, "Afrika", "Senegal, beläget i Västafrika, blev självständigt från Frankrike den 20 augusti 1960. Landet har cirka 16 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/sn.svg", "Senegal" },
                    { 155, "Europa", "Serbien, beläget på Balkanhalvön, blev självständigt från unionen med Montenegro den 5 juni 2006. Landet har cirka 7 miljoner invånare. Det officiella språket är serbiska.", "https://flagcdn.com/rs.svg", "Serbien" },
                    { 156, "Afrika", "Seychellerna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 29 juni 1976. Landet har cirka 98 000 invånare. De officiella språken är kreol, engelska och franska.", "https://flagcdn.com/sc.svg", "Seychellerna" },
                    { 157, "Afrika", "Sierra Leone, beläget i Västafrika, blev självständigt från Storbritannien den 27 april 1961. Landet har cirka 7,5 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/sl.svg", "Sierra Leone" },
                    { 158, "Asien", "Singapore, en stadstat i Sydostasien, blev självständigt från Malaysia den 9 augusti 1965. Landet har cirka 5,7 miljoner invånare. De officiella språken är engelska, mandarin, malajiska och tamil.", "https://flagcdn.com/sg.svg", "Singapore" },
                    { 159, "Europa", "Slovakien, beläget i Centraleuropa, blev självständigt från Tjeckoslovakien den 1 januari 1993. Landet har cirka 5,4 miljoner invånare. Det officiella språket är slovakiska.", "https://flagcdn.com/sk.svg", "Slovakien" },
                    { 160, "Europa", "Slovenien, beläget i Centraleuropa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är slovenska.", "https://flagcdn.com/si.svg", "Slovenien" },
                    { 161, "Oceanien", "Salomonöarna, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 7 juli 1978. Landet har cirka 652 000 invånare. De officiella språken är engelska och pijin.", "https://flagcdn.com/sb.svg", "Salomonöarna" },
                    { 162, "Afrika", "Somalia, beläget i Afrikas horn, blev självständigt från Storbritannien och Italien den 1 juli 1960. Landet har cirka 15 miljoner invånare. Det officiella språket är somaliska.", "https://flagcdn.com/so.svg", "Somalia" },
                    { 163, "Afrika", "Sydafrika, beläget på Afrikas sydspets, blev självständigt från Storbritannien den 31 maj 1910. Landet har cirka 58 miljoner invånare. Det finns 11 officiella språk, inklusive afrikaans och engelska.", "https://flagcdn.com/za.svg", "Sydafrika" },
                    { 164, "Afrika", "Sydsudan, världens yngsta nation, blev självständigt från Sudan den 9 juli 2011. Landet har cirka 11 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/ss.svg", "Sydsudan" },
                    { 165, "Europa", "Spanien, beläget på den iberiska halvön i södra Europa, är känt för sin rika kultur och historia. Landet har cirka 47 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/es.svg", "Spanien" },
                    { 166, "Asien", "Sri Lanka, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 4 februari 1948. Landet har cirka 21 miljoner invånare. De officiella språken är singalesiska och tamil.", "https://flagcdn.com/lk.svg", "Sri Lanka" },
                    { 167, "Afrika", "Sudan, beläget i Nordafrika, blev självständigt från Egypten och Storbritannien den 1 januari 1956. Landet har cirka 42 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/sd.svg", "Sudan" },
                    { 168, "Sydamerika", "Surinam, beläget i norra Sydamerika, blev självständigt från Nederländerna den 25 november 1975. Landet har cirka 586 000 invånare. Det officiella språket är nederländska.", "https://flagcdn.com/sr.svg", "Surinam" },
                    { 169, "Europa", "Sverige, beläget i norra Europa på Skandinaviska halvön, har en lång historia som självständig nation. Landet har cirka 10,3 miljoner invånare. Det officiella språket är svenska.", "https://flagcdn.com/se.svg", "Sverige" },
                    { 170, "Europa", "Schweiz, beläget i Centraleuropa, är känt för sin neutralitet och stabilitet. Landet har cirka 8,5 miljoner invånare. De officiella språken är tyska, franska, italienska och rätoromanska.", "https://flagcdn.com/ch.svg", "Schweiz" },
                    { 171, "Asien", "Syrien, beläget i Mellanöstern, blev självständigt från Frankrike den 17 april 1946. Landet har cirka 17 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/sy.svg", "Syrien" },
                    { 172, "Asien", "Tadzjikistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 9 september 1991. Landet har cirka 9,5 miljoner invånare. Det officiella språket är tadzjikiska.", "https://flagcdn.com/tj.svg", "Tadzjikistan" },
                    { 173, "Afrika", "Tanzania, beläget i Östafrika, bildades genom sammanslagningen av Tanganyika och Zanzibar den 26 april 1964. Landet har cirka 58 miljoner invånare. De officiella språken är swahili och engelska.", "https://flagcdn.com/tz.svg", "Tanzania" },
                    { 174, "Asien", "Thailand, beläget i Sydostasien, är känt för sin rika kultur och historia. Landet har cirka 70 miljoner invånare. Det officiella språket är thailändska.", "https://flagcdn.com/th.svg", "Thailand" },
                    { 175, "Afrika", "Togo, beläget i Västafrika, blev självständigt från Frankrike den 27 april 1960. Landet har cirka 8 miljoner invånare. Det officiella språket är franska.", "https://flagcdn.com/tg.svg", "Togo" },
                    { 176, "Oceanien", "Tonga, en ö-nation i Stilla havet, blev aldrig koloniserat men blev en konstitutionell monarki 1875. Landet har cirka 104 000 invånare. Det officiella språket är tonganska och engelska.", "https://flagcdn.com/to.svg", "Tonga" },
                    { 177, "Nordamerika", "Trinidad och Tobago, en ö-nation i Karibien, blev självständigt från Storbritannien den 31 augusti 1962. Landet har cirka 1,4 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/tt.svg", "Trinidad och Tobago" },
                    { 178, "Afrika", "Tunisien, beläget i Nordafrika vid Medelhavet, blev självständigt från Frankrike den 20 mars 1956. Landet har cirka 12 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/tn.svg", "Tunisien" },
                    { 179, "Asien", "Turkiet, beläget på gränsen mellan Europa och Asien, blev en republik den 29 oktober 1923 efter det osmanska rikets fall. Landet har cirka 82 miljoner invånare. Det officiella språket är turkiska.", "https://flagcdn.com/tr.svg", "Turkiet" },
                    { 180, "Asien", "Turkmenistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 27 oktober 1991. Landet har cirka 6 miljoner invånare. Det officiella språket är turkmeniska.", "https://flagcdn.com/tm.svg", "Turkmenistan" },
                    { 181, "Oceanien", "Tuvalu, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 1 oktober 1978. Landet har cirka 11 000 invånare. De officiella språken är tuvaluanska och engelska.", "https://flagcdn.com/tv.svg", "Tuvalu" },
                    { 182, "Afrika", "Uganda, beläget i Östafrika, blev självständigt från Storbritannien den 9 oktober 1962. Landet har cirka 45 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/ug.svg", "Uganda" },
                    { 183, "Europa", "Ukraina, beläget i Östeuropa, blev självständigt från Sovjetunionen den 24 augusti 1991. Landet har cirka 41 miljoner invånare. Det officiella språket är ukrainska.", "https://flagcdn.com/ua.svg", "Ukraina" },
                    { 184, "Asien", "Förenade Arabemiraten, beläget i Mellanöstern, blev självständigt från Storbritannien den 2 december 1971. Landet har cirka 9,9 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/ae.svg", "Förenade Arabemiraten" },
                    { 185, "Europa", "Storbritannien, beläget i nordvästra Europa, är en av världens äldsta konstitutionella monarkier. Landet har cirka 67 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/gb.svg", "Storbritannien" },
                    { 186, "Nordamerika", "USA, beläget i Nordamerika, blev självständigt från Storbritannien den 4 juli 1776. Landet har cirka 331 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/us.svg", "USA" },
                    { 187, "Sydamerika", "Uruguay, beläget i Sydamerika, blev självständigt från Brasilien den 25 augusti 1825. Landet har cirka 3,5 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/uy.svg", "Uruguay" },
                    { 188, "Asien", "Uzbekistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 1 september 1991. Landet har cirka 33 miljoner invånare. Det officiella språket är uzbekiska.", "https://flagcdn.com/uz.svg", "Uzbekistan" },
                    { 189, "Oceanien", "Vanuatu, en ö-nation i Stilla havet, blev självständigt från Frankrike och Storbritannien den 30 juli 1980. Landet har cirka 307 000 invånare. De officiella språken är bislama, engelska och franska.", "https://flagcdn.com/vu.svg", "Vanuatu" },
                    { 190, "Europa", "Vatikanstaten, en mikrostatsstat i Rom, är världens minsta suveräna stat. Landet har cirka 800 invånare. Det officiella språket är latin.", "https://flagcdn.com/va.svg", "Vatikanstaten" },
                    { 191, "Sydamerika", "Venezuela, beläget i norra Sydamerika, blev självständigt från Spanien den 5 juli 1811. Landet har cirka 28 miljoner invånare. Det officiella språket är spanska.", "https://flagcdn.com/ve.svg", "Venezuela" },
                    { 192, "Asien", "Vietnam, beläget i Sydostasien, blev självständigt från Frankrike den 2 september 1945. Landet har cirka 97 miljoner invånare. Det officiella språket är vietnamesiska.", "https://flagcdn.com/vn.svg", "Vietnam" },
                    { 193, "Asien", "Jemen, beläget på Arabiska halvön, blev en enad republik den 22 maj 1990. Landet har cirka 29 miljoner invånare. Det officiella språket är arabiska.", "https://flagcdn.com/ye.svg", "Jemen" },
                    { 194, "Afrika", "Zambia, beläget i södra Afrika, blev självständigt från Storbritannien den 24 oktober 1964. Landet har cirka 18 miljoner invånare. Det officiella språket är engelska.", "https://flagcdn.com/zm.svg", "Zambia" },
                    { 195, "Afrika", "Zimbabwe, beläget i södra Afrika, blev självständigt från Storbritannien den 18 april 1980. Landet har cirka 14 miljoner invånare. De officiella språken är engelska, shona och ndebele.", "https://flagcdn.com/zw.svg", "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CountryId", "Difficulty" },
                values: new object[,]
                {
                    { 1, 1, "Hard" },
                    { 2, 2, "Normal" },
                    { 3, 3, "Normal" },
                    { 4, 4, "Hard" },
                    { 5, 5, "Normal" },
                    { 6, 6, "Hard" },
                    { 7, 7, "Easy" },
                    { 8, 8, "Hard" },
                    { 9, 9, "Easy" },
                    { 10, 10, "Normal" },
                    { 11, 11, "Normal" },
                    { 12, 12, "Hard" },
                    { 13, 13, "Normal" },
                    { 14, 14, "Normal" },
                    { 15, 15, "Hard" },
                    { 16, 16, "Hard" },
                    { 17, 17, "Normal" },
                    { 18, 18, "Hard" },
                    { 19, 19, "Normal" },
                    { 20, 20, "Hard" },
                    { 21, 21, "Normal" },
                    { 22, 22, "Hard" },
                    { 23, 23, "Hard" },
                    { 24, 24, "Easy" },
                    { 25, 25, "Hard" },
                    { 26, 26, "Normal" },
                    { 27, 27, "Hard" },
                    { 28, 28, "Hard" },
                    { 29, 29, "Hard" },
                    { 30, 30, "Normal" },
                    { 31, 31, "Normal" },
                    { 32, 32, "Easy" },
                    { 33, 33, "Hard" },
                    { 34, 34, "Normal" },
                    { 35, 35, "Easy" },
                    { 36, 36, "Easy" },
                    { 37, 37, "Easy" },
                    { 38, 38, "Hard" },
                    { 39, 39, "Normal" },
                    { 40, 40, "Normal" },
                    { 41, 41, "Normal" },
                    { 42, 42, "Normal" },
                    { 43, 43, "Normal" },
                    { 44, 44, "Normal" },
                    { 45, 45, "Normal" },
                    { 46, 46, "Normal" },
                    { 47, 47, "Hard" },
                    { 48, 48, "Hard" },
                    { 49, 49, "Normal" },
                    { 50, 50, "Hard" },
                    { 51, 51, "Normal" },
                    { 52, 52, "Easy" },
                    { 53, 53, "Normal" },
                    { 54, 54, "Hard" },
                    { 55, 55, "Hard" },
                    { 56, 56, "Normal" },
                    { 57, 57, "Hard" },
                    { 58, 58, "Normal" },
                    { 59, 59, "Hard" },
                    { 60, 60, "Normal" },
                    { 61, 61, "Easy" },
                    { 62, 62, "Hard" },
                    { 63, 63, "Hard" },
                    { 64, 64, "Hard" },
                    { 65, 65, "Easy" },
                    { 66, 66, "Normal" },
                    { 67, 67, "Easy" },
                    { 68, 68, "Hard" },
                    { 69, 69, "Normal" },
                    { 70, 70, "Hard" },
                    { 71, 71, "Hard" },
                    { 72, 72, "Hard" },
                    { 73, 73, "Normal" },
                    { 74, 74, "Normal" },
                    { 75, 75, "Normal" },
                    { 76, 76, "Hard" },
                    { 77, 77, "Easy" },
                    { 78, 78, "Easy" },
                    { 79, 79, "Normal" },
                    { 80, 80, "Normal" },
                    { 81, 81, "Normal" },
                    { 82, 82, "Easy" },
                    { 83, 83, "Normal" },
                    { 84, 84, "Normal" },
                    { 85, 85, "Easy" },
                    { 86, 86, "Normal" },
                    { 87, 87, "Hard" },
                    { 88, 88, "Normal" },
                    { 89, 89, "Hard" },
                    { 90, 90, "Normal" },
                    { 91, 91, "Normal" },
                    { 92, 92, "Hard" },
                    { 93, 93, "Normal" },
                    { 94, 94, "Hard" },
                    { 95, 95, "Hard" },
                    { 96, 96, "Normal" },
                    { 97, 97, "Normal" },
                    { 98, 98, "Hard" },
                    { 99, 99, "Normal" },
                    { 100, 100, "Normal" },
                    { 101, 101, "Hard" },
                    { 102, 102, "Normal" },
                    { 103, 103, "Normal" },
                    { 104, 104, "Normal" },
                    { 105, 105, "Normal" },
                    { 106, 106, "Normal" },
                    { 107, 107, "Hard" },
                    { 108, 108, "Normal" },
                    { 109, 109, "Hard" },
                    { 110, 110, "Hard" },
                    { 111, 111, "Normal" },
                    { 112, 112, "Hard" },
                    { 113, 113, "Easy" },
                    { 114, 114, "Hard" },
                    { 115, 115, "Hard" },
                    { 116, 116, "Hard" },
                    { 117, 117, "Normal" },
                    { 118, 118, "Hard" },
                    { 119, 119, "Normal" },
                    { 120, 120, "Normal" },
                    { 121, 121, "Normal" },
                    { 122, 122, "Hard" },
                    { 123, 123, "Hard" },
                    { 124, 124, "Normal" },
                    { 125, 125, "Normal" },
                    { 126, 126, "Normal" },
                    { 127, 127, "Normal" },
                    { 128, 128, "Hard" },
                    { 129, 129, "Normal" },
                    { 130, 130, "Hard" },
                    { 131, 131, "Normal" },
                    { 132, 132, "Hard" },
                    { 133, 133, "Normal" },
                    { 134, 134, "Hard" },
                    { 135, 135, "Hard" },
                    { 136, 136, "Normal" },
                    { 137, 137, "Hard" },
                    { 138, 138, "Normal" },
                    { 139, 139, "Normal" },
                    { 140, 140, "Normal" },
                    { 141, 141, "Normal" },
                    { 142, 142, "Easy" },
                    { 143, 143, "Normal" },
                    { 144, 144, "Normal" },
                    { 145, 145, "Easy" },
                    { 146, 146, "Normal" },
                    { 147, 147, "Hard" },
                    { 148, 148, "Hard" },
                    { 149, 149, "Hard" },
                    { 150, 150, "Hard" },
                    { 151, 151, "Hard" },
                    { 152, 152, "Hard" },
                    { 153, 153, "Normal" },
                    { 154, 154, "Normal" },
                    { 155, 155, "Normal" },
                    { 156, 156, "Hard" },
                    { 157, 157, "Hard" },
                    { 158, 158, "Normal" },
                    { 159, 159, "Normal" },
                    { 160, 160, "Normal" },
                    { 161, 161, "Hard" },
                    { 162, 162, "Normal" },
                    { 163, 163, "Easy" },
                    { 164, 164, "Hard" },
                    { 165, 165, "Easy" },
                    { 166, 166, "Normal" },
                    { 167, 167, "Normal" },
                    { 168, 168, "Hard" },
                    { 169, 169, "Easy" },
                    { 170, 170, "Normal" },
                    { 171, 171, "Normal" },
                    { 172, 172, "Hard" },
                    { 173, 173, "Normal" },
                    { 174, 174, "Normal" },
                    { 175, 175, "Hard" },
                    { 176, 176, "Hard" },
                    { 177, 177, "Normal" },
                    { 178, 178, "Normal" },
                    { 179, 179, "Easy" },
                    { 180, 180, "Hard" },
                    { 181, 181, "Hard" },
                    { 182, 182, "Normal" },
                    { 183, 183, "Normal" },
                    { 184, 184, "Normal" },
                    { 185, 185, "Easy" },
                    { 186, 186, "Easy" },
                    { 187, 187, "Normal" },
                    { 188, 188, "Normal" },
                    { 189, 189, "Hard" },
                    { 190, 190, "Hard" },
                    { 191, 191, "Normal" },
                    { 192, 192, "Normal" },
                    { 193, 193, "Normal" },
                    { 194, 194, "Normal" },
                    { 195, 195, "Normal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CountryId",
                table: "Questions",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_UserId",
                table: "Results",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
