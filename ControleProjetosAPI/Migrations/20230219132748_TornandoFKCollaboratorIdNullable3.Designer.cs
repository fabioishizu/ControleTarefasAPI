﻿// <auto-generated />
using System;
using ControleProjetosAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleProjetosAPI.Migrations
{
    [DbContext(typeof(ProjetoContext))]
    [Migration("20230219132748_TornandoFKCollaboratorIdNullable3")]
    partial class TornandoFKCollaboratorIdNullable3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleProjetosAPI.Model.Collaborators", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.Projeto", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.TimeTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CollaboratorsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("TimeZoneId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("tasksId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorsId");

                    b.HasIndex("tasksId");

                    b.ToTable("TimeTrackers");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.Tasks", b =>
                {
                    b.HasOne("ControleProjetosAPI.Model.Projeto", "projeto")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("projeto");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.TimeTracker", b =>
                {
                    b.HasOne("ControleProjetosAPI.Model.Collaborators", "collaborators")
                        .WithMany()
                        .HasForeignKey("CollaboratorsId");

                    b.HasOne("ControleProjetosAPI.Model.Tasks", "tasks")
                        .WithMany()
                        .HasForeignKey("tasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("collaborators");

                    b.Navigation("tasks");
                });

            modelBuilder.Entity("ControleProjetosAPI.Model.Projeto", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
