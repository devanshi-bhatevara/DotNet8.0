using System.ComponentModel.DataAnnotations;

namespace DotNet8._0
{
    public class DataAnnotations
    {
        [Length(2, 20)]
        public string Username { get; set; }

        [Range(1, 1000, MinimumIsExclusive = true, MaximumIsExclusive = false)]
        public double PriceRange { get; set; }

        [AllowedValues("Computers", "Video Games")]
        public string Type { get; set; }

        [DeniedValues("Printers")]
        public string SubType { get; set; }
    }
}
