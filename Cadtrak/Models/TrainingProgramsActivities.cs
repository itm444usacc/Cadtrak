namespace Cadtrak.Models
{
    public class TrainingProgramsActivities
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int ActivitiesId { get; set; }
        public int TrainingProgramsActivitesGradesId { get; set; }
    }
}