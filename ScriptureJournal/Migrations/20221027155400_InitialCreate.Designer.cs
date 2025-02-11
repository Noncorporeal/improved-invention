﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScriptureJournal.Data;

#nullable disable

namespace ScriptureJournal.Migrations
{
    [DbContext(typeof(ScriptureNoteContext))]
    [Migration("20221027155400_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("ScriptureJournal.Models.ScriptureNote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("book")
                        .HasColumnType("INTEGER");

                    b.Property<int>("chapter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("verse")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("ScriptureNote");
                });
#pragma warning restore 612, 618
        }
    }
}
