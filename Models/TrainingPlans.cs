using System.Collections.Generic;

namespace Cadtrak.Models
{
    public class TrainingPlans
    {
        public int Id { get; set; }
        public IEnumerable<TrainingPrograms> Plan { get; set; }
        public string Description { get; set; }
    }
}