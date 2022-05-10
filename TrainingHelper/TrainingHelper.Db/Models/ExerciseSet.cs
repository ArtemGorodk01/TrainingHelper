namespace TrainingHelper.Db.Models
{
    public class ExerciseSet
    {
        public Guid Id { get; set; }

        public TimeSpan RestTime { get; set; }


        public Guid? ExerciseSetPlanId { get; set; }

        public virtual ExerciseSetPlan ExerciseSetPlan { get; set; }

        public Guid? TrainingId { get; set; }

        public virtual Training Training { get; set; }

        public virtual List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
