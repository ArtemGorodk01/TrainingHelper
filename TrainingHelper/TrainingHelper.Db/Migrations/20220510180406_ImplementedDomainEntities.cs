using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingHelper.Db.Migrations
{
    public partial class ImplementedDomainEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseSetPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSetPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExercizeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercizeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSetPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSetPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExercisePlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExersizeSetPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExerciseSetPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisePlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExercisePlan_ExerciseSetPlan_ExerciseSetPlanId",
                        column: x => x.ExerciseSetPlanId,
                        principalTable: "ExerciseSetPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSetPlanExercizeGroup",
                columns: table => new
                {
                    ExerciseSetPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExercizeGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSetPlanExercizeGroup", x => new { x.ExerciseSetPlansId, x.ExercizeGroupsId });
                    table.ForeignKey(
                        name: "FK_ExerciseSetPlanExercizeGroup_ExerciseSetPlan_ExerciseSetPlansId",
                        column: x => x.ExerciseSetPlansId,
                        principalTable: "ExerciseSetPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseSetPlanExercizeGroup_ExercizeGroup_ExercizeGroupsId",
                        column: x => x.ExercizeGroupsId,
                        principalTable: "ExercizeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSetPlanTrainingPlan",
                columns: table => new
                {
                    ExerciseSetPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainingPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSetPlanTrainingPlan", x => new { x.ExerciseSetPlansId, x.TrainingPlansId });
                    table.ForeignKey(
                        name: "FK_ExerciseSetPlanTrainingPlan_ExerciseSetPlan_ExerciseSetPlansId",
                        column: x => x.ExerciseSetPlansId,
                        principalTable: "ExerciseSetPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseSetPlanTrainingPlan_TrainingPlans_TrainingPlansId",
                        column: x => x.TrainingPlansId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlanTrainingSetPlan",
                columns: table => new
                {
                    TrainingPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainingSetPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlanTrainingSetPlan", x => new { x.TrainingPlansId, x.TrainingSetPlansId });
                    table.ForeignKey(
                        name: "FK_TrainingPlanTrainingSetPlan_TrainingPlans_TrainingPlansId",
                        column: x => x.TrainingPlansId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPlanTrainingSetPlan_TrainingSetPlans_TrainingSetPlansId",
                        column: x => x.TrainingSetPlansId,
                        principalTable: "TrainingSetPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExercisePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExerciseSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_ExercisePlan_ExercisePlanId",
                        column: x => x.ExercisePlanId,
                        principalTable: "ExercisePlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseParameterValue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExercisePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseParameterValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseParameterValue_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExerciseParameterValue_ExercisePlan_ExercisePlanId",
                        column: x => x.ExercisePlanId,
                        principalTable: "ExercisePlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Training_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExerciseSetPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseSet_ExerciseSetPlan_ExerciseSetPlanId",
                        column: x => x.ExerciseSetPlanId,
                        principalTable: "ExerciseSetPlan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExerciseSet_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExercisePlanId",
                table: "Exercise",
                column: "ExercisePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExerciseSetId",
                table: "Exercise",
                column: "ExerciseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseParameterValue_ExerciseId",
                table: "ExerciseParameterValue",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseParameterValue_ExercisePlanId",
                table: "ExerciseParameterValue",
                column: "ExercisePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ExercisePlan_ExerciseSetPlanId",
                table: "ExercisePlan",
                column: "ExerciseSetPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSet_ExerciseSetPlanId",
                table: "ExerciseSet",
                column: "ExerciseSetPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSet_TrainingId",
                table: "ExerciseSet",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSetPlanExercizeGroup_ExercizeGroupsId",
                table: "ExerciseSetPlanExercizeGroup",
                column: "ExercizeGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSetPlanTrainingPlan_TrainingPlansId",
                table: "ExerciseSetPlanTrainingPlan",
                column: "TrainingPlansId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_ExerciseId",
                table: "Training",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingPlanId",
                table: "Training",
                column: "TrainingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanTrainingSetPlan_TrainingSetPlansId",
                table: "TrainingPlanTrainingSetPlan",
                column: "TrainingSetPlansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_ExerciseSet_ExerciseSetId",
                table: "Exercise",
                column: "ExerciseSetId",
                principalTable: "ExerciseSet",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_ExercisePlan_ExercisePlanId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_ExerciseSet_ExerciseSetId",
                table: "Exercise");

            migrationBuilder.DropTable(
                name: "ExerciseParameterValue");

            migrationBuilder.DropTable(
                name: "ExerciseSetPlanExercizeGroup");

            migrationBuilder.DropTable(
                name: "ExerciseSetPlanTrainingPlan");

            migrationBuilder.DropTable(
                name: "TrainingPlanTrainingSetPlan");

            migrationBuilder.DropTable(
                name: "ExercizeGroup");

            migrationBuilder.DropTable(
                name: "TrainingSetPlans");

            migrationBuilder.DropTable(
                name: "ExercisePlan");

            migrationBuilder.DropTable(
                name: "ExerciseSet");

            migrationBuilder.DropTable(
                name: "ExerciseSetPlan");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "TrainingPlans");
        }
    }
}
