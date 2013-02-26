using System.Collections.Generic;

namespace MVC3Test.Models
{
    public class TrainingPlans
    {
        public int Id { get; set; }
        public IEnumerable<TrainingPrograms> Plan { get; set; }
        public string Description { get; set; }
    }
}