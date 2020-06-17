﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE_CodeModel;

namespace SE_CodeModel.Migrations
{
    [DbContext(typeof(SafariExplorerContext))]
    partial class SafariExplorerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SE_CodeModel.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("SE_CodeModel.AnimalInfo", b =>
                {
                    b.Property<int>("AnimalInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Diet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Lifespan")
                        .HasColumnType("int");

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("AnimalInfoId");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalsInfo");
                });

            modelBuilder.Entity("SE_CodeModel.AnimalInfo", b =>
                {
                    b.HasOne("SE_CodeModel.Animal", "Animal")
                        .WithMany("AnimalInfos")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
