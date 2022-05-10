using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TrainingHelper.Db.Models;

namespace TrainingHelper.Db
{
    public class TrainingHelperDbContext : DbContext
    {
        public DbSet<TrainingSetPlan> TrainingSetPlans { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }

        public TrainingHelperDbContext()
        {
        }

        public TrainingHelperDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetDefaultConnectionString());
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TrainingSetPlan>()
        //        .HasMany(traingnSetPlan => traingnSetPlan.TrainingPlans)
        //        .WithMany(trainingPlan => trainingPlan.TrainingSetPlans);

        //    modelBuilder.Entity<TrainingPlan>()
        //        .HasMany(traingPlan => traingPlan.ExerciseSetPlans)
        //        .WithMany(exerciseSetPlan => exerciseSetPlan.TrainingPlans);

        //    modelBuilder.Entity<TrainingPlan>()
        //        .HasMany(traingPlan => traingPlan.Trainings)
        //        .WithOne(training => training.TrainingPlan);

        //    modelBuilder.Entity<ExerciseSetPlan>()
        //        .HasMany(exercizeSetPlan => exercizeSetPlan.ExercizeGroups)
        //        .WithMany(group => group.ExerciseSetPlans);

        //    modelBuilder.Entity<ExerciseSetPlan>()
        //        .HasMany(exercizeSetPlan => exercizeSetPlan.ExercisePlans)
        //        .WithOne(exercisePlan => exercisePlan.ExerciseSetPlan);

        //    modelBuilder.Entity<ExerciseSetPlan>()
        //        .HasMany(exercizeSetPlan => exercizeSetPlan.ExerciseSets)
        //        .WithOne(exercizeSet => exercizeSet.ExerciseSetPlan);

        //    modelBuilder.Entity<ExercisePlan>()
        //        .HasMany(exercisePlan => exercisePlan.Exercises)
        //        .WithOne(exercise => exercise.ExercisePlan);

        //    modelBuilder.Entity<ExercisePlan>()
        //        .HasMany(exercisePlan => exercisePlan.ExerciseParameters)
        //        .WithOne(exerciseParameter => exerciseParameter.ExercisePlan);

        //    modelBuilder.Entity<ExercisePlanParameterValue>()
        //        .HasMany(exerciseParameter => exerciseParameter.ExerciseParameterValues)
        //        .WithOne(exerciseParameter => exerciseParameter.ExercisePlanParameterValue);

        //    modelBuilder.Entity<Training>()
        //        .HasMany(training => training.ExerciseSets)
        //        .WithOne(exerciseSet => exerciseSet.Training);

        //    modelBuilder.Entity<ExerciseSet>()
        //         .HasMany(exerciseSet => exerciseSet.Exercises)
        //         .WithOne(exercise => exercise.ExerciseSet);

        //    modelBuilder.Entity<Exercise>()
        //        .HasMany(exercise => exercise.ExerciseParameters)
        //        .WithOne(exersizePrameter => exersizePrameter.Exercise);
        //}

        private static string GetDefaultConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            return root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }
    }
}
