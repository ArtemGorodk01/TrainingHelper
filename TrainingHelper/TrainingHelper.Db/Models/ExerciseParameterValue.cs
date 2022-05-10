namespace TrainingHelper.Db.Models
{
    public class ExerciseParameterValue
    {
        public Guid Id { get; set; }

        public string Parameter { get; set; }

        public string ValueType { get; set; }

        public string Value { get; set; }


        public Guid? ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; }
    }
}
