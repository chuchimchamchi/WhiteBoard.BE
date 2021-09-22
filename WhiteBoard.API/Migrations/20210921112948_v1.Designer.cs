﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteBoard_BE.Helpers;

namespace WhiteBoard_BE.Migrations
{
    [DbContext(typeof(WhiteBoardDBContext))]
    [Migration("20210921112948_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Avatar")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PhoneNumber")
                        .HasColumnType("decimal(11,0)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Campaign");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampaignCriterion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CampaignId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CampaignID");

                    b.Property<Guid>("CriteriaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CriteriaID");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CriteriaId");

                    b.ToTable("CampaignCriteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampaignOn", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CampaignId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CampaignID");

                    b.Property<Guid>("CampusMajorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CampusMajorID");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CampusMajorId");

                    b.ToTable("CampaignOn");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Campus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PhoneNumber")
                        .HasColumnType("decimal(11,0)");

                    b.Property<Guid>("UniversityId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UniversityID");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampusMajor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CampusId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CampusID");

                    b.Property<Guid>("MajorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MajorID");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.HasIndex("MajorId");

                    b.ToTable("CampusMajor");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CriteriaGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CriteriaGroup");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Criterion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GroupID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Criteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Major", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.PictureForReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Alt")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("Review")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Review");

                    b.ToTable("PictureForReview");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("Campaign")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OnDateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Campaign");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.ReviewCriterion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CampaignCriteriaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CampaignCriteriaID");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("Review")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CampaignCriteriaId");

                    b.HasIndex("Review");

                    b.ToTable("ReviewCriteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Reviewer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Avatar")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("BelongTo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Certification")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PhoneNumber")
                        .HasColumnType("decimal(11,0)");

                    b.HasKey("Id");

                    b.HasIndex("BelongTo");

                    b.ToTable("Reviewer");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PhoneNumber")
                        .HasColumnType("decimal(11,0)");

                    b.HasKey("Id");

                    b.ToTable("University");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampaignCriterion", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.Campaign", "Campaign")
                        .WithMany("CampaignCriteria")
                        .HasForeignKey("CampaignId")
                        .HasConstraintName("FK_CampaignHasCriteria_Campaign")
                        .IsRequired();

                    b.HasOne("WhiteBoard_BE.Models.Entities.Criterion", "Criteria")
                        .WithMany("CampaignCriteria")
                        .HasForeignKey("CriteriaId")
                        .HasConstraintName("FK_CampaignHasCriteria_Criteria")
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Criteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampaignOn", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.Campaign", "Campaign")
                        .WithMany("CampaignOns")
                        .HasForeignKey("CampaignId")
                        .HasConstraintName("FK_CampaignOn_Campaign")
                        .IsRequired();

                    b.HasOne("WhiteBoard_BE.Models.Entities.CampusMajor", "CampusMajor")
                        .WithMany("CampaignOns")
                        .HasForeignKey("CampusMajorId")
                        .HasConstraintName("FK_CampaignOn_CampusMajor")
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("CampusMajor");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Campus", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.University", "University")
                        .WithMany("Campuses")
                        .HasForeignKey("UniversityId")
                        .HasConstraintName("FK_Campus_University")
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampusMajor", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.Campus", "Campus")
                        .WithMany("CampusMajors")
                        .HasForeignKey("CampusId")
                        .HasConstraintName("FK_CampusMajor_Campus")
                        .IsRequired();

                    b.HasOne("WhiteBoard_BE.Models.Entities.Major", "Major")
                        .WithMany("CampusMajors")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FK_CampusMajor_Major")
                        .IsRequired();

                    b.Navigation("Campus");

                    b.Navigation("Major");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Criterion", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.CriteriaGroup", "Group")
                        .WithMany("Criteria")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_Criteria_CriteriaGroup");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.PictureForReview", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.Review", "ReviewNavigation")
                        .WithMany("PictureForReviews")
                        .HasForeignKey("Review")
                        .HasConstraintName("FK_PictureForReview_Review")
                        .IsRequired();

                    b.Navigation("ReviewNavigation");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Review", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.Campaign", "CampaignNavigation")
                        .WithMany("Reviews")
                        .HasForeignKey("Campaign")
                        .HasConstraintName("FK_Review_Campaign")
                        .IsRequired();

                    b.HasOne("WhiteBoard_BE.Models.Entities.Reviewer", "CreatedByNavigation")
                        .WithMany("Reviews")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK_Review_User")
                        .IsRequired();

                    b.Navigation("CampaignNavigation");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.ReviewCriterion", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.CampaignCriterion", "CampaignCriteria")
                        .WithMany("ReviewCriteria")
                        .HasForeignKey("CampaignCriteriaId")
                        .HasConstraintName("FK_ReviewCriteria_CampaignCriteria")
                        .IsRequired();

                    b.HasOne("WhiteBoard_BE.Models.Entities.Review", "ReviewNavigation")
                        .WithMany("ReviewCriteria")
                        .HasForeignKey("Review")
                        .HasConstraintName("FK_ReviewAboutCriteria_Review")
                        .IsRequired();

                    b.Navigation("CampaignCriteria");

                    b.Navigation("ReviewNavigation");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Reviewer", b =>
                {
                    b.HasOne("WhiteBoard_BE.Models.Entities.CampusMajor", "BelongToNavigation")
                        .WithMany("Reviewers")
                        .HasForeignKey("BelongTo")
                        .HasConstraintName("FK_User_CampusMajor");

                    b.Navigation("BelongToNavigation");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Campaign", b =>
                {
                    b.Navigation("CampaignCriteria");

                    b.Navigation("CampaignOns");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampaignCriterion", b =>
                {
                    b.Navigation("ReviewCriteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Campus", b =>
                {
                    b.Navigation("CampusMajors");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CampusMajor", b =>
                {
                    b.Navigation("CampaignOns");

                    b.Navigation("Reviewers");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.CriteriaGroup", b =>
                {
                    b.Navigation("Criteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Criterion", b =>
                {
                    b.Navigation("CampaignCriteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Major", b =>
                {
                    b.Navigation("CampusMajors");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Review", b =>
                {
                    b.Navigation("PictureForReviews");

                    b.Navigation("ReviewCriteria");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("WhiteBoard_BE.Models.Entities.University", b =>
                {
                    b.Navigation("Campuses");
                });
#pragma warning restore 612, 618
        }
    }
}