INSERT INTO "AspNetUsers" ("Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName")
VALUES ('bbed16ef-5ff6-4866-b5f6-609a6b2ff714', 0, '9fec3b45-e0d7-481f-b3a2-1c88527d4e53', 'reboxyz@gmail.com', 1, 0, NULL, 'reboxyz@gmail.com', 'reboxyz@gmail.com', 'AQAAAAEAACcQAAAAEInNqpVUy0VecIRv0/Rlx25kUinTBMsSObjIBZQTIoLvZy9xxQIHYKaNcNkJPb7DeQ==', NULL, 0, '4fb98e32-f734-4f82-a89e-3b5bd02e7957', 0, 'reboxyz@gmail.com');

INSERT INTO "AspNetUserClaims" ("Id", "ClaimType", "ClaimValue", "UserId")
VALUES (1, 'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', 'Admin', 'bbed16ef-5ff6-4866-b5f6-609a6b2ff714');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20201003023249_AdminUserAdded', '5.0.0-preview.7.20365.15');

