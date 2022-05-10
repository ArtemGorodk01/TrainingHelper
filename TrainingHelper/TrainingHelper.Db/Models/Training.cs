namespace TrainingHelper.Db.Models
{
    public class Training
    {
        public Guid Id { get; set; }

        public DateTime StartedAt { get; set; }

        public DateTime EndedAt { get; set; }


        public Guid? TrainingPlanId { get; set; }

        public virtual TrainingPlan TrainingPlan { get; set; }

        public virtual List<ExerciseSet> ExerciseSets { get; set; } = new List<ExerciseSet>();

    }
}
