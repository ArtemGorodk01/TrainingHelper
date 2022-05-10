namespace TrainingHelper.Db.Models
{
    public class TrainingSetPlan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public virtual List<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
    }
}
