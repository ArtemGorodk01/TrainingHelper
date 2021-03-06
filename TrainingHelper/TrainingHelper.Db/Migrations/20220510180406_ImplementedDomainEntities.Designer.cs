// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingHelper.Db;

#nullable disable

namespace TrainingHelper.Db.Migrations
{
    [DbContext(typeof(TrainingHelperDbContext))]
    [Migration("20220510180406_ImplementedDomainEntities")]
    partial class ImplementedDomainEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExerciseSetPlanExercizeGroup", b =>
                {
                    b.Property<Guid>("ExerciseSetPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExercizeGroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExerciseSetPlansId", "ExercizeGroupsId");

                    b.HasIndex("ExercizeGroupsId");

                    b.ToTable("ExerciseSetPlanExercizeGroup");
                });

            modelBuilder.Entity("ExerciseSetPlanTrainingPlan", b =>
                {
                    b.Property<Guid>("ExerciseSetPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrainingPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExerciseSetPlansId", "TrainingPlansId");

                    b.HasIndex("TrainingPlansId");

                    b.ToTable("ExerciseSetPlanTrainingPlan");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExercisePlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExerciseSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("RestTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ExercisePlanId");

                    b.HasIndex("ExerciseSetId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseParameterValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExercisePlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("ExercisePlanId");

                    b.ToTable("ExerciseParameterValue");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExercisePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExerciseSetPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExersizeSetPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("RestTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseSetPlanId");

                    b.ToTable("ExercisePlan");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExerciseSetPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("RestTime")
                        .HasColumnType("time");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseSetPlanId");

                    b.HasIndex("TrainingId");

                    b.ToTable("ExerciseSet");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseSetPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("RestTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("ExerciseSetPlan");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExercizeGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExercizeGroup");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TrainingPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.TrainingPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.TrainingSetPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingSetPlans");
                });

            modelBuilder.Entity("TrainingPlanTrainingSetPlan", b =>
                {
                    b.Property<Guid>("TrainingPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrainingSetPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TrainingPlansId", "TrainingSetPlansId");

                    b.HasIndex("TrainingSetPlansId");

                    b.ToTable("TrainingPlanTrainingSetPlan");
                });

            modelBuilder.Entity("ExerciseSetPlanExercizeGroup", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.ExerciseSetPlan", null)
                        .WithMany()
                        .HasForeignKey("ExerciseSetPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingHelper.Db.Models.ExercizeGroup", null)
                        .WithMany()
                        .HasForeignKey("ExercizeGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseSetPlanTrainingPlan", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.ExerciseSetPlan", null)
                        .WithMany()
                        .HasForeignKey("ExerciseSetPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingHelper.Db.Models.TrainingPlan", null)
                        .WithMany()
                        .HasForeignKey("TrainingPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Exercise", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.ExercisePlan", "ExercisePlan")
                        .WithMany("Exercises")
                        .HasForeignKey("ExercisePlanId");

                    b.HasOne("TrainingHelper.Db.Models.ExerciseSet", "ExerciseSet")
                        .WithMany("Exercises")
                        .HasForeignKey("ExerciseSetId");

                    b.Navigation("ExercisePlan");

                    b.Navigation("ExerciseSet");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseParameterValue", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.Exercise", "Exercise")
                        .WithMany("ExerciseParameters")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("TrainingHelper.Db.Models.ExercisePlan", null)
                        .WithMany("ExerciseParameters")
                        .HasForeignKey("ExercisePlanId");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExercisePlan", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.ExerciseSetPlan", "ExerciseSetPlan")
                        .WithMany("ExercisePlans")
                        .HasForeignKey("ExerciseSetPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseSetPlan");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseSet", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.ExerciseSetPlan", "ExerciseSetPlan")
                        .WithMany("ExerciseSets")
                        .HasForeignKey("ExerciseSetPlanId");

                    b.HasOne("TrainingHelper.Db.Models.Training", "Training")
                        .WithMany("ExerciseSets")
                        .HasForeignKey("TrainingId");

                    b.Navigation("ExerciseSetPlan");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Training", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.Exercise", null)
                        .WithMany("Trainings")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("TrainingHelper.Db.Models.TrainingPlan", "TrainingPlan")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingPlanId");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("TrainingPlanTrainingSetPlan", b =>
                {
                    b.HasOne("TrainingHelper.Db.Models.TrainingPlan", null)
                        .WithMany()
                        .HasForeignKey("TrainingPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingHelper.Db.Models.TrainingSetPlan", null)
                        .WithMany()
                        .HasForeignKey("TrainingSetPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseParameters");

                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExercisePlan", b =>
                {
                    b.Navigation("ExerciseParameters");

                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseSet", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.ExerciseSetPlan", b =>
                {
                    b.Navigation("ExercisePlans");

                    b.Navigation("ExerciseSets");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.Training", b =>
                {
                    b.Navigation("ExerciseSets");
                });

            modelBuilder.Entity("TrainingHelper.Db.Models.TrainingPlan", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
