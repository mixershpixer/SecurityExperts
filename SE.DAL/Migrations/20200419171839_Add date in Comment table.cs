using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SE.DAL.Migrations
{
    public partial class AdddateinCommenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Users_UserId",
                table: "Materials");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57bd4c9e-0d84-45e2-a1a4-b82d6c975112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf363809-78e2-4a06-97cb-e1292798e9ba"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("dbad49cb-e158-4882-acea-e85324b9b055"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Auditory", "Description", "DownloadingLink", "DownloadsCount", "Name", "Picture", "PublishingDate", "Rating", "SourceOfInformation", "Status", "Theme", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a9ffa8e-b5e9-468a-aebc-794d8f7f1389"), 1, "DescriptionDescriptionDescriptionDescription1", "https://www.freepng.ru/png-miditu/download.html", 55, "NameNameName1", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 362, DateTimeKind.Local).AddTicks(8087), 1.0, "SourceOfInformationSourceOfInformation1", 2, 5, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("810ae232-a761-4688-8271-58826d1b2834"), 1, "DescriptionDescriptionDescriptionDescription46", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 69, "NameNameName46", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5067), 2.0, "SourceOfInformationSourceOfInformation46", 1, 5, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("195a85ab-52c6-4dcd-bc19-be3acb60623b"), 1, "DescriptionDescriptionDescriptionDescription44", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 86, "NameNameName44", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5052), 2.0, "SourceOfInformationSourceOfInformation44", 1, 2, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("867c2755-0da1-47b0-ba5a-ca066323176e"), 1, "DescriptionDescriptionDescriptionDescription42", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 74, "NameNameName42", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5040), 2.0, "SourceOfInformationSourceOfInformation42", 1, 5, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("8f98c02a-59b4-4948-bc76-b3e7f075e818"), 1, "DescriptionDescriptionDescriptionDescription40", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 95, "NameNameName40", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4986), 3.0, "SourceOfInformationSourceOfInformation40", 1, 1, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("34bcceb6-fda1-4478-8a0e-65bf10843af7"), 1, "DescriptionDescriptionDescriptionDescription38", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 79, "NameNameName38", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4973), 1.0, "SourceOfInformationSourceOfInformation38", 1, 3, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("812ba038-cbab-4f29-ad13-4e285d90b504"), 1, "DescriptionDescriptionDescriptionDescription36", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 26, "NameNameName36", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4959), 2.0, "SourceOfInformationSourceOfInformation36", 1, 2, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("e9cf0059-1d5e-412c-b254-7cfcc60f9d61"), 1, "DescriptionDescriptionDescriptionDescription34", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 47, "NameNameName34", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4942), 1.0, "SourceOfInformationSourceOfInformation34", 1, 2, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("f0c231dc-71d3-4371-8be1-930f789f6369"), 1, "DescriptionDescriptionDescriptionDescription32", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 93, "NameNameName32", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4929), 2.0, "SourceOfInformationSourceOfInformation32", 1, 5, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("b7f7f7ca-9b78-456a-8dc9-cb2e2473a1fc"), 1, "DescriptionDescriptionDescriptionDescription30", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 60, "NameNameName30", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4917), 3.0, "SourceOfInformationSourceOfInformation30", 1, 5, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("f9576341-2e63-45c7-95a5-16448818390f"), 1, "DescriptionDescriptionDescriptionDescription28", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 55, "NameNameName28", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4856), 4.0, "SourceOfInformationSourceOfInformation28", 1, 5, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("12a6746d-6967-4058-ba60-35d747694e49"), 1, "DescriptionDescriptionDescriptionDescription26", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 43, "NameNameName26", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4844), 2.0, "SourceOfInformationSourceOfInformation26", 1, 5, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("e06d0425-bd7f-41a6-824d-98d7529f3a9f"), 1, "DescriptionDescriptionDescriptionDescription24", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 4, "NameNameName24", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4832), 4.0, "SourceOfInformationSourceOfInformation24", 1, 1, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("cc5f3dcf-5e0d-4602-9ce4-1aa248cdaff5"), 1, "DescriptionDescriptionDescriptionDescription22", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 47, "NameNameName22", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4820), 4.0, "SourceOfInformationSourceOfInformation22", 1, 3, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("04f15353-519c-402b-b2e5-ba9944280fcc"), 1, "DescriptionDescriptionDescriptionDescription20", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 2, "NameNameName20", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4805), 3.0, "SourceOfInformationSourceOfInformation20", 1, 4, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("704ab757-9cef-45e7-9b8b-1013e9c6820b"), 1, "DescriptionDescriptionDescriptionDescription18", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 48, "NameNameName18", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4793), 4.0, "SourceOfInformationSourceOfInformation18", 1, 2, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("9136596c-42c9-44c3-93f7-afda53810322"), 1, "DescriptionDescriptionDescriptionDescription16", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 20, "NameNameName16", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4776), 1.0, "SourceOfInformationSourceOfInformation16", 1, 5, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("02a257ae-c1e2-47dc-9fd0-06c5b66e83b1"), 1, "DescriptionDescriptionDescriptionDescription14", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 61, "NameNameName14", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4653), 2.0, "SourceOfInformationSourceOfInformation14", 1, 1, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("aa748b44-c126-4c5f-a186-2e87b1b81ca4"), 1, "DescriptionDescriptionDescriptionDescription12", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 78, "NameNameName12", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4637), 2.0, "SourceOfInformationSourceOfInformation12", 1, 5, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("4925c795-260c-43a8-a9f6-81661d3587e8"), 1, "DescriptionDescriptionDescriptionDescription10", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 63, "NameNameName10", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4624), 1.0, "SourceOfInformationSourceOfInformation10", 1, 1, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("3691b73b-10d4-4735-97cf-f717f72878cd"), 1, "DescriptionDescriptionDescriptionDescription8", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 81, "NameNameName8", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4610), 3.0, "SourceOfInformationSourceOfInformation8", 1, 4, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("f0d989bd-b0ab-485e-ae3f-e0e951499b13"), 1, "DescriptionDescriptionDescriptionDescription6", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 67, "NameNameName6", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4597), 3.0, "SourceOfInformationSourceOfInformation6", 1, 1, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("a1d0041f-ee07-42b4-bf6b-2e258667efa7"), 1, "DescriptionDescriptionDescriptionDescription48", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 39, "NameNameName48", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5079), 2.0, "SourceOfInformationSourceOfInformation48", 1, 3, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("c353b5d5-c2fc-41ba-a085-f00542052a84"), 1, "DescriptionDescriptionDescriptionDescription4", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 2, "NameNameName4", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4568), 4.0, "SourceOfInformationSourceOfInformation4", 1, 3, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("5fe26aad-2cf5-451e-8f1a-06799f1ac102"), 1, "DescriptionDescriptionDescriptionDescription50", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 10, "NameNameName50", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5090), 2.0, "SourceOfInformationSourceOfInformation50", 1, 3, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("f588f905-43d7-4f8a-9488-a27eb617ae14"), 1, "DescriptionDescriptionDescriptionDescription54", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 83, "NameNameName54", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5117), 1.0, "SourceOfInformationSourceOfInformation54", 1, 4, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("4f79c98f-1d3f-4520-b414-7d5dac4f4c92"), 1, "DescriptionDescriptionDescriptionDescription96", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 76, "NameNameName96", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5653), 2.0, "SourceOfInformationSourceOfInformation96", 1, 3, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("1c1247c6-00ea-40d4-bc7b-5f5ead4bb4ae"), 1, "DescriptionDescriptionDescriptionDescription94", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 2, "NameNameName94", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5640), 2.0, "SourceOfInformationSourceOfInformation94", 1, 1, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("50b949d2-5fc9-4f66-9372-2ac1b4a4829d"), 1, "DescriptionDescriptionDescriptionDescription92", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 46, "NameNameName92", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5544), 2.0, "SourceOfInformationSourceOfInformation92", 1, 1, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("a107a8bb-e3da-4c3e-a292-105f9f3a8117"), 1, "DescriptionDescriptionDescriptionDescription90", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 79, "NameNameName90", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5532), 2.0, "SourceOfInformationSourceOfInformation90", 1, 4, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("2ab21a91-5d60-4864-92d4-318e8ea038fc"), 1, "DescriptionDescriptionDescriptionDescription88", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 11, "NameNameName88", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5520), 1.0, "SourceOfInformationSourceOfInformation88", 1, 4, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("cb07696f-ce66-490f-a28e-fab6a79079ed"), 1, "DescriptionDescriptionDescriptionDescription86", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 99, "NameNameName86", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5509), 2.0, "SourceOfInformationSourceOfInformation86", 1, 2, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("b3a2009b-f74b-4dc1-ab5b-90ada49e28bb"), 1, "DescriptionDescriptionDescriptionDescription84", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 41, "NameNameName84", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5494), 1.0, "SourceOfInformationSourceOfInformation84", 1, 5, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("ba9abd07-8155-4fbc-b34b-69938f686a05"), 1, "DescriptionDescriptionDescriptionDescription82", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 21, "NameNameName82", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5483), 3.0, "SourceOfInformationSourceOfInformation82", 1, 4, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("acb17bc8-68c4-4213-8675-a3cddf593c9a"), 1, "DescriptionDescriptionDescriptionDescription80", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 57, "NameNameName80", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5429), 3.0, "SourceOfInformationSourceOfInformation80", 1, 5, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("8456f874-4731-4cea-95c9-d45bcdfafb1a"), 1, "DescriptionDescriptionDescriptionDescription78", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 28, "NameNameName78", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5417), 3.0, "SourceOfInformationSourceOfInformation78", 1, 4, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("27a92bd5-8998-4d31-8e42-d3ff00b373f5"), 1, "DescriptionDescriptionDescriptionDescription76", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 15, "NameNameName76", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5403), 2.0, "SourceOfInformationSourceOfInformation76", 1, 4, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("822b680c-b62d-4c98-81bb-8450802bf276"), 1, "DescriptionDescriptionDescriptionDescription74", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 13, "NameNameName74", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5391), 2.0, "SourceOfInformationSourceOfInformation74", 1, 3, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("0d99d688-4126-4030-987b-3224a959f2f0"), 1, "DescriptionDescriptionDescriptionDescription72", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 24, "NameNameName72", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5380), 2.0, "SourceOfInformationSourceOfInformation72", 1, 2, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("4778b16b-94c1-4ef4-8562-4e46d9a35c76"), 1, "DescriptionDescriptionDescriptionDescription70", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 79, "NameNameName70", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5368), 1.0, "SourceOfInformationSourceOfInformation70", 1, 1, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("35841f71-2305-4dc4-ab1e-f0e39fffac63"), 1, "DescriptionDescriptionDescriptionDescription68", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 15, "NameNameName68", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5353), 3.0, "SourceOfInformationSourceOfInformation68", 1, 4, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("1aa3a1f0-c95a-4d37-8af2-d8675cb0e142"), 1, "DescriptionDescriptionDescriptionDescription66", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 97, "NameNameName66", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5237), 3.0, "SourceOfInformationSourceOfInformation66", 1, 5, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("624bb2ad-9f24-49c8-b6ea-61ecc9bd900e"), 1, "DescriptionDescriptionDescriptionDescription64", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 67, "NameNameName64", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5223), 1.0, "SourceOfInformationSourceOfInformation64", 1, 1, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("1b1b3c23-63bb-4810-9801-790596f40d69"), 1, "DescriptionDescriptionDescriptionDescription62", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 11, "NameNameName62", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5210), 3.0, "SourceOfInformationSourceOfInformation62", 1, 5, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("a61012ba-c15b-4b0d-b29d-93296dbebad3"), 1, "DescriptionDescriptionDescriptionDescription60", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 18, "NameNameName60", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5196), 3.0, "SourceOfInformationSourceOfInformation60", 1, 1, 2, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("39d7fba9-f0ef-4909-a946-adb413bb250a"), 1, "DescriptionDescriptionDescriptionDescription58", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 54, "NameNameName58", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5184), 2.0, "SourceOfInformationSourceOfInformation58", 1, 4, 4, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("b0d9140b-c20b-44c7-9722-98c00cd1857d"), 1, "DescriptionDescriptionDescriptionDescription56", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 7, "NameNameName56", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5172), 1.0, "SourceOfInformationSourceOfInformation56", 1, 5, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("751a0857-e70e-472e-92e1-35f62346e86b"), 1, "DescriptionDescriptionDescriptionDescription52", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 27, "NameNameName52", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5103), 3.0, "SourceOfInformationSourceOfInformation52", 1, 1, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("4a2bc6a4-e91a-464a-871a-4d0c041824ee"), 1, "DescriptionDescriptionDescriptionDescription2", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 94, "NameNameName2", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4419), 2.0, "SourceOfInformationSourceOfInformation2", 1, 4, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("987d7c6c-ee6a-41a7-83a4-4177920aba35"), 1, "DescriptionDescriptionDescriptionDescription99", "https://www.freepng.ru/png-miditu/download.html", 30, "NameNameName99", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5671), 3.0, "SourceOfInformationSourceOfInformation99", 2, 4, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("d43331c5-3ebb-417b-9997-eb0df108b242"), 1, "DescriptionDescriptionDescriptionDescription97", "https://www.freepng.ru/png-miditu/download.html", 36, "NameNameName97", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5659), 2.0, "SourceOfInformationSourceOfInformation97", 2, 2, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("e8628cbc-836e-4ebf-b763-dfe12b188d52"), 1, "DescriptionDescriptionDescriptionDescription43", "https://www.freepng.ru/png-miditu/download.html", 55, "NameNameName43", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5047), 2.0, "SourceOfInformationSourceOfInformation43", 2, 4, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("9b69c5ef-9e2a-4e89-9456-2eb382d75ed8"), 1, "DescriptionDescriptionDescriptionDescription41", "https://www.freepng.ru/png-miditu/download.html", 9, "NameNameName41", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4992), 1.0, "SourceOfInformationSourceOfInformation41", 2, 4, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("43f3eab3-9330-4f90-aaf2-096b2499d2e0"), 1, "DescriptionDescriptionDescriptionDescription39", "https://www.freepng.ru/png-miditu/download.html", 52, "NameNameName39", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4980), 2.0, "SourceOfInformationSourceOfInformation39", 2, 4, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("09b12b05-7874-40e8-9f86-e5257839a746"), 1, "DescriptionDescriptionDescriptionDescription37", "https://www.freepng.ru/png-miditu/download.html", 43, "NameNameName37", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4965), 1.0, "SourceOfInformationSourceOfInformation37", 2, 4, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("16973f26-f127-4d97-bb95-a0faeeb112db"), 1, "DescriptionDescriptionDescriptionDescription35", "https://www.freepng.ru/png-miditu/download.html", 40, "NameNameName35", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4953), 4.0, "SourceOfInformationSourceOfInformation35", 2, 1, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("529f9c46-5b4a-4cf7-abea-90ecb528ba90"), 1, "DescriptionDescriptionDescriptionDescription33", "https://www.freepng.ru/png-miditu/download.html", 32, "NameNameName33", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4935), 3.0, "SourceOfInformationSourceOfInformation33", 2, 1, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("2f33ff1c-c6bb-497d-bd08-6b2f72164707"), 1, "DescriptionDescriptionDescriptionDescription31", "https://www.freepng.ru/png-miditu/download.html", 70, "NameNameName31", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4923), 1.0, "SourceOfInformationSourceOfInformation31", 2, 3, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("9004150b-3b2b-477a-bb0b-8251aa9345fc"), 1, "DescriptionDescriptionDescriptionDescription29", "https://www.freepng.ru/png-miditu/download.html", 41, "NameNameName29", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4907), 1.0, "SourceOfInformationSourceOfInformation29", 2, 4, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("11e40856-b8c2-41a4-bcbd-2553961778b2"), 1, "DescriptionDescriptionDescriptionDescription27", "https://www.freepng.ru/png-miditu/download.html", 21, "NameNameName27", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4850), 4.0, "SourceOfInformationSourceOfInformation27", 2, 5, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("f674b9da-470e-4c79-b193-2222331ecf0e"), 1, "DescriptionDescriptionDescriptionDescription25", "https://www.freepng.ru/png-miditu/download.html", 76, "NameNameName25", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4838), 4.0, "SourceOfInformationSourceOfInformation25", 2, 1, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("f4b6517e-bee3-4c4f-93f3-c137b2faab8d"), 1, "DescriptionDescriptionDescriptionDescription23", "https://www.freepng.ru/png-miditu/download.html", 83, "NameNameName23", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4826), 3.0, "SourceOfInformationSourceOfInformation23", 2, 5, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("96649bf5-88ca-4ecb-a5ff-dad9429b7dc6"), 1, "DescriptionDescriptionDescriptionDescription21", "https://www.freepng.ru/png-miditu/download.html", 94, "NameNameName21", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4811), 4.0, "SourceOfInformationSourceOfInformation21", 2, 4, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("0e714cca-6909-46aa-ba23-058d42408620"), 1, "DescriptionDescriptionDescriptionDescription19", "https://www.freepng.ru/png-miditu/download.html", 80, "NameNameName19", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4799), 4.0, "SourceOfInformationSourceOfInformation19", 2, 3, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("81b59061-eccc-494b-a311-6792ae5d2e4d"), 1, "DescriptionDescriptionDescriptionDescription17", "https://www.freepng.ru/png-miditu/download.html", 8, "NameNameName17", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4785), 4.0, "SourceOfInformationSourceOfInformation17", 2, 5, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("30b82b88-d4de-4f2c-9cd8-aa3149129961"), 1, "DescriptionDescriptionDescriptionDescription15", "https://www.freepng.ru/png-miditu/download.html", 67, "NameNameName15", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4659), 3.0, "SourceOfInformationSourceOfInformation15", 2, 4, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("6bfbc1a1-2a25-43ec-b1ad-b6f834458155"), 1, "DescriptionDescriptionDescriptionDescription13", "https://www.freepng.ru/png-miditu/download.html", 40, "NameNameName13", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4643), 3.0, "SourceOfInformationSourceOfInformation13", 2, 1, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("32b4bf84-0d9d-4c26-9107-1c607df4d90b"), 1, "DescriptionDescriptionDescriptionDescription11", "https://www.freepng.ru/png-miditu/download.html", 66, "NameNameName11", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4631), 3.0, "SourceOfInformationSourceOfInformation11", 2, 4, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("366c6574-fef3-46c6-9b97-a7a5bb394abd"), 1, "DescriptionDescriptionDescriptionDescription9", "https://www.freepng.ru/png-miditu/download.html", 29, "NameNameName9", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4616), 2.0, "SourceOfInformationSourceOfInformation9", 2, 3, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("50102928-ac48-4c73-a6b8-eced55a2f7c3"), 1, "DescriptionDescriptionDescriptionDescription7", "https://www.freepng.ru/png-miditu/download.html", 80, "NameNameName7", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4604), 1.0, "SourceOfInformationSourceOfInformation7", 2, 5, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("f6f5e087-21e5-4761-939d-f86c0724c9be"), 1, "DescriptionDescriptionDescriptionDescription5", "https://www.freepng.ru/png-miditu/download.html", 64, "NameNameName5", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4575), 2.0, "SourceOfInformationSourceOfInformation5", 2, 2, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("46d8b278-d431-4e11-a578-3cf007fcd0d3"), 1, "DescriptionDescriptionDescriptionDescription3", "https://www.freepng.ru/png-miditu/download.html", 27, "NameNameName3", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(4558), 1.0, "SourceOfInformationSourceOfInformation3", 2, 2, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("ba20e530-4823-4c77-847a-2aa7a5b15416"), 1, "DescriptionDescriptionDescriptionDescription45", "https://www.freepng.ru/png-miditu/download.html", 79, "NameNameName45", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5058), 4.0, "SourceOfInformationSourceOfInformation45", 2, 5, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("329b9550-3062-40ee-840d-eaee892d4c4f"), 1, "DescriptionDescriptionDescriptionDescription47", "https://www.freepng.ru/png-miditu/download.html", 10, "NameNameName47", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5073), 3.0, "SourceOfInformationSourceOfInformation47", 2, 4, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("d426d732-70e4-47c5-af02-64fa9ff056d6"), 1, "DescriptionDescriptionDescriptionDescription49", "https://www.freepng.ru/png-miditu/download.html", 32, "NameNameName49", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5084), 3.0, "SourceOfInformationSourceOfInformation49", 2, 5, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("59210685-0cdb-4906-a052-7c3bf227c172"), 1, "DescriptionDescriptionDescriptionDescription51", "https://www.freepng.ru/png-miditu/download.html", 97, "NameNameName51", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5097), 4.0, "SourceOfInformationSourceOfInformation51", 2, 5, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("dbac9ba1-0819-4733-8c97-cd56c2ce00ea"), 1, "DescriptionDescriptionDescriptionDescription95", "https://www.freepng.ru/png-miditu/download.html", 83, "NameNameName95", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5647), 4.0, "SourceOfInformationSourceOfInformation95", 2, 5, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("b2003915-5836-4cc3-b567-207f7b873dfc"), 1, "DescriptionDescriptionDescriptionDescription93", "https://www.freepng.ru/png-miditu/download.html", 78, "NameNameName93", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5551), 4.0, "SourceOfInformationSourceOfInformation93", 2, 1, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("c73f85bd-a14f-403e-b84b-330b81556040"), 1, "DescriptionDescriptionDescriptionDescription91", "https://www.freepng.ru/png-miditu/download.html", 36, "NameNameName91", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5538), 1.0, "SourceOfInformationSourceOfInformation91", 2, 5, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("a5028797-6d34-42ee-9402-68287752ebd6"), 1, "DescriptionDescriptionDescriptionDescription89", "https://www.freepng.ru/png-miditu/download.html", 46, "NameNameName89", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5526), 2.0, "SourceOfInformationSourceOfInformation89", 2, 3, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("9afc0d73-18be-4198-ad68-dfbd2b47af85"), 1, "DescriptionDescriptionDescriptionDescription87", "https://www.freepng.ru/png-miditu/download.html", 49, "NameNameName87", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5514), 4.0, "SourceOfInformationSourceOfInformation87", 2, 3, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("5016f6be-c831-4486-9719-d71d768d04df"), 1, "DescriptionDescriptionDescriptionDescription85", "https://www.freepng.ru/png-miditu/download.html", 66, "NameNameName85", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5501), 3.0, "SourceOfInformationSourceOfInformation85", 2, 2, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("25ba84a1-186d-4745-bae6-af66f4ce0a82"), 1, "DescriptionDescriptionDescriptionDescription83", "https://www.freepng.ru/png-miditu/download.html", 80, "NameNameName83", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5489), 3.0, "SourceOfInformationSourceOfInformation83", 2, 5, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("51eaff2e-8238-4ae8-880e-1d56947a975d"), 1, "DescriptionDescriptionDescriptionDescription81", "https://www.freepng.ru/png-miditu/download.html", 50, "NameNameName81", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5477), 1.0, "SourceOfInformationSourceOfInformation81", 2, 3, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("27926eb6-658b-4caf-81c5-b6d27965e17d"), 1, "DescriptionDescriptionDescriptionDescription79", "https://www.freepng.ru/png-miditu/download.html", 24, "NameNameName79", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5423), 4.0, "SourceOfInformationSourceOfInformation79", 2, 4, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("f73ab246-7c10-461f-951e-3eb0be2fe977"), 1, "DescriptionDescriptionDescriptionDescription77", "https://www.freepng.ru/png-miditu/download.html", 91, "NameNameName77", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5409), 1.0, "SourceOfInformationSourceOfInformation77", 2, 1, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("39363448-5a50-4b04-866e-36a0e6220717"), 1, "DescriptionDescriptionDescriptionDescription98", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 43, "NameNameName98", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5665), 3.0, "SourceOfInformationSourceOfInformation98", 1, 5, 3, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") },
                    { new Guid("f081a37c-71bc-4686-bb3e-20595536809f"), 1, "DescriptionDescriptionDescriptionDescription75", "https://www.freepng.ru/png-miditu/download.html", 92, "NameNameName75", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5397), 1.0, "SourceOfInformationSourceOfInformation75", 2, 5, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("e8b4f672-2217-4f7d-99e5-843a589706c1"), 1, "DescriptionDescriptionDescriptionDescription71", "https://www.freepng.ru/png-miditu/download.html", 85, "NameNameName71", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5374), 2.0, "SourceOfInformationSourceOfInformation71", 2, 2, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("60b030de-8f46-4ba2-9fbf-4d336a764370"), 1, "DescriptionDescriptionDescriptionDescription69", "https://www.freepng.ru/png-miditu/download.html", 48, "NameNameName69", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5359), 3.0, "SourceOfInformationSourceOfInformation69", 2, 4, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("69c87d35-d4db-476d-9282-dc9f760a2fe3"), 1, "DescriptionDescriptionDescriptionDescription67", "https://www.freepng.ru/png-miditu/download.html", 83, "NameNameName67", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5347), 3.0, "SourceOfInformationSourceOfInformation67", 2, 1, 1, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("5d2475b5-4ca6-43b5-a849-81f7efb3af77"), 1, "DescriptionDescriptionDescriptionDescription65", "https://www.freepng.ru/png-miditu/download.html", 8, "NameNameName65", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5229), 4.0, "SourceOfInformationSourceOfInformation65", 2, 2, 3, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("ce632248-e7ce-4f10-a2f0-e35cc30ec242"), 1, "DescriptionDescriptionDescriptionDescription63", "https://www.freepng.ru/png-miditu/download.html", 97, "NameNameName63", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5217), 3.0, "SourceOfInformationSourceOfInformation63", 2, 5, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("f1d11f9c-5ba5-4075-899f-d7cf7de01d9b"), 1, "DescriptionDescriptionDescriptionDescription61", "https://www.freepng.ru/png-miditu/download.html", 14, "NameNameName61", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5201), 1.0, "SourceOfInformationSourceOfInformation61", 2, 3, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("4931c776-54de-4aac-82ba-edd7d2bdcd2f"), 1, "DescriptionDescriptionDescriptionDescription59", "https://www.freepng.ru/png-miditu/download.html", 39, "NameNameName59", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5190), 4.0, "SourceOfInformationSourceOfInformation59", 2, 3, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("48b2d261-fb80-4d76-a74c-0f732b8b6382"), 1, "DescriptionDescriptionDescriptionDescription57", "https://www.freepng.ru/png-miditu/download.html", 23, "NameNameName57", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5178), 3.0, "SourceOfInformationSourceOfInformation57", 2, 1, 4, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("a8c9bfe6-bec5-4763-bbc1-4beb89d74cee"), 1, "DescriptionDescriptionDescriptionDescription55", "https://www.freepng.ru/png-miditu/download.html", 98, "NameNameName55", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5165), 2.0, "SourceOfInformationSourceOfInformation55", 2, 3, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("200d3c7b-bd9b-4987-855e-1ecc49252628"), 1, "DescriptionDescriptionDescriptionDescription53", "https://www.freepng.ru/png-miditu/download.html", 13, "NameNameName53", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5109), 3.0, "SourceOfInformationSourceOfInformation53", 2, 5, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("32bcff26-43a1-455d-9f75-0f0656bedf9c"), 1, "DescriptionDescriptionDescriptionDescription73", "https://www.freepng.ru/png-miditu/download.html", 40, "NameNameName73", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5385), 1.0, "SourceOfInformationSourceOfInformation73", 2, 4, 2, new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0") },
                    { new Guid("eaa5e5c5-dccb-4661-8a8e-58cde0ae2df8"), 1, "DescriptionDescriptionDescriptionDescription100", "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации", 72, "NameNameName100", new byte[] { 1, 2, 3 }, new DateTime(2020, 4, 19, 20, 18, 38, 365, DateTimeKind.Local).AddTicks(5678), 4.0, "SourceOfInformationSourceOfInformation100", 1, 3, 1, new Guid("dbad49cb-e158-4882-acea-e85324b9b055") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Users_UserId",
                table: "Materials",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Users_UserId",
                table: "Materials");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("02a257ae-c1e2-47dc-9fd0-06c5b66e83b1"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("04f15353-519c-402b-b2e5-ba9944280fcc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("09b12b05-7874-40e8-9f86-e5257839a746"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("0d99d688-4126-4030-987b-3224a959f2f0"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("0e714cca-6909-46aa-ba23-058d42408620"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("11e40856-b8c2-41a4-bcbd-2553961778b2"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("12a6746d-6967-4058-ba60-35d747694e49"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("16973f26-f127-4d97-bb95-a0faeeb112db"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("195a85ab-52c6-4dcd-bc19-be3acb60623b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("1aa3a1f0-c95a-4d37-8af2-d8675cb0e142"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("1b1b3c23-63bb-4810-9801-790596f40d69"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("1c1247c6-00ea-40d4-bc7b-5f5ead4bb4ae"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("200d3c7b-bd9b-4987-855e-1ecc49252628"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("25ba84a1-186d-4745-bae6-af66f4ce0a82"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("27926eb6-658b-4caf-81c5-b6d27965e17d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("27a92bd5-8998-4d31-8e42-d3ff00b373f5"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("2ab21a91-5d60-4864-92d4-318e8ea038fc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("2f33ff1c-c6bb-497d-bd08-6b2f72164707"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("30b82b88-d4de-4f2c-9cd8-aa3149129961"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("329b9550-3062-40ee-840d-eaee892d4c4f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("32b4bf84-0d9d-4c26-9107-1c607df4d90b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("32bcff26-43a1-455d-9f75-0f0656bedf9c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("34bcceb6-fda1-4478-8a0e-65bf10843af7"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("35841f71-2305-4dc4-ab1e-f0e39fffac63"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("366c6574-fef3-46c6-9b97-a7a5bb394abd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("3691b73b-10d4-4735-97cf-f717f72878cd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("39363448-5a50-4b04-866e-36a0e6220717"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("39d7fba9-f0ef-4909-a946-adb413bb250a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("43f3eab3-9330-4f90-aaf2-096b2499d2e0"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("46d8b278-d431-4e11-a578-3cf007fcd0d3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4778b16b-94c1-4ef4-8562-4e46d9a35c76"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("48b2d261-fb80-4d76-a74c-0f732b8b6382"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4925c795-260c-43a8-a9f6-81661d3587e8"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4931c776-54de-4aac-82ba-edd7d2bdcd2f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4a2bc6a4-e91a-464a-871a-4d0c041824ee"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4f79c98f-1d3f-4520-b414-7d5dac4f4c92"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("50102928-ac48-4c73-a6b8-eced55a2f7c3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("5016f6be-c831-4486-9719-d71d768d04df"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("50b949d2-5fc9-4f66-9372-2ac1b4a4829d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("51eaff2e-8238-4ae8-880e-1d56947a975d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("529f9c46-5b4a-4cf7-abea-90ecb528ba90"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("59210685-0cdb-4906-a052-7c3bf227c172"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("5d2475b5-4ca6-43b5-a849-81f7efb3af77"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("5fe26aad-2cf5-451e-8f1a-06799f1ac102"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("60b030de-8f46-4ba2-9fbf-4d336a764370"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("624bb2ad-9f24-49c8-b6ea-61ecc9bd900e"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("69c87d35-d4db-476d-9282-dc9f760a2fe3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("6a9ffa8e-b5e9-468a-aebc-794d8f7f1389"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("6bfbc1a1-2a25-43ec-b1ad-b6f834458155"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("704ab757-9cef-45e7-9b8b-1013e9c6820b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("751a0857-e70e-472e-92e1-35f62346e86b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("810ae232-a761-4688-8271-58826d1b2834"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("812ba038-cbab-4f29-ad13-4e285d90b504"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("81b59061-eccc-494b-a311-6792ae5d2e4d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("822b680c-b62d-4c98-81bb-8450802bf276"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8456f874-4731-4cea-95c9-d45bcdfafb1a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("867c2755-0da1-47b0-ba5a-ca066323176e"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8f98c02a-59b4-4948-bc76-b3e7f075e818"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9004150b-3b2b-477a-bb0b-8251aa9345fc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9136596c-42c9-44c3-93f7-afda53810322"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("96649bf5-88ca-4ecb-a5ff-dad9429b7dc6"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("987d7c6c-ee6a-41a7-83a4-4177920aba35"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9afc0d73-18be-4198-ad68-dfbd2b47af85"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9b69c5ef-9e2a-4e89-9456-2eb382d75ed8"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a107a8bb-e3da-4c3e-a292-105f9f3a8117"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a1d0041f-ee07-42b4-bf6b-2e258667efa7"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a5028797-6d34-42ee-9402-68287752ebd6"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a61012ba-c15b-4b0d-b29d-93296dbebad3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a8c9bfe6-bec5-4763-bbc1-4beb89d74cee"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("aa748b44-c126-4c5f-a186-2e87b1b81ca4"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("acb17bc8-68c4-4213-8675-a3cddf593c9a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b0d9140b-c20b-44c7-9722-98c00cd1857d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b2003915-5836-4cc3-b567-207f7b873dfc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b3a2009b-f74b-4dc1-ab5b-90ada49e28bb"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b7f7f7ca-9b78-456a-8dc9-cb2e2473a1fc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("ba20e530-4823-4c77-847a-2aa7a5b15416"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("ba9abd07-8155-4fbc-b34b-69938f686a05"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("c353b5d5-c2fc-41ba-a085-f00542052a84"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("c73f85bd-a14f-403e-b84b-330b81556040"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("cb07696f-ce66-490f-a28e-fab6a79079ed"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("cc5f3dcf-5e0d-4602-9ce4-1aa248cdaff5"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("ce632248-e7ce-4f10-a2f0-e35cc30ec242"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d426d732-70e4-47c5-af02-64fa9ff056d6"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d43331c5-3ebb-417b-9997-eb0df108b242"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("dbac9ba1-0819-4733-8c97-cd56c2ce00ea"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e06d0425-bd7f-41a6-824d-98d7529f3a9f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e8628cbc-836e-4ebf-b763-dfe12b188d52"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e8b4f672-2217-4f7d-99e5-843a589706c1"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e9cf0059-1d5e-412c-b254-7cfcc60f9d61"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("eaa5e5c5-dccb-4661-8a8e-58cde0ae2df8"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f081a37c-71bc-4686-bb3e-20595536809f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f0c231dc-71d3-4371-8be1-930f789f6369"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f0d989bd-b0ab-485e-ae3f-e0e951499b13"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f1d11f9c-5ba5-4075-899f-d7cf7de01d9b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f4b6517e-bee3-4c4f-93f3-c137b2faab8d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f588f905-43d7-4f8a-9488-a27eb617ae14"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f674b9da-470e-4c79-b193-2222331ecf0e"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f6f5e087-21e5-4761-939d-f86c0724c9be"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f73ab246-7c10-461f-951e-3eb0be2fe977"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f9576341-2e63-45c7-95a5-16448818390f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("831957bb-c3fc-4df0-a20a-6f1553401ea0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbad49cb-e158-4882-acea-e85324b9b055"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("bf363809-78e2-4a06-97cb-e1292798e9ba"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("57bd4c9e-0d84-45e2-a1a4-b82d6c975112"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Users_UserId",
                table: "Materials",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
