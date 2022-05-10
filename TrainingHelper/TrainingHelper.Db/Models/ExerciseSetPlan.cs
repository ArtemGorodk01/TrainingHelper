namespace TrainingHelper.Db.Models
{
    public class ExerciseSetPlan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan RestTime { get; set; }


        public virtual List<ExercisePlan> ExercisePlans { get; set; } = new List<ExercisePlan>();

        public virtual List<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();

        public virtual List<ExercizeGroup> ExercizeGroups { get; set; } = new List<ExercizeGroup>();

        public virtual List<ExerciseSet> ExerciseSets { get; set; } = new List<ExerciseSet>();
    }
}
