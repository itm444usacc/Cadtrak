using System;

namespace MVC3Test.Models
{
    public class TrainingProgramsCoursesGrades
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int TrainingProgramsCourseId { get; set; }
        public int TrainingProgramsCoursesGradesTypesId { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastModified { get; set; }

    }
}