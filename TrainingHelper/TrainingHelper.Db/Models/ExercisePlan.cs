namespace TrainingHelper.Db.Models
{
    public class ExercisePlan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan RestTime { get; set; }


        public Guid? ExersizeSetPlanId { get; set; }

        public virtual ExerciseSetPlan ExerciseSetPlan { get; set; }

        public virtual List<Exercise> Exercises { get; set; }

        public virtual List<ExerciseParameterValue> ExerciseParameters { get; set; }
    }
}
