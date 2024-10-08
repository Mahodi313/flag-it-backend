﻿using flag_it_backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace flag_it_backend.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ResultModel> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CountryModel>().HasData(
                new CountryModel { Id = 1, Name = "Afghanistan", Continent = "Asien", Description = "Afghanistan, beläget i Centralasien, blev självständigt från Storbritannien den 19 augusti 1919. Landet har cirka 38 miljoner invånare. De officiella språken är pashto och dari.", FlagImage = "https://flagcdn.com/af.svg" },
                new CountryModel { Id = 2, Name = "Albanien", Continent = "Europa", Description = "Albanien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 28 november 1912. Landet har cirka 2,9 miljoner invånare. Det officiella språket är albanska.", FlagImage = "https://flagcdn.com/al.svg" },
                new CountryModel { Id = 3, Name = "Algeriet", Continent = "Afrika", Description = "Algeriet, beläget i Nordafrika, blev självständigt från Frankrike den 5 juli 1962. Landet har cirka 44 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/dz.svg" },
                new CountryModel { Id = 4, Name = "Andorra", Continent = "Europa", Description = "Andorra, en liten landlocked nation i Pyrenéerna mellan Frankrike och Spanien, har cirka 77 000 invånare. Det officiella språket är katalanska.", FlagImage = "https://flagcdn.com/ad.svg" },
                new CountryModel { Id = 5, Name = "Angola", Continent = "Afrika", Description = "Angola, beläget på västkusten av södra Afrika, blev självständigt från Portugal den 11 november 1975. Landet har cirka 32 miljoner invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/ao.svg" },
                new CountryModel { Id = 6, Name = "Antigua och Barbuda", Continent = "Nordamerika", Description = "Antigua och Barbuda är en ö-nation i Karibien som blev självständigt från Storbritannien den 1 november 1981. Landet har cirka 97 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/ag.svg" },
                new CountryModel { Id = 7, Name = "Argentina", Continent = "Sydamerika", Description = "Argentina, beläget i Sydamerika, förklarade sig självständigt från Spanien den 9 juli 1816. Landet har cirka 45 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/ar.svg" },
                new CountryModel { Id = 8, Name = "Armenien", Continent = "Asien", Description = "Armenien, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 21 september 1991. Landet har cirka 3 miljoner invånare. Det officiella språket är armeniska.", FlagImage = "https://flagcdn.com/am.svg" },
                new CountryModel { Id = 9, Name = "Australien", Continent = "Oceanien", Description = "Australien, en kontinent och land i Oceanien, blev självständigt från Storbritannien den 1 januari 1901. Landet har cirka 25 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/au.svg" },
                new CountryModel { Id = 10, Name = "Österrike", Continent = "Europa", Description = "Österrike, beläget i Centraleuropa, har en historia av självständighet som går tillbaka till 1156. Landet har cirka 9 miljoner invånare. Det officiella språket är tyska.", FlagImage = "https://flagcdn.com/at.svg" },
                new CountryModel { Id = 11, Name = "Azerbajdzjan", Continent = "Asien", Description = "Azerbajdzjan, beläget i södra Kaukasus, blev självständigt från Sovjetunionen den 30 augusti 1991. Landet har cirka 10 miljoner invånare. Det officiella språket är azerbajdzjanska.", FlagImage = "https://flagcdn.com/az.svg" },
                new CountryModel { Id = 12, Name = "Bahamas", Continent = "Nordamerika", Description = "Bahamas, en ö-nation i Karibien, blev självständigt från Storbritannien den 10 juli 1973. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/bs.svg" },
                new CountryModel { Id = 13, Name = "Bahrain", Continent = "Asien", Description = "Bahrain, en ö-nation i Persiska viken, blev självständigt från Storbritannien den 15 augusti 1971. Landet har cirka 1,7 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/bh.svg" },
                new CountryModel { Id = 14, Name = "Bangladesh", Continent = "Asien", Description = "Bangladesh, beläget i Sydasien, blev självständigt från Pakistan den 26 mars 1971. Landet har cirka 163 miljoner invånare. Det officiella språket är bengali.", FlagImage = "https://flagcdn.com/bd.svg" },
                new CountryModel { Id = 15, Name = "Barbados", Continent = "Nordamerika", Description = "Barbados, en ö-nation i Karibien, blev självständigt från Storbritannien den 30 november 1966. Landet har cirka 287 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/bb.svg" },
                new CountryModel { Id = 16, Name = "Vitryssland", Continent = "Europa", Description = "Vitryssland, beläget i Östeuropa, blev självständigt från Sovjetunionen den 25 augusti 1991. Landet har cirka 9,4 miljoner invånare. Det officiella språket är vitryska.", FlagImage = "https://flagcdn.com/by.svg" },
                new CountryModel { Id = 17, Name = "Belgien", Continent = "Europa", Description = "Belgien, beläget i Västeuropa, blev självständigt från Nederländerna den 4 oktober 1830. Landet har cirka 11,5 miljoner invånare. De officiella språken är nederländska, franska och tyska.", FlagImage = "https://flagcdn.com/be.svg" },
                new CountryModel { Id = 18, Name = "Belize", Continent = "Nordamerika", Description = "Belize, ett land i Centralamerika, blev självständigt från Storbritannien den 21 september 1981. Landet har cirka 400 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/bz.svg" },
                new CountryModel { Id = 19, Name = "Benin", Continent = "Afrika", Description = "Benin, ett västafrikanskt land, blev självständigt från Frankrike den 1 augusti 1960. Landet har cirka 12 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/bj.svg" },
                new CountryModel { Id = 20, Name = "Bhutan", Continent = "Asien", Description = "Bhutan, ett litet kungarike i Himalaya, har aldrig varit under utländsk kontroll. Landet har cirka 770 000 invånare. Det officiella språket är dzongkha.", FlagImage = "https://flagcdn.com/bt.svg" },
                new CountryModel { Id = 21, Name = "Bolivia", Continent = "Sydamerika", Description = "Bolivia, beläget i Sydamerika, blev självständigt från Spanien den 6 augusti 1825. Landet har cirka 11 miljoner invånare. De officiella språken är spanska och flera inhemska språk.", FlagImage = "https://flagcdn.com/bo.svg" },
                new CountryModel { Id = 22, Name = "Bosnien och Hercegovina", Continent = "Europa", Description = "Bosnien och Hercegovina, beläget i Balkanregionen i Sydöstra Europa, blev självständigt från Jugoslavien den 1 mars 1992. Landet har cirka 3,5 miljoner invånare. De officiella språken är bosniska, kroatiska och serbiska.", FlagImage = "https://flagcdn.com/ba.svg" },
                new CountryModel { Id = 23, Name = "Botswana", Continent = "Afrika", Description = "Botswana, beläget i södra Afrika, blev självständigt från Storbritannien den 30 september 1966. Landet har cirka 2,3 miljoner invånare. Det officiella språket är engelska, men setswana talas också brett.", FlagImage = "https://flagcdn.com/bw.svg" },
                new CountryModel { Id = 24, Name = "Brasilien", Continent = "Sydamerika", Description = "Brasilien, det största landet i Sydamerika, blev självständigt från Portugal den 7 september 1822. Landet har cirka 211 miljoner invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/br.svg" },
                new CountryModel { Id = 25, Name = "Brunei", Continent = "Asien", Description = "Brunei, beläget på ön Borneo i Sydostasien, blev självständigt från Storbritannien den 1 januari 1984. Landet har cirka 437 000 invånare. Det officiella språket är malajiska.", FlagImage = "https://flagcdn.com/bn.svg" },
                new CountryModel { Id = 26, Name = "Bulgarien", Continent = "Europa", Description = "Bulgarien, beläget i Sydöstra Europa, blev självständigt från Osmanska riket den 22 september 1908. Landet har cirka 7 miljoner invånare. Det officiella språket är bulgariska.", FlagImage = "https://flagcdn.com/bg.svg" },
                new CountryModel { Id = 27, Name = "Burkina Faso", Continent = "Afrika", Description = "Burkina Faso, ett land i Västafrika, blev självständigt från Frankrike den 5 augusti 1960. Landet har cirka 21 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/bf.svg" },
                new CountryModel { Id = 28, Name = "Burundi", Continent = "Afrika", Description = "Burundi, beläget i Östafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kirundi, franska och engelska.", FlagImage = "https://flagcdn.com/bi.svg" },
                new CountryModel { Id = 29, Name = "Cabo Verde", Continent = "Afrika", Description = "Cabo Verde, en ögrupp utanför nordvästra Afrikas kust, blev självständigt från Portugal den 5 juli 1975. Landet har cirka 550 000 invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/cv.svg" },
                new CountryModel { Id = 30, Name = "Kambodja", Continent = "Asien", Description = "Kambodja, beläget i Sydostasien, blev självständigt från Frankrike den 9 november 1953. Landet har cirka 16 miljoner invånare. Det officiella språket är khmer.", FlagImage = "https://flagcdn.com/kh.svg" },
                new CountryModel { Id = 31, Name = "Kamerun", Continent = "Afrika", Description = "Kamerun, ett land i Centralafrika, blev självständigt från Frankrike den 1 januari 1960. Landet har cirka 26 miljoner invånare. De officiella språken är franska och engelska.", FlagImage = "https://flagcdn.com/cm.svg" },
                new CountryModel { Id = 32, Name = "Kanada", Continent = "Nordamerika", Description = "Kanada, världens näst största land till ytan, blev självständigt från Storbritannien den 1 juli 1867. Landet har cirka 37 miljoner invånare. De officiella språken är engelska och franska.", FlagImage = "https://flagcdn.com/ca.svg" },
                new CountryModel { Id = 33, Name = "Centralafrikanska republiken", Continent = "Afrika", Description = "Centralafrikanska republiken, beläget i hjärtat av Afrika, blev självständigt från Frankrike den 13 augusti 1960. Landet har cirka 4,8 miljoner invånare. De officiella språken är franska och sango.", FlagImage = "https://flagcdn.com/cf.svg" },
                new CountryModel { Id = 34, Name = "Tchad", Continent = "Afrika", Description = "Tchad, beläget i Nord-Centralafrika, blev självständigt från Frankrike den 11 augusti 1960. Landet har cirka 17 miljoner invånare. De officiella språken är franska och arabiska.", FlagImage = "https://flagcdn.com/td.svg" },
                new CountryModel { Id = 35, Name = "Chile", Continent = "Sydamerika", Description = "Chile, beläget i Sydamerika, blev självständigt från Spanien den 18 september 1810. Landet har cirka 19 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/cl.svg" },
                new CountryModel { Id = 36, Name = "Kina", Continent = "Asien", Description = "Kina, världens mest folkrika land med cirka 1,4 miljarder invånare, är en av världens äldsta kontinuerliga civilisationer. Landet grundades som Folkrepubliken Kina den 1 oktober 1949. Det officiella språket är mandarin.", FlagImage = "https://flagcdn.com/cn.svg" },
                new CountryModel { Id = 37, Name = "Colombia", Continent = "Sydamerika", Description = "Colombia, beläget i norra Sydamerika, blev självständigt från Spanien den 20 juli 1810. Landet har cirka 50 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/co.svg" },
                new CountryModel { Id = 38, Name = "Komorerna", Continent = "Afrika", Description = "Komorerna är en ögruppsnation utanför Afrikas östkust som blev självständigt från Frankrike den 6 juli 1975. Landet har cirka 870 000 invånare. De officiella språken är komoriska, arabiska och franska.", FlagImage = "https://flagcdn.com/km.svg" },
                new CountryModel { Id = 39, Name = "Kongo-Brazzaville", Continent = "Afrika", Description = "Kongo-Brazzaville, officiellt Republiken Kongo, blev självständigt från Frankrike den 15 augusti 1960. Landet har cirka 5,5 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/cg.svg" },
                new CountryModel { Id = 40, Name = "Kongo-Kinshasa", Continent = "Afrika", Description = "Kongo-Kinshasa, officiellt Demokratiska republiken Kongo, blev självständigt från Belgien den 30 juni 1960. Landet har cirka 89 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/cd.svg" },
                new CountryModel { Id = 41, Name = "Costa Rica", Continent = "Nordamerika", Description = "Costa Rica, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 5 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/cr.svg" },
                new CountryModel { Id = 42, Name = "Kroatien", Continent = "Europa", Description = "Kroatien, beläget i Sydöstra Europa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 4 miljoner invånare. Det officiella språket är kroatiska.", FlagImage = "https://flagcdn.com/hr.svg" },
                new CountryModel { Id = 43, Name = "Kuba", Continent = "Nordamerika", Description = "Kuba, en ö-nation i Karibien, blev självständigt från Spanien den 20 maj 1902. Landet har cirka 11 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/cu.svg" },
                new CountryModel { Id = 44, Name = "Cypern", Continent = "Asien", Description = "Cypern, en ö i östra Medelhavet, blev självständigt från Storbritannien den 16 augusti 1960. Landet har cirka 1,2 miljoner invånare. De officiella språken är grekiska och turkiska.", FlagImage = "https://flagcdn.com/cy.svg" },
                new CountryModel { Id = 45, Name = "Tjeckien", Continent = "Europa", Description = "Tjeckien, beläget i Centraleuropa, blev självständigt som Tjeckoslovakien från Österrike-Ungern den 28 oktober 1918. Landet har cirka 10,7 miljoner invånare. Det officiella språket är tjeckiska.", FlagImage = "https://flagcdn.com/cz.svg" },
                new CountryModel { Id = 46, Name = "Danmark", Continent = "Europa", Description = "Danmark, ett nordiskt land i Europa, har en lång historia som självständig nation och är världens äldsta monarki. Landet har cirka 5,8 miljoner invånare. Det officiella språket är danska.", FlagImage = "https://flagcdn.com/dk.svg" },
                new CountryModel { Id = 47, Name = "Djibouti", Continent = "Afrika", Description = "Djibouti, beläget i Afrikas horn, blev självständigt från Frankrike den 27 juni 1977. Landet har cirka 1 miljon invånare. De officiella språken är franska och arabiska.", FlagImage = "https://flagcdn.com/dj.svg" },
                new CountryModel { Id = 48, Name = "Dominica", Continent = "Nordamerika", Description = "Dominica, en ö-nation i Karibien, blev självständigt från Storbritannien den 3 november 1978. Landet har cirka 71 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/dm.svg" },
                new CountryModel { Id = 49, Name = "Dominikanska republiken", Continent = "Nordamerika", Description = "Dominikanska republiken, beläget på ön Hispaniola i Karibien, blev självständigt från Haiti den 27 februari 1844. Landet har cirka 10,8 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/do.svg" },
                new CountryModel { Id = 50, Name = "Östtimor", Continent = "Asien", Description = "Östtimor, beläget i Sydostasien, blev självständigt från Indonesien den 20 maj 2002. Landet har cirka 1,3 miljoner invånare. Det officiella språket är portugisiska och tetum.", FlagImage = "https://flagcdn.com/tl.svg" },
                new CountryModel { Id = 51, Name = "Ecuador", Continent = "Sydamerika", Description = "Ecuador, beläget i nordvästra Sydamerika, blev självständigt från Spanien den 24 maj 1822. Landet har cirka 17 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/ec.svg" },
                new CountryModel { Id = 52, Name = "Egypten", Continent = "Afrika", Description = "Egypten, beläget i Nordafrika, blev självständigt från Storbritannien den 28 februari 1922. Landet har cirka 100 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/eg.svg" },
                new CountryModel { Id = 53, Name = "El Salvador", Continent = "Nordamerika", Description = "El Salvador, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,5 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/sv.svg" },
                new CountryModel { Id = 54, Name = "Ekvatorialguinea", Continent = "Afrika", Description = "Ekvatorialguinea, beläget i Centralafrika, blev självständigt från Spanien den 12 oktober 1968. Landet har cirka 1,4 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/gq.svg" },
                new CountryModel { Id = 55, Name = "Eritrea", Continent = "Afrika", Description = "Eritrea, beläget i östra Afrika vid Röda havet, blev självständigt från Etiopien den 24 maj 1993. Landet har cirka 5,3 miljoner invånare. De officiella språken är tigrinska, arabiska och engelska.", FlagImage = "https://flagcdn.com/er.svg" },
                new CountryModel { Id = 56, Name = "Estland", Continent = "Europa", Description = "Estland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 20 augusti 1991. Landet har cirka 1,3 miljoner invånare. Det officiella språket är estniska.", FlagImage = "https://flagcdn.com/ee.svg" },
                new CountryModel { Id = 57, Name = "Eswatini", Continent = "Afrika", Description = "Eswatini, tidigare känt som Swaziland, är ett litet land i södra Afrika. Det blev självständigt från Storbritannien den 6 september 1968. Landet har cirka 1,1 miljoner invånare. De officiella språken är swazi och engelska.", FlagImage = "https://flagcdn.com/sz.svg" },
                new CountryModel { Id = 58, Name = "Etiopien", Continent = "Afrika", Description = "Etiopien, beläget i östra Afrika, är en av världens äldsta nationer och har aldrig varit koloniserat. Landet har cirka 115 miljoner invånare. Det officiella språket är amhariska.", FlagImage = "https://flagcdn.com/et.svg" },
                new CountryModel { Id = 59, Name = "Fiji", Continent = "Oceanien", Description = "Fiji, en ögrupp i Stilla havet, blev självständigt från Storbritannien den 10 oktober 1970. Landet har cirka 900 000 invånare. De officiella språken är engelska, fijianska och hindi.", FlagImage = "https://flagcdn.com/fj.svg" },
                new CountryModel { Id = 60, Name = "Finland", Continent = "Europa", Description = "Finland, beläget i norra Europa, blev självständigt från Ryssland den 6 december 1917. Landet har cirka 5,5 miljoner invånare. De officiella språken är finska och svenska.", FlagImage = "https://flagcdn.com/fi.svg" },
                new CountryModel { Id = 61, Name = "Frankrike", Continent = "Europa", Description = "Frankrike, beläget i Västeuropa, är en av världens äldsta nationer. Landet har cirka 67 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/fr.svg" },
                new CountryModel { Id = 62, Name = "Gabon", Continent = "Afrika", Description = "Gabon, beläget i Centralafrika, blev självständigt från Frankrike den 17 augusti 1960. Landet har cirka 2,2 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/ga.svg" },
                new CountryModel { Id = 63, Name = "Gambia", Continent = "Afrika", Description = "Gambia, ett litet land i Västafrika, blev självständigt från Storbritannien den 18 februari 1965. Landet har cirka 2,4 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/gm.svg" },
                new CountryModel { Id = 64, Name = "Georgien", Continent = "Asien", Description = "Georgien, beläget vid gränsen mellan Europa och Asien, blev självständigt från Sovjetunionen den 9 april 1991. Landet har cirka 3,7 miljoner invånare. Det officiella språket är georgiska.", FlagImage = "https://flagcdn.com/ge.svg" },
                new CountryModel { Id = 65, Name = "Tyskland", Continent = "Europa", Description = "Tyskland, beläget i Centraleuropa, återförenades som en nation den 3 oktober 1990 efter att ha varit uppdelat efter andra världskriget. Landet har cirka 83 miljoner invånare. Det officiella språket är tyska.", FlagImage = "https://flagcdn.com/de.svg" },
                new CountryModel { Id = 66, Name = "Ghana", Continent = "Afrika", Description = "Ghana, beläget i Västafrika, blev självständigt från Storbritannien den 6 mars 1957. Landet har cirka 31 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/gh.svg" },
                new CountryModel { Id = 67, Name = "Grekland", Continent = "Europa", Description = "Grekland, beläget i Sydöstra Europa, är känt som demokratins födelseplats. Landet blev självständigt från Osmanska riket den 25 mars 1821. Landet har cirka 10,4 miljoner invånare. Det officiella språket är grekiska.", FlagImage = "https://flagcdn.com/gr.svg" },
                new CountryModel { Id = 68, Name = "Grenada", Continent = "Nordamerika", Description = "Grenada, en ö-nation i Karibien, blev självständigt från Storbritannien den 7 februari 1974. Landet har cirka 112 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/gd.svg" },
                new CountryModel { Id = 69, Name = "Guatemala", Continent = "Nordamerika", Description = "Guatemala, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 18 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/gt.svg" },
                new CountryModel { Id = 70, Name = "Guinea", Continent = "Afrika", Description = "Guinea, beläget i Västafrika, blev självständigt från Frankrike den 2 oktober 1958. Landet har cirka 13 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/gn.svg" },
                new CountryModel { Id = 71, Name = "Guinea-Bissau", Continent = "Afrika", Description = "Guinea-Bissau, beläget i Västafrika, blev självständigt från Portugal den 24 september 1973. Landet har cirka 2 miljoner invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/gw.svg" },
                new CountryModel { Id = 72, Name = "Guyana", Continent = "Sydamerika", Description = "Guyana, beläget i norra Sydamerika, blev självständigt från Storbritannien den 26 maj 1966. Landet har cirka 786 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/gy.svg" },
                new CountryModel { Id = 73, Name = "Haiti", Continent = "Nordamerika", Description = "Haiti, beläget på ön Hispaniola i Karibien, blev självständigt från Frankrike den 1 januari 1804. Landet har cirka 11 miljoner invånare. De officiella språken är franska och haitisk kreol.", FlagImage = "https://flagcdn.com/ht.svg" },
                new CountryModel { Id = 74, Name = "Honduras", Continent = "Nordamerika", Description = "Honduras, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 9,9 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/hn.svg" },
                new CountryModel { Id = 75, Name = "Ungern", Continent = "Europa", Description = "Ungern, beläget i Centraleuropa, blev en självständig stat efter första världskriget den 31 oktober 1918. Landet har cirka 9,6 miljoner invånare. Det officiella språket är ungerska.", FlagImage = "https://flagcdn.com/hu.svg" },
                new CountryModel { Id = 76, Name = "Island", Continent = "Europa", Description = "Island, beläget i norra Atlanten, blev en självständig republik den 17 juni 1944. Landet har cirka 364 000 invånare. Det officiella språket är isländska.", FlagImage = "https://flagcdn.com/is.svg" },
                new CountryModel { Id = 77, Name = "Indien", Continent = "Asien", Description = "Indien, beläget i Sydasien, blev självständigt från Storbritannien den 15 augusti 1947. Landet har cirka 1,3 miljarder invånare. De officiella språken är hindi och engelska.", FlagImage = "https://flagcdn.com/in.svg" },
                new CountryModel { Id = 78, Name = "Indonesien", Continent = "Asien", Description = "Indonesien, en ö-nation i Sydostasien, blev självständigt från Nederländerna den 17 augusti 1945. Landet har cirka 270 miljoner invånare. Det officiella språket är indonesiska.", FlagImage = "https://flagcdn.com/id.svg" },
                new CountryModel { Id = 79, Name = "Iran", Continent = "Asien", Description = "Iran, beläget i Mellanöstern, blev en islamisk republik efter revolutionen den 11 februari 1979. Landet har cirka 83 miljoner invånare. Det officiella språket är persiska.", FlagImage = "https://flagcdn.com/ir.svg" },
                new CountryModel { Id = 80, Name = "Irak", Continent = "Asien", Description = "Irak, beläget i Mellanöstern, blev självständigt från Storbritannien den 3 oktober 1932. Landet har cirka 40 miljoner invånare. De officiella språken är arabiska och kurdiska.", FlagImage = "https://flagcdn.com/iq.svg" },
                new CountryModel { Id = 81, Name = "Irland", Continent = "Europa", Description = "Irland, beläget i nordvästra Europa, blev en självständig stat från Storbritannien den 6 december 1922. Landet har cirka 4,9 miljoner invånare. Det officiella språket är engelska och iriska.", FlagImage = "https://flagcdn.com/ie.svg" },
                new CountryModel { Id = 82, Name = "Italien", Continent = "Europa", Description = "Italien, beläget i södra Europa på den apenninska halvön, blev en enad nation 1861. Landet har cirka 60 miljoner invånare. Det officiella språket är italienska.", FlagImage = "https://flagcdn.com/it.svg" },
                new CountryModel { Id = 83, Name = "Elfenbenskusten", Continent = "Afrika", Description = "Elfenbenskusten, beläget i Västafrika, blev självständigt från Frankrike den 7 augusti 1960. Landet har cirka 26 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/ci.svg" },
                new CountryModel { Id = 84, Name = "Jamaica", Continent = "Nordamerika", Description = "Jamaica, en ö-nation i Karibien, blev självständigt från Storbritannien den 6 augusti 1962. Landet har cirka 3 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/jm.svg" },
                new CountryModel { Id = 85, Name = "Japan", Continent = "Asien", Description = "Japan, en ö-nation i Östasien, har en lång historia som en enad stat. Landet har cirka 126 miljoner invånare. Det officiella språket är japanska.", FlagImage = "https://flagcdn.com/jp.svg" },
                new CountryModel { Id = 86, Name = "Jordanien", Continent = "Asien", Description = "Jordanien, beläget i Mellanöstern, blev självständigt från Storbritannien den 25 maj 1946. Landet har cirka 10 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/jo.svg" },
                new CountryModel { Id = 87, Name = "Kazakstan", Continent = "Asien", Description = "Kazakstan, beläget i Centralasien, blev självständigt från Sovjetunionen den 16 december 1991. Landet har cirka 18 miljoner invånare. De officiella språken är kazakiska och ryska.", FlagImage = "https://flagcdn.com/kz.svg" },
                new CountryModel { Id = 88, Name = "Kenya", Continent = "Afrika", Description = "Kenya, beläget i Östafrika, blev självständigt från Storbritannien den 12 december 1963. Landet har cirka 54 miljoner invånare. De officiella språken är engelska och swahili.", FlagImage = "https://flagcdn.com/ke.svg" },
                new CountryModel { Id = 89, Name = "Kiribati", Continent = "Oceanien", Description = "Kiribati, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 12 juli 1979. Landet har cirka 119 000 invånare. De officiella språken är engelska och kiribatiska.", FlagImage = "https://flagcdn.com/ki.svg" },
                new CountryModel { Id = 90, Name = "Nordkorea", Continent = "Asien", Description = "Nordkorea, officiellt Demokratiska folkrepubliken Korea, grundades den 9 september 1948 efter Koreas delning. Landet har cirka 25 miljoner invånare. Det officiella språket är koreanska.", FlagImage = "https://flagcdn.com/kp.svg" },
                new CountryModel { Id = 91, Name = "Sydkorea", Continent = "Asien", Description = "Sydkorea, officiellt Republiken Korea, grundades den 15 augusti 1948 efter Koreas delning. Landet har cirka 51 miljoner invånare. Det officiella språket är koreanska.", FlagImage = "https://flagcdn.com/kr.svg" },
                new CountryModel { Id = 92, Name = "Kosovo", Continent = "Europa", Description = "Kosovo, beläget på Balkanhalvön, förklarade självständighet från Serbien den 17 februari 2008. Landet har cirka 1,8 miljoner invånare. Det officiella språket är albanska och serbiska.", FlagImage = "https://flagcdn.com/xk.svg" },
                new CountryModel { Id = 93, Name = "Kuwait", Continent = "Asien", Description = "Kuwait, beläget i Mellanöstern vid Persiska viken, blev självständigt från Storbritannien den 19 juni 1961. Landet har cirka 4,2 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/kw.svg" },
                new CountryModel { Id = 94, Name = "Kirgizistan", Continent = "Asien", Description = "Kirgizistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 31 augusti 1991. Landet har cirka 6,5 miljoner invånare. De officiella språken är kirgiziska och ryska.", FlagImage = "https://flagcdn.com/kg.svg" },
                new CountryModel { Id = 95, Name = "Laos", Continent = "Asien", Description = "Laos, beläget i Sydostasien, blev självständigt från Frankrike den 22 oktober 1953. Landet har cirka 7,3 miljoner invånare. Det officiella språket är laotiska.", FlagImage = "https://flagcdn.com/la.svg" },
                new CountryModel { Id = 96, Name = "Lettland", Continent = "Europa", Description = "Lettland, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 21 augusti 1991. Landet har cirka 1,9 miljoner invånare. Det officiella språket är lettiska.", FlagImage = "https://flagcdn.com/lv.svg" },
                new CountryModel { Id = 97, Name = "Libanon", Continent = "Asien", Description = "Libanon, beläget i Mellanöstern vid Medelhavet, blev självständigt från Frankrike den 22 november 1943. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/lb.svg" },
                new CountryModel { Id = 98, Name = "Lesotho", Continent = "Afrika", Description = "Lesotho, ett litet bergigt land omgiven av Sydafrika, blev självständigt från Storbritannien den 4 oktober 1966. Landet har cirka 2 miljoner invånare. De officiella språken är sesotho och engelska.", FlagImage = "https://flagcdn.com/ls.svg" },
                new CountryModel { Id = 99, Name = "Liberia", Continent = "Afrika", Description = "Liberia, beläget i Västafrika, grundades av frigivna amerikanska slavar och blev en självständig stat den 26 juli 1847. Landet har cirka 5 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/lr.svg" },
                new CountryModel { Id = 100, Name = "Libyen", Continent = "Afrika", Description = "Libyen, beläget i Nordafrika vid Medelhavet, blev självständigt från Italien den 24 december 1951. Landet har cirka 6,8 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/ly.svg" },
                new CountryModel { Id = 101, Name = "Liechtenstein", Continent = "Europa", Description = "Liechtenstein, ett litet alpland mellan Schweiz och Österrike, blev en suverän stat 1719. Landet har cirka 39 000 invånare. Det officiella språket är tyska.", FlagImage = "https://flagcdn.com/li.svg" },
                new CountryModel { Id = 102, Name = "Litauen", Continent = "Europa", Description = "Litauen, beläget i norra Europa vid Östersjön, blev självständigt från Sovjetunionen den 11 mars 1990. Landet har cirka 2,8 miljoner invånare. Det officiella språket är litauiska.", FlagImage = "https://flagcdn.com/lt.svg" },
                new CountryModel { Id = 103, Name = "Luxemburg", Continent = "Europa", Description = "Luxemburg, ett litet land i Västeuropa, är ett av världens rikaste länder. Landet har cirka 630 000 invånare. De officiella språken är luxemburgiska, franska och tyska.", FlagImage = "https://flagcdn.com/lu.svg" },
                new CountryModel { Id = 104, Name = "Madagaskar", Continent = "Afrika", Description = "Madagaskar, en stor ö utanför Afrikas sydöstra kust, blev självständigt från Frankrike den 26 juni 1960. Landet har cirka 26 miljoner invånare. De officiella språken är malagassiska och franska.", FlagImage = "https://flagcdn.com/mg.svg" },
                new CountryModel { Id = 105, Name = "Malawi", Continent = "Afrika", Description = "Malawi, beläget i sydöstra Afrika, blev självständigt från Storbritannien den 6 juli 1964. Landet har cirka 19 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/mw.svg" },
                new CountryModel { Id = 106, Name = "Malaysia", Continent = "Asien", Description = "Malaysia, beläget i Sydostasien, blev självständigt från Storbritannien den 31 augusti 1957. Landet har cirka 32 miljoner invånare. Det officiella språket är malajiska.", FlagImage = "https://flagcdn.com/my.svg" },
                new CountryModel { Id = 107, Name = "Maldiverna", Continent = "Asien", Description = "Maldiverna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 26 juli 1965. Landet har cirka 540 000 invånare. Det officiella språket är dhivehi.", FlagImage = "https://flagcdn.com/mv.svg" },
                new CountryModel { Id = 108, Name = "Mali", Continent = "Afrika", Description = "Mali, beläget i Västafrika, blev självständigt från Frankrike den 22 september 1960. Landet har cirka 20 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/ml.svg" },
                new CountryModel { Id = 109, Name = "Malta", Continent = "Europa", Description = "Malta, en ö-nation i Medelhavet, blev självständigt från Storbritannien den 21 september 1964. Landet har cirka 514 000 invånare. De officiella språken är maltesiska och engelska.", FlagImage = "https://flagcdn.com/mt.svg" },
                new CountryModel { Id = 110, Name = "Marshallöarna", Continent = "Oceanien", Description = "Marshallöarna, en ö-nation i Stilla havet, blev självständigt från USA den 21 oktober 1986. Landet har cirka 59 000 invånare. De officiella språken är engelska och marshallesiska.", FlagImage = "https://flagcdn.com/mh.svg" },
                new CountryModel { Id = 111, Name = "Mauretanien", Continent = "Afrika", Description = "Mauretanien, beläget i Västafrika, blev självständigt från Frankrike den 28 november 1960. Landet har cirka 4,5 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/mr.svg" },
                new CountryModel { Id = 112, Name = "Mauritius", Continent = "Afrika", Description = "Mauritius, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 12 mars 1968. Landet har cirka 1,3 miljoner invånare. De officiella språken är engelska och franska.", FlagImage = "https://flagcdn.com/mu.svg" },
                new CountryModel { Id = 113, Name = "Mexiko", Continent = "Nordamerika", Description = "Mexiko, beläget i Nordamerika, blev självständigt från Spanien den 16 september 1810. Landet har cirka 128 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/mx.svg" },
                new CountryModel { Id = 114, Name = "Mikronesien", Continent = "Oceanien", Description = "Mikronesien, en ö-nation i Stilla havet, blev självständigt från USA den 3 november 1986. Landet har cirka 104 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/fm.svg" },
                new CountryModel { Id = 115, Name = "Moldavien", Continent = "Europa", Description = "Moldavien, beläget i Östeuropa, blev självständigt från Sovjetunionen den 27 augusti 1991. Landet har cirka 2,6 miljoner invånare. Det officiella språket är rumänska.", FlagImage = "https://flagcdn.com/md.svg" },
                new CountryModel { Id = 116, Name = "Monaco", Continent = "Europa", Description = "Monaco, en liten stadsstat på franska rivieran, är världens näst minsta land. Landet har cirka 39 000 invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/mc.svg" },
                new CountryModel { Id = 117, Name = "Mongoliet", Continent = "Asien", Description = "Mongoliet, beläget i Östasien, blev självständigt från Kina den 11 juli 1921. Landet har cirka 3,2 miljoner invånare. Det officiella språket är mongoliska.", FlagImage = "https://flagcdn.com/mn.svg" },
                new CountryModel { Id = 118, Name = "Montenegro", Continent = "Europa", Description = "Montenegro, beläget på Balkanhalvön, blev självständigt från Serbien och Montenegro den 3 juni 2006. Landet har cirka 620 000 invånare. Det officiella språket är montenegrinska.", FlagImage = "https://flagcdn.com/me.svg" },
                new CountryModel { Id = 119, Name = "Marocko", Continent = "Afrika", Description = "Marocko, beläget i Nordafrika vid Atlanten och Medelhavet, blev självständigt från Frankrike den 2 mars 1956. Landet har cirka 36 miljoner invånare. De officiella språken är arabiska och berbiska.", FlagImage = "https://flagcdn.com/ma.svg" },
                new CountryModel { Id = 120, Name = "Moçambique", Continent = "Afrika", Description = "Moçambique, beläget i sydöstra Afrika, blev självständigt från Portugal den 25 juni 1975. Landet har cirka 30 miljoner invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/mz.svg" },
                new CountryModel { Id = 121, Name = "Myanmar", Continent = "Asien", Description = "Myanmar, tidigare känt som Burma, beläget i Sydostasien, blev självständigt från Storbritannien den 4 januari 1948. Landet har cirka 54 miljoner invånare. Det officiella språket är burmesiska.", FlagImage = "https://flagcdn.com/mm.svg" },
                new CountryModel { Id = 122, Name = "Namibia", Continent = "Afrika", Description = "Namibia, beläget i sydvästra Afrika, blev självständigt från Sydafrika den 21 mars 1990. Landet har cirka 2,5 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/na.svg" },
                new CountryModel { Id = 123, Name = "Nauru", Continent = "Oceanien", Description = "Nauru, en liten ö-nation i Stilla havet, blev självständigt från Australien, Nya Zeeland och Storbritannien den 31 januari 1968. Landet har cirka 10 000 invånare. Det officiella språket är nauruanska.", FlagImage = "https://flagcdn.com/nr.svg" },
                new CountryModel { Id = 124, Name = "Nepal", Continent = "Asien", Description = "Nepal, beläget i Himalaya, är en av världens äldsta suveräna stater. Landet har cirka 29 miljoner invånare. Det officiella språket är nepalesiska.", FlagImage = "https://flagcdn.com/np.svg" },
                new CountryModel { Id = 125, Name = "Nederländerna", Continent = "Europa", Description = "Nederländerna, beläget i Västeuropa, har en lång historia som självständig nation. Landet har cirka 17 miljoner invånare. Det officiella språket är nederländska.", FlagImage = "https://flagcdn.com/nl.svg" },
                new CountryModel { Id = 126, Name = "Nya Zeeland", Continent = "Oceanien", Description = "Nya Zeeland, en ö-nation i sydvästra Stilla havet, blev självständigt från Storbritannien den 26 september 1907. Landet har cirka 5 miljoner invånare. De officiella språken är engelska och maori.", FlagImage = "https://flagcdn.com/nz.svg" },
                new CountryModel { Id = 127, Name = "Nicaragua", Continent = "Nordamerika", Description = "Nicaragua, beläget i Centralamerika, blev självständigt från Spanien den 15 september 1821. Landet har cirka 6,6 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/ni.svg" },
                new CountryModel { Id = 128, Name = "Niger", Continent = "Afrika", Description = "Niger, beläget i Västafrika, blev självständigt från Frankrike den 3 augusti 1960. Landet har cirka 24 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/ne.svg" },
                new CountryModel { Id = 129, Name = "Nigeria", Continent = "Afrika", Description = "Nigeria, beläget i Västafrika, blev självständigt från Storbritannien den 1 oktober 1960. Landet har cirka 206 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/ng.svg" },
                new CountryModel { Id = 130, Name = "Nordmakedonien", Continent = "Europa", Description = "Nordmakedonien, beläget på Balkanhalvön, blev självständigt från Jugoslavien den 8 september 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är makedonska.", FlagImage = "https://flagcdn.com/mk.svg" },
                new CountryModel { Id = 131, Name = "Norge", Continent = "Europa", Description = "Norge, beläget i norra Europa på Skandinaviska halvön, blev självständigt från Sverige den 7 juni 1905. Landet har cirka 5,4 miljoner invånare. Det officiella språket är norska.", FlagImage = "https://flagcdn.com/no.svg" },
                new CountryModel { Id = 132, Name = "Oman", Continent = "Asien", Description = "Oman, beläget på Arabiska halvön, blev en självständig stat efter att ha avskaffat det portugisiska styret 1651. Landet har cirka 5 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/om.svg" },
                new CountryModel { Id = 133, Name = "Pakistan", Continent = "Asien", Description = "Pakistan, beläget i Sydasien, bildades som en självständig stat från Indien den 14 augusti 1947. Landet har cirka 220 miljoner invånare. Det officiella språket är urdu.", FlagImage = "https://flagcdn.com/pk.svg" },
                new CountryModel { Id = 134, Name = "Palau", Continent = "Oceanien", Description = "Palau, en ö-nation i Stilla havet, blev självständigt från USA den 1 oktober 1994. Landet har cirka 18 000 invånare. De officiella språken är palauanska och engelska.", FlagImage = "https://flagcdn.com/pw.svg" },
                new CountryModel { Id = 135, Name = "Palestina", Continent = "Asien", Description = "Palestina, beläget i Mellanöstern, består av Västbanken och Gaza. Befolkningen uppgår till cirka 5 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/ps.svg" },
                new CountryModel { Id = 136, Name = "Panama", Continent = "Nordamerika", Description = "Panama, beläget i Centralamerika, blev självständigt från Colombia den 3 november 1903. Landet har cirka 4,2 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/pa.svg" },
                new CountryModel { Id = 137, Name = "Papua Nya Guinea", Continent = "Oceanien", Description = "Papua Nya Guinea, beläget i sydvästra Stilla havet, blev självständigt från Australien den 16 september 1975. Landet har cirka 8,9 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/pg.svg" },
                new CountryModel { Id = 138, Name = "Paraguay", Continent = "Sydamerika", Description = "Paraguay, beläget i Sydamerika, blev självständigt från Spanien den 14 maj 1811. Landet har cirka 7 miljoner invånare. De officiella språken är spanska och guarani.", FlagImage = "https://flagcdn.com/py.svg" },
                new CountryModel { Id = 139, Name = "Peru", Continent = "Sydamerika", Description = "Peru, beläget i västra Sydamerika, blev självständigt från Spanien den 28 juli 1821. Landet har cirka 33 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/pe.svg" },
                new CountryModel { Id = 140, Name = "Filippinerna", Continent = "Asien", Description = "Filippinerna, en ö-nation i Sydostasien, blev självständigt från USA den 4 juli 1946. Landet har cirka 109 miljoner invånare. Det officiella språket är filippinska och engelska.", FlagImage = "https://flagcdn.com/ph.svg" },
                new CountryModel { Id = 141, Name = "Polen", Continent = "Europa", Description = "Polen, beläget i Centraleuropa, återfick sin självständighet den 11 november 1918 efter att ha varit uppdelat mellan olika imperier i över ett sekel. Landet har cirka 38 miljoner invånare. Det officiella språket är polska.", FlagImage = "https://flagcdn.com/pl.svg" },
                new CountryModel { Id = 142, Name = "Portugal", Continent = "Europa", Description = "Portugal, beläget på den iberiska halvön i södra Europa, är en av världens äldsta nationer. Landet har cirka 10 miljoner invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/pt.svg" },
                new CountryModel { Id = 143, Name = "Qatar", Continent = "Asien", Description = "Qatar, beläget på Arabiska halvön vid Persiska viken, blev självständigt från Storbritannien den 3 september 1971. Landet har cirka 2,8 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/qa.svg" },
                new CountryModel { Id = 144, Name = "Rumänien", Continent = "Europa", Description = "Rumänien, beläget i sydöstra Europa, blev självständigt från Osmanska riket den 9 maj 1877. Landet har cirka 19 miljoner invånare. Det officiella språket är rumänska.", FlagImage = "https://flagcdn.com/ro.svg" },
                new CountryModel { Id = 145, Name = "Ryssland", Continent = "Europa", Description = "Ryssland, världens största land till ytan, blev självständigt från Sovjetunionen den 25 december 1991. Landet har cirka 146 miljoner invånare. Det officiella språket är ryska.", FlagImage = "https://flagcdn.com/ru.svg" },
                new CountryModel { Id = 146, Name = "Rwanda", Continent = "Afrika", Description = "Rwanda, beläget i Centralafrika, blev självständigt från Belgien den 1 juli 1962. Landet har cirka 12 miljoner invånare. De officiella språken är kinyarwanda, franska och engelska.", FlagImage = "https://flagcdn.com/rw.svg" },
                new CountryModel { Id = 147, Name = "Saint Kitts och Nevis", Continent = "Nordamerika", Description = "Saint Kitts och Nevis, en ö-nation i Karibien, blev självständigt från Storbritannien den 19 september 1983. Landet har cirka 53 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/kn.svg" },
                new CountryModel { Id = 148, Name = "Saint Lucia", Continent = "Nordamerika", Description = "Saint Lucia, en ö-nation i Karibien, blev självständigt från Storbritannien den 22 februari 1979. Landet har cirka 180 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/lc.svg" },
                new CountryModel { Id = 149, Name = "Saint Vincent och Grenadinerna", Continent = "Nordamerika", Description = "Saint Vincent och Grenadinerna, en ö-nation i Karibien, blev självständigt från Storbritannien den 27 oktober 1979. Landet har cirka 110 000 invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/vc.svg" },
                new CountryModel { Id = 150, Name = "Samoa", Continent = "Oceanien", Description = "Samoa, en ö-nation i Stilla havet, blev självständigt från Nya Zeeland den 1 januari 1962. Landet har cirka 200 000 invånare. Det officiella språket är samoanska och engelska.", FlagImage = "https://flagcdn.com/ws.svg" },
                new CountryModel { Id = 151, Name = "San Marino", Continent = "Europa", Description = "San Marino, en mikrostatsrepublik belägen i norra Italien, anses vara världens äldsta republik. Landet har cirka 34 000 invånare. Det officiella språket är italienska.", FlagImage = "https://flagcdn.com/sm.svg" },
                new CountryModel { Id = 152, Name = "Sao Tomé och Principe", Continent = "Afrika", Description = "Sao Tomé och Principe, en ö-nation i Guineabukten, blev självständigt från Portugal den 12 juli 1975. Landet har cirka 200 000 invånare. Det officiella språket är portugisiska.", FlagImage = "https://flagcdn.com/st.svg" },
                new CountryModel { Id = 153, Name = "Saudiarabien", Continent = "Asien", Description = "Saudiarabien, beläget på Arabiska halvön, grundades som ett enat kungarike den 23 september 1932. Landet har cirka 34 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/sa.svg" },
                new CountryModel { Id = 154, Name = "Senegal", Continent = "Afrika", Description = "Senegal, beläget i Västafrika, blev självständigt från Frankrike den 20 augusti 1960. Landet har cirka 16 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/sn.svg" },
                new CountryModel { Id = 155, Name = "Serbien", Continent = "Europa", Description = "Serbien, beläget på Balkanhalvön, blev självständigt från unionen med Montenegro den 5 juni 2006. Landet har cirka 7 miljoner invånare. Det officiella språket är serbiska.", FlagImage = "https://flagcdn.com/rs.svg" },
                new CountryModel { Id = 156, Name = "Seychellerna", Continent = "Afrika", Description = "Seychellerna, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 29 juni 1976. Landet har cirka 98 000 invånare. De officiella språken är kreol, engelska och franska.", FlagImage = "https://flagcdn.com/sc.svg" },
                new CountryModel { Id = 157, Name = "Sierra Leone", Continent = "Afrika", Description = "Sierra Leone, beläget i Västafrika, blev självständigt från Storbritannien den 27 april 1961. Landet har cirka 7,5 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/sl.svg" },
                new CountryModel { Id = 158, Name = "Singapore", Continent = "Asien", Description = "Singapore, en stadstat i Sydostasien, blev självständigt från Malaysia den 9 augusti 1965. Landet har cirka 5,7 miljoner invånare. De officiella språken är engelska, mandarin, malajiska och tamil.", FlagImage = "https://flagcdn.com/sg.svg" },
                new CountryModel { Id = 159, Name = "Slovakien", Continent = "Europa", Description = "Slovakien, beläget i Centraleuropa, blev självständigt från Tjeckoslovakien den 1 januari 1993. Landet har cirka 5,4 miljoner invånare. Det officiella språket är slovakiska.", FlagImage = "https://flagcdn.com/sk.svg" },
                new CountryModel { Id = 160, Name = "Slovenien", Continent = "Europa", Description = "Slovenien, beläget i Centraleuropa, blev självständigt från Jugoslavien den 25 juni 1991. Landet har cirka 2,1 miljoner invånare. Det officiella språket är slovenska.", FlagImage = "https://flagcdn.com/si.svg" },
                new CountryModel { Id = 161, Name = "Salomonöarna", Continent = "Oceanien", Description = "Salomonöarna, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 7 juli 1978. Landet har cirka 652 000 invånare. De officiella språken är engelska och pijin.", FlagImage = "https://flagcdn.com/sb.svg" },
                new CountryModel { Id = 162, Name = "Somalia", Continent = "Afrika", Description = "Somalia, beläget i Afrikas horn, blev självständigt från Storbritannien och Italien den 1 juli 1960. Landet har cirka 15 miljoner invånare. Det officiella språket är somaliska.", FlagImage = "https://flagcdn.com/so.svg" },
                new CountryModel { Id = 163, Name = "Sydafrika", Continent = "Afrika", Description = "Sydafrika, beläget på Afrikas sydspets, blev självständigt från Storbritannien den 31 maj 1910. Landet har cirka 58 miljoner invånare. Det finns 11 officiella språk, inklusive afrikaans och engelska.", FlagImage = "https://flagcdn.com/za.svg" },
                new CountryModel { Id = 164, Name = "Sydsudan", Continent = "Afrika", Description = "Sydsudan, världens yngsta nation, blev självständigt från Sudan den 9 juli 2011. Landet har cirka 11 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/ss.svg" },
                new CountryModel { Id = 165, Name = "Spanien", Continent = "Europa", Description = "Spanien, beläget på den iberiska halvön i södra Europa, är känt för sin rika kultur och historia. Landet har cirka 47 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/es.svg" },
                new CountryModel { Id = 166, Name = "Sri Lanka", Continent = "Asien", Description = "Sri Lanka, en ö-nation i Indiska oceanen, blev självständigt från Storbritannien den 4 februari 1948. Landet har cirka 21 miljoner invånare. De officiella språken är singalesiska och tamil.", FlagImage = "https://flagcdn.com/lk.svg" },
                new CountryModel { Id = 167, Name = "Sudan", Continent = "Afrika", Description = "Sudan, beläget i Nordafrika, blev självständigt från Egypten och Storbritannien den 1 januari 1956. Landet har cirka 42 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/sd.svg" },
                new CountryModel { Id = 168, Name = "Surinam", Continent = "Sydamerika", Description = "Surinam, beläget i norra Sydamerika, blev självständigt från Nederländerna den 25 november 1975. Landet har cirka 586 000 invånare. Det officiella språket är nederländska.", FlagImage = "https://flagcdn.com/sr.svg" },
                new CountryModel { Id = 169, Name = "Sverige", Continent = "Europa", Description = "Sverige, beläget i norra Europa på Skandinaviska halvön, har en lång historia som självständig nation. Landet har cirka 10,3 miljoner invånare. Det officiella språket är svenska.", FlagImage = "https://flagcdn.com/se.svg" },
                new CountryModel { Id = 170, Name = "Schweiz", Continent = "Europa", Description = "Schweiz, beläget i Centraleuropa, är känt för sin neutralitet och stabilitet. Landet har cirka 8,5 miljoner invånare. De officiella språken är tyska, franska, italienska och rätoromanska.", FlagImage = "https://flagcdn.com/ch.svg" },
                new CountryModel { Id = 171, Name = "Syrien", Continent = "Asien", Description = "Syrien, beläget i Mellanöstern, blev självständigt från Frankrike den 17 april 1946. Landet har cirka 17 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/sy.svg" },
                new CountryModel { Id = 172, Name = "Tadzjikistan", Continent = "Asien", Description = "Tadzjikistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 9 september 1991. Landet har cirka 9,5 miljoner invånare. Det officiella språket är tadzjikiska.", FlagImage = "https://flagcdn.com/tj.svg" },
                new CountryModel { Id = 173, Name = "Tanzania", Continent = "Afrika", Description = "Tanzania, beläget i Östafrika, bildades genom sammanslagningen av Tanganyika och Zanzibar den 26 april 1964. Landet har cirka 58 miljoner invånare. De officiella språken är swahili och engelska.", FlagImage = "https://flagcdn.com/tz.svg" },
                new CountryModel { Id = 174, Name = "Thailand", Continent = "Asien", Description = "Thailand, beläget i Sydostasien, är känt för sin rika kultur och historia. Landet har cirka 70 miljoner invånare. Det officiella språket är thailändska.", FlagImage = "https://flagcdn.com/th.svg" },
                new CountryModel { Id = 175, Name = "Togo", Continent = "Afrika", Description = "Togo, beläget i Västafrika, blev självständigt från Frankrike den 27 april 1960. Landet har cirka 8 miljoner invånare. Det officiella språket är franska.", FlagImage = "https://flagcdn.com/tg.svg" },
                new CountryModel { Id = 176, Name = "Tonga", Continent = "Oceanien", Description = "Tonga, en ö-nation i Stilla havet, blev aldrig koloniserat men blev en konstitutionell monarki 1875. Landet har cirka 104 000 invånare. Det officiella språket är tonganska och engelska.", FlagImage = "https://flagcdn.com/to.svg" },
                new CountryModel { Id = 177, Name = "Trinidad och Tobago", Continent = "Nordamerika", Description = "Trinidad och Tobago, en ö-nation i Karibien, blev självständigt från Storbritannien den 31 augusti 1962. Landet har cirka 1,4 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/tt.svg" },
                new CountryModel { Id = 178, Name = "Tunisien", Continent = "Afrika", Description = "Tunisien, beläget i Nordafrika vid Medelhavet, blev självständigt från Frankrike den 20 mars 1956. Landet har cirka 12 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/tn.svg" },
                new CountryModel { Id = 179, Name = "Turkiet", Continent = "Asien", Description = "Turkiet, beläget på gränsen mellan Europa och Asien, blev en republik den 29 oktober 1923 efter det osmanska rikets fall. Landet har cirka 82 miljoner invånare. Det officiella språket är turkiska.", FlagImage = "https://flagcdn.com/tr.svg" },
                new CountryModel { Id = 180, Name = "Turkmenistan", Continent = "Asien", Description = "Turkmenistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 27 oktober 1991. Landet har cirka 6 miljoner invånare. Det officiella språket är turkmeniska.", FlagImage = "https://flagcdn.com/tm.svg" },
                new CountryModel { Id = 181, Name = "Tuvalu", Continent = "Oceanien", Description = "Tuvalu, en ö-nation i Stilla havet, blev självständigt från Storbritannien den 1 oktober 1978. Landet har cirka 11 000 invånare. De officiella språken är tuvaluanska och engelska.", FlagImage = "https://flagcdn.com/tv.svg" },
                new CountryModel { Id = 182, Name = "Uganda", Continent = "Afrika", Description = "Uganda, beläget i Östafrika, blev självständigt från Storbritannien den 9 oktober 1962. Landet har cirka 45 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/ug.svg" },
                new CountryModel { Id = 183, Name = "Ukraina", Continent = "Europa", Description = "Ukraina, beläget i Östeuropa, blev självständigt från Sovjetunionen den 24 augusti 1991. Landet har cirka 41 miljoner invånare. Det officiella språket är ukrainska.", FlagImage = "https://flagcdn.com/ua.svg" },
                new CountryModel { Id = 184, Name = "Förenade Arabemiraten", Continent = "Asien", Description = "Förenade Arabemiraten, beläget i Mellanöstern, blev självständigt från Storbritannien den 2 december 1971. Landet har cirka 9,9 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/ae.svg" },
                new CountryModel { Id = 185, Name = "Storbritannien", Continent = "Europa", Description = "Storbritannien, beläget i nordvästra Europa, är en av världens äldsta konstitutionella monarkier. Landet har cirka 67 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/gb.svg" },
                new CountryModel { Id = 186, Name = "USA", Continent = "Nordamerika", Description = "USA, beläget i Nordamerika, blev självständigt från Storbritannien den 4 juli 1776. Landet har cirka 331 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/us.svg" },
                new CountryModel { Id = 187, Name = "Uruguay", Continent = "Sydamerika", Description = "Uruguay, beläget i Sydamerika, blev självständigt från Brasilien den 25 augusti 1825. Landet har cirka 3,5 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/uy.svg" },
                new CountryModel { Id = 188, Name = "Uzbekistan", Continent = "Asien", Description = "Uzbekistan, beläget i Centralasien, blev självständigt från Sovjetunionen den 1 september 1991. Landet har cirka 33 miljoner invånare. Det officiella språket är uzbekiska.", FlagImage = "https://flagcdn.com/uz.svg" },
                new CountryModel { Id = 189, Name = "Vanuatu", Continent = "Oceanien", Description = "Vanuatu, en ö-nation i Stilla havet, blev självständigt från Frankrike och Storbritannien den 30 juli 1980. Landet har cirka 307 000 invånare. De officiella språken är bislama, engelska och franska.", FlagImage = "https://flagcdn.com/vu.svg" },
                new CountryModel { Id = 190, Name = "Vatikanstaten", Continent = "Europa", Description = "Vatikanstaten, en mikrostatsstat i Rom, är världens minsta suveräna stat. Landet har cirka 800 invånare. Det officiella språket är latin.", FlagImage = "https://flagcdn.com/va.svg" },
                new CountryModel { Id = 191, Name = "Venezuela", Continent = "Sydamerika", Description = "Venezuela, beläget i norra Sydamerika, blev självständigt från Spanien den 5 juli 1811. Landet har cirka 28 miljoner invånare. Det officiella språket är spanska.", FlagImage = "https://flagcdn.com/ve.svg" },
                new CountryModel { Id = 192, Name = "Vietnam", Continent = "Asien", Description = "Vietnam, beläget i Sydostasien, blev självständigt från Frankrike den 2 september 1945. Landet har cirka 97 miljoner invånare. Det officiella språket är vietnamesiska.", FlagImage = "https://flagcdn.com/vn.svg" },
                new CountryModel { Id = 193, Name = "Jemen", Continent = "Asien", Description = "Jemen, beläget på Arabiska halvön, blev en enad republik den 22 maj 1990. Landet har cirka 29 miljoner invånare. Det officiella språket är arabiska.", FlagImage = "https://flagcdn.com/ye.svg" },
                new CountryModel { Id = 194, Name = "Zambia", Continent = "Afrika", Description = "Zambia, beläget i södra Afrika, blev självständigt från Storbritannien den 24 oktober 1964. Landet har cirka 18 miljoner invånare. Det officiella språket är engelska.", FlagImage = "https://flagcdn.com/zm.svg" },
                new CountryModel { Id = 195, Name = "Zimbabwe", Continent = "Afrika", Description = "Zimbabwe, beläget i södra Afrika, blev självständigt från Storbritannien den 18 april 1980. Landet har cirka 14 miljoner invånare. De officiella språken är engelska, shona och ndebele.", FlagImage = "https://flagcdn.com/zw.svg" }
            );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { Id = 1, CountryId = 1, Difficulty = "Hard" }, // Afghanistan
                new QuestionModel { Id = 2, CountryId = 2, Difficulty = "Normal" }, // Albanien
                new QuestionModel { Id = 3, CountryId = 3, Difficulty = "Normal" }, // Algeriet
                new QuestionModel { Id = 4, CountryId = 4, Difficulty = "Hard" }, // Andorra
                new QuestionModel { Id = 5, CountryId = 5, Difficulty = "Normal" }, // Angola
                new QuestionModel { Id = 6, CountryId = 6, Difficulty = "Hard" }, // Antigua och Barbuda
                new QuestionModel { Id = 7, CountryId = 7, Difficulty = "Easy" }, // Argentina
                new QuestionModel { Id = 8, CountryId = 8, Difficulty = "Hard" }, // Armenien
                new QuestionModel { Id = 9, CountryId = 9, Difficulty = "Easy" }, // Australien
                new QuestionModel { Id = 10, CountryId = 10, Difficulty = "Normal" }, // Österrike
                new QuestionModel { Id = 11, CountryId = 11, Difficulty = "Normal" }, // Azerbajdzjan
                new QuestionModel { Id = 12, CountryId = 12, Difficulty = "Hard" }, // Bahamas
                new QuestionModel { Id = 13, CountryId = 13, Difficulty = "Normal" }, // Bahrain
                new QuestionModel { Id = 14, CountryId = 14, Difficulty = "Normal" }, // Bangladesh
                new QuestionModel { Id = 15, CountryId = 15, Difficulty = "Hard" }, // Barbados
                new QuestionModel { Id = 16, CountryId = 16, Difficulty = "Hard" }, // Vitryssland
                new QuestionModel { Id = 17, CountryId = 17, Difficulty = "Normal" }, // Belgien
                new QuestionModel { Id = 18, CountryId = 18, Difficulty = "Hard" }, // Belize
                new QuestionModel { Id = 19, CountryId = 19, Difficulty = "Normal" }, // Benin
                new QuestionModel { Id = 20, CountryId = 20, Difficulty = "Hard" }, // Bhutan
                new QuestionModel { Id = 21, CountryId = 21, Difficulty = "Normal" }, // Bolivia
                new QuestionModel { Id = 22, CountryId = 22, Difficulty = "Hard" }, // Bosnien och Hercegovina
                new QuestionModel { Id = 23, CountryId = 23, Difficulty = "Hard" }, // Botswana
                new QuestionModel { Id = 24, CountryId = 24, Difficulty = "Easy" }, // Brasilien
                new QuestionModel { Id = 25, CountryId = 25, Difficulty = "Hard" }, // Brunei
                new QuestionModel { Id = 26, CountryId = 26, Difficulty = "Normal" }, // Bulgarien
                new QuestionModel { Id = 27, CountryId = 27, Difficulty = "Hard" }, // Burkina Faso
                new QuestionModel { Id = 28, CountryId = 28, Difficulty = "Hard" }, // Burundi
                new QuestionModel { Id = 29, CountryId = 29, Difficulty = "Hard" }, // Cabo Verde
                new QuestionModel { Id = 30, CountryId = 30, Difficulty = "Normal" }, // Kambodja
                new QuestionModel { Id = 31, CountryId = 31, Difficulty = "Normal" }, // Kamerun
                new QuestionModel { Id = 32, CountryId = 32, Difficulty = "Easy" }, // Kanada
                new QuestionModel { Id = 33, CountryId = 33, Difficulty = "Hard" }, // Centralafrikanska republiken
                new QuestionModel { Id = 34, CountryId = 34, Difficulty = "Normal" }, // Tchad
                new QuestionModel { Id = 35, CountryId = 35, Difficulty = "Easy" }, // Chile
                new QuestionModel { Id = 36, CountryId = 36, Difficulty = "Easy" }, // Kina
                new QuestionModel { Id = 37, CountryId = 37, Difficulty = "Easy" }, // Colombia
                new QuestionModel { Id = 38, CountryId = 38, Difficulty = "Hard" }, // Komorerna
                new QuestionModel { Id = 39, CountryId = 39, Difficulty = "Normal" }, // Kongo-Brazzaville
                new QuestionModel { Id = 40, CountryId = 40, Difficulty = "Normal" }, // Kongo-Kinshasa
                new QuestionModel { Id = 41, CountryId = 41, Difficulty = "Normal" }, // Costa Rica
                new QuestionModel { Id = 42, CountryId = 42, Difficulty = "Normal" }, // Kroatien
                new QuestionModel { Id = 43, CountryId = 43, Difficulty = "Normal" }, // Kuba
                new QuestionModel { Id = 44, CountryId = 44, Difficulty = "Normal" }, // Cypern
                new QuestionModel { Id = 45, CountryId = 45, Difficulty = "Normal" }, // Tjeckien
                new QuestionModel { Id = 46, CountryId = 46, Difficulty = "Normal" }, // Danmark
                new QuestionModel { Id = 47, CountryId = 47, Difficulty = "Hard" }, // Djibouti
                new QuestionModel { Id = 48, CountryId = 48, Difficulty = "Hard" }, // Dominica
                new QuestionModel { Id = 49, CountryId = 49, Difficulty = "Normal" }, // Dominikanska republiken
                new QuestionModel { Id = 50, CountryId = 50, Difficulty = "Hard" }, // Östtimor
                new QuestionModel { Id = 51, CountryId = 51, Difficulty = "Normal" }, // Ecuador
                new QuestionModel { Id = 52, CountryId = 52, Difficulty = "Easy" }, // Egypten
                new QuestionModel { Id = 53, CountryId = 53, Difficulty = "Normal" }, // El Salvador
                new QuestionModel { Id = 54, CountryId = 54, Difficulty = "Hard" }, // Ekvatorialguinea
                new QuestionModel { Id = 55, CountryId = 55, Difficulty = "Hard" }, // Eritrea
                new QuestionModel { Id = 56, CountryId = 56, Difficulty = "Normal" }, // Estland
                new QuestionModel { Id = 57, CountryId = 57, Difficulty = "Hard" }, // Eswatini
                new QuestionModel { Id = 58, CountryId = 58, Difficulty = "Normal" }, // Etiopien
                new QuestionModel { Id = 59, CountryId = 59, Difficulty = "Hard" }, // Fiji
                new QuestionModel { Id = 60, CountryId = 60, Difficulty = "Normal" }, // Finland
                new QuestionModel { Id = 61, CountryId = 61, Difficulty = "Easy" }, // Frankrike
                new QuestionModel { Id = 62, CountryId = 62, Difficulty = "Hard" }, // Gabon
                new QuestionModel { Id = 63, CountryId = 63, Difficulty = "Hard" }, // Gambia
                new QuestionModel { Id = 64, CountryId = 64, Difficulty = "Hard" }, // Georgien
                new QuestionModel { Id = 65, CountryId = 65, Difficulty = "Easy" }, // Tyskland
                new QuestionModel { Id = 66, CountryId = 66, Difficulty = "Normal" }, // Ghana
                new QuestionModel { Id = 67, CountryId = 67, Difficulty = "Easy" }, // Grekland
                new QuestionModel { Id = 68, CountryId = 68, Difficulty = "Hard" }, // Grenada
                new QuestionModel { Id = 69, CountryId = 69, Difficulty = "Normal" }, // Guatemala
                new QuestionModel { Id = 70, CountryId = 70, Difficulty = "Hard" }, // Guinea
                new QuestionModel { Id = 71, CountryId = 71, Difficulty = "Hard" }, // Guinea-Bissau
                new QuestionModel { Id = 72, CountryId = 72, Difficulty = "Hard" }, // Guyana
                new QuestionModel { Id = 73, CountryId = 73, Difficulty = "Normal" }, // Haiti
                new QuestionModel { Id = 74, CountryId = 74, Difficulty = "Normal" }, // Honduras
                new QuestionModel { Id = 75, CountryId = 75, Difficulty = "Normal" }, // Ungern
                new QuestionModel { Id = 76, CountryId = 76, Difficulty = "Hard" }, // Island
                new QuestionModel { Id = 77, CountryId = 77, Difficulty = "Easy" }, // Indien
                new QuestionModel { Id = 78, CountryId = 78, Difficulty = "Easy" }, // Indonesien
                new QuestionModel { Id = 79, CountryId = 79, Difficulty = "Normal" }, // Iran
                new QuestionModel { Id = 80, CountryId = 80, Difficulty = "Normal" }, // Irak
                new QuestionModel { Id = 81, CountryId = 81, Difficulty = "Normal" }, // Irland
                new QuestionModel { Id = 82, CountryId = 82, Difficulty = "Easy" }, // Italien
                new QuestionModel { Id = 83, CountryId = 83, Difficulty = "Normal" }, // Elfenbenskusten
                new QuestionModel { Id = 84, CountryId = 84, Difficulty = "Normal" }, // Jamaica
                new QuestionModel { Id = 85, CountryId = 85, Difficulty = "Easy" }, // Japan
                new QuestionModel { Id = 86, CountryId = 86, Difficulty = "Normal" }, // Jordanien
                new QuestionModel { Id = 87, CountryId = 87, Difficulty = "Hard" }, // Kazakstan
                new QuestionModel { Id = 88, CountryId = 88, Difficulty = "Normal" }, // Kenya
                new QuestionModel { Id = 89, CountryId = 89, Difficulty = "Hard" }, // Kiribati
                new QuestionModel { Id = 90, CountryId = 90, Difficulty = "Normal" }, // Nordkorea
                new QuestionModel { Id = 91, CountryId = 91, Difficulty = "Normal" }, // Sydkorea
                new QuestionModel { Id = 92, CountryId = 92, Difficulty = "Hard" }, // Kosovo
                new QuestionModel { Id = 93, CountryId = 93, Difficulty = "Normal" }, // Kuwait
                new QuestionModel { Id = 94, CountryId = 94, Difficulty = "Hard" }, // Kirgizistan
                new QuestionModel { Id = 95, CountryId = 95, Difficulty = "Hard" }, // Laos
                new QuestionModel { Id = 96, CountryId = 96, Difficulty = "Normal" }, // Lettland
                new QuestionModel { Id = 97, CountryId = 97, Difficulty = "Normal" }, // Libanon
                new QuestionModel { Id = 98, CountryId = 98, Difficulty = "Hard" }, // Lesotho
                new QuestionModel { Id = 99, CountryId = 99, Difficulty = "Normal" }, // Liberia
                new QuestionModel { Id = 100, CountryId = 100, Difficulty = "Normal" }, // Libyen
                new QuestionModel { Id = 101, CountryId = 101, Difficulty = "Hard" }, // Liechtenstein
                new QuestionModel { Id = 102, CountryId = 102, Difficulty = "Normal" }, // Litauen
                new QuestionModel { Id = 103, CountryId = 103, Difficulty = "Normal" }, // Luxemburg
                new QuestionModel { Id = 104, CountryId = 104, Difficulty = "Normal" }, // Madagaskar
                new QuestionModel { Id = 105, CountryId = 105, Difficulty = "Normal" }, // Malawi
                new QuestionModel { Id = 106, CountryId = 106, Difficulty = "Normal" }, // Malaysia
                new QuestionModel { Id = 107, CountryId = 107, Difficulty = "Hard" }, // Maldiverna
                new QuestionModel { Id = 108, CountryId = 108, Difficulty = "Normal" }, // Mali
                new QuestionModel { Id = 109, CountryId = 109, Difficulty = "Hard" }, // Malta
                new QuestionModel { Id = 110, CountryId = 110, Difficulty = "Hard" }, // Marshallöarna
                new QuestionModel { Id = 111, CountryId = 111, Difficulty = "Normal" }, // Mauretanien
                new QuestionModel { Id = 112, CountryId = 112, Difficulty = "Hard" }, // Mauritius
                new QuestionModel { Id = 113, CountryId = 113, Difficulty = "Easy" }, // Mexiko
                new QuestionModel { Id = 114, CountryId = 114, Difficulty = "Hard" }, // Mikronesien
                new QuestionModel { Id = 115, CountryId = 115, Difficulty = "Hard" }, // Moldavien
                new QuestionModel { Id = 116, CountryId = 116, Difficulty = "Hard" }, // Monaco
                new QuestionModel { Id = 117, CountryId = 117, Difficulty = "Normal" }, // Mongoliet
                new QuestionModel { Id = 118, CountryId = 118, Difficulty = "Hard" }, // Montenegro
                new QuestionModel { Id = 119, CountryId = 119, Difficulty = "Normal" }, // Marocko
                new QuestionModel { Id = 120, CountryId = 120, Difficulty = "Normal" }, // Moçambique
                new QuestionModel { Id = 121, CountryId = 121, Difficulty = "Normal" }, // Myanmar
                new QuestionModel { Id = 122, CountryId = 122, Difficulty = "Hard" }, // Namibia
                new QuestionModel { Id = 123, CountryId = 123, Difficulty = "Hard" }, // Nauru
                new QuestionModel { Id = 124, CountryId = 124, Difficulty = "Normal" }, // Nepal
                new QuestionModel { Id = 125, CountryId = 125, Difficulty = "Normal" }, // Nederländerna
                new QuestionModel { Id = 126, CountryId = 126, Difficulty = "Normal" }, // Nya Zeeland
                new QuestionModel { Id = 127, CountryId = 127, Difficulty = "Normal" }, // Nicaragua
                new QuestionModel { Id = 128, CountryId = 128, Difficulty = "Hard" }, // Niger
                new QuestionModel { Id = 129, CountryId = 129, Difficulty = "Normal" }, // Nigeria
                new QuestionModel { Id = 130, CountryId = 130, Difficulty = "Hard" }, // Nordmakedonien
                new QuestionModel { Id = 131, CountryId = 131, Difficulty = "Normal" }, // Norge
                new QuestionModel { Id = 132, CountryId = 132, Difficulty = "Hard" }, // Oman
                new QuestionModel { Id = 133, CountryId = 133, Difficulty = "Normal" }, // Pakistan
                new QuestionModel { Id = 134, CountryId = 134, Difficulty = "Hard" }, // Palau
                new QuestionModel { Id = 135, CountryId = 135, Difficulty = "Hard" }, // Palestina
                new QuestionModel { Id = 136, CountryId = 136, Difficulty = "Normal" }, // Panama
                new QuestionModel { Id = 137, CountryId = 137, Difficulty = "Hard" }, // Papua Nya Guinea
                new QuestionModel { Id = 138, CountryId = 138, Difficulty = "Normal" }, // Paraguay
                new QuestionModel { Id = 139, CountryId = 139, Difficulty = "Normal" }, // Peru
                new QuestionModel { Id = 140, CountryId = 140, Difficulty = "Normal" }, // Filippinerna
                new QuestionModel { Id = 141, CountryId = 141, Difficulty = "Normal" }, // Polen
                new QuestionModel { Id = 142, CountryId = 142, Difficulty = "Easy" }, // Portugal
                new QuestionModel { Id = 143, CountryId = 143, Difficulty = "Normal" }, // Qatar
                new QuestionModel { Id = 144, CountryId = 144, Difficulty = "Normal" }, // Rumänien
                new QuestionModel { Id = 145, CountryId = 145, Difficulty = "Easy" }, // Ryssland
                new QuestionModel { Id = 146, CountryId = 146, Difficulty = "Normal" }, // Rwanda
                new QuestionModel { Id = 147, CountryId = 147, Difficulty = "Hard" }, // Saint Kitts och Nevis
                new QuestionModel { Id = 148, CountryId = 148, Difficulty = "Hard" }, // Saint Lucia
                new QuestionModel { Id = 149, CountryId = 149, Difficulty = "Hard" }, // Saint Vincent och Grenadinerna
                new QuestionModel { Id = 150, CountryId = 150, Difficulty = "Hard" }, // Samoa
                new QuestionModel { Id = 151, CountryId = 151, Difficulty = "Hard" }, // San Marino
                new QuestionModel { Id = 152, CountryId = 152, Difficulty = "Hard" }, // Sao Tomé och Principe
                new QuestionModel { Id = 153, CountryId = 153, Difficulty = "Normal" }, // Saudiarabien
                new QuestionModel { Id = 154, CountryId = 154, Difficulty = "Normal" }, // Senegal
                new QuestionModel { Id = 155, CountryId = 155, Difficulty = "Normal" }, // Serbien
                new QuestionModel { Id = 156, CountryId = 156, Difficulty = "Hard" }, // Seychellerna
                new QuestionModel { Id = 157, CountryId = 157, Difficulty = "Hard" }, // Sierra Leone
                new QuestionModel { Id = 158, CountryId = 158, Difficulty = "Normal" }, // Singapore
                new QuestionModel { Id = 159, CountryId = 159, Difficulty = "Normal" }, // Slovakien
                new QuestionModel { Id = 160, CountryId = 160, Difficulty = "Normal" }, // Slovenien
                new QuestionModel { Id = 161, CountryId = 161, Difficulty = "Hard" }, // Salomonöarna
                new QuestionModel { Id = 162, CountryId = 162, Difficulty = "Normal" }, // Somalia
                new QuestionModel { Id = 163, CountryId = 163, Difficulty = "Easy" }, // Sydafrika
                new QuestionModel { Id = 164, CountryId = 164, Difficulty = "Hard" }, // Sydsudan
                new QuestionModel { Id = 165, CountryId = 165, Difficulty = "Easy" }, // Spanien
                new QuestionModel { Id = 166, CountryId = 166, Difficulty = "Normal" }, // Sri Lanka
                new QuestionModel { Id = 167, CountryId = 167, Difficulty = "Normal" }, // Sudan
                new QuestionModel { Id = 168, CountryId = 168, Difficulty = "Hard" }, // Surinam
                new QuestionModel { Id = 169, CountryId = 169, Difficulty = "Easy" }, // Sverige
                new QuestionModel { Id = 170, CountryId = 170, Difficulty = "Normal" }, // Schweiz
                new QuestionModel { Id = 171, CountryId = 171, Difficulty = "Normal" }, // Syrien
                new QuestionModel { Id = 172, CountryId = 172, Difficulty = "Hard" }, // Tadzjikistan
                new QuestionModel { Id = 173, CountryId = 173, Difficulty = "Normal" }, // Tanzania
                new QuestionModel { Id = 174, CountryId = 174, Difficulty = "Normal" }, // Thailand
                new QuestionModel { Id = 175, CountryId = 175, Difficulty = "Hard" }, // Togo
                new QuestionModel { Id = 176, CountryId = 176, Difficulty = "Hard" }, // Tonga
                new QuestionModel { Id = 177, CountryId = 177, Difficulty = "Normal" }, // Trinidad och Tobago
                new QuestionModel { Id = 178, CountryId = 178, Difficulty = "Normal" }, // Tunisien
                new QuestionModel { Id = 179, CountryId = 179, Difficulty = "Easy" }, // Turkiet
                new QuestionModel { Id = 180, CountryId = 180, Difficulty = "Hard" }, // Turkmenistan
                new QuestionModel { Id = 181, CountryId = 181, Difficulty = "Hard" }, // Tuvalu
                new QuestionModel { Id = 182, CountryId = 182, Difficulty = "Normal" }, // Uganda
                new QuestionModel { Id = 183, CountryId = 183, Difficulty = "Normal" }, // Ukraina
                new QuestionModel { Id = 184, CountryId = 184, Difficulty = "Normal" }, // Förenade Arabemiraten
                new QuestionModel { Id = 185, CountryId = 185, Difficulty = "Easy" }, // Storbritannien
                new QuestionModel { Id = 186, CountryId = 186, Difficulty = "Easy" }, // USA
                new QuestionModel { Id = 187, CountryId = 187, Difficulty = "Normal" }, // Uruguay
                new QuestionModel { Id = 188, CountryId = 188, Difficulty = "Normal" }, // Uzbekistan
                new QuestionModel { Id = 189, CountryId = 189, Difficulty = "Hard" }, // Vanuatu
                new QuestionModel { Id = 190, CountryId = 190, Difficulty = "Hard" }, // Vatikanstaten
                new QuestionModel { Id = 191, CountryId = 191, Difficulty = "Normal" }, // Venezuela
                new QuestionModel { Id = 192, CountryId = 192, Difficulty = "Normal" }, // Vietnam
                new QuestionModel { Id = 193, CountryId = 193, Difficulty = "Normal" }, // Jemen
                new QuestionModel { Id = 194, CountryId = 194, Difficulty = "Normal" }, // Zambia
                new QuestionModel { Id = 195, CountryId = 195, Difficulty = "Normal" }  // Zimbabwe
            );
        }
    }
}
