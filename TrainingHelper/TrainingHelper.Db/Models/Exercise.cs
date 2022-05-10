namespace TrainingHelper.Db.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }

        public TimeSpan RestTime { get; set; }


        public Guid? ExercisePlanId { get; set; }

        public ExercisePlan ExercisePlan { get; set; }

        public Guid? ExerciseSetId { get; set; }

        public ExerciseSet ExerciseSet { get; set; }

        public virtual List<Training> Trainings { get; set; } = new List<Training>();

        public virtual List<ExerciseParameterValue> ExerciseParameters { get; set; } = new List<ExerciseParameterValue>();
    }
}
