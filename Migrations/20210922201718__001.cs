using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace racesmiths.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Gamertag = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileData = table.Column<byte[]>(type: "bytea", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubName = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Rules = table.Column<string>(type: "text", nullable: true),
                    Roles = table.Column<string>(type: "text", nullable: true),
                    JoinRequests = table.Column<string>(type: "text", nullable: true),
                    SelectedUsers = table.Column<string[]>(type: "text[]", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<byte[]>(type: "bytea", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileData = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Champs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    ClubUserId = table.Column<string>(type: "text", nullable: true),
                    ChampUserId = table.Column<string>(type: "text", nullable: true),
                    ChampName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Game = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    System = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Rounds = table.Column<int>(type: "integer", nullable: false),
                    Rules = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: true),
                    Laps = table.Column<int>(type: "integer", maxLength: 999, nullable: true),
                    PracticeLength = table.Column<int>(type: "integer", nullable: true),
                    RaceHours = table.Column<int>(type: "integer", nullable: true),
                    RaceMinutes = table.Column<int>(type: "integer", nullable: true),
                    QualifyHours = table.Column<int>(type: "integer", nullable: true),
                    QualifyMinutes = table.Column<int>(type: "integer", nullable: true),
                    IGTimeQualify = table.Column<string>(type: "text", nullable: true),
                    IGTimeRace = table.Column<string>(type: "text", nullable: true),
                    IGDateRace = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FormationLap = table.Column<bool>(type: "boolean", nullable: false),
                    MandatoryPit = table.Column<bool>(type: "boolean", nullable: false),
                    AutoStart = table.Column<bool>(type: "boolean", nullable: false),
                    ForceInnerView = table.Column<bool>(type: "boolean", nullable: false),
                    ForceDriveLine = table.Column<bool>(type: "boolean", nullable: false),
                    ForceSetup = table.Column<bool>(type: "boolean", nullable: false),
                    ForceGears = table.Column<bool>(type: "boolean", nullable: false),
                    ForceAids = table.Column<bool>(type: "boolean", nullable: false),
                    AllowTcs = table.Column<bool>(type: "boolean", nullable: false),
                    AllowAbs = table.Column<bool>(type: "boolean", nullable: false),
                    AllowStm = table.Column<bool>(type: "boolean", nullable: false),
                    MechFailure = table.Column<bool>(type: "boolean", nullable: false),
                    AllowGhost = table.Column<bool>(type: "boolean", nullable: false),
                    ForceManualPit = table.Column<bool>(type: "boolean", nullable: false),
                    FuelUsage = table.Column<bool>(type: "boolean", nullable: false),
                    ForceCoolDown = table.Column<bool>(type: "boolean", nullable: false),
                    RulesPenalty = table.Column<bool>(type: "boolean", nullable: false),
                    TrackLimit = table.Column<bool>(type: "boolean", nullable: false),
                    DriveThruPenalty = table.Column<bool>(type: "boolean", nullable: false),
                    PitExitPenalty = table.Column<bool>(type: "boolean", nullable: false),
                    RacingLicense = table.Column<bool>(type: "boolean", nullable: false),
                    License = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    ExcludeVehicle = table.Column<string>(type: "text", nullable: true),
                    VehicleClass = table.Column<string>(type: "text", nullable: true),
                    Vehicle = table.Column<string>(type: "text", nullable: true),
                    StartType = table.Column<int>(type: "integer", nullable: false),
                    Season = table.Column<int>(type: "integer", nullable: false),
                    IGDateType = table.Column<int>(type: "integer", nullable: false),
                    TimeProgression = table.Column<int>(type: "integer", nullable: false),
                    WeatherProgression = table.Column<int>(type: "integer", nullable: false),
                    AllowablePenalty = table.Column<int>(type: "integer", nullable: false),
                    TireWear = table.Column<int>(type: "integer", nullable: false),
                    DamageType = table.Column<int>(type: "integer", nullable: false),
                    IsPublished = table.Column<bool>(type: "boolean", nullable: false),
                    Multi1 = table.Column<string>(type: "text", nullable: true),
                    Multi2 = table.Column<string>(type: "text", nullable: true),
                    Multi3 = table.Column<string>(type: "text", nullable: true),
                    Multi4 = table.Column<string>(type: "text", nullable: true),
                    QualWeatherSlot1 = table.Column<int>(type: "integer", nullable: false),
                    QualWeatherSlot2 = table.Column<int>(type: "integer", nullable: false),
                    QualWeatherSlot3 = table.Column<int>(type: "integer", nullable: false),
                    QualWeatherSlot4 = table.Column<int>(type: "integer", nullable: false),
                    WeatherSlot1 = table.Column<int>(type: "integer", nullable: false),
                    WeatherSlot2 = table.Column<int>(type: "integer", nullable: false),
                    WeatherSlot3 = table.Column<int>(type: "integer", nullable: false),
                    WeatherSlot4 = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Settings = table.Column<string>(type: "text", nullable: true),
                    SelectedUsers = table.Column<string[]>(type: "text[]", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubRSUser",
                columns: table => new
                {
                    ClubUsersId = table.Column<string>(type: "text", nullable: false),
                    ClubsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubRSUser", x => new { x.ClubUsersId, x.ClubsId });
                    table.ForeignKey(
                        name: "FK_ClubRSUser_AspNetUsers_ClubUsersId",
                        column: x => x.ClubUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubRSUser_Clubs_ClubsId",
                        column: x => x.ClubsId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChampRSUser",
                columns: table => new
                {
                    ChampUsersId = table.Column<string>(type: "text", nullable: false),
                    ChampsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampRSUser", x => new { x.ChampUsersId, x.ChampsId });
                    table.ForeignKey(
                        name: "FK_ChampRSUser_AspNetUsers_ChampUsersId",
                        column: x => x.ChampUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampRSUser_Champs_ChampsId",
                        column: x => x.ChampsId,
                        principalTable: "Champs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChampId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    RSUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_RSUserId",
                        column: x => x.RSUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Champs_ChampId",
                        column: x => x.ChampId,
                        principalTable: "Champs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChampId = table.Column<int>(type: "integer", nullable: false),
                    RoundNumber = table.Column<int>(type: "integer", nullable: false),
                    TrackName = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    TrackVariant = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Settings = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Scheduled = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Laps = table.Column<int>(type: "integer", nullable: true),
                    PracticeLength = table.Column<int>(type: "integer", nullable: true),
                    RaceLength = table.Column<int>(type: "integer", nullable: true),
                    QualifyLength = table.Column<int>(type: "integer", nullable: true),
                    Season = table.Column<string>(type: "text", nullable: true),
                    WeatherSlot1 = table.Column<string>(type: "text", nullable: true),
                    WeatherSlot2 = table.Column<string>(type: "text", nullable: true),
                    WeatherSlot3 = table.Column<string>(type: "text", nullable: true),
                    WeatherSlot4 = table.Column<string>(type: "text", nullable: true),
                    IGTimeQualify = table.Column<string>(type: "text", nullable: true),
                    IGTimeRace = table.Column<string>(type: "text", nullable: true),
                    IGDateRace = table.Column<string>(type: "text", nullable: true),
                    QualWeatherSlot1 = table.Column<string>(type: "text", nullable: true),
                    QualWeatherSlot2 = table.Column<string>(type: "text", nullable: true),
                    QualWeatherSlot3 = table.Column<string>(type: "text", nullable: true),
                    QualWeatherSlot4 = table.Column<string>(type: "text", nullable: true),
                    VehicleClass = table.Column<string>(type: "text", nullable: true),
                    Vehicle = table.Column<string>(type: "text", nullable: true),
                    ExcludeVehicle = table.Column<string>(type: "text", nullable: true),
                    Multi1 = table.Column<string>(type: "text", nullable: true),
                    Multi2 = table.Column<string>(type: "text", nullable: true),
                    Multi3 = table.Column<string>(type: "text", nullable: true),
                    Multi4 = table.Column<string>(type: "text", nullable: true),
                    SelectedUsers = table.Column<string[]>(type: "text[]", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Champs_ChampId",
                        column: x => x.ChampId,
                        principalTable: "Champs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventRSUser",
                columns: table => new
                {
                    EventUsersId = table.Column<string>(type: "text", nullable: false),
                    EventsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRSUser", x => new { x.EventUsersId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_EventRSUser_AspNetUsers_EventUsersId",
                        column: x => x.EventUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRSUser_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RecipientId = table.Column<string>(type: "text", nullable: true),
                    SenderId = table.Column<string>(type: "text", nullable: true),
                    Viewed = table.Column<bool>(type: "boolean", nullable: false),
                    ChampId = table.Column<int>(type: "integer", nullable: true),
                    RaceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Champs_ChampId",
                        column: x => x.ChampId,
                        principalTable: "Champs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Event_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    TrackName = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<int>(type: "integer", nullable: true),
                    Points = table.Column<int>(type: "integer", nullable: true),
                    Bonus = table.Column<int>(type: "integer", nullable: true),
                    Revoke = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Race_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSUserRace",
                columns: table => new
                {
                    ClubUsersId = table.Column<string>(type: "text", nullable: false),
                    RacesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSUserRace", x => new { x.ClubUsersId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_RSUserRace_AspNetUsers_ClubUsersId",
                        column: x => x.ClubUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSUserRace_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChampRSUser_ChampsId",
                table: "ChampRSUser",
                column: "ChampsId");

            migrationBuilder.CreateIndex(
                name: "IX_Champs_ClubId",
                table: "Champs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubRSUser_ClubsId",
                table: "ClubRSUser",
                column: "ClubsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ChampId",
                table: "Comments",
                column: "ChampId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RSUserId",
                table: "Comments",
                column: "RSUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ChampId",
                table: "Event",
                column: "ChampId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRSUser_EventsId",
                table: "EventRSUser",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ChampId",
                table: "Notifications",
                column: "ChampId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RaceId",
                table: "Notifications",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RecipientId",
                table: "Notifications",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SenderId",
                table: "Notifications",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Race_EventId",
                table: "Race",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RSUserRace_RacesId",
                table: "RSUserRace",
                column: "RacesId");
        }

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
                name: "ChampRSUser");

            migrationBuilder.DropTable(
                name: "ClubRSUser");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "EventRSUser");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "RSUserRace");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Champs");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
