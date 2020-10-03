using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    // Note! This is not working but Seed.cs should be used 
    public partial class AdminUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { 
                    "Id",                       // 1
                    "AccessFailedCount",        // 2
                    "ConcurrencyStamp",         // 3
                    "Email",                    // 4
                    "EmailConfirmed",           // 5
                    "LockoutEnabled",           // 6
                    "LockoutEnd",               // 7
                    "NormalizedEmail",          // 8
                    "NormalizedUserName",       // 9
                    "PasswordHash",             // 10
                    "PhoneNumber",              // 11
                    "PhoneNumberConfirmed",     // 12
                    "SecurityStamp",            // 13
                    "TwoFactorEnabled",         // 14
                    "UserName" },               // 15
                values: new object[] { 
                    "bbed16ef-5ff6-4866-b5f6-609a6b2ff714",         // 1
                     0,                                             // 2 
                     "9fec3b45-e0d7-481f-b3a2-1c88527d4e53",        // 3
                     "reboxyz@gmail.com",                           // 4
                     true,                                          // 5
                     false,                                         // 6
                     null,                                          // 7 manully inserted
                     "reboxyz@gmail.com",                           // 8
                     "reboxyz@gmail.com",                           // 9
                     "AQAAAAEAACcQAAAAEInNqpVUy0VecIRv0/Rlx25kUinTBMsSObjIBZQTIoLvZy9xxQIHYKaNcNkJPb7DeQ==",    // 10
                     null,                                                                                      // 11 manually inserted
                     false,                                                                                     // 12
                     "4fb98e32-f734-4f82-a89e-3b5bd02e7957",                                                    // 13
                     false,                                                                                     // 14
                     "reboxyz@gmail.com" });                                                                    // 15

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "bbed16ef-5ff6-4866-b5f6-609a6b2ff714" });
            */    
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbed16ef-5ff6-4866-b5f6-609a6b2ff714");
            */    
        }
    }
}
