using System.Collections.Generic;

namespace FirstEF.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string Ttitle { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
