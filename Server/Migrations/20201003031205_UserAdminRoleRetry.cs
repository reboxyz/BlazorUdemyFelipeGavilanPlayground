using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    // Note! This is not working but Seed.cs should be used 
    public partial class UserAdminRoleRetry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            // Important NOte! This is not working due to Security Stamp and Hashing!!!
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
                    "5c356b8e-4662-400d-b079-b08812fb35e3",         // 1
                     0,                                             // 2 
                     "75e1cf41-6f53-4f50-aabe-b557acfee59f",        // 3    // Note! Copied as a pattern from other AspNetUser record
                     "reboxyz@test.com",                           // 4
                     true,                                          // 5
                     false,                                         // 6
                     null,                                          // 7 manully inserted
                     "reboxyz@test.com",                           // 8
                     "reboxyz@test.com",                           // 9
                     "AQAAAAEAACcQAAAAEInNqpVUy0VecIRv0/Rlx25kUinTBMsSObjIBZQTIoLvZy9xxQIHYKaNcNkJPb7DeQ==",    // 10
                     null,                                                                                      // 11 manually inserted
                     false,                                                                                     // 12
                     "C7F3AL5SF4GNTV3BYTIHIGNF5CTU2TFI",                                                        // 13 // Note! Copied as a pattern from other AspNetUser record
                     false,                                                                                     // 14
                     "reboxyz@gmail.com" });                                                                    // 15

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "5c356b8e-4662-400d-b079-b08812fb35e3" });
            */    
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c356b8e-4662-400d-b079-b08812fb35e3");
            */    
        }
    }
}
