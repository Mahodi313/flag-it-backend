using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace flag_it_backend.Migrations
{
    /// <inheritdoc />
    public partial class Länder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Description", "FlagImage", "Name" },
                values: new object[,]
                {
                    { 1, "Asien", "Afghanistan, beläget i Centralasien, blev självständigt från Storbritannien den 19 augusti 1919. Landet har cirka 38 miljoner invånare. De officiella språken är pashto och dari.", "path/to/flag/image", "Afghanistan" },
                    { 2, "Europa", "Albanien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 28 november 1912. Landet har cirka 2,9 miljoner invånare. Det officiella språket är albanska.", "path/to/flag/image", "Albanien" },
                    { 3, "Afrika", "Algeriet, beläget i Nordafrika, blev självständigt från Frankrike den 5 juli 1962. Landet har cirka 44 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Algeriet" },
                    { 4, "Europa", "Andorra, en liten landlocked nation i Pyrenéerna mellan Frankrike och Spanien, har cirka 77 000 invånare. Det officiella språket är katalanska.", "path/to/flag/image", "Andorra" },
                    { 5, "Afrika", "Angola, beläget på västkusten av södra Afrika, blev självständigt från Portugal den 11 november 1975. Landet har cirka 32 miljoner invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Angola" },
                    { 6, "Nordamerika", "Antigua och Barbuda är en ö-nation i Karibien som blev självständigt från Storbritannien den 1 november 1981. Landet har cirka 97 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Antigua och Barbuda" },
                    { 7, "Sydamerika", "Argentina, beläget i Sydamerika, förklarade sig självständigt från Spanien den 9 juli 1816. Landet har cirka 45 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Argentina" },
                    { 8, "Asien", "Armenien, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 21 september 1991. Landet har cirka 3 miljoner invånare. Det officiella språket är armeniska.", "path/to/flag/image", "Armenien" },
                    { 9, "Oceanien", "Australien, en kontinent och land i Oceanien, blev självständigt från Storbritannien den 1 januari 1901. Landet har cirka 25 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Australien" },
                    { 10, "Europa", "Österrike, beläget i Centraleuropa, har en historia av självständighet som går tillbaka till 1156. Landet har cirka 9 miljoner invånare. Det officiella språket är tyska.", "path/to/flag/image", "Österrike" },
                    { 11, "Asien", "Azerbajdzjan, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 30 augusti 1991. Landet har cirka 10 miljoner invånare. Det officiella språket är azerbajdzjanska.", "path/to/flag/image", "Azerbajdzjan" },
                    { 12, "Nordamerika", "Bahamas, en ö-nation i Karibien, blev självständigt från Storbritannien den 10 juli 1973. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Bahamas" },
                    { 13, "Asien", "Bahrain, en ö-nation i Persiska viken, blev självständigt från Storbritannien den 15 augusti 1971. Landet har cirka 1,7 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Bahrain" },
                    { 14, "Asien", "Bangladesh, beläget i Sydasien, blev självständigt från Pakistan den 26 mars 1971. Landet har cirka 163 miljoner invånare. Det officiella språket är bengali.", "path/to/flag/image", "Bangladesh" },
                    { 15, "Nordamerika", "Barbados, en ö-nation i Karibien, blev självständigt från Storbritannien den 30 november 1966. Landet har cirka 287 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Barbados" },
                    { 16, "Europa", "Vitryssland, beläget i Östeuropa, blev självständigt från Sovjetunionen den 25 augusti 1991. Landet har cirka 9,4 miljoner invånare. Det officiella språket är vitryska.", "path/to/flag/image", "Vitryssland" },
                    { 17, "Europa", "Belgien, beläget i Västeuropa, blev självständigt från Nederländerna den 4 oktober 1830. Landet har cirka 11,5 miljoner invånare. De officiella språken är nederländska, franska och tyska.", "path/to/flag/image", "Belgien" },
                    { 18, "Nordamerika", "Belize, ett land i Centralamerika, blev självständigt från Storbritannien den 21 september 1981. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Belize" },
                    { 19, "Afrika", "Benin, ett västafrikanskt land, blev självständigt från Frankrike den 1 augusti 1960. Landet har cirka 12 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Benin" },
                    { 20, "Asien", "Bhutan, ett litet kungarike i Himalaya, har aldrig varit under utländsk kontroll. Landet har cirka 770 000 invånare. Det officiella språket är dzongkha.", "path/to/flag/image", "Bhutan" },
                    { 21, "Sydamerika", "Bolivia, beläget i Sydamerika, blev självständigt från Spanien den 6 augusti 1825. Landet har cirka 11 miljoner invånare. De officiella språken är spanska och flera inhemska språk.", "path/to/flag/image", "Bolivia" },
                    { 22, "Europa", "Bosnien och Hercegovina, beläget i Balkanregionen i Sydöstra Europa, blev självständigt från Jugoslavien den 1 mars 1992. Landet har cirka 3,5 miljoner invånare. De officiella språken är bosniska, kroatiska och serbiska.", "path/to/flag/image", "Bosnien och Hercegovina" },
                    { 23, "Afrika", "Botswana, beläget i södra Afrika, blev självständigt från Storbritannien den 30 september 1966. Landet har cirka 2,3 miljoner invånare. Det officiella språket är engelska, men setswana talas också brett.", "path/to/flag/image", "Botswana" },
                    { 24, "Sydamerika", "Brasilien, det största landet i Sydamerika, blev självständigt från Portugal den 7 september 1822. Landet har cirka 211 miljoner invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Brasilien" },
                    { 25, "Asien", "Brunei, beläget på ön Borneo i Sydostasien, blev självständigt från Storbritannien den 1 januari 1984. Landet har cirka 437 000 invånare. Det officiella språket är malajiska.", "path/to/flag/image", "Brunei" },
                    { 26, "Europa", "Bulgarien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 22 september 1908. Landet har cirka 7 miljoner invånare. Det officiella språket är bulgariska.", "path/to/flag/image", "Bulgarien" },
                    { 27, "Afrika", "Burkina Faso, ett land i Västafrika, blev självständigt från Frankrike den 5 augusti 1960. Landet har cirka 21 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Burkina Faso" },
                    { 28, "Afrika", "Burundi, beläget i Östafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kirundi, franska och engelska.", "path/to/flag/image", "Burundi" },
                    { 29, "Afrika", "Cabo Verde, en ögrupp utanför nordvästra Afrikas kust, blev självständigt från Portugal den 5 juli 1975. Landet har cirka 550 000 invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Cabo Verde" },
                    { 30, "Asien", "Kambodja, beläget i Sydostasien, blev självständigt från Frankrike den 9 november 1953. Landet har cirka 16 miljoner invånare. Det officiella språket är khmer.", "path/to/flag/image", "Kambodja" },
                    { 31, "Afrika", "Kamerun, ett land i Centralafrika, blev självständigt från Frankrike den 1 januari 1960. Landet har cirka 26 miljoner invånare. De officiella språken är franska och engelska.", "path/to/flag/image", "Kamerun" },
                    { 32, "Nordamerika", "Kanada, världens näst största land till ytan, blev självständigt från Storbritannien den 1 juli 1867. Landet har cirka 37 miljoner invånare. De officiella språken är engelska och franska.", "path/to/flag/image", "Kanada" },
                    { 33, "Afrika", "Centralafrikanska republiken, beläget i hjärtat av Afrika, blev självständigt från Frankrike den 13 augusti 1960. Landet har cirka 4,8 miljoner invånare. De officiella språken är franska och sango.", "path/to/flag/image", "Centralafrikanska republiken" },
                    { 34, "Afrika", "Tchad, beläget i Nord-Centralafrika, blev självständigt från Frankrike den 11 augusti 1960. Landet har cirka 17 miljoner invånare. De officiella språken är franska och arabiska.", "path/to/flag/image", "Tchad" },
                    { 35, "Sydamerika", "Chile, beläget i Sydamerika, blev självständigt från Spanien den 18 september 1810. Landet har cirka 19 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Chile" },
                    { 36, "Asien", "Kina, världens mest folkrika land med cirka 1,4 miljarder invånare, är en av världens äldsta kontinuerliga civilisationer. Landet grundades som Folkrepubliken Kina den 1 oktober 1949. Det officiella språket är mandarin.", "path/to/flag/image", "Kina" },
                    { 37, "Sydamerika", "Colombia, beläget i norra Sydamerika, blev självständigt från Spanien den 20 juli 1810. Landet har cirka 50 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Colombia" },
                    { 38, "Afrika", "Komorerna är en ögruppsnation utanför Afrikas östkust som blev självständigt från Frankrike den 6 juli 1975. Landet har cirka 870 000 invånare. De officiella språken är komoriska, arabiska och franska.", "path/to/flag/image", "Komorerna" },
                    { 39, "Afrika", "Kongo-Brazzaville, officiellt Republiken Kongo, blev självständigt från Frankrike den 15 augusti 1960. Landet har cirka 5,5 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Kongo-Brazzaville" },
                    { 40, "Afrika", "Kongo-Kinshasa, officiellt Demokratiska republiken Kongo, blev självständigt från Belgien den 30 juni 1960. Landet har cirka 89 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Kongo-Kinshasa" },
                    { 41, "Nordamerika", "Costa Rica, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 5 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Costa Rica" },
                    { 42, "Europa", "Kroatien, beläget i Sydöstra Europa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 4 miljoner invånare. Det officiella språket är kroatiska.", "path/to/flag/image", "Kroatien" },
                    { 43, "Nordamerika", "Kuba, en ö-nation i Karibien, blev självständigt från Spanien den 20 maj 1902. Landet har cirka 11 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Kuba" },
                    { 44, "Asien", "Cypern, en ö i östra Medelhavet, blev självständigt från Storbritannien den 16 augusti 1960. Landet har cirka 1,2 miljoner invånare. De officiella språken är grekiska och turkiska.", "path/to/flag/image", "Cypern" },
                    { 45, "Europa", "Tjeckien, beläget i Centraleuropa, blev självständigt som Tjeckoslovakien från Österrike-Ungern den 28 oktober 1918. Landet har cirka 10,7 miljoner invånare. Det officiella språket är tjeckiska.", "path/to/flag/image", "Tjeckien" },
                    { 46, "Europa", "Danmark, ett nordiskt land i Europa, har en lång historia som självständig nation och är världens äldsta monarki. Landet har cirka 5,8 miljoner invånare. Det officiella språket är danska.", "path/to/flag/image", "Danmark" },
                    { 47, "Afrika", "Djibouti, beläget i Afrikas horn, blev självständigt från Frankrike den 27 juni 1977. Landet har cirka 1 miljon invånare. De officiella språken är franska och arabiska.", "path/to/flag/image", "Djibouti" },
                    { 48, "Nordamerika", "Dominica, en ö-nation i Karibien, blev självständigt från Storbritannien den 3 november 1978. Landet har cirka 71 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Dominica" },
                    { 49, "Nordamerika", "Dominikanska republiken, beläget på ön Hispaniola i Karibien, blev självständigt från Haiti den 27 februari 1844. Landet har cirka 10,8 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Dominikanska republiken" },
                    { 50, "Asien", "Östtimor, beläget i Sydostasien, blev självständigt från Indonesien den 20 maj 2002. Landet har cirka 1,3 miljoner invånare. Det officiella språket är portugisiska och tetum.", "path/to/flag/image", "Östtimor" },
                    { 51, "Sydamerika", "Ecuador, beläget i nordvästra Sydamerika, blev självständigt från Spanien den 24 maj 1822. Landet har cirka 17 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Ecuador" },
                    { 52, "Afrika", "Egypten, beläget i Nordafrika, blev självständigt från Storbritannien den 28 februari 1922. Landet har cirka 100 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Egypten" },
                    { 53, "Nordamerika", "El Salvador, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,5 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "El Salvador" },
                    { 54, "Afrika", "Ekvatorialguinea, beläget i Centralafrika, blev självständigt från Spanien den 12 oktober 1968. Landet har cirka 1,4 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Ekvatorialguinea" },
                    { 55, "Afrika", "Eritrea, beläget i östra Afrika vid Röda havet, blev självständigt från Etiopien den 24 maj 1993. Landet har cirka 5,3 miljoner invånare. De officiella språken är tigrinska, arabiska och engelska.", "path/to/flag/image", "Eritrea" },
                    { 56, "Europa", "Estland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 20 augusti 1991. Landet har cirka 1,3 miljoner invånare. Det officiella språket är estniska.", "path/to/flag/image", "Estland" },
                    { 57, "Afrika", "Eswatini, tidigare känt som Swaziland, är ett litet land i södra Afrika. Det blev självständigt från Storbritannien den 6 september 1968. Landet har cirka 1,1 miljoner invånare. De officiella språken är swazi och engelska.", "path/to/flag/image", "Eswatini" },
                    { 58, "Afrika", "Etiopien, beläget i östra Afrika, är en av världens äldsta nationer och har aldrig varit koloniserat. Landet har cirka 115 miljoner invånare. Det officiella språket är amhariska.", "path/to/flag/image", "Etiopien" },
                    { 59, "Oceanien", "Fiji, en ögrupp i Stilla havet, blev självständigt från Storbritannien den 10 oktober 1970. Landet har cirka 900 000 invånare. De officiella språken är engelska, fijianska och hindi.", "path/to/flag/image", "Fiji" },
                    { 60, "Europa", "Finland, beläget i norra Europa, blev självständigt från Ryssland den 6 december 1917. Landet har cirka 5,5 miljoner invånare. De officiella språken är finska och svenska.", "path/to/flag/image", "Finland" },
                    { 61, "Europa", "Frankrike, beläget i Västeuropa, är en av världens äldsta nationer. Landet har cirka 67 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Frankrike" },
                    { 62, "Afrika", "Gabon, beläget i Centralafrika, blev självständigt från Frankrike den 17 augusti 1960. Landet har cirka 2,2 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Gabon" },
                    { 63, "Afrika", "Gambia, ett litet land i Västafrika, blev självständigt från Storbritannien den 18 februari 1965. Landet har cirka 2,4 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Gambia" },
                    { 64, "Asien", "Georgien, beläget vid gränsen mellan Europa och Asien, blev självständigt från Sovjetunionen den 9 april 1991. Landet har cirka 3,7 miljoner invånare. Det officiella språket är georgiska.", "path/to/flag/image", "Georgien" },
                    { 65, "Europa", "Tyskland, beläget i Centraleuropa, återförenades som en nation den 3 oktober 1990 efter att ha varit uppdelat efter andra världskriget. Landet har cirka 83 miljoner invånare. Det officiella språket är tyska.", "path/to/flag/image", "Tyskland" },
                    { 66, "Afrika", "Ghana, beläget i Västafrika, blev självständigt från Storbritannien den 6 mars 1957. Landet har cirka 31 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Ghana" },
                    { 67, "Europa", "Grekland, beläget i Sydöstra Europa, är känt som demokratins födelseplats. Landet blev självständigt från Osmanska riket den 25 mars 1821. Landet har cirka 10,4 miljoner invånare. Det officiella språket är grekiska.", "path/to/flag/image", "Grekland" },
                    { 68, "Nordamerika", "Grenada, en ö-nation i Karibien, blev självständigt från Storbritannien den 7 februari 1974. Landet har cirka 112 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Grenada" },
                    { 69, "Nordamerika", "Guatemala, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 18 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Guatemala" },
                    { 70, "Afrika", "Guinea, beläget i Västafrika, blev självständigt från Frankrike den 2 oktober 1958. Landet har cirka 13 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Guinea" },
                    { 71, "Afrika", "Guinea-Bissau, beläget i Västafrika, blev självständigt från Portugal den 24 september 1973. Landet har cirka 2 miljoner invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Guinea-Bissau" },
                    { 72, "Sydamerika", "Guyana, beläget i norra Sydamerika, blev självständigt från Storbritannien den 26 maj 1966. Landet har cirka 786 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Guyana" },
                    { 73, "Nordamerika", "Haiti, beläget på ön Hispaniola i Karibien, blev självständigt från Frankrike den 1 januari 1804. Landet har cirka 11 miljoner invånare. De officiella språken är franska och haitisk kreol.", "path/to/flag/image", "Haiti" },
                    { 74, "Nordamerika", "Honduras, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 9,9 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Honduras" },
                    { 75, "Europa", "Ungern, beläget i Centraleuropa, blev en självständig stat efter första världskriget den 31 oktober 1918. Landet har cirka 9,6 miljoner invånare. Det officiella språket är ungerska.", "path/to/flag/image", "Ungern" },
                    { 76, "Europa", "Island, beläget i norra Atlanten, blev en självständig republik den 17 juni 1944. Landet har cirka 364 000 invånare. Det officiella språket är isländska.", "path/to/flag/image", "Island" },
                    { 77, "Asien", "Indien, beläget i Sydasien, blev självständigt från Storbritannien den 15 augusti 1947. Landet har cirka 1,3 miljarder invånare. De officiella språken är hindi och engelska.", "path/to/flag/image", "Indien" },
                    { 78, "Asien", "Indonesien, en ö-nation i Sydostasien, blev självständigt från Nederländerna den 17 augusti 1945. Landet har cirka 270 miljoner invånare. Det officiella språket är indonesiska.", "path/to/flag/image", "Indonesien" },
                    { 79, "Asien", "Iran, beläget i Mellanöstern, blev en islamisk republik efter revolutionen den 11 februari 1979. Landet har cirka 83 miljoner invånare. Det officiella språket är persiska.", "path/to/flag/image", "Iran" },
                    { 80, "Asien", "Irak, beläget i Mellanöstern, blev självständigt från Storbritannien den 3 oktober 1932. Landet har cirka 40 miljoner invånare. De officiella språken är arabiska och kurdiska.", "path/to/flag/image", "Irak" },
                    { 81, "Europa", "Irland, beläget i nordvästra Europa, blev en självständig stat från Storbritannien den 6 december 1922. Landet har cirka 4,9 miljoner invånare. Det officiella språket är engelska och iriska.", "path/to/flag/image", "Irland" },
                    { 82, "Europa", "Italien, beläget i södra Europa på den apenninska halvön, blev en enad nation 1861. Landet har cirka 60 miljoner invånare. Det officiella språket är italienska.", "path/to/flag/image", "Italien" },
                    { 83, "Afrika", "Elfenbenskusten, beläget i Västafrika, blev självständigt från Frankrike den 7 augusti 1960. Landet har cirka 26 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Elfenbenskusten" },
                    { 84, "Nordamerika", "Jamaica, en ö-nation i Karibien, blev självständigt från Storbritannien den 6 augusti 1962. Landet har cirka 3 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Jamaica" },
                    { 85, "Asien", "Japan, en ö-nation i Östasien, har en lång historia som en enad stat. Landet har cirka 126 miljoner invånare. Det officiella språket är japanska.", "path/to/flag/image", "Japan" },
                    { 86, "Asien", "Jordanien, beläget i Mellanöstern, blev självständigt från Storbritannien den 25 maj 1946. Landet har cirka 10 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Jordanien" },
                    { 87, "Asien", "Kazakstan, beläget i Centralasien, blev självständigt från Sovjetunionen den 16 december 1991. Landet har cirka 18 miljoner invånare. De officiella språken är kazakiska och ryska.", "path/to/flag/image", "Kazakstan" },
                    { 88, "Afrika", "Kenya, beläget i Östafrika, blev självständigt från Storbritannien den 12 december 1963. Landet har cirka 54 miljoner invånare. De officiella språken är engelska och swahili.", "path/to/flag/image", "Kenya" },
                    { 89, "Oceanien", "Kiribati, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 12 juli 1979. Landet har cirka 119 000 invånare. De officiella språken är engelska och kiribatiska.", "path/to/flag/image", "Kiribati" },
                    { 90, "Asien", "Nordkorea, officiellt Demokratiska folkrepubliken Korea, grundades den 9 september 1948 efter Koreas delning. Landet har cirka 25 miljoner invånare. Det officiella språket är koreanska.", "path/to/flag/image", "Nordkorea" },
                    { 91, "Asien", "Sydkorea, officiellt Republiken Korea, grundades den 15 augusti 1948 efter Koreas delning. Landet har cirka 51 miljoner invånare. Det officiella språket är koreanska.", "path/to/flag/image", "Sydkorea" },
                    { 92, "Europa", "Kosovo, beläget på Balkanhalvön, förklarade självständighet från Serbien den 17 februari 2008. Landet har cirka 1,8 miljoner invånare. Det officiella språket är albanska och serbiska.", "path/to/flag/image", "Kosovo" },
                    { 93, "Asien", "Kuwait, beläget i Mellanöstern vid Persiska viken, blev självständigt från Storbritannien den 19 juni 1961. Landet har cirka 4,2 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Kuwait" },
                    { 94, "Asien", "Kirgizistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 31 augusti 1991. Landet har cirka 6,5 miljoner invånare. De officiella språken är kirgiziska och ryska.", "path/to/flag/image", "Kirgizistan" },
                    { 95, "Asien", "Laos, beläget i Sydostasien, blev självständigt från Frankrike den 22 oktober 1953. Landet har cirka 7,3 miljoner invånare. Det officiella språket är laotiska.", "path/to/flag/image", "Laos" },
                    { 96, "Europa", "Lettland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 21 augusti 1991. Landet har cirka 1,9 miljoner invånare. Det officiella språket är lettiska.", "path/to/flag/image", "Lettland" },
                    { 97, "Asien", "Libanon, beläget i Mellanöstern vid Medelhavet, blev självständigt från Frankrike den 22 november 1943. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Libanon" },
                    { 98, "Afrika", "Lesotho, ett litet bergigt land omgiven av Sydafrika, blev självständigt från Storbritannien den 4 oktober 1966. Landet har cirka 2 miljoner invånare. De officiella språken är sesotho och engelska.", "path/to/flag/image", "Lesotho" },
                    { 99, "Afrika", "Liberia, beläget i Västafrika, grundades av frigivna amerikanska slavar och blev en självständig stat den 26 juli 1847. Landet har cirka 5 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Liberia" },
                    { 100, "Afrika", "Libyen, beläget i Nordafrika vid Medelhavet, blev självständigt från Italien den 24 december 1951. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Libyen" },
                    { 101, "Europa", "Liechtenstein, ett litet alpland mellan Schweiz och Österrike, blev en suverän stat 1719. Landet har cirka 39 000 invånare. Det officiella språket är tyska.", "path/to/flag/image", "Liechtenstein" },
                    { 102, "Europa", "Litauen, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 11 mars 1990. Landet har cirka 2,8 miljoner invånare. Det officiella språket är litauiska.", "path/to/flag/image", "Litauen" },
                    { 103, "Europa", "Luxemburg, ett litet land i Västeuropa, är ett av världens rikaste länder. Landet har cirka 630 000 invånare. De officiella språken är luxemburgiska, franska och tyska.", "path/to/flag/image", "Luxemburg" },
                    { 104, "Afrika", "Madagaskar, en stor ö utanför Afrikas sydöstra kust, blev självständigt från Frankrike den 26 juni 1960. Landet har cirka 26 miljoner invånare. De officiella språken är malagassiska och franska.", "path/to/flag/image", "Madagaskar" },
                    { 105, "Afrika", "Malawi, beläget i sydöstra Afrika, blev självständigt från Storbritannien den 6 juli 1964. Landet har cirka 19 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Malawi" },
                    { 106, "Asien", "Malaysia, beläget i Sydostasien, blev självständigt från Storbritannien den 31 augusti 1957. Landet har cirka 32 miljoner invånare. Det officiella språket är malajiska.", "path/to/flag/image", "Malaysia" },
                    { 107, "Asien", "Maldiverna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 26 juli 1965. Landet har cirka 540 000 invånare. Det officiella språket är dhivehi.", "path/to/flag/image", "Maldiverna" },
                    { 108, "Afrika", "Mali, beläget i Västafrika, blev självständigt från Frankrike den 22 september 1960. Landet har cirka 20 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Mali" },
                    { 109, "Europa", "Malta, en ö-nation i Medelhavet, blev självständigt från Storbritannien den 21 september 1964. Landet har cirka 514 000 invånare. De officiella språken är maltesiska och engelska.", "path/to/flag/image", "Malta" },
                    { 110, "Oceanien", "Marshallöarna, en ö-nation i Stilla havet, blev självständigt från USA den 21 oktober 1986. Landet har cirka 59 000 invånare. De officiella språken är engelska och marshallesiska.", "path/to/flag/image", "Marshallöarna" },
                    { 111, "Afrika", "Mauretanien, beläget i Västafrika, blev självständigt från Frankrike den 28 november 1960. Landet har cirka 4,5 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Mauretanien" },
                    { 112, "Afrika", "Mauritius, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 12 mars 1968. Landet har cirka 1,3 miljoner invånare. De officiella språken är engelska och franska.", "path/to/flag/image", "Mauritius" },
                    { 113, "Nordamerika", "Mexiko, beläget i Nordamerika, blev självständigt från Spanien den 16 september 1810. Landet har cirka 128 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Mexiko" },
                    { 114, "Oceanien", "Mikronesien, en ö-nation i Stilla havet, blev självständigt från USA den 3 november 1986. Landet har cirka 104 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Mikronesien" },
                    { 115, "Europa", "Moldavien, beläget i Östeuropa, blev självständigt från Sovjetunionen den 27 augusti 1991. Landet har cirka 2,6 miljoner invånare. Det officiella språket är rumänska.", "path/to/flag/image", "Moldavien" },
                    { 116, "Europa", "Monaco, en liten stadsstat på franska rivieran, är världens näst minsta land. Landet har cirka 39 000 invånare. Det officiella språket är franska.", "path/to/flag/image", "Monaco" },
                    { 117, "Asien", "Mongoliet, beläget i Östasien, blev självständigt från Kina den 11 juli 1921. Landet har cirka 3,2 miljoner invånare. Det officiella språket är mongoliska.", "path/to/flag/image", "Mongoliet" },
                    { 118, "Europa", "Montenegro, beläget på Balkanhalvön, blev självständigt från Serbien och Montenegro den 3 juni 2006. Landet har cirka 620 000 invånare. Det officiella språket är montenegrinska.", "path/to/flag/image", "Montenegro" },
                    { 119, "Afrika", "Marocko, beläget i Nordafrika vid Atlanten och Medelhavet, blev självständigt från Frankrike den 2 mars 1956. Landet har cirka 36 miljoner invånare. De officiella språken är arabiska och berbiska.", "path/to/flag/image", "Marocko" },
                    { 120, "Afrika", "Moçambique, beläget i sydöstra Afrika, blev självständigt från Portugal den 25 juni 1975. Landet har cirka 30 miljoner invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Moçambique" },
                    { 121, "Asien", "Myanmar, tidigare känt som Burma, beläget i Sydostasien, blev självständigt från Storbritannien den 4 januari 1948. Landet har cirka 54 miljoner invånare. Det officiella språket är burmesiska.", "path/to/flag/image", "Myanmar" },
                    { 122, "Afrika", "Namibia, beläget i sydvästra Afrika, blev självständigt från Sydafrika den 21 mars 1990. Landet har cirka 2,5 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Namibia" },
                    { 123, "Oceanien", "Nauru, en liten ö-nation i Stilla havet, blev självständigt från Australien, Nya Zeeland och Storbritannien den 31 januari 1968. Landet har cirka 10 000 invånare. Det officiella språket är nauruanska.", "path/to/flag/image", "Nauru" },
                    { 124, "Asien", "Nepal, beläget i Himalaya, är en av världens äldsta suveräna stater. Landet har cirka 29 miljoner invånare. Det officiella språket är nepalesiska.", "path/to/flag/image", "Nepal" },
                    { 125, "Europa", "Nederländerna, beläget i Västeuropa, har en lång historia som självständig nation. Landet har cirka 17 miljoner invånare. Det officiella språket är nederländska.", "path/to/flag/image", "Nederländerna" },
                    { 126, "Oceanien", "Nya Zeeland, en ö-nation i sydvästra Stilla havet, blev självständigt från Storbritannien den 26 september 1907. Landet har cirka 5 miljoner invånare. De officiella språken är engelska och maori.", "path/to/flag/image", "Nya Zeeland" },
                    { 127, "Nordamerika", "Nicaragua, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,6 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Nicaragua" },
                    { 128, "Afrika", "Niger, beläget i Västafrika, blev självständigt från Frankrike den 3 augusti 1960. Landet har cirka 24 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Niger" },
                    { 129, "Afrika", "Nigeria, beläget i Västafrika, blev självständigt från Storbritannien den 1 oktober 1960. Landet har cirka 206 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Nigeria" },
                    { 130, "Europa", "Nordmakedonien, beläget på Balkanhalvön, blev självständigt från Jugoslavien den 8 september 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är makedonska.", "path/to/flag/image", "Nordmakedonien" },
                    { 131, "Europa", "Norge, beläget i norra Europa på Skandinaviska halvön, blev självständigt från Sverige den 7 juni 1905. Landet har cirka 5,4 miljoner invånare. Det officiella språket är norska.", "path/to/flag/image", "Norge" },
                    { 132, "Asien", "Oman, beläget på Arabiska halvön, blev en självständig stat efter att ha avskaffat det portugisiska styret 1651. Landet har cirka 5 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Oman" },
                    { 133, "Asien", "Pakistan, beläget i Sydasien, bildades som en självständig stat från Indien den 14 augusti 1947. Landet har cirka 220 miljoner invånare. Det officiella språket är urdu.", "path/to/flag/image", "Pakistan" },
                    { 134, "Oceanien", "Palau, en ö-nation i Stilla havet, blev självständigt från USA den 1 oktober 1994. Landet har cirka 18 000 invånare. De officiella språken är palauanska och engelska.", "path/to/flag/image", "Palau" },
                    { 135, "Asien", "Palestina, beläget i Mellanöstern, består av Västbanken och Gaza. Befolkningen uppgår till cirka 5 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Palestina" },
                    { 136, "Nordamerika", "Panama, beläget i Centralamerika, blev självständigt från Colombia den 3 november 1903. Landet har cirka 4,2 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Panama" },
                    { 137, "Oceanien", "Papua Nya Guinea, beläget i sydvästra Stilla havet, blev självständigt från Australien den 16 september 1975. Landet har cirka 8,9 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Papua Nya Guinea" },
                    { 138, "Sydamerika", "Paraguay, beläget i Sydamerika, blev självständigt från Spanien den 14 maj 1811. Landet har cirka 7 miljoner invånare. De officiella språken är spanska och guarani.", "path/to/flag/image", "Paraguay" },
                    { 139, "Sydamerika", "Peru, beläget i västra Sydamerika, blev självständigt från Spanien den 28 juli 1821. Landet har cirka 33 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Peru" },
                    { 140, "Asien", "Filippinerna, en ö-nation i Sydostasien, blev självständigt från USA den 4 juli 1946. Landet har cirka 109 miljoner invånare. Det officiella språket är filippinska och engelska.", "path/to/flag/image", "Filippinerna" },
                    { 141, "Europa", "Polen, beläget i Centraleuropa, återfick sin självständighet den 11 november 1918 efter att ha varit uppdelat mellan olika imperier i över ett sekel. Landet har cirka 38 miljoner invånare. Det officiella språket är polska.", "path/to/flag/image", "Polen" },
                    { 142, "Europa", "Portugal, beläget på den iberiska halvön i södra Europa, är en av världens äldsta nationer. Landet har cirka 10 miljoner invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Portugal" },
                    { 143, "Asien", "Qatar, beläget på Arabiska halvön vid Persiska viken, blev självständigt från Storbritannien den 3 september 1971. Landet har cirka 2,8 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Qatar" },
                    { 144, "Europa", "Rumänien, beläget i sydöstra Europa, blev självständigt från Osmanska riket den 9 maj 1877. Landet har cirka 19 miljoner invånare. Det officiella språket är rumänska.", "path/to/flag/image", "Rumänien" },
                    { 145, "Europa", "Ryssland, världens största land till ytan, blev självständigt från Sovjetunionen den 25 december 1991. Landet har cirka 146 miljoner invånare. Det officiella språket är ryska.", "path/to/flag/image", "Ryssland" },
                    { 146, "Afrika", "Rwanda, beläget i Centralafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kinyarwanda, franska och engelska.", "path/to/flag/image", "Rwanda" },
                    { 147, "Nordamerika", "Saint Kitts och Nevis, en ö-nation i Karibien, blev självständigt från Storbritannien den 19 september 1983. Landet har cirka 53 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Saint Kitts och Nevis" },
                    { 148, "Nordamerika", "Saint Lucia, en ö-nation i Karibien, blev självständigt från Storbritannien den 22 februari 1979. Landet har cirka 180 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Saint Lucia" },
                    { 149, "Nordamerika", "Saint Vincent och Grenadinerna, en ö-nation i Karibien, blev självständigt från Storbritannien den 27 oktober 1979. Landet har cirka 110 000 invånare. Det officiella språket är engelska.", "path/to/flag/image", "Saint Vincent och Grenadinerna" },
                    { 150, "Oceanien", "Samoa, en ö-nation i Stilla havet, blev självständigt från Nya Zeeland den 1 januari 1962. Landet har cirka 200 000 invånare. Det officiella språket är samoanska och engelska.", "path/to/flag/image", "Samoa" },
                    { 151, "Europa", "San Marino, en mikrostatsrepublik belägen i norra Italien, anses vara världens äldsta republik. Landet har cirka 34 000 invånare. Det officiella språket är italienska.", "path/to/flag/image", "San Marino" },
                    { 152, "Afrika", "Sao Tomé och Principe, en ö-nation i Guineabukten, blev självständigt från Portugal den 12 juli 1975. Landet har cirka 200 000 invånare. Det officiella språket är portugisiska.", "path/to/flag/image", "Sao Tomé och Principe" },
                    { 153, "Asien", "Saudiarabien, beläget på Arabiska halvön, grundades som ett enat kungarike den 23 september 1932. Landet har cirka 34 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Saudiarabien" },
                    { 154, "Afrika", "Senegal, beläget i Västafrika, blev självständigt från Frankrike den 20 augusti 1960. Landet har cirka 16 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Senegal" },
                    { 155, "Europa", "Serbien, beläget på Balkanhalvön, blev självständigt från unionen med Montenegro den 5 juni 2006. Landet har cirka 7 miljoner invånare. Det officiella språket är serbiska.", "path/to/flag/image", "Serbien" },
                    { 156, "Afrika", "Seychellerna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 29 juni 1976. Landet har cirka 98 000 invånare. De officiella språken är kreol, engelska och franska.", "path/to/flag/image", "Seychellerna" },
                    { 157, "Afrika", "Sierra Leone, beläget i Västafrika, blev självständigt från Storbritannien den 27 april 1961. Landet har cirka 7,5 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Sierra Leone" },
                    { 158, "Asien", "Singapore, en stadstat i Sydostasien, blev självständigt från Malaysia den 9 augusti 1965. Landet har cirka 5,7 miljoner invånare. De officiella språken är engelska, mandarin, malajiska och tamil.", "path/to/flag/image", "Singapore" },
                    { 159, "Europa", "Slovakien, beläget i Centraleuropa, blev självständigt från Tjeckoslovakien den 1 januari 1993. Landet har cirka 5,4 miljoner invånare. Det officiella språket är slovakiska.", "path/to/flag/image", "Slovakien" },
                    { 160, "Europa", "Slovenien, beläget i Centraleuropa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är slovenska.", "path/to/flag/image", "Slovenien" },
                    { 161, "Oceanien", "Salomonöarna, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 7 juli 1978. Landet har cirka 652 000 invånare. De officiella språken är engelska och pijin.", "path/to/flag/image", "Salomonöarna" },
                    { 162, "Afrika", "Somalia, beläget i Afrikas horn, blev självständigt från Storbritannien och Italien den 1 juli 1960. Landet har cirka 15 miljoner invånare. Det officiella språket är somaliska.", "path/to/flag/image", "Somalia" },
                    { 163, "Afrika", "Sydafrika, beläget på Afrikas sydspets, blev självständigt från Storbritannien den 31 maj 1910. Landet har cirka 58 miljoner invånare. Det finns 11 officiella språk, inklusive afrikaans och engelska.", "path/to/flag/image", "Sydafrika" },
                    { 164, "Afrika", "Sydsudan, världens yngsta nation, blev självständigt från Sudan den 9 juli 2011. Landet har cirka 11 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Sydsudan" },
                    { 165, "Europa", "Spanien, beläget på den iberiska halvön i södra Europa, är känt för sin rika kultur och historia. Landet har cirka 47 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Spanien" },
                    { 166, "Asien", "Sri Lanka, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 4 februari 1948. Landet har cirka 21 miljoner invånare. De officiella språken är singalesiska och tamil.", "path/to/flag/image", "Sri Lanka" },
                    { 167, "Afrika", "Sudan, beläget i Nordafrika, blev självständigt från Egypten och Storbritannien den 1 januari 1956. Landet har cirka 42 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Sudan" },
                    { 168, "Sydamerika", "Surinam, beläget i norra Sydamerika, blev självständigt från Nederländerna den 25 november 1975. Landet har cirka 586 000 invånare. Det officiella språket är nederländska.", "path/to/flag/image", "Surinam" },
                    { 169, "Europa", "Sverige, beläget i norra Europa på Skandinaviska halvön, har en lång historia som självständig nation. Landet har cirka 10,3 miljoner invånare. Det officiella språket är svenska.", "path/to/flag/image", "Sverige" },
                    { 170, "Europa", "Schweiz, beläget i Centraleuropa, är känt för sin neutralitet och stabilitet. Landet har cirka 8,5 miljoner invånare. De officiella språken är tyska, franska, italienska och rätoromanska.", "path/to/flag/image", "Schweiz" },
                    { 171, "Asien", "Syrien, beläget i Mellanöstern, blev självständigt från Frankrike den 17 april 1946. Landet har cirka 17 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Syrien" },
                    { 172, "Asien", "Tadzjikistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 9 september 1991. Landet har cirka 9,5 miljoner invånare. Det officiella språket är tadzjikiska.", "path/to/flag/image", "Tadzjikistan" },
                    { 173, "Afrika", "Tanzania, beläget i Östafrika, bildades genom sammanslagningen av Tanganyika och Zanzibar den 26 april 1964. Landet har cirka 58 miljoner invånare. De officiella språken är swahili och engelska.", "path/to/flag/image", "Tanzania" },
                    { 174, "Asien", "Thailand, beläget i Sydostasien, är känt för sin rika kultur och historia. Landet har cirka 70 miljoner invånare. Det officiella språket är thailändska.", "path/to/flag/image", "Thailand" },
                    { 175, "Afrika", "Togo, beläget i Västafrika, blev självständigt från Frankrike den 27 april 1960. Landet har cirka 8 miljoner invånare. Det officiella språket är franska.", "path/to/flag/image", "Togo" },
                    { 176, "Oceanien", "Tonga, en ö-nation i Stilla havet, blev aldrig koloniserat men blev en konstitutionell monarki 1875. Landet har cirka 104 000 invånare. Det officiella språket är tonganska och engelska.", "path/to/flag/image", "Tonga" },
                    { 177, "Nordamerika", "Trinidad och Tobago, en ö-nation i Karibien, blev självständigt från Storbritannien den 31 augusti 1962. Landet har cirka 1,4 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Trinidad och Tobago" },
                    { 178, "Afrika", "Tunisien, beläget i Nordafrika vid Medelhavet, blev självständigt från Frankrike den 20 mars 1956. Landet har cirka 12 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Tunisien" },
                    { 179, "Asien", "Turkiet, beläget på gränsen mellan Europa och Asien, blev en republik den 29 oktober 1923 efter det osmanska rikets fall. Landet har cirka 82 miljoner invånare. Det officiella språket är turkiska.", "path/to/flag/image", "Turkiet" },
                    { 180, "Asien", "Turkmenistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 27 oktober 1991. Landet har cirka 6 miljoner invånare. Det officiella språket är turkmeniska.", "path/to/flag/image", "Turkmenistan" },
                    { 181, "Oceanien", "Tuvalu, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 1 oktober 1978. Landet har cirka 11 000 invånare. De officiella språken är tuvaluanska och engelska.", "path/to/flag/image", "Tuvalu" },
                    { 182, "Afrika", "Uganda, beläget i Östafrika, blev självständigt från Storbritannien den 9 oktober 1962. Landet har cirka 45 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Uganda" },
                    { 183, "Europa", "Ukraina, beläget i Östeuropa, blev självständigt från Sovjetunionen den 24 augusti 1991. Landet har cirka 41 miljoner invånare. Det officiella språket är ukrainska.", "path/to/flag/image", "Ukraina" },
                    { 184, "Asien", "Förenade Arabemiraten, beläget i Mellanöstern, blev självständigt från Storbritannien den 2 december 1971. Landet har cirka 9,9 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Förenade Arabemiraten" },
                    { 185, "Europa", "Storbritannien, beläget i nordvästra Europa, är en av världens äldsta konstitutionella monarkier. Landet har cirka 67 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Storbritannien" },
                    { 186, "Nordamerika", "USA, beläget i Nordamerika, blev självständigt från Storbritannien den 4 juli 1776. Landet har cirka 331 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "USA" },
                    { 187, "Sydamerika", "Uruguay, beläget i Sydamerika, blev självständigt från Brasilien den 25 augusti 1825. Landet har cirka 3,5 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Uruguay" },
                    { 188, "Asien", "Uzbekistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 1 september 1991. Landet har cirka 33 miljoner invånare. Det officiella språket är uzbekiska.", "path/to/flag/image", "Uzbekistan" },
                    { 189, "Oceanien", "Vanuatu, en ö-nation i Stilla havet, blev självständigt från Frankrike och Storbritannien den 30 juli 1980. Landet har cirka 307 000 invånare. De officiella språken är bislama, engelska och franska.", "path/to/flag/image", "Vanuatu" },
                    { 190, "Europa", "Vatikanstaten, en mikrostatsstat i Rom, är världens minsta suveräna stat. Landet har cirka 800 invånare. Det officiella språket är latin.", "path/to/flag/image", "Vatikanstaten" },
                    { 191, "Sydamerika", "Venezuela, beläget i norra Sydamerika, blev självständigt från Spanien den 5 juli 1811. Landet har cirka 28 miljoner invånare. Det officiella språket är spanska.", "path/to/flag/image", "Venezuela" },
                    { 192, "Asien", "Vietnam, beläget i Sydostasien, blev självständigt från Frankrike den 2 september 1945. Landet har cirka 97 miljoner invånare. Det officiella språket är vietnamesiska.", "path/to/flag/image", "Vietnam" },
                    { 193, "Asien", "Jemen, beläget på Arabiska halvön, blev en enad republik den 22 maj 1990. Landet har cirka 29 miljoner invånare. Det officiella språket är arabiska.", "path/to/flag/image", "Jemen" },
                    { 194, "Afrika", "Zambia, beläget i södra Afrika, blev självständigt från Storbritannien den 24 oktober 1964. Landet har cirka 18 miljoner invånare. Det officiella språket är engelska.", "path/to/flag/image", "Zambia" },
                    { 195, "Afrika", "Zimbabwe, beläget i södra Afrika, blev självständigt från Storbritannien den 18 april 1980. Landet har cirka 14 miljoner invånare. De officiella språken är engelska, shona och ndebele.", "path/to/flag/image", "Zimbabwe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);
        }
    }
}
