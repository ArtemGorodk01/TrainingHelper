namespace TrainingHelper.Db.Models
{
    public class TrainingPlan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public virtual List<TrainingSetPlan> TrainingSetPlans { get; set; } = new List<TrainingSetPlan>();

        public virtual List<Training> Trainings { get; set; } = new List<Training>();

        public virtual List<ExerciseSetPlan> ExerciseSetPlans { get; set; } = new List<ExerciseSetPlan>();
    }
}
