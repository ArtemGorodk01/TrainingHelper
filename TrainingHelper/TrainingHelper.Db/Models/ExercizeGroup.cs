namespace TrainingHelper.Db.Models
{
    public class ExercizeGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        public virtual List<ExerciseSetPlan> ExerciseSetPlans { get; set; } = new List<ExerciseSetPlan>();
    }
}
