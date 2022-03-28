﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reception_App.Models;

namespace ReceptionApp_2._0.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reception_App.Models.Meeting", b =>
                {
                    b.Property<Guid>("MeetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeetingID");

                    b.ToTable("Meetings");

                    b.HasData(
                        new
                        {
                            MeetingID = new Guid("6ef41f9d-e936-45c4-827e-abedbea8dbbc"),
                            Date = "2022-12-01",
                            Description = "Investment"
                        },
                        new
                        {
                            MeetingID = new Guid("7385d280-7ec8-4b66-9ac8-0dedc96c8658"),
                            Date = "2022-12-02",
                            Description = "Visit"
                        });
                });

            modelBuilder.Entity("Reception_App.Models.StaffMember", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Company = "WTC",
                            ContactNumber = "0000000000",
                            Email = "shakirah@wethinkcode.co.za",
                            Name = "Shakirah Brittle",
                            Role = "Campus Coordinator"
                        },
                        new
                        {
                            ID = 2,
                            Company = "WTC",
                            ContactNumber = "1111111111",
                            Email = "awesome@wethinkcode.co.za",
                            Name = "Awesome Flan",
                            Role = "Senior Developer"
                        },
                        new
                        {
                            ID = 3,
                            Company = "WTC",
                            ContactNumber = "2222222222",
                            Email = "ruin@wethinkcode.co.za",
                            Name = "Ruin the Beer",
                            Role = "Student Performance"
                        },
                        new
                        {
                            ID = 4,
                            Company = "WTC",
                            ContactNumber = "3333333333",
                            Email = "durian@wethinkcode.co.za",
                            Name = "Durian Woof",
                            Role = "Senior Developer"
                        },
                        new
                        {
                            ID = 5,
                            Company = "WTC",
                            ContactNumber = "4444444444",
                            Email = "ready@wethinkcode.co.za",
                            Name = "Ready Sett Go",
                            Role = "Senior Developer"
                        });
                });

            modelBuilder.Entity("Reception_App.Models.StaffMemberAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<Guid>("MeetingID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("StaffMeetingAttendance");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AttendeeID = 1,
                            MeetingID = new Guid("6ef41f9d-e936-45c4-827e-abedbea8dbbc")
                        },
                        new
                        {
                            ID = 2,
                            AttendeeID = 2,
                            MeetingID = new Guid("6ef41f9d-e936-45c4-827e-abedbea8dbbc")
                        },
                        new
                        {
                            ID = 3,
                            AttendeeID = 1,
                            MeetingID = new Guid("7385d280-7ec8-4b66-9ac8-0dedc96c8658")
                        });
                });

            modelBuilder.Entity("Reception_App.Models.Visitor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Visitors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Company = "CoolTechStartup",
                            ContactNumber = "1234567890",
                            Email = "investor@cooltech.co.za",
                            Name = "Potential Investor",
                            Role = "CEO"
                        },
                        new
                        {
                            ID = 2,
                            Company = "CoolTechStartup",
                            ContactNumber = "1112131415",
                            Email = "prev@cooltech.co.za",
                            Name = "Prev Student",
                            Role = "Junior developer"
                        },
                        new
                        {
                            ID = 3,
                            Company = "CoolTechStartup",
                            ContactNumber = "1617181920",
                            Email = "koel@cooltech.co.za",
                            Name = "Koel Thum",
                            Role = "Junior developer"
                        });
                });

            modelBuilder.Entity("Reception_App.Models.VisitorAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<Guid>("MeetingID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("VisitorMeetingAttendance");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AttendeeID = 1,
                            MeetingID = new Guid("6ef41f9d-e936-45c4-827e-abedbea8dbbc")
                        },
                        new
                        {
                            ID = 2,
                            AttendeeID = 2,
                            MeetingID = new Guid("7385d280-7ec8-4b66-9ac8-0dedc96c8658")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}