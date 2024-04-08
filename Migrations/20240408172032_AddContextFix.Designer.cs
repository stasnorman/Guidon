﻿// <auto-generated />
using System;
using GuidonApp.ActionApp.OdbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GuidonApp.Migrations
{
    [DbContext(typeof(ConnectOdbContext))]
    [Migration("20240408172032_AddContextFix")]
    partial class AddContextFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("GuidonApp.Models.Boss", b =>
                {
                    b.Property<int>("BossID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Health")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BossID");

                    b.ToTable("Bosses");
                });

            modelBuilder.Entity("GuidonApp.Models.BossDrop", b =>
                {
                    b.Property<int>("BossID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemID")
                        .HasColumnType("INTEGER");

                    b.Property<float>("DropRate")
                        .HasColumnType("REAL");

                    b.HasKey("BossID", "ItemID");

                    b.HasIndex("ItemID");

                    b.ToTable("BossesDrops");
                });

            modelBuilder.Entity("GuidonApp.Models.BossSkill", b =>
                {
                    b.Property<int>("BossID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BossID", "SkillID");

                    b.HasIndex("SkillID");

                    b.ToTable("BossesSkills");
                });

            modelBuilder.Entity("GuidonApp.Models.GameField", b =>
                {
                    b.Property<int>("GameFieldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HeroID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameFieldID");

                    b.ToTable("GameFields");
                });

            modelBuilder.Entity("GuidonApp.Models.GameFieldBoss", b =>
                {
                    b.Property<int>("BossID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameFieldID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BossID", "GameFieldID");

                    b.HasIndex("GameFieldID");

                    b.ToTable("GameFieldBosses");
                });

            modelBuilder.Entity("GuidonApp.Models.GameFieldNPC", b =>
                {
                    b.Property<int>("NPCID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameFieldID")
                        .HasColumnType("INTEGER");

                    b.HasKey("NPCID", "GameFieldID");

                    b.HasIndex("GameFieldID");

                    b.ToTable("GameFieldNPCs");
                });

            modelBuilder.Entity("GuidonApp.Models.Hero", b =>
                {
                    b.Property<int>("HeroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GameFieldID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Health")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mana")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PositionX")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PositionY")
                        .HasColumnType("INTEGER");

                    b.HasKey("HeroID");

                    b.HasIndex("GameFieldID")
                        .IsUnique();

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("GuidonApp.Models.HeroSkill", b =>
                {
                    b.Property<int>("SkillID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeroID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SkillID", "HeroID");

                    b.HasIndex("HeroID");

                    b.ToTable("HeroesSkills");
                });

            modelBuilder.Entity("GuidonApp.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("InventoryID");

                    b.HasIndex("HeroId");

                    b.HasIndex("ItemID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("GuidonApp.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ItemID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GuidonApp.Models.NPC", b =>
                {
                    b.Property<int>("NPCID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NPCID");

                    b.ToTable("NPCs");
                });

            modelBuilder.Entity("GuidonApp.Models.NPCItem", b =>
                {
                    b.Property<int>("NPCID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("NPCID", "ItemID");

                    b.HasIndex("ItemID");

                    b.ToTable("NPCsItems");
                });

            modelBuilder.Entity("GuidonApp.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cooldown")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("GuidonApp.Models.BossDrop", b =>
                {
                    b.HasOne("GuidonApp.Models.Boss", "Boss")
                        .WithMany()
                        .HasForeignKey("BossID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boss");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("GuidonApp.Models.BossSkill", b =>
                {
                    b.HasOne("GuidonApp.Models.Boss", "Boss")
                        .WithMany("BossSkills")
                        .HasForeignKey("BossID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boss");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("GuidonApp.Models.GameFieldBoss", b =>
                {
                    b.HasOne("GuidonApp.Models.Boss", "Boss")
                        .WithMany()
                        .HasForeignKey("BossID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.GameField", "GameField")
                        .WithMany("GameFieldBosses")
                        .HasForeignKey("GameFieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boss");

                    b.Navigation("GameField");
                });

            modelBuilder.Entity("GuidonApp.Models.GameFieldNPC", b =>
                {
                    b.HasOne("GuidonApp.Models.GameField", "GameField")
                        .WithMany("GameFieldNPCs")
                        .HasForeignKey("GameFieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.NPC", "NPC")
                        .WithMany()
                        .HasForeignKey("NPCID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameField");

                    b.Navigation("NPC");
                });

            modelBuilder.Entity("GuidonApp.Models.Hero", b =>
                {
                    b.HasOne("GuidonApp.Models.GameField", "GameField")
                        .WithOne("Hero")
                        .HasForeignKey("GuidonApp.Models.Hero", "GameFieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameField");
                });

            modelBuilder.Entity("GuidonApp.Models.HeroSkill", b =>
                {
                    b.HasOne("GuidonApp.Models.Hero", "Hero")
                        .WithMany("HeroSkills")
                        .HasForeignKey("HeroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("GuidonApp.Models.Inventory", b =>
                {
                    b.HasOne("GuidonApp.Models.Hero", "Hero")
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("GuidonApp.Models.NPCItem", b =>
                {
                    b.HasOne("GuidonApp.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuidonApp.Models.NPC", "NPC")
                        .WithMany("NPCsItems")
                        .HasForeignKey("NPCID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("NPC");
                });

            modelBuilder.Entity("GuidonApp.Models.Boss", b =>
                {
                    b.Navigation("BossSkills");
                });

            modelBuilder.Entity("GuidonApp.Models.GameField", b =>
                {
                    b.Navigation("GameFieldBosses");

                    b.Navigation("GameFieldNPCs");

                    b.Navigation("Hero")
                        .IsRequired();
                });

            modelBuilder.Entity("GuidonApp.Models.Hero", b =>
                {
                    b.Navigation("HeroSkills");
                });

            modelBuilder.Entity("GuidonApp.Models.NPC", b =>
                {
                    b.Navigation("NPCsItems");
                });
#pragma warning restore 612, 618
        }
    }
}
