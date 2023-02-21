using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogEngineApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c1581ce-1739-4129-99fb-24f2ed019df2", "2323c33c-8f67-4f25-9199-14509857c21c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f25831ff-0464-4465-8fed-756924411ee0", "598c6f2b-919c-457b-a65a-94335ebccdf4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c1581ce-1739-4129-99fb-24f2ed019df2", "793a3044-37aa-4945-9c8e-6d36764a7c5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "724e2bca-7573-48a8-b28b-cde92224dabb", "b2b46cf5-db99-4e2a-a715-1dabb19bdcf7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c1581ce-1739-4129-99fb-24f2ed019df2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "724e2bca-7573-48a8-b28b-cde92224dabb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f25831ff-0464-4465-8fed-756924411ee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2323c33c-8f67-4f25-9199-14509857c21c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "598c6f2b-919c-457b-a65a-94335ebccdf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "793a3044-37aa-4945-9c8e-6d36764a7c5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b46cf5-db99-4e2a-a715-1dabb19bdcf7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1611af41-a19e-4c5b-9d14-28c63bde63bd", null, "IdentityRole", "Writer", "WRITER" },
                    { "809b5375-beac-4364-8a78-35e8763a8e0c", null, "IdentityRole", "Editor", "EDITOR" },
                    { "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41", null, "IdentityRole", "Public", "PUBLIC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a51f58c-74fa-4ee3-91a6-9f5b385b7a49", 0, "e2fa64c8-29f3-4cc5-99aa-3400a1449fd9", "roberth@gmail.com", false, false, null, "ROBERTH@GMAIL.COM", "ROBERTH", "AQAAAAIAAYagAAAAEFVWmn0wX5fBYYEtI3KRGqwWZm08elCLTHtiV9vYIAv+F+X7idP7A3BzIL0gp7Kh3w==", null, false, "d5d5c33b-d493-415a-a282-593aa3cce777", false, "roberth" },
                    { "52d013ea-3f61-4f6a-a1f0-a5547c1ba1b8", 0, "0ace33d7-bd3a-4ea5-997a-095164957c74", "johnny@gmail.com", false, false, null, "JOHNNY@GMAIL.COM", "JOHNNY", "AQAAAAIAAYagAAAAEFgObWaiN3VyYdKU8/QGDp/tTYJnReppXhdr2lKcqq2Ruz+7yXYPqYlX2gx190I6Yw==", null, false, "057322c0-ddb0-475a-8274-84bf2fbadaa2", false, "johnny" },
                    { "6e26ce30-4b26-46d8-809b-8586a7abe346", 0, "82841a12-56b0-4de8-816b-10dde085ea7d", "karina@gmail.com", false, false, null, "KARINA@GMAIL.COM", "KARINA", "AQAAAAIAAYagAAAAENcmfQIPYLljy2jqDm4ZfplVqQ6Y50CIiKnEpKb86zfCUsvg5CoSdNjxEoeMSyzBHg==", null, false, "d2e0349b-6e9f-40f6-a542-874e6505d8c7", false, "karina" },
                    { "f2719645-ed47-4320-9a28-e368771b8948", 0, "f422339e-d3fb-4187-862d-2049efe4498d", "sofia@yahho.com", false, false, null, "SOFIA@YAHOO.COM", "SOFIA", "AQAAAAIAAYagAAAAELWKzQO4qlIHcLe+lXVKSSJhoJbjCZuV24oLxFu6mbK+D0bw5lZJAXlnZVr9LSlBIw==", null, false, "32f029cd-054f-4b98-9416-373ad5ec23d2", false, "sofia" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "809b5375-beac-4364-8a78-35e8763a8e0c", "3a51f58c-74fa-4ee3-91a6-9f5b385b7a49" },
                    { "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41", "52d013ea-3f61-4f6a-a1f0-a5547c1ba1b8" },
                    { "1611af41-a19e-4c5b-9d14-28c63bde63bd", "6e26ce30-4b26-46d8-809b-8586a7abe346" },
                    { "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41", "f2719645-ed47-4320-9a28-e368771b8948" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "809b5375-beac-4364-8a78-35e8763a8e0c", "3a51f58c-74fa-4ee3-91a6-9f5b385b7a49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41", "52d013ea-3f61-4f6a-a1f0-a5547c1ba1b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1611af41-a19e-4c5b-9d14-28c63bde63bd", "6e26ce30-4b26-46d8-809b-8586a7abe346" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41", "f2719645-ed47-4320-9a28-e368771b8948" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1611af41-a19e-4c5b-9d14-28c63bde63bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "809b5375-beac-4364-8a78-35e8763a8e0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f01cfd08-cdbc-4b4f-9c6c-f4746d3c8e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a51f58c-74fa-4ee3-91a6-9f5b385b7a49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52d013ea-3f61-4f6a-a1f0-a5547c1ba1b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e26ce30-4b26-46d8-809b-8586a7abe346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2719645-ed47-4320-9a28-e368771b8948");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c1581ce-1739-4129-99fb-24f2ed019df2", null, "IdentityRole", "Public", "PUBLIC" },
                    { "724e2bca-7573-48a8-b28b-cde92224dabb", null, "IdentityRole", "Writer", "WRITER" },
                    { "f25831ff-0464-4465-8fed-756924411ee0", null, "IdentityRole", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2323c33c-8f67-4f25-9199-14509857c21c", 0, "0f60c45a-e8b0-4321-84d0-80b04236afb9", "sofia@yahho.com", false, false, null, "SOFIA@YAHOO.COM", "SOFIA", "AQAAAAIAAYagAAAAEPy0KzDR9rn53mRXTg8cCaQdENvCNP4zxidO+5AZLNBjIOeWp6xZMPicnccyoKFD7A==", null, false, "3b8a31a5-0170-4061-8f6a-23a95342f421", false, "sofia" },
                    { "598c6f2b-919c-457b-a65a-94335ebccdf4", 0, "73087f2e-fd01-4002-845c-f28e73762fb9", "roberth@gmail.com", false, false, null, "ROBERTH@GMAIL.COM", "ROBERTH", "AQAAAAIAAYagAAAAEBYyJWxPncLFGS4B2cLcnYvr8PHy7vKy207r45UIDyBOsfE6hYVbc+jR3gcxWzR4Dw==", null, false, "016b639d-dcbe-47e4-a5c2-7f0796c64bc3", false, "roberth" },
                    { "793a3044-37aa-4945-9c8e-6d36764a7c5c", 0, "b17903f4-8c90-4e75-8822-78d6d8c3a5c7", "johnny@gmail.com", false, false, null, "JOHNNY@GMAIL.COM", "JOHNNY", "AQAAAAIAAYagAAAAEA2LzblxA2PUq1Lku1J7AFTTZAbZdlFTueOqUeEfDSnY++yMYL7dTiF+MLGo5QMegw==", null, false, "fb860938-36d5-443c-8ef1-4886cb660ea1", false, "johnny" },
                    { "b2b46cf5-db99-4e2a-a715-1dabb19bdcf7", 0, "d35c8be7-a1a2-41f8-9866-4dc3e5cc73de", "karina@gmail.com", false, false, null, "KARINA@GMAIL.COM", "KARINA", "AQAAAAIAAYagAAAAEPM/zHa94dgiNDZUzKFfRgDb8+hAg8rO6JuLyvxpItmHzpYFIhEcAs5fheHxsyko3g==", null, false, "c61fb9a4-9314-411d-a3d9-b568cc7e0826", false, "karina" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1c1581ce-1739-4129-99fb-24f2ed019df2", "2323c33c-8f67-4f25-9199-14509857c21c" },
                    { "f25831ff-0464-4465-8fed-756924411ee0", "598c6f2b-919c-457b-a65a-94335ebccdf4" },
                    { "1c1581ce-1739-4129-99fb-24f2ed019df2", "793a3044-37aa-4945-9c8e-6d36764a7c5c" },
                    { "724e2bca-7573-48a8-b28b-cde92224dabb", "b2b46cf5-db99-4e2a-a715-1dabb19bdcf7" }
                });
        }
    }
}
