using System;

namespace MVC3Test.Models
{
    public class TrainingProgramsCourses
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Completed { get; set; }
    }
}