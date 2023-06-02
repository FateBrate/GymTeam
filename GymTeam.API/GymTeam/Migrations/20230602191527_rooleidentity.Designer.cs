﻿// <auto-generated />
using System;
using GymTeam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymTeam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230602191527_rooleidentity")]
    partial class rooleidentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymTeam.LoginModels.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("autentifikacijaTokenKorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("korisnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("korisnikId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("GymTeam.Models.Cjenovnik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<float>("cijena")
                        .HasColumnType("real");

                    b.Property<int>("cjenovnikKorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("korisnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nazivStavke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("korisnikId");

                    b.ToTable("Cjenovnik");
                });

            modelBuilder.Entity("GymTeam.Models.Clanarina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("datumUplate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumVazenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("iznos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clanarina");
                });

            modelBuilder.Entity("GymTeam.Models.ClanarinaPlacanje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("clanarinaID")
                        .HasColumnType("int");

                    b.Property<int>("placanjeID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clanarinaID");

                    b.HasIndex("placanjeID");

                    b.ToTable("ClanarinaPlacanje");
                });

            modelBuilder.Entity("GymTeam.Models.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("brojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("lokacijaId")
                        .HasColumnType("int");

                    b.Property<string>("lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("roleId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("lokacijaId");

                    b.HasIndex("roleId1");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GymTeam.Models.Narudzba", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("brojNarudzbe")
                        .HasColumnType("int");

                    b.Property<string>("cijena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.Property<string>("korisnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("popust")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("korisnikId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("GymTeam.Models.NarudzbaPlacanje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("narudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("placanjeID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("narudzbaID");

                    b.HasIndex("placanjeID");

                    b.ToTable("NarudzbaPlacanje");
                });

            modelBuilder.Entity("GymTeam.Models.Obavijest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("datumObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("korisnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("obavijestKorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("korisnikId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("GymTeam.Models.Placanje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("iznos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Placanje");
                });

            modelBuilder.Entity("GymTeam.Models.PlanIshrane", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ukupanBrojKalorija")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("PlanIshrane");
                });

            modelBuilder.Entity("GymTeam.Models.PlanIshrane_PrehrambeniArtikal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.Property<int>("planIshraneID")
                        .HasColumnType("int");

                    b.Property<int>("prehrambeniArtikalID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("planIshraneID");

                    b.HasIndex("prehrambeniArtikalID");

                    b.ToTable("planIshrane_PrehrambeniArtikal");
                });

            modelBuilder.Entity("GymTeam.Models.PrehrambeniArtikal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("brojKalorija")
                        .HasColumnType("int");

                    b.Property<string>("kategorija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PrehrambeniArtikal");
                });

            modelBuilder.Entity("GymTeam.Models.PrivatniTrener", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("id");

                    b.ToTable("PrivatniTrener");
                });

            modelBuilder.Entity("GymTeam.Models.Produkt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cijena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kategorija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("masa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifraProdukta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zemljaPorijekla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("GymTeam.Models.ProduktNarudzba", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.Property<int>("narudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("produktID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("narudzbaID");

                    b.HasIndex("produktID");

                    b.ToTable("ProduktNarudzba");
                });

            modelBuilder.Entity("GymTeam.Models.Rezervacija", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("datumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<string>("korisnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("rezervacijaKorisnikId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("korisnikId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("GymTeam.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rolename")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("GymTeam.Models.Termin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("datumOdrzavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("lokacijaId")
                        .HasColumnType("int");

                    b.Property<int>("rezervacijaId")
                        .HasColumnType("int");

                    b.Property<string>("trajanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("lokacijaId");

                    b.HasIndex("rezervacijaId");

                    b.ToTable("Termin");
                });

            modelBuilder.Entity("GymTeam.Models.VideoTrening", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ukupnoTrajanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("VideoTrening");
                });

            modelBuilder.Entity("GymTeam.Moduls.Adresa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("NazivUlice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazivGrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postanskiBroj")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("GymTeam.Moduls.Lokacija", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("adresaId")
                        .HasColumnType("int");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("id");

                    b.HasIndex("adresaId");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GymTeam.LoginModels.AutentifikacijaToken", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("GymTeam.Models.Cjenovnik", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("GymTeam.Models.ClanarinaPlacanje", b =>
                {
                    b.HasOne("GymTeam.Models.Clanarina", "clanarina")
                        .WithMany()
                        .HasForeignKey("clanarinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTeam.Models.Placanje", "placanje")
                        .WithMany()
                        .HasForeignKey("placanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clanarina");

                    b.Navigation("placanje");
                });

            modelBuilder.Entity("GymTeam.Models.Korisnik", b =>
                {
                    b.HasOne("GymTeam.Moduls.Lokacija", "lokacija")
                        .WithMany()
                        .HasForeignKey("lokacijaId");

                    b.HasOne("GymTeam.Models.Role", "role")
                        .WithMany()
                        .HasForeignKey("roleId1");

                    b.Navigation("lokacija");

                    b.Navigation("role");
                });

            modelBuilder.Entity("GymTeam.Models.Narudzba", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("GymTeam.Models.NarudzbaPlacanje", b =>
                {
                    b.HasOne("GymTeam.Models.Narudzba", "narudzba")
                        .WithMany()
                        .HasForeignKey("narudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTeam.Models.Placanje", "placanje")
                        .WithMany()
                        .HasForeignKey("placanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("narudzba");

                    b.Navigation("placanje");
                });

            modelBuilder.Entity("GymTeam.Models.Obavijest", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("GymTeam.Models.PlanIshrane_PrehrambeniArtikal", b =>
                {
                    b.HasOne("GymTeam.Models.PlanIshrane", "planIshrane")
                        .WithMany()
                        .HasForeignKey("planIshraneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTeam.Models.PrehrambeniArtikal", "prehrambeniArtikal")
                        .WithMany()
                        .HasForeignKey("prehrambeniArtikalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("planIshrane");

                    b.Navigation("prehrambeniArtikal");
                });

            modelBuilder.Entity("GymTeam.Models.ProduktNarudzba", b =>
                {
                    b.HasOne("GymTeam.Models.Narudzba", "narudzba")
                        .WithMany()
                        .HasForeignKey("narudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTeam.Models.Produkt", "produkt")
                        .WithMany()
                        .HasForeignKey("produktID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("narudzba");

                    b.Navigation("produkt");
                });

            modelBuilder.Entity("GymTeam.Models.Rezervacija", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("GymTeam.Models.Termin", b =>
                {
                    b.HasOne("GymTeam.Moduls.Lokacija", "lokacija")
                        .WithMany()
                        .HasForeignKey("lokacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTeam.Models.Rezervacija", "rezervacija")
                        .WithMany()
                        .HasForeignKey("rezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lokacija");

                    b.Navigation("rezervacija");
                });

            modelBuilder.Entity("GymTeam.Moduls.Lokacija", b =>
                {
                    b.HasOne("GymTeam.Moduls.Adresa", "adresa")
                        .WithMany()
                        .HasForeignKey("adresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("adresa");
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
                    b.HasOne("GymTeam.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", null)
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

                    b.HasOne("GymTeam.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GymTeam.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}