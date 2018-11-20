﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeTradeCenter.Models;

namespace PokeTradeCenter.Migrations
{
    [DbContext(typeof(PokeTradeCenterContext))]
    [Migration("20181120072839_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokeTradeCenter.Models.Ad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Atk");

                    b.Property<int>("Def");

                    b.Property<int>("Hp");

                    b.Property<int>("Level");

                    b.Property<int>("Move1");

                    b.Property<int>("Move2");

                    b.Property<int>("Move3");

                    b.Property<int>("Move4");

                    b.Property<string>("Nature");

                    b.Property<int>("Pokemon");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("SpeAtk");

                    b.Property<int>("SpeDef");

                    b.Property<int>("Speed");

                    b.HasKey("ID");

                    b.ToTable("Ad");
                });
#pragma warning restore 612, 618
        }
    }
}