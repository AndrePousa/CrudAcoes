﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TarefaMvc.Data;

namespace TarefaMvc.Migrations
{
    [DbContext(typeof(TarefaMvcContext))]
    partial class TarefaMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TarefaMvc.Models.Acoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acao");

                    b.Property<DateTime>("Data_hora");

                    b.Property<string>("Observacao");

                    b.Property<double>("Preco");

                    b.Property<int>("Quantidade");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Acoes");
                });
#pragma warning restore 612, 618
        }
    }
}
