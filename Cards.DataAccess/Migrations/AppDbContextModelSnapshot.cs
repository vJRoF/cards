﻿// <auto-generated />
using Cards.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cards.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Cards.DataAccess.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeckName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUri")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeckName = "Sample",
                            PictureUri = "https://drive.google.com/uc?export=view&id=1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}