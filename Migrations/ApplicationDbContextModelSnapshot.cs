﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using racesmiths.Data;

namespace racesmiths.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ChampRSUser", b =>
                {
                    b.Property<string>("ChampUsersId")
                        .HasColumnType("text");

                    b.Property<int>("ChampsId")
                        .HasColumnType("integer");

                    b.HasKey("ChampUsersId", "ChampsId");

                    b.HasIndex("ChampsId");

                    b.ToTable("ChampRSUser");
                });

            modelBuilder.Entity("ClubRSUser", b =>
                {
                    b.Property<string>("ClubUsersId")
                        .HasColumnType("text");

                    b.Property<int>("ClubsId")
                        .HasColumnType("integer");

                    b.HasKey("ClubUsersId", "ClubsId");

                    b.HasIndex("ClubsId");

                    b.ToTable("ClubRSUser");
                });

            modelBuilder.Entity("EventRSUser", b =>
                {
                    b.Property<string>("EventUsersId")
                        .HasColumnType("text");

                    b.Property<int>("EventsId")
                        .HasColumnType("integer");

                    b.HasKey("EventUsersId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("EventRSUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RSUserRace", b =>
                {
                    b.Property<string>("ClubUsersId")
                        .HasColumnType("text");

                    b.Property<int>("RacesId")
                        .HasColumnType("integer");

                    b.HasKey("ClubUsersId", "RacesId");

                    b.HasIndex("RacesId");

                    b.ToTable("RSUserRace");
                });

            modelBuilder.Entity("racesmiths.Models.Champ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ChampName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ChampUserId")
                        .HasColumnType("text");

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<string>("ClubUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("ExcludeVehicle")
                        .HasColumnType("text");

                    b.Property<string>("Game")
                        .HasColumnType("text");

                    b.Property<string>("IGTQualify")
                        .HasColumnType("text");

                    b.Property<string>("IGTRace")
                        .HasColumnType("text");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("bytea");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<int?>("Laps")
                        .HasColumnType("integer");

                    b.Property<string>("Multi1")
                        .HasColumnType("text");

                    b.Property<string>("Multi2")
                        .HasColumnType("text");

                    b.Property<string>("Multi3")
                        .HasColumnType("text");

                    b.Property<string>("Multi4")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot1")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot2")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot3")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot4")
                        .HasColumnType("text");

                    b.Property<int?>("QualifyLength")
                        .HasColumnType("integer");

                    b.Property<int?>("RaceLength")
                        .HasColumnType("integer");

                    b.Property<int>("Rounds")
                        .HasColumnType("integer");

                    b.Property<string>("Rules")
                        .HasColumnType("text");

                    b.Property<string>("Season")
                        .HasColumnType("text");

                    b.Property<string[]>("SelectedUsers")
                        .HasColumnType("text[]");

                    b.Property<string>("Settings")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("System")
                        .HasColumnType("text");

                    b.Property<string>("Vehicle")
                        .HasColumnType("text");

                    b.Property<string>("VehicleClass")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot1")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot2")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot3")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot4")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Champs");
                });

            modelBuilder.Entity("racesmiths.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("FileData")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("bytea");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("JoinRequests")
                        .HasColumnType("text");

                    b.Property<string>("Roles")
                        .HasColumnType("text");

                    b.Property<string>("Rules")
                        .HasColumnType("text");

                    b.Property<string[]>("SelectedUsers")
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("racesmiths.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ChampId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RSUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChampId");

                    b.HasIndex("RSUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("racesmiths.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ChampId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("IGTQualify")
                        .HasColumnType("text");

                    b.Property<string>("IGTRace")
                        .HasColumnType("text");

                    b.Property<byte[]>("Image")
                        .HasColumnType("bytea");

                    b.Property<int?>("Laps")
                        .HasColumnType("integer");

                    b.Property<string>("Multi1")
                        .HasColumnType("text");

                    b.Property<string>("Multi2")
                        .HasColumnType("text");

                    b.Property<string>("Multi3")
                        .HasColumnType("text");

                    b.Property<string>("Multi4")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot1")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot2")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot3")
                        .HasColumnType("text");

                    b.Property<string>("QualWeatherSlot4")
                        .HasColumnType("text");

                    b.Property<int?>("QualifyLength")
                        .HasColumnType("integer");

                    b.Property<int?>("RaceLength")
                        .HasColumnType("integer");

                    b.Property<int>("RoundNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Scheduled")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Season")
                        .HasColumnType("text");

                    b.Property<string[]>("SelectedUsers")
                        .HasColumnType("text[]");

                    b.Property<string>("Settings")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("TrackVariant")
                        .HasColumnType("text");

                    b.Property<string>("Vehicle")
                        .HasColumnType("text");

                    b.Property<string>("VehicleClass")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot1")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot2")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot3")
                        .HasColumnType("text");

                    b.Property<string>("WeatherSlot4")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChampId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("racesmiths.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ChampId")
                        .HasColumnType("integer");

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("RaceId")
                        .HasColumnType("integer");

                    b.Property<string>("RecipientId")
                        .HasColumnType("text");

                    b.Property<string>("SenderId")
                        .HasColumnType("text");

                    b.Property<bool>("Viewed")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ChampId");

                    b.HasIndex("RaceId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("racesmiths.Models.RSUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("FileData")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("Gamertag")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("racesmiths.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Bonus")
                        .HasColumnType("integer");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<int?>("Points")
                        .HasColumnType("integer");

                    b.Property<int?>("Position")
                        .HasColumnType("integer");

                    b.Property<int?>("Revoke")
                        .HasColumnType("integer");

                    b.Property<string>("TrackName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Race");
                });

            modelBuilder.Entity("ChampRSUser", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("ChampUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.Champ", null)
                        .WithMany()
                        .HasForeignKey("ChampsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClubRSUser", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("ClubUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventRSUser", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("EventUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RSUserRace", b =>
                {
                    b.HasOne("racesmiths.Models.RSUser", null)
                        .WithMany()
                        .HasForeignKey("ClubUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("racesmiths.Models.Champ", b =>
                {
                    b.HasOne("racesmiths.Models.Club", "Club")
                        .WithMany("Champs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("racesmiths.Models.Comment", b =>
                {
                    b.HasOne("racesmiths.Models.Champ", "Champ")
                        .WithMany()
                        .HasForeignKey("ChampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("racesmiths.Models.RSUser", "RSUser")
                        .WithMany()
                        .HasForeignKey("RSUserId");

                    b.Navigation("Champ");

                    b.Navigation("RSUser");
                });

            modelBuilder.Entity("racesmiths.Models.Event", b =>
                {
                    b.HasOne("racesmiths.Models.Champ", "Champ")
                        .WithMany("Events")
                        .HasForeignKey("ChampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champ");
                });

            modelBuilder.Entity("racesmiths.Models.Notification", b =>
                {
                    b.HasOne("racesmiths.Models.Champ", "Champ")
                        .WithMany()
                        .HasForeignKey("ChampId");

                    b.HasOne("racesmiths.Models.Event", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");

                    b.HasOne("racesmiths.Models.RSUser", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId");

                    b.HasOne("racesmiths.Models.RSUser", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Champ");

                    b.Navigation("Race");

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("racesmiths.Models.Race", b =>
                {
                    b.HasOne("racesmiths.Models.Event", "Event")
                        .WithMany("Races")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("racesmiths.Models.Champ", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("racesmiths.Models.Club", b =>
                {
                    b.Navigation("Champs");
                });

            modelBuilder.Entity("racesmiths.Models.Event", b =>
                {
                    b.Navigation("Races");
                });
#pragma warning restore 612, 618
        }
    }
}
