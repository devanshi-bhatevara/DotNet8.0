using System.ComponentModel.DataAnnotations;

namespace DotNet8._0.ComplexTypes
{
    public class Employee
    {
        public int Id { get; set; }

        [Length(2, 20)]
        public string Name { get; set; } = string.Empty;

        [Range(18, 100, MinimumIsExclusive = true, MaximumIsExclusive = false)]
        public int Age { get; set; }

        [AllowedValues("Female", "Male", "Other")]
        public string Gender { get; set; }

        [DeniedValues("badword")]

        public string Description { get; set; }

        public Address Address { get; set; } = new Address();

        public DateOnly BirthDate { get; set; } 

        public TimeOnly BirthTime { get; set; }
    }
}
